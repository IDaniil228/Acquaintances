using HeartFluttering.Classes;
using HeartFluttering.Resources.Localization.FilterForm;
using NLog;
using System.Data;
using System.Globalization;

namespace HeartFluttering
{
    public partial class FiltersForm : Form
    {
        /// <summary>
        /// Местоположение формы
        /// </summary>
        private Point lastPoint;
        /// <summary>
        /// Создаём экземпляр класса для логирования
        /// </summary>
        private static Logger logger = LogManager.GetCurrentClassLogger();
        private bool maximize = false;

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
            if (InitialAge < 18)
            {
                // Для Дани, доделать локализацию
                MessageBox.Show("Нельзя найти такого молодого пользователя");
                return;
            }
            if (FinalAge > 115)
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
            if (CurrentUser.currentUser != null)
            {
                if (CurrentUser.currentUser.Sex == 1)
                {
                    sexWomenButton.Checked = true;
                }
            }
            if (CurrentUser.currentUser != null)
            {
                if (CurrentUser.currentUser.Sex == 0)
                {
                    sexMenButton.Checked = true;
                }
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
                                        if ((DateTime.Now.Year - DateTime.ParseExact(user.DateOfBirth, "dd.MM.yyyy", provider).Year) >= InitialAge &&
                                    (DateTime.Now.Year - DateTime.ParseExact(user.DateOfBirth, "dd.MM.yyyy", provider).Year) <= FinalAge)
                                        {
                                            currentUsers.Add(user);
                                        }
                                    }
                                }
                                else if (!CurrentUser.currentUser.AnotherAccounts.Split(',').Contains(user.IdUsers))
                                {
                                    if (!user.IdUsers.Equals(CurrentUser.currentUser.IdUsers))
                                    {
                                        if ((DateTime.Now.Year - DateTime.ParseExact(user.DateOfBirth, "dd.MM.yyyy", provider).Year) >= InitialAge &&
                                    (DateTime.Now.Year - DateTime.ParseExact(user.DateOfBirth, "dd.MM.yyyy", provider).Year) <= FinalAge)
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
                catch (Exception ex)
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
                                        if ((DateTime.Now.Year - DateTime.ParseExact(user.DateOfBirth, "dd.MM.yyyy", provider).Year) >= InitialAge &&
                                         (DateTime.Now.Year - DateTime.ParseExact(user.DateOfBirth, "dd.MM.yyyy", provider).Year) <= FinalAge)
                                        {
                                            currentUsers.Add(user);
                                        }
                                    }
                                }
                                else if (!CurrentUser.currentUser.AnotherAccounts.Split(',').Contains(user.IdUsers))
                                {
                                    if (!user.IdUsers.Equals(CurrentUser.currentUser.IdUsers))
                                    {
                                        if ((DateTime.Now.Year - DateTime.ParseExact(user.DateOfBirth, "dd.MM.yyyy", provider).Year) >= InitialAge &&
                                         (DateTime.Now.Year - DateTime.ParseExact(user.DateOfBirth, "dd.MM.yyyy", provider).Year) <= FinalAge)
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
                                        if ((DateTime.Now.Year - DateTime.ParseExact(user.DateOfBirth, "dd.MM.yyyy", provider).Year) >= InitialAge &&
                                    (DateTime.Now.Year - DateTime.ParseExact(user.DateOfBirth, "dd.MM.yyyy", provider).Year) <= FinalAge)
                                        {
                                            currentUsers.Add(user);
                                        }
                                    }
                                }
                                else if (!CurrentUser.currentUser.AnotherAccounts.Split(',').Contains(user.IdUsers))
                                {
                                    if (!user.IdUsers.Equals(CurrentUser.currentUser.IdUsers))
                                    {
                                        if ((DateTime.Now.Year - DateTime.ParseExact(user.DateOfBirth, "dd.MM.yyyy", provider).Year) >= InitialAge &&
                                    (DateTime.Now.Year - DateTime.ParseExact(user.DateOfBirth, "dd.MM.yyyy", provider).Year) <= FinalAge)
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
                                        if ((DateTime.Now.Year - DateTime.ParseExact(user.DateOfBirth, "dd.MM.yyyy", provider).Year) >= InitialAge &&
                                    (DateTime.Now.Year - DateTime.ParseExact(user.DateOfBirth, "dd.MM.yyyy", provider).Year) <= FinalAge)
                                        {
                                            currentUsers.Add(user);
                                        }
                                    }
                                }
                                else if (!CurrentUser.currentUser.AnotherAccounts.Split(',').Contains(user.IdUsers))
                                {
                                    if (!user.IdUsers.Equals(CurrentUser.currentUser.IdUsers))
                                    {
                                        if ((DateTime.Now.Year - DateTime.ParseExact(user.DateOfBirth, "dd.MM.yyyy", provider).Year) >= InitialAge &&
                                    (DateTime.Now.Year - DateTime.ParseExact(user.DateOfBirth, "dd.MM.yyyy", provider).Year) <= FinalAge)
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
        /// <summary>
        /// Устанавливаем новое местоположение для формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FullterPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        /// <summary>
        /// Присваиваем новое местоположение для формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FullterPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        /// <summary>
        /// Устанавливаем новое местоположение для формы
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
        /// Присваиваем новое местоположение для формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void entryLabel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        /// <summary>
        /// Устанавливаем новое местоположение для формы
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
        /// Присваиваем новое местоположение для формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void girlPhoto_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        /// <summary>
        /// Устанавливаем новое местоположение для формы
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
        /// Присваиваем новое местоположение для формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void boyPhoto_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void BtnSize_Click(object sender, EventArgs e)
        {
            if (!maximize)
            {
                WindowState = FormWindowState.Maximized;
                maximize = true;
            }
            else
            {
                WindowState = FormWindowState.Normal;
                maximize = false;
            }
        }
    }
}
