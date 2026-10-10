using System;
using System.Collections.Generic;
using System.Linq;
using controleEstoque.Models;
using controleEstoque.Repositories;

namespace controleEstoque.Services
{
    public class EstoqueService
    {
        private readonly IEstoqueRepository _estoqueRepository;

        public EstoqueService(
            IEstoqueRepository estoqueRepository)
        {
            _estoqueRepository = estoqueRepository;
        }

        // Retorna todos os produtos cadastrados.
        public List<Produto> ListarProdutos()
        {
            return _estoqueRepository.ObterTodos();
        }

        // Busca um produto pelo código.
        public Produto ObterProdutoPorCodigo(int codigoProduto)
        {
            if (codigoProduto <= 0)
            {
                throw new ArgumentException("O código do produto deve ser maior que zero.");
            }

            List<Produto> produtos =
                _estoqueRepository.ObterTodos();

            Produto? produto = produtos.FirstOrDefault(p => p.CodigoProduto == codigoProduto);

            if (produto == null)
            {
                throw new InvalidOperationException("Produto não encontrado.");
            }

            return produto;
        }

        // Consulta o saldo atual de um produto.
        public int ConsultarQuantidade(int codigoProduto)
        {
            Produto produto = ObterProdutoPorCodigo(codigoProduto);

            return produto.Estoque;
        }

        // Atualiza o saldo de um produto.
        public void AtualizarEstoque(int codigoProduto,int novaQuantidade)
        {
            if (novaQuantidade < 0)
            {
                throw new ArgumentException("O estoque não pode ser negativo.");
            }

            List<Produto> produtos = _estoqueRepository.ObterTodos();

            Produto? produto = produtos.FirstOrDefault(p => p.CodigoProduto == codigoProduto);

            if (produto == null)
            {
                throw new InvalidOperationException("Produto não encontrado.");
            }

            produto.Estoque = novaQuantidade;

            _estoqueRepository.SalvarTodos(produtos);
        }
    }
}