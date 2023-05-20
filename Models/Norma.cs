using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace PaintQualityCompass.Models
{
    [Table("NORMA")]
    public class Norma
    {
        [Key]
        public int Id { get; set; }
        public string Nomeclatura { get; set; } = null!;
        public string Descricao { get; set; } = null!;
        public string OrgaoRegulador { get; set; } = null!;
        public string UnidadeDeMedida { get; set; } = string.Empty;

        protected Norma()
        {

        }

        public Norma(string nomeclatura, string descricao, string orgaoRegulador, string unidadeDeMedida)
        {
            Nomeclatura = nomeclatura;
            Descricao = descricao;
            OrgaoRegulador = orgaoRegulador;
            UnidadeDeMedida = unidadeDeMedida;
        }

        public Norma(int id, string nomeclatura, string descricao, string orgaoRegulador, string unidadeDeMedida)
        {
            Id = id;
            Nomeclatura = nomeclatura;
            Descricao = descricao;
            OrgaoRegulador = orgaoRegulador;
            UnidadeDeMedida = unidadeDeMedida;
        }
    }

}
