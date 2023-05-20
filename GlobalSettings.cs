using PaintQualityCompass.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintQualityCompass
{
    public static class GlobalSettings
    {
        public static DbContext dbContext { get; } = new DbContext();
    }
}
