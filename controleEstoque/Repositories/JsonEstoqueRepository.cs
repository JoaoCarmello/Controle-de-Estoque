using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using controleEstoque.Models;
using System.Linq;

namespace controleEstoque.Repositories
{
    public class JsonEstoqueRepository : IEstoqueRepository
    {
        private readonly string _caminhoArquivo;

        private readonly JsonSerializerOptions _opcoes = new()
        {
            PropertyNameCaseInsensitive = true,
            WriteIndented = true
        };

        public JsonEstoqueRepository()
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

            _caminhoArquivo = Path.Combine(pastaData, "Estoque.json");
        }

        public List<Produto> ObterTodos()
        {
            if (!File.Exists(_caminhoArquivo))
                throw new FileNotFoundException("Arquivo de estoque não encontrado.", _caminhoArquivo);

            string json = File.ReadAllText(_caminhoArquivo);

            var arquivo = JsonSerializer.Deserialize<EstoqueArquivo>(json, _opcoes);

            return arquivo?.Estoque ?? new List<Produto>();
        }

        public void SalvarTodos(List<Produto> produtos)
        {
            var arquivo = new EstoqueArquivo
            {
                Estoque = produtos
            };

            string json = JsonSerializer.Serialize(arquivo, _opcoes);

            File.WriteAllText(_caminhoArquivo, json);
        }

        private class EstoqueArquivo
        {
            [JsonPropertyName("estoque")]
            public List<Produto> Estoque { get; set; } = new();
        }
    }
}