using HeartFluttering.Classes;
using HeartFluttering.Resources.Localization.RegistrForm;
using HeartFluttering.Resources.Localization.VKForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VkNet.Enums.Filters;
using VkNet.Model;
using VkNet.Utils;

namespace HeartFluttering.Forms
{
    public partial class VkForm : Form
    {
        public VkForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            AuthorizationForm authorizationForm = new AuthorizationForm();
            authorizationForm.Show();
            Hide();
        }

        private void BntSIngIn_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new AcquaintanceSqlContext())
                {
                    var users = context.Users.ToList();
                    foreach (var user_1 in users)
                    {
                        if (context.Accounts.FirstOrDefault(x => x.Id == user_1.Id).Login == loginField.Text)
                        {
                            MessageBox.Show(InscriptionsSignUp.Account);
                            return;
                        }
                    }

                    ulong appId = 51924473;
                    var vkApi = new VkNet.VkApi();
                    vkApi.Authorize(new ApiAuthParams
                    {
                        ApplicationId = appId,
                        Login = loginField.Text,
                        Password = passwordField.Text,
                    });
                    Hash hash = new Hash();
                    string accessToken = vkApi.Token;
                    var user = vkApi.Users.Get(new long[] { vkApi.UserId.Value }, ProfileFields.Sex | ProfileFields.BirthDate |
                        ProfileFields.City | ProfileFields.PhotoMaxOrig).FirstOrDefault();
                    var newUser = new User();
                    Guid guidOfUser = Guid.NewGuid();
                    Guid guidOfAccount = Guid.NewGuid();
                    Account account = new Account();
                    account.Login = loginField.Text;
                    account.Password = hash.CalculateMD5Hash(passwordField.Text);
                    account.Id = guidOfAccount.ToString();

                    newUser.IdNavigation = account;
                    newUser.IdUsers = guidOfUser.ToString();
                    newUser.Name = user.FirstName;
                    newUser.Surname = user.LastName;
                    newUser.AnotherAccounts = "";
                    newUser.NotificationsFriend = "";
                    newUser.Friends = "";
                    if (user.City != null)
                    {
                        newUser.City = user.City.Title.ToString();
                    }
                    newUser.Vk = 1;
                    newUser.DateOfBirth = Convert.ToDateTime(user.BirthDate.ToString()).ToShortDateString();
                    var provider = new DateTimeFormatInfo();
                    provider.ShortDatePattern = "dd.MM.yyyy";
                    int age = DateTime.Now.Year - DateTime.ParseExact(newUser.DateOfBirth,
                         "dd.MM.yyyy", provider).Year;
                    if (age < 18)
                    {
                        MessageBox.Show(InscriptionsSignUp.Youth);
                        return;
                    }
                    WebClient wc = new WebClient();
                    byte[] photo = wc.DownloadData(user.PhotoMaxOrig.ToString());
                    newUser.Photo = photo;
                    if (user.Sex.ToString() == "Male")
                    {
                        newUser.Sex = 1;
                    }
                    else
                    {
                        newUser.Sex = 0;
                    }
                    context.Accounts.Add(account);
                    context.Users.Add(newUser);
                    context.SaveChanges();
                    MessageBox.Show(InscriptionsSignUp.Done);
                    AuthorizationForm authorizationForm = new AuthorizationForm();
                    Hide();
                    authorizationForm.Show();
                }
            }
            catch
            {
                MessageBox.Show(InscriptionsVk.Error);
            }

        }


        private void ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPassword.Checked == true)
            {
                passwordField.UseSystemPasswordChar = false;
            }
            else 
            {
                passwordField.UseSystemPasswordChar = true;
            }
        }
    }
}
