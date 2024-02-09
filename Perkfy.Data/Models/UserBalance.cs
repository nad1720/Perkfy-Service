using System;
using System.Collections.Generic;

namespace Perkfy.Data.Models;

public partial class UserBalance
{
    public int Id { get; set; }

    public int? SettingId { get; set; }

    public string? UserId { get; set; }

    public int? Balance { get; set; }
}
