using Perkfy.DTO.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perkfy.DTO
{
    public class BrandDTO
    {
        public int Id { get; set; }
        public StatusEnum StatusId { get; set; }

        public string? Name { get; set; }

        public string? Logo { get; set; }

        public DateTime? RenewDate { get; set; }

        public DateTime? StartDate { get; set; }

        public int? NumberOfUsers { get; set; }

        //public int? ThemeId { get; set; }

    }
}
