using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HeartFluttering.Classes;
using HeartFluttering.Resources.Localization;
using HeartFluttering.Resources.Localization.AuthorForm;
using HeartFluttering.Resources.Localization.RegistrForm;

namespace HeartFluttering
{
    public partial class RegistrForm : Form
    {
        public RegistrForm()
        {
            InitializeComponent();
        }

        //public Account account;

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CollapseButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void LoginField_Enter(object sender, EventArgs e)
        {
            if (LoginField.Text.Equals(Inscriptions.Login))
            {
                LoginField.Text = string.Empty;
                LoginField.ForeColor = Color.Black;
            }
        }

        private void LoginField_Leave(object sender, EventArgs e)
        {
            if (LoginField.Text.Equals(string.Empty))
            {
                LoginField.ForeColor = Color.Gray;
                LoginField.Text = Inscriptions.Login;
            }
        }

        private void passwordField_Enter(object sender, EventArgs e)
        {
            if (passwordField.Text.Equals(Inscriptions.Password))
            {
                passwordField.Text = string.Empty;
                passwordField.ForeColor = Color.Black;
            }
        }

        private void passwordField_Leave(object sender, EventArgs e)
        {
            if (passwordField.Text.Equals(string.Empty))
            {
                passwordField.ForeColor = Color.Gray;
                passwordField.Text = Inscriptions.Password;
            }
        }

        private void password2Field_Enter(object sender, EventArgs e)
        {
            if (password2Field.Text.Equals(Inscriptions.Repeat_password))
            {
                password2Field.Text = string.Empty;
                password2Field.ForeColor = Color.Black;
            }
        }

        private void password2Field_Leave(object sender, EventArgs e)
        {
            if (password2Field.Text.Equals(string.Empty))
            {
                password2Field.ForeColor = Color.Gray;
                password2Field.Text = Inscriptions.Repeat_password;
            }
        }
        private void nameField_Enter(object sender, EventArgs e)
        {
            if (nameField.Text.Equals(Inscriptions.Name))
            {
                nameField.Text = string.Empty;
                nameField.ForeColor = Color.Black;
            }
        }

        private void nameField_Leave(object sender, EventArgs e)
        {
            if (nameField.Text.Equals(string.Empty))
            {
                nameField.ForeColor = Color.Gray;
                nameField.Text = Inscriptions.Name;
            }
        }

        private void surnameField_Enter(object sender, EventArgs e)
        {
            if (surnameField.Text.Equals(Inscriptions.Surname))
            {
                surnameField.Text = string.Empty;
                surnameField.ForeColor = Color.Black;
            }
        }

        private void surnameField_Leave(object sender, EventArgs e)
        {
            if (surnameField.Text.Equals(string.Empty))
            {
                surnameField.ForeColor = Color.Gray;
                surnameField.Text = Inscriptions.Surname;
            }
        }

        private void BirhdayFields_Enter(object sender, EventArgs e)
        {
            if (BirhdayFields.Text.Equals(Inscriptions.Birthday))
            {
                BirhdayFields.Text = string.Empty;
                BirhdayFields.ForeColor = Color.Black;
            }
        }

        private void BirhdayFields_Leave(object sender, EventArgs e)
        {
            if (BirhdayFields.Text.Equals(string.Empty))
            {
                BirhdayFields.ForeColor = Color.Gray;
                BirhdayFields.Text = Inscriptions.Birthday;
            }
        }

        private void cityField_Enter(object sender, EventArgs e)
        {
            if (cityField.Text.Equals(Inscriptions.City))
            {
                cityField.Text = string.Empty;
                cityField.ForeColor = Color.Black;
            }
        }

        private void cityField_Leave(object sender, EventArgs e)
        {
            if (cityField.Text.Equals(string.Empty))
            {
                cityField.ForeColor = Color.Gray;
                cityField.Text = Inscriptions.City;
            }
        }

        private Account dataAuthorization(string login, string password)
        {
            Hash hash = new Hash();
            Account account = new Account();
            account.Id = $"{Guid.NewGuid()}";
            account.Login = login;
            account.Password = hash.CalculateMD5Hash(password);
            return account;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {

            if (LoginField.Text == string.Empty)
            {
                MessageBox.Show(InscriptionsSignUp.LoginField);
                return;
            }
            if (passwordField.Text == string.Empty)
            {
                MessageBox.Show(InscriptionsSignUp.PasswordField);
                return;
            }
            if (password2Field.Text == string.Empty)
            {
                MessageBox.Show(InscriptionsSignUp.RepeatPasswordField);
                return;
            }
            if (passwordField.Text != password2Field.Text)
            {
                MessageBox.Show(InscriptionsSignUp.MatchingPassword);
                return;
            }
            if (nameField.Text == string.Empty || nameField.Text.Equals(Inscriptions.Name))
            {
                MessageBox.Show(InscriptionsSignUp.NameField);
                return;
            }
            if (surnameField.Text == string.Empty || surnameField.Text.Equals(Inscriptions.Surname))
            {
                MessageBox.Show(InscriptionsSignUp.SurnameFiald);
                return;
            }
            if (cityField.Text == string.Empty || cityField.Text.Equals(Inscriptions.City))
            {
                MessageBox.Show(InscriptionsSignUp.CityField);
                return;
            }
            if (sexMenButton.Checked == false && sexWomenButton.Checked == false)
            {
                MessageBox.Show(InscriptionsSignUp.SexField);
                return;
            }
            using (var context = new AcquaintanceSqlContext())
            {
                var accounts = context.Accounts;
                foreach (var login in accounts)
                {
                    if (LoginField.Text.Equals(login.Login))
                    {
                        MessageBox.Show(InscriptionsSignUp.Account);
                        return;
                    }
                }
                foreach (var password in accounts)
                {
                    if (passwordField.Text.Equals(password.Password))
                    {
                        MessageBox.Show(InscriptionsSignUp.Password);
                        return;
                    }
                }
                Account account = new Account();
                Hash hash = new Hash();
                string guid = Guid.NewGuid().ToString();
                account.Id = guid;
                account.Login = LoginField.Text;
                account.Password = hash.CalculateMD5Hash(passwordField.Text);
                context.Accounts.Add(account);
                User user = new User();
                user.IdUsers = Guid.NewGuid().ToString();
                foreach (char letter in nameField.Text)//
                {
                    if (!Char.IsLetter(letter))
                    {
                        MessageBox.Show(InscriptionsSignUp.LettersInName);
                        return;
                    }
                }
                user.Name = nameField.Text;

                foreach (char letter in surnameField.Text)//
                {
                    if (!Char.IsLetter(letter))
                    {
                        MessageBox.Show(InscriptionsSignUp.LettersInSurname);
                        return;
                    }
                }
                user.Surname = surnameField.Text;

                DateTime time = BirhdayFields.Value;

                int yearOld = time.Year;
                int yearNow = DateTime.Now.Year;
                if ((yearNow - yearOld) < 18)
                {
                    MessageBox.Show(InscriptionsSignUp.Youth);
                    return;
                }
                if ((yearNow - yearOld) > 120)
                {
                    MessageBox.Show(InscriptionsSignUp.Old);
                    return;
                }
                string birth = time.ToString("dd.MM.yyyy");
                user.DateOfBirth = birth;

                AllCities Allcities = new AllCities();
                if (cityField.Text != string.Empty)//
                {
                    if (!Allcities.getCities().Contains(cityField.Text.ToLower()))
                    {
                        MessageBox.Show(InscriptionsSignUp.CityIsNotExists);
                        return;
                    }
                }

                user.City = cityField.Text;
                if (sexMenButton.Checked)
                {
                    user.Sex = 1;
                }
                if (sexWomenButton.Checked)
                {
                    user.Sex = 0;
                }
                user.Id = guid.ToString();
                context.Users.Add(user);
                context.SaveChanges();
                MessageBox.Show(InscriptionsSignUp.Done);
                this.Hide();
                AuthorizationForm form = new AuthorizationForm();
                form.Show();
            }
        }
    }
}
