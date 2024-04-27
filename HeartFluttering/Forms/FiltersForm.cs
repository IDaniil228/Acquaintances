using HeartFluttering.Classes;
using HeartFluttering.Resources.Localization.FilterForm;
using Microsoft.VisualBasic;
using NLog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeartFluttering
{
    public partial class FiltersForm : Form
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        public FiltersForm()
        {
            InitializeComponent();
            logger.Info("Инициализация данных");
        }
        /// <summary>
        /// Кнопка закрытия приложения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseButton_Click(object sender, EventArgs e)
        {
            logger.Trace("Закрытие приложения");
            Application.Exit();
        }
        /// <summary>
        /// Кнопка скрытия приложения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CollapseButton_Click(object sender, EventArgs e)
        {
            logger.Trace("Сворачивание приложения");
            this.WindowState = FormWindowState.Minimized;
        }
        /// <summary>
        /// Кнопка для установка фильтров
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FiltersButton_Click(object sender, EventArgs e)
        {
            if (InitialAgeField.Text == string.Empty)
            {
                MessageBox.Show(InscriptionsFilter.Age);
                return;
            }
            if (FinalAgeField.Text == string.Empty)
            {
                MessageBox.Show(InscriptionsFilter.Age);
                return;
            }
            if (InitialAgeField.Text != null)
            {
                foreach (char symbol in InitialAgeField.Text)
                {
                    if (!Char.IsNumber(symbol))
                    {
                        MessageBox.Show(InscriptionsFilter.OnlyNumb);
                        return;
                    }
                }
            }
            logger.Warn("Проверка на корректный возраст");
            int InitialAge = Convert.ToInt32(InitialAgeField.Text);
            foreach (char symbol in FinalAgeField.Text)
            {
                if (!Char.IsNumber(symbol))
                {
                    MessageBox.Show(InscriptionsFilter.OnlyNumb);
                    return;
                }
            }
            logger.Warn("Проверка на корректный возраст");
            int FinalAge = Convert.ToInt32(FinalAgeField.Text);
            AllCities allCities = new AllCities();
            if (cityField.Text != string.Empty)
            {
                if (!allCities.getCities().Contains(cityField.Text.ToLower()))
                {
                    MessageBox.Show(InscriptionsFilter.CityExist);
                    return;
                }
            }
            logger.Warn("Проверка на существующий город");
            if(InitialAge < 18)
            {
                // Для Дани, доделать локализацию
                MessageBox.Show("Нельзя найти такого молодого пользователя");
                return;
            }
            if(FinalAge > 115)
            {
                // Для Дани, доделать локализацию
                MessageBox.Show("Нельзя найти такого старого пользователя");
                return;
            }
            int age = FinalAge - InitialAge;
            if (age < 0)
            {
                MessageBox.Show(InscriptionsFilter.AgeРositive);
                return;
            }
            if (sexMenButton.Checked == false && sexWomenButton.Checked == false)
            {
                MessageBox.Show(InscriptionsFilter.Sex);
                return;
            }
            List<User> currentUsers = new List<User>();

            PhotoUserForm photoUserForm = new PhotoUserForm();
            if (cityField.Text == string.Empty && sexMenButton.Checked == true)
            {
                try
                {
                    using (var context = new AcquaintanceSqlContext())
                    {
                        var users = context.Users.Where(r => r.Sex == 1);
                        foreach (User user in users)
                        {
                            DateTimeFormatInfo provider = new DateTimeFormatInfo();
                            provider.ShortDatePattern = "dd.MM.yyyy";
                            try
                            {
                                if (CurrentUser.currentUser.AnotherAccounts == null)
                                {
                                    if (!user.IdUsers.Equals(CurrentUser.currentUser.IdUsers))
                                    {
                                        if ((DateTime.Now.Year - DateTime.ParseExact(user.DateOfBirth, "dd.MM.yyyy H:mm:ss", provider).Year) >= InitialAge &&
                                    (DateTime.Now.Year - DateTime.ParseExact(user.DateOfBirth, "dd.MM.yyyy H:mm:ss", provider).Year) <= FinalAge)
                                        {
                                            currentUsers.Add(user);
                                        }
                                    }
                                }
                                else if (!CurrentUser.currentUser.AnotherAccounts.Split(',').Contains(user.IdUsers))
                                {
                                    if (!user.IdUsers.Equals(CurrentUser.currentUser.IdUsers))
                                    {
                                        if ((DateTime.Now.Year - DateTime.ParseExact(user.DateOfBirth, "dd.MM.yyyy H:mm:ss", provider).Year) >= InitialAge &&
                                    (DateTime.Now.Year - DateTime.ParseExact(user.DateOfBirth, "dd.MM.yyyy H:mm:ss", provider).Year) <= FinalAge)
                                        {
                                            currentUsers.Add(user);
                                        }
                                    }
                                }
                                logger.Warn("Получение пользователей по установленным фильтрам");
                            }
                            catch (Exception ex)
                            {
                                logger.Error("Ошибка расшифровки даты");
                                MessageBox.Show(ex.Message);
                                return;
                            }
                        }
                        photoUserForm.currentUsers = currentUsers;
                        logger.Trace("Открытие формы для поиска пользователей по установленным фильтрам");
                        this.Hide();
                        photoUserForm.Show();
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    logger.Fatal("Ошибка в подключение к базе данных");
                }
            }
            if (cityField.Text == string.Empty && sexWomenButton.Checked == true)
            {
                try
                {
                    using (var context = new AcquaintanceSqlContext())
                    {
                        var users = context.Users.Where(r => r.Sex == 0);
                        foreach (User user in users)
                        {
                            DateTimeFormatInfo provider = new DateTimeFormatInfo();
                            provider.ShortDatePattern = "dd.MM.yyyy";
                            try
                            {
                                if (CurrentUser.currentUser.AnotherAccounts == null)
                                {
                                    if (!user.IdUsers.Equals(CurrentUser.currentUser.IdUsers))
                                    {
                                        if ((DateTime.Now.Year - DateTime.ParseExact(user.DateOfBirth, "dd.MM.yyyy H:mm:ss", provider).Year) >= InitialAge &&
                                         (DateTime.Now.Year - DateTime.ParseExact(user.DateOfBirth, "dd.MM.yyyy H:mm:ss", provider).Year) <= FinalAge)
                                        {
                                            currentUsers.Add(user);
                                        }
                                    }
                                }
                                else if (!CurrentUser.currentUser.AnotherAccounts.Split(',').Contains(user.IdUsers))
                                {
                                    if (!user.IdUsers.Equals(CurrentUser.currentUser.IdUsers))
                                    {
                                        if ((DateTime.Now.Year - DateTime.ParseExact(user.DateOfBirth, "dd.MM.yyyy H:mm:ss", provider).Year) >= InitialAge &&
                                         (DateTime.Now.Year - DateTime.ParseExact(user.DateOfBirth, "dd.MM.yyyy H:mm:ss", provider).Year) <= FinalAge)
                                        {
                                            currentUsers.Add(user);
                                        }
                                    }
                                }
                                logger.Warn("Получение пользователей по установленным фильтрам");
                            }
                            catch (Exception ex)
                            {
                                logger.Error("Ошибка расшифровки даты");
                                MessageBox.Show(ex.Message);
                                return;
                            }
                        }
                        logger.Trace("Открытие формы для поиска пользователей по установленным фильтрам");
                        photoUserForm.currentUsers = currentUsers;
                        this.Hide();
                        photoUserForm.Show();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    logger.Fatal("Ошибка в подключение к базе данных");
                }
            }
            if (cityField.Text != string.Empty && sexMenButton.Checked == true)
            {
                try
                {
                    using (var context = new AcquaintanceSqlContext())
                    {
                        var users = context.Users.Where(r => r.Sex == 1 && r.City.Equals(cityField.Text));
                        foreach (User user in users)
                        {
                            DateTimeFormatInfo provider = new DateTimeFormatInfo();
                            provider.ShortDatePattern = "dd.MM.yyyy";
                            try
                            {
                                if (CurrentUser.currentUser.AnotherAccounts == null)
                                {
                                    if (!user.IdUsers.Equals(CurrentUser.currentUser.IdUsers))
                                    {
                                        if ((DateTime.Now.Year - DateTime.ParseExact(user.DateOfBirth, "dd.MM.yyyy H:mm:ss", provider).Year) >= InitialAge &&
                                    (DateTime.Now.Year - DateTime.ParseExact(user.DateOfBirth, "dd.MM.yyyy H:mm:ss", provider).Year) <= FinalAge)
                                        {
                                            currentUsers.Add(user);
                                        }
                                    }
                                }
                                else if (!CurrentUser.currentUser.AnotherAccounts.Split(',').Contains(user.IdUsers))
                                {
                                    if (!user.IdUsers.Equals(CurrentUser.currentUser.IdUsers))
                                    {
                                        if ((DateTime.Now.Year - DateTime.ParseExact(user.DateOfBirth, "dd.MM.yyyy H:mm:ss", provider).Year) >= InitialAge &&
                                    (DateTime.Now.Year - DateTime.ParseExact(user.DateOfBirth, "dd.MM.yyyy H:mm:ss", provider).Year) <= FinalAge)
                                        {
                                            currentUsers.Add(user);
                                        }
                                    }
                                }
                                logger.Warn("Получение пользователей по установленным фильтрам");
                            }
                            catch (Exception ex)
                            {
                                logger.Error("Ошибка расшифровки даты");
                                MessageBox.Show(ex.Message);
                                return;
                            }
                        }
                    }
                    logger.Trace("Открытие формы для поиска пользователей по установленным фильтрам");
                    photoUserForm.currentUsers = currentUsers;
                    this.Hide();
                    photoUserForm.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    logger.Fatal("Ошибка в подключение к базе данных");
                }
            }
            if (cityField.Text != string.Empty && sexWomenButton.Checked == true)
            {
                try
                {
                    using (var context = new AcquaintanceSqlContext())
                    {
                        var users = context.Users.Where(r => r.Sex == 0 && r.City.Equals(cityField.Text));
                        foreach (User user in users)
                        {
                            DateTimeFormatInfo provider = new DateTimeFormatInfo();
                            provider.ShortDatePattern = "dd.MM.yyyy";
                            try
                            {
                                if (CurrentUser.currentUser.AnotherAccounts == null)
                                {
                                    if (!user.IdUsers.Equals(CurrentUser.currentUser.IdUsers))
                                    {
                                        if ((DateTime.Now.Year - DateTime.ParseExact(user.DateOfBirth, "dd.MM.yyyy H:mm:ss", provider).Year) >= InitialAge &&
                                    (DateTime.Now.Year - DateTime.ParseExact(user.DateOfBirth, "dd.MM.yyyy H:mm:ss", provider).Year) <= FinalAge)
                                        {
                                            currentUsers.Add(user);
                                        }
                                    }
                                }
                                else if (!CurrentUser.currentUser.AnotherAccounts.Split(',').Contains(user.IdUsers))
                                {
                                    if (!user.IdUsers.Equals(CurrentUser.currentUser.IdUsers))
                                    {
                                        if ((DateTime.Now.Year - DateTime.ParseExact(user.DateOfBirth, "dd.MM.yyyy H:mm:ss", provider).Year) >= InitialAge &&
                                    (DateTime.Now.Year - DateTime.ParseExact(user.DateOfBirth, "dd.MM.yyyy H:mm:ss", provider).Year) <= FinalAge)
                                        {
                                            currentUsers.Add(user);
                                        }
                                    }
                                }
                                logger.Warn("Получение пользователей по установленным фильтрам");
                            }
                            catch (Exception ex)
                            {
                                logger.Error("Ошибка расшифровки даты");
                                MessageBox.Show(ex.Message);
                                return;
                            }
                        }
                    }
                    logger.Trace("Открытие формы для поиска пользователей по установленным фильтрам");
                    photoUserForm.currentUsers = currentUsers;
                    this.Hide();
                    photoUserForm.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    logger.Fatal("Ошибка в подключение к базе данных");
                }
            }
        }
    }
}
