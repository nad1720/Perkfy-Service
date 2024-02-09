using System;
using System.Collections.Generic;

namespace Perkfy.Data.Models;

public partial class Theme
{
    public int Id { get; set; }

    public string? FontFamily { get; set; }

    public string? MainColor { get; set; }

    public string? BackgroundColor { get; set; }

    public string? SecoundColor { get; set; }

    public virtual ICollection<Brand> Brands { get; set; } = new List<Brand>();
}
