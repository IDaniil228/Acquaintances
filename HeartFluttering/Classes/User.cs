using System;
using System.Collections.Generic;

namespace HeartFluttering.Classes;

public partial class User
{
    public string IdUsers { get; set; } = null!;

    public string? Name { get; set; }

    public string Surname { get; set; } = null!;

    public string? DateOfBirth { get; set; }

    public string? City { get; set; }

    public int? Sex { get; set; }

    public string? Mail { get; set; }

    public string? Number { get; set; }

    public byte[]? Photo { get; set; }

    public string? Favorites { get; set; }

    public int? Likes { get; set; }

    public string Id { get; set; } = null!;

    public string? AnotherAccounts { get; set; }

    public int? Status { get; set; }

    public string? Notifications { get; set; }

    public virtual Account IdNavigation { get; set; } = null!;
}
