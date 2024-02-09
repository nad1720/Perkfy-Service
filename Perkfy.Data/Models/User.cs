using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace Perkfy.Data.Models;

public partial class User:IdentityUser<string>
{
    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public DateTime? Birthday { get; set; }

    public int Gender { get; set; }

    public string? ProfileImageUrl { get; set; }

    public DateTime? LastLoginDate { get; set; }

    public int? LoginCount { get; set; }

    public int? StatusId { get; set; }

    public int? BrandId { get; set; }

    public int? Balance { get; set; }
}
