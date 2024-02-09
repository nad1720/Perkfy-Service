using System;
using System.Collections.Generic;

namespace Perkfy.Data.Models;

public partial class PunchCardSetting
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

    public virtual Product? Product { get; set; }

    public virtual Setting? Setting { get; set; }
}
