using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace PaintQualityCompass.Models
{
    [Table("PADRAO")]
    public class Padrao
    {

        [Key]
        public int Id { get; set; }
        public string Empresa { get; set; } = null!;
        public string Descricao { get; set; } = null!;

        [Write(false)]
        public IEnumerable<Requisito> Requisitos { get; set; } = new List<Requisito>();

        protected Padrao()
        {

        }

        public Padrao(int id, string empresa, string descricao)
        {
            Id = id;
            Empresa = empresa;
            Descricao = descricao;
        }

        public Padrao(string empresa, string descricao)
        {
            Empresa = empresa;
            Descricao = descricao;
        }
    }
}
