namespace HeartFluttering.Classes
{
    internal class MailList
    {
        /// <summary>
        /// Коллекция окончаний почт
        /// </summary>
        private List<string> AllMail = new List<string>()
    {
        "@yandex.ru",
        "@yandex.com",
        "@mail.ru",
        "@mail.com",
        "@inbox.ru",
        "@inbox.com",
        "@bk.ru",
        "@bk.com",
        "@hotmail.com",
        "@hotmail.ru",
        "@live.com",
        "@live.ru",
        "@furmail.ru",
        "@furmail.com",
        "@list.ru",
        "@list.com",
        "@email.ru",
        "@email.com"
    };
        /// <summary>
        /// Метод, который возвращает окончания почт
        /// </summary>
        /// <returns></returns>
        public List<string> getMail()
        {
            return AllMail;
        }
    }
}
