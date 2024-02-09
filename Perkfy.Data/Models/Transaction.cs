using System;
using System.Collections.Generic;

namespace Perkfy.Data.Models;

public partial class Transaction
{
    public int Id { get; set; }

    public int? UserId { get; set; }

    public int? CashierId { get; set; }

    public DateTime? TransactionTime { get; set; }

    public string? Note { get; set; }

    public int? PointsCount { get; set; }

    public int? TypeId { get; set; }

    public int? SettingId { get; set; }

    public virtual Setting? Setting { get; set; }
}
