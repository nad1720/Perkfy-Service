using Perkfy.DTO.Enums;
using System;
using System.Collections.Generic;

namespace Perkfy.Data.Models;

public partial class Brand
{
    public int Id { get; set; }

    public StatusEnum StatusId { get; set; }

    public string? Name { get; set; }

    public string? Logo { get; set; }

    public DateTime? RenewDate { get; set; }

    public DateTime? StartDate { get; set; }

    public int? NumberOfUsers { get; set; }

    public int? ThemeId { get; set; }

    public virtual ICollection<Setting> Settings { get; set; } = new List<Setting>();

    public virtual Theme? Theme { get; set; }
}
