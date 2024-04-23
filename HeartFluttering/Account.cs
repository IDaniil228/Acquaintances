using System;
using System.Collections.Generic;

namespace HeartFluttering;

public partial class Account
{
    // Что-то
    // локализатион и что-тоо
    // что-то еще
    public string Id { get; set; } = null!;

    public string Login { get; set; } = null!;

    public string Password { get; set; } = null!;

    public virtual Administrator? Administrator { get; set; }

    public virtual User? User { get; set; }
}
