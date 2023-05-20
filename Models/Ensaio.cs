using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace PaintQualityCompass.Models
{
    [Table("ENSAIO")]
    public class Ensaio
    {
        [Key]
        public int IdNorma { get; set; }
        [Key]
        public int IdAnalise { get; set; }
        public double Valor { get; set; }
    }
}
