using HeartFluttering.Classes;
using System;
using System.Collections.Generic;

namespace HeartFluttering;

public partial class Account
{
    //Что-то
    // asdfghjkl;'
    //wzexrctvbubh8ew8e7rry398r38
    //Что-то еще
    //ecrtyni,[.p
    public string Id { get; set; } = null!;

    public string Login { get; set; } = null!;

    public string Password { get; set; } = null!;

    public virtual Administrator? Administrator { get; set; }

    public virtual User? User { get; set; }
}
