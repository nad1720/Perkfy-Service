using System;
using System.Collections.Generic;

namespace Perkfy.Data.Models;

public partial class Product
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Image { get; set; }

    public virtual ICollection<PunchCardSetting> PunchCardSettings { get; set; } = new List<PunchCardSetting>();

    public virtual ICollection<RewardItem> RewardItems { get; set; } = new List<RewardItem>();
}
