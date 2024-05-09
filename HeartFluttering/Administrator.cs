namespace HeartFluttering;

public partial class Administrator
{
    /// <summary>
    /// Id администратора
    /// </summary>
    public string IdAdmin { get; set; } = null!;
    /// <summary>
    /// Имя администратора
    /// </summary>
    public string Name { get; set; } = null!;
    /// <summary>
    /// Фамилия администратора
    /// </summary>
    public string Surname { get; set; } = null!;
    /// <summary>
    /// Id, который связывает данных администратора с данными аккаунта
    /// </summary>
    public string Id { get; set; } = null!;
    /// <summary>
    /// Статус блокировки аккаунта
    /// </summary>
    public int? Blocker { get; set; }
    /// <summary>
    /// Ключ на аккаунт
    /// </summary>
    public virtual Account IdNavigation { get; set; } = null!;
}
