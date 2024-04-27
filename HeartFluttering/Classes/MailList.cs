using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeartFluttering.Classes
{
    internal class MailList
    {
        private List<string> AllMail = new List<string>()
    {
        "@yandex.ru",
        "@mail.ru",
        "@inbox.ru",
        "@bk.ru",
        "@hotmail.com",
        "@live.com",
        "@xakep.ru",
        "@furmail.ru",
        "@list.ru"
    };
        public List<string> getMail()
        {
            return AllMail;
        }
    }
}
