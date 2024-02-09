using System;
using System.Collections.Generic;

namespace Perkfy.Data.Models;

public partial class Setting
{
    public int Id { get; set; }

    public int? TypeId { get; set; }

    public int? BrandId { get; set; }

    public virtual Brand? Brand { get; set; }

    public virtual ICollection<PointSetting> PointSettings { get; set; } = new List<PointSetting>();

    public virtual ICollection<PunchCardSetting> PunchCardSettings { get; set; } = new List<PunchCardSetting>();

    public virtual ICollection<RewardItem> RewardItems { get; set; } = new List<RewardItem>();

    public virtual ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
}
