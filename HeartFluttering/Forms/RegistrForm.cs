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
using NLog;

namespace HeartFluttering
{
    public partial class RegistrForm : Form
    {
        /// <summary>
        /// Местоположение формы
        /// </summary>
        private Point lastPoint;
        /// <summary>
        /// Создаём экземпляр класса для логирования
        /// </summary>
        private static Logger logger = LogManager.GetCurrentClassLogger();
        public RegistrForm()
        {
            InitializeComponent();
            logger.Info("Инициализация данных");
        }
        /// <summary>
        /// Кнопка для закрытия приложения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        ///
        private void CloseButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new AcquaintanceSqlContext())
                {
                    var users = context.Users.ToList();
                    var admins = context.Administrators.ToList();
                    foreach (var user in users)
                    {
                        user.Blocker = 0;
                    }
                    foreach (var admin in admins)
                    {
                        admin.Blocker = 0;
                    }
                    context.SaveChanges();
                }
                logger.Trace("Закрытие приложения");
                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                logger.Fatal("Ошибка в подключении к базе данных");
            }
        }
        /// <summary>
        /// Кнопка для сворачивания приложения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CollapseButton_Click(object sender, EventArgs e)
        {
            logger.Trace("Сворачивание приложения");
            this.WindowState = FormWindowState.Minimized;
        }
        /// <summary>
        /// При нажатии строку логина, подсказка убирает
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginField_Enter(object sender, EventArgs e)
        {
            if (LoginField.Text.Equals(Inscriptions.Login))
            {
                LoginField.Text = string.Empty;
                LoginField.ForeColor = Color.Black;
            }
        }
        /// <summary>
        /// При отжатии строки логина, появляется подсказка, если строка была пустой
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginField_Leave(object sender, EventArgs e)
        {
            if (LoginField.Text.Equals(string.Empty))
            {
                LoginField.ForeColor = Color.Gray;
                LoginField.Text = Inscriptions.Login;
            }
        }
        /// <summary>
        /// При нажатии строку пароля, подсказка убирает
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void passwordField_Enter(object sender, EventArgs e)
        {
            if (passwordField.Text.Equals(Inscriptions.Password))
            {
                passwordField.Text = string.Empty;
                passwordField.ForeColor = Color.Black;
            }
        }
        /// <summary>
        /// При отжатии строки пароля, появляется подсказка, если строка была пустой
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void passwordField_Leave(object sender, EventArgs e)
        {
            if (passwordField.Text.Equals(string.Empty))
            {
                passwordField.ForeColor = Color.Gray;
                passwordField.Text = Inscriptions.Password;
            }
        }
        /// <summary>
        /// При нажатии строку повторного пароля, подсказка убирает
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void password2Field_Enter(object sender, EventArgs e)
        {
            if (password2Field.Text.Equals(Inscriptions.Repeat_password))
            {
                password2Field.Text = string.Empty;
                password2Field.ForeColor = Color.Black;
            }
        }
        /// <summary>
        /// При отжатии строки повторного пароля, появляется подсказка, если строка была пустой
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void password2Field_Leave(object sender, EventArgs e)
        {
            if (password2Field.Text.Equals(string.Empty))
            {
                password2Field.ForeColor = Color.Gray;
                password2Field.Text = Inscriptions.Repeat_password;
            }
        }
        /// <summary>
        /// При нажатии строку имени, подсказка убирает
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nameField_Enter(object sender, EventArgs e)
        {
            if (nameField.Text.Equals(Inscriptions.Name))
            {
                nameField.Text = string.Empty;
                nameField.ForeColor = Color.Black;
            }
        }
        /// <summary>
        /// При отжатии строки имени, появляется подсказка, если строка была пустой
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nameField_Leave(object sender, EventArgs e)
        {
            if (nameField.Text.Equals(string.Empty))
            {
                nameField.ForeColor = Color.Gray;
                nameField.Text = Inscriptions.Name;
            }
        }
        /// <summary>
        /// При нажатии строку фамилии, подсказка убирает
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void surnameField_Enter(object sender, EventArgs e)
        {
            if (surnameField.Text.Equals(Inscriptions.Surname))
            {
                surnameField.Text = string.Empty;
                surnameField.ForeColor = Color.Black;
            }
        }
        /// <summary>
        /// При отжатии строки фамилии, появляется подсказка, если строка была пустой
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void surnameField_Leave(object sender, EventArgs e)
        {
            if (surnameField.Text.Equals(string.Empty))
            {
                surnameField.ForeColor = Color.Gray;
                surnameField.Text = Inscriptions.Surname;
            }
        }
        /// <summary>
        /// При нажатии строку даты рождения, подсказка убирает
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BirhdayFields_Enter(object sender, EventArgs e)
        {
            if (BirhdayFields.Text.Equals(Inscriptions.Birthday))
            {
                BirhdayFields.Text = string.Empty;
                BirhdayFields.ForeColor = Color.Black;
            }
        }
        /// <summary>
        /// При отжатии строки даты рождения, появляется подсказка, если строка была пустой
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BirhdayFields_Leave(object sender, EventArgs e)
        {
            if (BirhdayFields.Text.Equals(string.Empty))
            {
                BirhdayFields.ForeColor = Color.Gray;
                BirhdayFields.Text = Inscriptions.Birthday;
            }
        }
        /// <summary>
        /// При нажатии строку города, подсказка убирает
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cityField_Enter(object sender, EventArgs e)
        {
            if (cityField.Text.Equals(Inscriptions.City))
            {
                cityField.Text = string.Empty;
                cityField.ForeColor = Color.Black;
            }
        }
        /// <summary>
        /// При отжатии строки города, появляется подсказка, если строка была пустой
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cityField_Leave(object sender, EventArgs e)
        {
            if (cityField.Text.Equals(string.Empty))
            {
                cityField.ForeColor = Color.Gray;
                cityField.Text = Inscriptions.City;
            }
        }
        /// <summary>
        /// Метод, который создает аккаунт по логина и паролю
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <returns></returns>
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
                logger.Info("Получение всех аккаунтов");
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
                if (!Examination.CheckLetter(nameField.Text))
                {
                    MessageBox.Show(InscriptionsSignUp.LettersInName);
                    return;
                }
                logger.Warn("Проверка имени на корректные символы");
                user.Name = nameField.Text;
                if (!Examination.CheckLetter(surnameField.Text))
                {
                    MessageBox.Show(InscriptionsSignUp.LettersInSurname);
                    return;
                }
                logger.Warn("Проверка фамилия на корректные символы");
                user.Surname = surnameField.Text;

                DateTime time = BirhdayFields.Value;

                int yearOld = time.Year;
                int yearNow = DateTime.Now.Year;
                if ((yearNow - yearOld) < 18)
                {
                    MessageBox.Show(InscriptionsSignUp.Youth);
                    return;
                }
                if ((yearNow - yearOld) > 115)
                {
                    MessageBox.Show(InscriptionsSignUp.Old);
                    return;
                }
                logger.Warn("Проверка на корректный возраст пользователя");
                string birth = time.ToString("dd.MM.yyyy");
                user.DateOfBirth = birth;

                AllCities Allcities = new AllCities();
                if (!Examination.CheckCity(cityField.Text))
                {
                    MessageBox.Show(InscriptionsSignUp.CityIsNotExists);
                    return;
                }
                string city = Examination.GetCity(cityField.Text);
                user.City = city;
                if (sexMenButton.Checked)
                {
                    user.Sex = 1;
                }
                if (sexWomenButton.Checked)
                {
                    user.Sex = 0;
                }
                user.Id = guid.ToString();
                user.Blocker = 0;
                user.Likes = 0;
                context.Users.Add(user);
                context.SaveChanges();
                try
                {
                    using (var context2 = new AcquaintanceSqlContext())
                    {
                        var users = context2.Users.ToList();
                        var admins = context2.Administrators.ToList();
                        var bloking = context2.BlockerForms.FirstOrDefault();
                        if (bloking == null)
                        {
                            MessageBox.Show("Ошибка в подключении базы данных");
                            return;
                        }
                        bloking.BlockerLogin = 0;
                        foreach (var user1 in users)
                        {
                            user1.Blocker = 0;
                        }
                        foreach (var admin in admins)
                        {
                            admin.Blocker = 0;
                        }
                        context2.SaveChanges();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    logger.Fatal("Ошибка в подключении к базе данных");
                }

                MessageBox.Show(InscriptionsSignUp.Done);
                logger.Trace("Открытие формы входа");
                this.Hide();
                AuthorizationForm form = new AuthorizationForm();
                form.Show();
            }
        }

        private void RegistrForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                using (var context = new AcquaintanceSqlContext())
                {
                    var users = context.Users.ToList();
                    var admins = context.Administrators.ToList();
                    var bloking = context.BlockerForms.FirstOrDefault();
                    if (bloking == null)
                    {
                        MessageBox.Show("Ошибка в подключении базы данных");
                        return;
                    }
                    bloking.BlockerLogin = 0;
                    foreach (var user1 in users)
                    {
                        user1.Blocker = 0;
                    }
                    foreach (var admin in admins)
                    {
                        admin.Blocker = 0;
                    }
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                logger.Fatal("Ошибка в подключении к базе данных");
            }
        }
        /// <summary>
        /// Устанавливаем новое значение положения для формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RegistrForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        /// <summary>
        /// Присваиваем новое значение положения для формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RegistrForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        /// <summary>
        /// Устанавливаем новое значение положения для формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void entryLabel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        /// <summary>
        /// Присваиваем новое значение положения для формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void entryLabel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        /// <summary>
        /// Устанавливаем новое значение положения для формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void girlPhoto_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        /// <summary>
        /// Присваиваем новое значение положения для формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void girlPhoto_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        /// <summary>
        /// Устанавливаем новое значение положения для формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void boyPhoto_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        /// <summary>
        /// Присваиваем новое значение положения для формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void boyPhoto_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
    }
}
