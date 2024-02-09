using System;
using System.Collections.Generic;

namespace Perkfy.Data.Models;

public partial class RewardItemGallery
{
    public int Id { get; set; }

    public string? ImageUrl { get; set; }

    public int? RewardItemId { get; set; }

    public virtual RewardItem? RewardItem { get; set; }
}
