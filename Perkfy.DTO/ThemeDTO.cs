using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perkfy.DTO
{
    public class ThemeDTO
    {
        public int Id { get; set; }

        public string? FontFamily { get; set; }

        public string? MainColor { get; set; }

        public string? BackgroundColor { get; set; }

        public string? SecoundColor { get; set; }
    }
}
