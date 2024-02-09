using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perkfy.DTO
{
    public class TransactionDTO
    {
        public int Id { get; set; }

        public int? UserId { get; set; }

        public int? CashierId { get; set; }

        public DateTime? TransactionTime { get; set; }

        public string? Note { get; set; }

        public int? PointsCount { get; set; }

        public int? TypeId { get; set; }

        public int? SettingId { get; set; }
    }
}
