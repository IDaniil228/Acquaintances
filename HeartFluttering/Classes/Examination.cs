namespace HeartFluttering.Classes
{
    public static class Examination
    {
        /// <summary>
        /// Проверка на наличие других символов кроме букв
        /// </summary>
        /// <param name="letters"></param>
        /// <returns></returns>
        public static bool CheckLetter(string letters)
        {
            foreach (char letter in letters)
            {
                if (!Char.IsLetter(letter))
                {
                    return false;
                }
            }
            return true;
        }
        /// <summary>
        /// Проверка на наличие других символов кроме цифр
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public static bool CheckNumber(string numbers)
        {
            if (!numbers.StartsWith("+7") && !numbers.StartsWith("8"))
            {
                return false;
            }
            if ((numbers.StartsWith("+7") && numbers.Length == 12) || (numbers.StartsWith("8") && numbers.Length == 11))
            {
                if (Char.IsNumber(numbers[0]) || numbers[0] == '+')
                {
                    for (int i = 1; i < numbers.Length; i++)
                    {
                        if (!Char.IsNumber(numbers[i]))
                        {
                            return false;
                        }
                    }
                    return true;
                }
            }
            return false;

        }
        /// <summary>
        /// Проврка на существующий город
        /// </summary>
        /// <param name="cities"></param>
        /// <returns></returns>
        public static bool CheckCity(string cities)
        {
            AllCities Allcities = new AllCities();
            if (!Allcities.getCities().Contains(cities.ToLower()))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        /// <summary>
        /// Проверка на корректную почту
        /// </summary>
        /// <param name="mail"></param>
        /// <returns></returns>
        public static bool CheckFormatMail(string mail)
        {
            MailList emailList = new MailList();
            foreach (string email in emailList.getMail())
            {
                if (mail.EndsWith(email))
                {
                    return true;
                }
            }
            return false;
        }
        public static string GetCity(string city)
        {
            string correctCity = null;
            for (int i = 0; i < city.Length; i++)
            {
                if (i == 0)
                {
                    correctCity += Char.ToUpper(city[i]);
                }
                else
                {
                    correctCity += Char.ToLower(city[i]);
                }
            }
            return correctCity;
        }
    }
}
