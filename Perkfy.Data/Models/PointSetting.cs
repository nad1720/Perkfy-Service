using System;
using System.Collections.Generic;

namespace Perkfy.Data.Models;

public partial class PointSetting
{
    public int Id { get; set; }

    public int? SettingId { get; set; }

    public int? GainPoints { get; set; }

    public int? RedeemPoints { get; set; }

    public decimal? GainMoney { get; set; }

    public decimal? RedeemMoney { get; set; }

    public virtual Setting? Setting { get; set; }
}
