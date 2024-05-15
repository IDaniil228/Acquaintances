using HeartFluttering.Classes;
using HeartFluttering.Forms;
using HeartFluttering.Resources.Localization.AuthorForm;
using NLog;

namespace HeartFluttering
{
    public partial class AuthorizationForm : Form
    {
        /// <summary>
        /// Местоположении формы авторизации
        /// </summary>
        private Point lastPoint;
        private bool flag = false;
        private int currentIndex;
        /// <summary>
        /// Создаем экземпляр класса для логирования
        /// </summary>
        private static Logger logger = LogManager.GetCurrentClassLogger();
        public AuthorizationForm()
        {
            InitializeComponent();
            loginField.ForeColor = Color.Gray;
            passwordField.ForeColor = Color.Gray;
            logger.Info("Инициализация данных");
        }

        /// <summary>
        /// ÌМетод, который возвращает аккаунт по логину и паролю
        /// </summary>
        /// <param name="loginUsers"></param>
        /// <param name="passwordUsers"></param>
        /// <returns></returns>
        public Account UserAuthorization(string loginUsers, string passwordUsers) // Для тестирования
        {
            try
            {
                using (var context = new AcquaintanceSqlContext())
                {
                    Hash hash = new Hash();
                    string password = hash.CalculateMD5Hash(passwordUsers);
                    var account = context.Accounts.FirstOrDefault(r => r.Login.Equals(loginUsers) && r.Password.Equals(password));
                    logger.Info($"Получение аккаунта по логину: {loginUsers} и паролю: {password}");
                    return account;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                logger.Fatal("Ошибка подключения к базе данных");
                return null;
            }
        }
        /// <summary>
        /// Метод для входа пользователя или админа в аккаунт
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loginButton_Click(object sender, EventArgs e)
        {
            if (choice.Text.Equals(Inscriptions.User))
            {
                if (loginField.Text == string.Empty || loginField.Text.Equals(Inscriptions.Login))
                {
                    MessageBox.Show(Inscriptions.MessageEmptyLogin);
                    return;
                }
                if (passwordField.Text == string.Empty || passwordField.Text.Equals(Inscriptions.Password))
                {
                    MessageBox.Show(Inscriptions.MessageEmptyPassword);
                    return;
                }

                try
                {
                    using (var context = new AcquaintanceSqlContext())
                    {
                        var account = UserAuthorization(loginField.Text, passwordField.Text);
                        logger.Info("Получение аккаунта по логину и паролю");
                        if (account == null)
                        {
                            MessageBox.Show(Inscriptions.MessageWrongData);
                            return;
                        }
                        try
                        {
                            using (var context2 = new AcquaintanceSqlContext())
                            {
                                var person = context2.Users.FirstOrDefault(r => r.Id.Equals(account.Id));
                                logger.Info("Получение пользователя по данным аккаунта");
                                if (person == null)
                                {
                                    MessageBox.Show(Inscriptions.MessageNotFoundUser);
                                    return;
                                }
                                if (account != null && person == null)
                                {
                                    MessageBox.Show(Inscriptions.MessageCantEnterLikeUser);
                                    return;
                                }

                                if (person.Blocker == 1)
                                {
                                    MessageBox.Show("Форма входа занята, подождите пока пользователь пройдет регистрацию");
                                    return;
                                }

                                this.Hide();
                                HomeForm homeForm = new HomeForm();
                                CurrentUser.currentUser = person;
                                logger.Trace("Открытия главной формы");
                                homeForm.Show();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            logger.Fatal("Ошибка подключения к базе данных");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    logger.Fatal("Ошибка подключения к базе данных");
                }

            }
            else if (choice.Text.Equals(Inscriptions.Admin))
            {
                try
                {
                    using (var context = new AcquaintanceSqlContext())
                    {
                        var account = UserAuthorization(loginField.Text, passwordField.Text);
                        logger.Info("Получение аккаунта по логину и паролю");
                        if (account == null)
                        {
                            MessageBox.Show(Inscriptions.MessageWrongData);
                            return;
                        }
                        using (var context2 = new AcquaintanceSqlContext())
                        {
                            var admin = context2.Administrators.FirstOrDefault(r => r.Id.Equals(account.Id));
                            logger.Info("Получение администратора по данным аккаунта");
                            if (account != null && admin == null)
                            {
                                MessageBox.Show(Inscriptions.MessageCantEnterLikeAdmin);
                                return;
                            }
                            if (admin.Blocker == 1)
                            {
                                MessageBox.Show("Форма входа занята, подождите пока пользователь пройдет регистрацию");
                                return;
                            }
                            this.Hide();
                            AdministratorForm administratorForm = new AdministratorForm();
                            administratorForm.Show();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    logger.Fatal("Ошибка подключения к базе данных");
                }
            }
            else
            {
                MessageBox.Show(Inscriptions.MessageChooseRole);
                return;
            }

        }
        /// <summary>
        /// Кнопка для регистрации пользователя
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void registrButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new AcquaintanceSqlContext())
                {
                    var users = context.Users.ToList();
                    var admins = context.Administrators.ToList();
                    foreach (var user in users)
                    {
                        if (user.Blocker == 1)
                        {
                            MessageBox.Show("Форма регистрации занята");
                            return;
                        }
                    }
                    foreach (var admin in admins)
                    {
                        if (admin.Blocker == 1)
                        {
                            MessageBox.Show("Форма регистрации занята");
                            return;
                        }
                    }
                    foreach (var user in users)
                    {
                        user.Blocker = 1;
                    }
                    foreach (var admin in admins)
                    {
                        admin.Blocker = 1;
                    }
                    context.SaveChanges();
                }
                this.Hide();
                RegistrForm form = new RegistrForm();
                logger.Trace("Открытие формы регистрации");
                form.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                logger.Fatal("Ошибка подключения к базе данных");
            }
        }
        /// <summary>
        /// Сворачивание приложения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CollapseButton_Click(object sender, EventArgs e)
        {
            logger.Trace("Сворачивание приложения");
            this.WindowState = FormWindowState.Minimized;
        }
        /// <summary>
        /// Закрытие приложения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseButton_Click(object sender, EventArgs e)
        {
            logger.Debug("Закрытие приложения");
            Application.Exit();
        }
        /// <summary>
        /// Загрузка данных в форму
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AuthorizationForm_Load(object sender, EventArgs e)
        {
            logger.Debug("Загрузка данных");
            choice.Items.Add(Inscriptions.User);
            choice.Items.Add(Inscriptions.Admin);
            flag = false;
            if (EnterLike.Text == "Log in as")
            {
                LanguageComboBox.SelectedIndex = 1;
            }
            else
            {
                LanguageComboBox.SelectedIndex = 0;
            }


        }

        private void LanguageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!flag)
            {
                flag = true;
                return;
            }
            if (LanguageComboBox.SelectedIndex == 0)
            {
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("ru");
                currentIndex = 0;
            }
            else
            {
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
                currentIndex = 1;
            }
            Controls.Clear();
            InitializeComponent();
            flag = false;
            LanguageComboBox.SelectedIndex = currentIndex;
            choice.Items.Clear();
            choice.Items.Add(Inscriptions.User);
            choice.Items.Add(Inscriptions.Admin);
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
        /// Происваиваем новое местоположение для формы
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
        private void AuthorizationForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        /// <summary>
        /// Происваиваем новое местоположение для формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AuthorizationForm_MouseDown(object sender, MouseEventArgs e)
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
        /// Происваиваем новое местоположение для формы
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
        /// Происваиваем новое местоположение для формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void boyPhoto_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void BtnVK_Click(object sender, EventArgs e)
        {
            VkForm vkForm = new VkForm();
            vkForm.Show();
            Hide();
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
