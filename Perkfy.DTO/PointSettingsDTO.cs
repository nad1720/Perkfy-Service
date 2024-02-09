using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perkfy.DTO
{
    public class PointSettingsDTO
    {
        public int Id { get; set; }

        public int? SettingId { get; set; }

        public int? GainPoints { get; set; }

        public int? RedeemPoints { get; set; }

        public decimal? GainMoney { get; set; }

        public decimal? RedeemMoney { get; set; }

    }
}
