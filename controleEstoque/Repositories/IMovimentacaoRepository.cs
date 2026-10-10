using controleEstoque.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controleEstoque.Repositories
{
    public interface IMovimentacaoRepository
    {
        List<Movimentacao> ObterTodas();
        void SalvarTodas(List<Movimentacao> movimentacoes);
    }
}
