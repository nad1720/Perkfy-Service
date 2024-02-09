using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perkfy.DTO
{
    public class PunchCardSettingDTO
    {
        public int Id { get; set; }

        public int? SettingId { get; set; }

        public string? ImageUrl { get; set; }

        public string? Title { get; set; }

        public int? NumberOfRewardCup { get; set; }

        public int? NumberOfBuyedCup { get; set; }

        public string? RewardCupType { get; set; }

        public string? BuyerCupType { get; set; }

        public int? ProductId { get; set; }
    }
}
