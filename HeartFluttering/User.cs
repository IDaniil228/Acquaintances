using System;
using System.Collections.Generic;

namespace HeartFluttering;

public partial class User
{
    /// <summary>
    /// Id пользователя
    /// </summary>
    public string IdUsers { get; set; } = null!;
    /// <summary>
    /// Имя пользователя
    /// </summary>
    public string? Name { get; set; }
    /// <summary>
    /// Фамилия пользователя
    /// </summary>
    public string Surname { get; set; } = null!;
    /// <summary>
    /// Дата рождения пользователя
    /// </summary>
    public string? DateOfBirth { get; set; }
    /// <summary>
    /// Город 
    /// </summary>
    public string? City { get; set; }
    /// <summary>
    /// Пол
    /// </summary>
    public int? Sex { get; set; }
    /// <summary>
    /// Почта
    /// </summary>
    public string? Mail { get; set; }
    /// <summary>
    /// Номер телефона
    /// </summary>
    public string? Number { get; set; }
    /// <summary>
    /// Фотография
    /// </summary>
    public byte[]? Photo { get; set; }
    /// <summary>
    /// Статус блокировки
    /// </summary>
    public int? Blocker { get; set; }
    /// <summary>
    /// Количество лайков
    /// </summary>
    public int? Likes { get; set; }
    /// <summary>
    /// Id пользователя, которые связывают его с данными аккаунта
    /// </summary>
    public string Id { get; set; } = null!;
    /// <summary>
    /// Id пользователей, которых мы добавили в избранное
    /// </summary>
    public string? AnotherAccounts { get; set; }
    /// <summary>
    /// Статус пользователя
    /// </summary>
    public int? Status { get; set; }
    /// <summary>
    /// Id пользователей, которых добавили текущего пользователя в избранное
    /// </summary>
    public string? Notifications { get; set; }
    /// <summary>
    /// Ключ к текущему аккаунту
    /// </summary>
    public virtual Account IdNavigation { get; set; } = null!;
}
