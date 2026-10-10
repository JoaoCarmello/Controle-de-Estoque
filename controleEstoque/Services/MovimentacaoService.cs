using System;
using System.Collections.Generic;
using System.Linq;
using controleEstoque.Models;
using controleEstoque.Repositories;

namespace controleEstoque.Services
{
    public class MovimentacaoService
    {
        private readonly IEstoqueRepository _estoqueRepository;
        private readonly IMovimentacaoRepository _movimentacaoRepository;

        public MovimentacaoService(
            IEstoqueRepository estoqueRepository,
            IMovimentacaoRepository movimentacaoRepository)
        {
            _estoqueRepository = estoqueRepository;
            _movimentacaoRepository = movimentacaoRepository;
        }

        public Movimentacao Registrar(int codigoProduto,TipoMovimentacao tipo,int quantidade)
        {
            if (quantidade <= 0)
                throw new ArgumentException("A quantidade deve ser maior que zero.");

            if (tipo != TipoMovimentacao.Entrada && tipo != TipoMovimentacao.Saida)
            {
                throw new ArgumentException("Tipo de movimentação inválido.");
            }

            List<Produto> produtos = _estoqueRepository.ObterTodos();

            Produto? produto = produtos.FirstOrDefault(p => p.CodigoProduto == codigoProduto);

            if (produto == null)
                throw new InvalidOperationException("Produto não encontrado.");

            int estoqueFinal;

            if (tipo == TipoMovimentacao.Entrada)
            {
                estoqueFinal = checked(produto.Estoque + quantidade);
            }
            else
            {
                if (quantidade > produto.Estoque)
                    throw new InvalidOperationException("Estoque insuficiente para realizar a saída.");

                estoqueFinal = produto.Estoque - quantidade;
            }

            List<Movimentacao> movimentacoes = _movimentacaoRepository.ObterTodas();

            int proximoId = movimentacoes.Count == 0
                ? 1
                : checked(movimentacoes.Max(m => m.Id) + 1);

            var movimentacao = new Movimentacao
            {
                Id = proximoId,
                CodigoProduto = produto.CodigoProduto,
                DescricaoProduto = produto.DescricaoProduto,
                Tipo = tipo,
                Quantidade = quantidade,
                Data = DateTime.Now,
                EstoqueFinal = estoqueFinal
            };

            // Atualiza o saldo do produto.
            produto.Estoque = estoqueFinal;

            // Persiste o estoque e o histórico.
            _estoqueRepository.SalvarTodos(produtos);
            movimentacoes.Add(movimentacao);
            _movimentacaoRepository.SalvarTodas(movimentacoes);

            return movimentacao;
        }

        public List<Produto> ListarProdutos()
        {
            return _estoqueRepository.ObterTodos();
        }
    }
}