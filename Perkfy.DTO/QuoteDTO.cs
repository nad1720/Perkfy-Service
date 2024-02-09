using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perkfy.DTO
{
    public class QuoteDTO
    {
        public int Id { get; set; }

        public string? QouteContent { get; set; }

        public DateTime PublishDate { get; set; }
    }
}
