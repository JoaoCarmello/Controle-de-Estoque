using controleEstoque.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controleEstoque.Repositories
{
    public interface IEstoqueRepository
    {
        List<Produto> ObterTodos();
        void SalvarTodos(List<Produto> produtos);
    }
}
