using System.Security.Cryptography;
using System.Text;

namespace HeartFluttering.Classes
{
    public class Hash
    {
        /// <summary>
        /// Метод для хеширования пароля
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public string CalculateMD5Hash(string input)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("x2"));
                }
                return sb.ToString();
            }
        }
    }
}
