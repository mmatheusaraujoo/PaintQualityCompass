using Dapper;
using Dapper.Contrib.Extensions;
using Microsoft.Data.Sqlite;
using PaintQualityCompass.Models;

namespace PaintQualityCompass.Repositories
{

    public class ProdutoRepository : Repository<Produto>
    {
        private readonly SqliteConnection _connection;
        public ProdutoRepository(SqliteConnection connection) : base(connection) => _connection = connection;


        public Produto GetWithAnalises(int idProduto)
        {
            var query = @"SELECT * FROM [PRODUTO] 
              LEFT JOIN [ANALISE] ON [ANALISE].[IdProduto] = [PRODUTO].Id
              WHERE PRODUTO.Id = @idProduto
              ORDER BY ANALISE.Data DESC";

            var parametros = new { idProduto = idProduto };

            var listaDeProdutosRetornados = new List<Produto>();
            using (_connection)
            {
                // Executa a consulta SQL e mapeia o resultado para uma lista de objetos do tipo Produto
                var enumeravelDeProduto = _connection.Query<Produto, Analise, Produto>
                (
                    query,
                    (produto, analise) =>
                    {
                        var produtoEncontrado = listaDeProdutosRetornados.FirstOrDefault(x => x.Id == produto.Id);
                        if (produtoEncontrado == null)
                        {
                            produtoEncontrado = produto;
                            produtoEncontrado.Analises.Add(analise);
                            listaDeProdutosRetornados.Add(produtoEncontrado);
                        }
                        else
                            produtoEncontrado.Analises.Add(analise);
                        return produto;
                    },
                    parametros,
                    splitOn: "Id"
                );
                var retorno = listaDeProdutosRetornados.FirstOrDefault(x => x.Id == idProduto);
                if (retorno is null) throw new ArgumentNullException($"Não há produto de id {idProduto}");
                return retorno;
            }
        }
    }
}