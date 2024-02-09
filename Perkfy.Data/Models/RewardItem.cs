using System;
using System.Collections.Generic;

namespace Perkfy.Data.Models;

public partial class RewardItem
{
    public int Id { get; set; }

    public int? SettingId { get; set; }

    public string? Name { get; set; }

    public int? PointsCount { get; set; }

    public int? ViewCount { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? ExpiryDate { get; set; }

    public string? Description { get; set; }

    public int? ProductId { get; set; }

    public virtual Product? Product { get; set; }

    public virtual ICollection<RewardItemGallery> RewardItemGalleries { get; set; } = new List<RewardItemGallery>();

    public virtual Setting? Setting { get; set; }
}
