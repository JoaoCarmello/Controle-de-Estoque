using System.Collections.Generic;
using controleEstoque.Models;
using controleEstoque.Repositories;
using controleEstoque.Services;

namespace controleEstoque.Controllers
{
    public class MovimentacaoController
    {
        private readonly MovimentacaoService _service;

        public MovimentacaoController()
        {
            IEstoqueRepository estoqueRepository = new JsonEstoqueRepository();

            IMovimentacaoRepository movimentacaoRepository = new JsonMovimentacaoRepository();

            _service = new MovimentacaoService(estoqueRepository, movimentacaoRepository);
        }

        public List<Produto> ListarProdutos()
        {
            return _service.ListarProdutos();
        }

        public Movimentacao RegistrarMovimentacao(int codigoProduto,TipoMovimentacao tipo, int quantidade)
        {
            return _service.Registrar(codigoProduto, tipo, quantidade);
        }
    }
}