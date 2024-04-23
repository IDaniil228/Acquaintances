using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            if (LoginField.Text.Equals("Введите логин..."))
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
                LoginField.Text = "Введите логин...";
            }
        }

        private void passwordField_Enter(object sender, EventArgs e)
        {
            if (passwordField.Text.Equals("Введите пароль..."))
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
                passwordField.Text = "Введите пароль...";
            }
        }

        private void password2Field_Enter(object sender, EventArgs e)
        {
            if (password2Field.Text.Equals("Введите повторно пароль..."))
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
                password2Field.Text = "Введите повторно пароль...";
            }
        }
        private void nameField_Enter(object sender, EventArgs e)
        {
            if (nameField.Text.Equals("Введите имя..."))
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
                nameField.Text = "Введите имя...";
            }
        }

        private void surnameField_Enter(object sender, EventArgs e)
        {
            if (surnameField.Text.Equals("Введите фамилию..."))
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
                surnameField.Text = "Введите фамилию...";
            }
        }

        private void BirhdayFields_Enter(object sender, EventArgs e)
        {
            if (BirhdayFields.Text.Equals("Введите дату рождения..."))
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
                BirhdayFields.Text = "Введите дату рождения...";
            }
        }

        private void cityField_Enter(object sender, EventArgs e)
        {
            if (cityField.Text.Equals("Введите город проживания..."))
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
                cityField.Text = "Введите город проживания...";
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
                MessageBox.Show("Поле для логина обязательно для заполнения");
                return;
            }
            if (passwordField.Text == string.Empty)
            {
                MessageBox.Show("Поле для пароля обязательно для заполнения");
                return;
            }
            if (password2Field.Text == string.Empty)
            {
                MessageBox.Show("Поле для повторного пароля обязательно для заполнения");
                return;
            }
            if (passwordField.Text != password2Field.Text)
            {
                MessageBox.Show("Пароли должны совпадать");
                return;
            }
            if (nameField.Text == string.Empty || nameField.Text.Equals("Введите имя..."))
            {
                MessageBox.Show("Поле для имени обязательно для заполнения");
                return;
            }
            if (surnameField.Text == string.Empty || surnameField.Text.Equals("Введите фамилию..."))
            {
                MessageBox.Show("Поле для фамилии обязательно для заполнения");
                return;
            }
            if(cityField.Text == string.Empty || cityField.Text.Equals("Введите город проживания..."))
            {
                MessageBox.Show("Поле для города обязательно для заполнения");
                return;
            }
            if(sexMenButton.Checked == false && sexWomenButton.Checked == false)
            {
                MessageBox.Show("Поле для пола обязательно для заполнения");
                return;
            }
            using (var context = new AcquaintanceSqlContext())
            {
                var accounts = context.Accounts;
                foreach (var login in accounts)
                {
                    if (LoginField.Text.Equals(login.Login))
                    {
                        MessageBox.Show("Аккаунт с таким пользователем уже существует");
                        return;
                    }
                }
                foreach (var password in accounts)
                {
                    if (passwordField.Text.Equals(password.Password))
                    {
                        MessageBox.Show("Аккаунт с таким паролем уже существует");
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
                foreach(char letter in nameField.Text)
                {
                    if (!Char.IsLetter(letter))
                    {
                        MessageBox.Show("Вашем имени должны быть только буквы");
                        return;
                    }
                }
                user.Name = nameField.Text;

                foreach (char letter in surnameField.Text)
                {
                    if(!Char.IsLetter(letter)) 
                    {
                        MessageBox.Show("Вашей фамилии должны быть только буквы");
                        return;
                    }
                }
                user.Surname = surnameField.Text;

                DateTime time = BirhdayFields.Value;

                int yearOld = time.Year;
                int yearNow = DateTime.Now.Year;
                if((yearNow - yearOld) < 18)
                {
                    MessageBox.Show("Вы ещё слишком молоды");
                    return;
                }
                if((yearNow - yearOld) > 100)
                {
                    MessageBox.Show("Вам не может быть столько много лет");
                    return;
                }
                DateTime birth = new DateTime(time.Year, time.Month, time.Day);
                user.DateOfBirth = birth.ToString();

                AllCities Allcities = new AllCities();
                if (cityField.Text != string.Empty)
                {
                    if (!Allcities.getCities().Contains(cityField.Text.ToLower()))
                    {
                        MessageBox.Show("Такого города не сущеcтвует");
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
                MessageBox.Show("Регистрация прошла успешно");
                this.Hide();
                AuthorizationForm form = new AuthorizationForm();
                form.Show();
            }
        }  
    }     
}
