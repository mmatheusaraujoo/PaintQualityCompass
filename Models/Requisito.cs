using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace PaintQualityCompass.Models
{
    [Table("REQUISITO")]
    public class Requisito
    {
        [Key]
        public int IdPadrao { get; set; }
        [Key]
        public int IdNorma { get; set; }
        public double? ValorMaximo { get; set; }
        public double? ValorMinimo { get; set; }

        public Requisito(int idPadrao, int idNorma, double? valorMaximo, double? valorMinimo)
        {
            IdPadrao = idPadrao;
            IdNorma = idNorma;
            ValorMaximo = valorMaximo;
            ValorMinimo = valorMinimo;
        }
    }
}
