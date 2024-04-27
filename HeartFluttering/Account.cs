using System;
using System.Collections.Generic;

namespace HeartFluttering;

public partial class Account
{
    /// <summary>
    /// Id аккаунта
    /// </summary>
    public string Id { get; set; } = null!;
    /// <summary>
    /// Логин
    /// </summary>
    public string Login { get; set; } = null!;
    /// <summary>
    /// Пароль
    /// </summary>
    public string Password { get; set; } = null!;
    /// <summary>
    /// Ссылка на администратора
    /// </summary>
    public virtual Administrator? Administrator { get; set; }
    /// <summary>
    /// Ссылка на пользователя
    /// </summary>
    public virtual User? User { get; set; }
}
