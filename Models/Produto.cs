using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace PaintQualityCompass.Models
{
    [Table("PRODUTO")]
    public class Produto
    {
        [Key]
        public int Id { get; set; }
        public string Tipo { get; set; } = null!;
        public string Linha { get; set; } = null!;
        public string Acabamento { get; set; } = null!;
        public string Cor { get; set; } = null!;

        [Write(false)]
        public IList<Analise> Analises { get; set; } = new List<Analise>();

        protected Produto()
        {
            Analises = new List<Analise>();
        }

        public Produto(int id, string tipo, string linha, string acabamento, string cor)
        {
            Id = id;
            Tipo = tipo;
            Linha = linha;
            Acabamento = acabamento;
            Cor = cor;
        }

        public Produto(string tipo, string linha, string acabamento, string cor)
        {
            Tipo = tipo;
            Linha = linha;
            Acabamento = acabamento;
            Cor = cor;
        }
    }
}

