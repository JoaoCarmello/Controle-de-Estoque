using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controleEstoque.Models
{
    public class Movimentacao
    {
        public int Id { get; set; }
        public int CodigoProduto { get; set; }
        public string DescricaoProduto { get; set; } = string.Empty;
        public TipoMovimentacao Tipo { get; set; }
        public string DescricaoTipo => Tipo == TipoMovimentacao.Entrada ? "Entrada de estoque" : "Saida de Estoque";
        public int Quantidade { get; set; }
        public DateTime Data { get; set; }
        public int EstoqueFinal { get; set; }
    }
}
