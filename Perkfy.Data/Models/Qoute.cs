using System;
using System.Collections.Generic;

namespace Perkfy.Data.Models;

public partial class Qoute
{
    public int Id { get; set; }

    public string? QouteContent { get; set; }

    public DateTime PublishDate { get; set; }
}
