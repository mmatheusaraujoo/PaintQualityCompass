using Dapper;
using Microsoft.Data.Sqlite;
using PaintQualityCompass.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace PaintQualityCompass.Data
{
    public class DbContext
    {
        public string StringDeConexao { get; } = GerarStringDeConexaoPadrao();
        public SqliteConnection sqliteConnection { get; }

        public DbContext(string stringDeConexao)
        {
            this.StringDeConexao = stringDeConexao;
            sqliteConnection = new SqliteConnection(StringDeConexao);
            if (!ChecarIntegridade(sqliteConnection)) { throw new SqliteException("Não foi possivel conectar ao banco", 400); }
        }

        public DbContext()
        {
            sqliteConnection = new SqliteConnection(StringDeConexao);
            if (!ChecarIntegridade(sqliteConnection)) { throw new SqliteException("Não foi possivel conectar ao banco", 400); }
        }

        private bool ChecarIntegridade(SqliteConnection connection)
        {
            string result;
            string sqlQuery = "PRAGMA integrity_check";
            using (connection)
            {
                result = connection.ExecuteScalar<string>(sqlQuery);
            }
            return (result == "ok");
        }

        private static string GerarStringDeConexaoPadrao()
        {
            string pastaProjeto = Path.GetDirectoryName(Application.ExecutablePath)!;
            string pastaDoArquivo = "Data";
            string nomeDoArquivo = "Database.db";
            string caminhoArquivo = Path.Combine(pastaProjeto,pastaDoArquivo,nomeDoArquivo);

            string connectionString;

            var sb = new StringBuilder();
            sb.Append(@"Data Source=");
            sb.Append(caminhoArquivo);
            sb.Append(';');

            connectionString = sb.ToString();
            return connectionString;
        }



    }
}
