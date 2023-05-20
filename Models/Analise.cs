using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace PaintQualityCompass.Models
{
    [Table("ANALISE")]
    public class Analise
    {

        [Key]
        public int Id { get; set; }
        public int IdProduto { get; set; }
        public string Descricao { get; set; } = null!;
        public DateTime Data { get; set; }
        public string Analista { get; set; } = null!;
        public string Observacoes { get; set; } = String.Empty;

        [Write(false)]
        public Produto Produto { get; set; } = null!;

        [Write(false)]
        public IEnumerable<Ensaio> Ensaios { get; set; } = new List<Ensaio>();

        protected Analise() { }

        public Analise(int idProduto, string descricao, DateTime data, string analista, string observacoes)
        {
            IdProduto = idProduto;
            Descricao = descricao;
            Data = data;
            Analista = analista;
            Observacoes = observacoes;
        }

        public Analise(int idProduto, string descricao, DateTime data, string analista)
        {
            IdProduto = idProduto;
            Descricao = descricao;
            Data = data;
            Analista = analista;
            Observacoes = String.Empty;
        }
    }
}
