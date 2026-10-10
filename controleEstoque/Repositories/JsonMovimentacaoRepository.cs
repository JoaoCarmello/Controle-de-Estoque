using controleEstoque.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Linq;

namespace controleEstoque.Repositories
{
    public class JsonMovimentacaoRepository : IMovimentacaoRepository
    {
        private readonly string _caminhoArquivo;

        private readonly JsonSerializerOptions _opcoes = new()
        {
            PropertyNameCaseInsensitive = true,
            WriteIndented = true
        };

        public JsonMovimentacaoRepository()
        {
            string diretorio = AppDomain.CurrentDomain.BaseDirectory;

            DirectoryInfo? pasta = new DirectoryInfo(diretorio);

            while (pasta != null &&
                   !Directory.GetFiles(pasta.FullName, "*.csproj").Any())
            {
                pasta = pasta.Parent;
            }

            if (pasta == null)
            {
                throw new DirectoryNotFoundException(
                    "Não foi possível localizar a pasta raiz do projeto."
                );
            }

            string pastaData = Path.Combine(pasta.FullName, "Data");

            if (!Directory.Exists(pastaData))
            {
                throw new DirectoryNotFoundException(
                    $"A pasta Data não foi encontrada: {pastaData}"
                );
            }

            _caminhoArquivo = Path.Combine(pastaData, "Movimentacoes.json");
        }

        public List<Movimentacao> ObterTodas()
        {
            if (!File.Exists(_caminhoArquivo))
                return new List<Movimentacao>();

            string json = File.ReadAllText(_caminhoArquivo);

            return JsonSerializer.Deserialize<List<Movimentacao>>(json, _opcoes) ?? new List<Movimentacao>();
        }

        public void SalvarTodas(List<Movimentacao> movimentacoes)
        {
            string json = JsonSerializer.Serialize(movimentacoes, _opcoes);

            File.WriteAllText(_caminhoArquivo, json);
        }
    }
}