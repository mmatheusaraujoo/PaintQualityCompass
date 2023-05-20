using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintQualityCompass.Views
{
    
    internal static class ColorSchema
    {
        public static Color BackgroundColor { get; } = Color.FromArgb(13, 27, 42);
        public static Color FontColor { get; } = Color.FromArgb(27, 38, 59);
        public static Color HeadingColor { get; } = Color.FromArgb(65, 90, 119);
        public static Color AccentColor { get; } = Color.FromArgb(119, 141, 169);
        public static Color TextColor { get; } = Color.FromArgb(224, 225, 221);
        public static Color ButtonColor { get; } = Color.FromArgb(88, 140, 199);
        public static Color ErrorColor { get; } = Color.FromArgb(165, 55, 55);
    }
}
