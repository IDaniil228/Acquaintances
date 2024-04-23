using HeartFluttering.Classes;
using NLog;

namespace HeartFluttering
{
    public partial class AuthorizationForm : Form
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        public AuthorizationForm()
        {
            InitializeComponent();
            loginField.ForeColor = Color.Gray;
            passwordField.ForeColor = Color.Gray;
        }
        /// <summary>
        /// При нажатии на строку логина, подсказка пропадает
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loginField_Enter(object sender, EventArgs e)
        {
            if (loginField.Text.Equals("Введите логин..."))
            {
                loginField.Text = string.Empty;
                loginField.ForeColor = Color.Black;
            }
        }
        /// <summary>
        /// При отжатии строки логина, подсказка появляется
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loginField_Leave(object sender, EventArgs e)
        {
            if (loginField.Text.Equals(string.Empty))
            {
                loginField.ForeColor = Color.Gray;
                loginField.Text = "Введите логин...";
            }
        }
        /// <summary>
        /// При нажатии на строку пароля, подсказка пропадает
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void passwordField_Enter(object sender, EventArgs e)
        {
            if (passwordField.Text.Equals("Введите пароль..."))
            {
                passwordField.Text = string.Empty;
                passwordField.ForeColor = Color.Black;
            }
        }
        /// <summary>
        /// При отжатии строки пароля, подсказка появляется
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void passwordField_Leave(object sender, EventArgs e)
        {
            if (passwordField.Text.Equals(string.Empty))
            {
                passwordField.ForeColor = Color.Gray;
                passwordField.Text = "Введите пароль...";
            }
        }
        /// <summary>
        /// Метод, который возвращает данные пользователя по логину и пароля
        /// </summary>
        /// <param name="loginUsers"></param>
        /// <param name="passwordUsers"></param>
        /// <returns></returns>
        private Account UserAuthorization(string loginUsers, string passwordUsers)
        {
            using (var context = new AcquaintanceSqlContext())
            {
                Hash hash = new Hash();
                string password = hash.CalculateMD5Hash(passwordUsers);
                var account = context.Accounts.FirstOrDefault(r => r.Login.Equals(loginUsers) && r.Password.Equals(password));
                return account;
            }
        }
        /// <summary>
        /// Данная кнопка позволяется войти в аккаунт для пользователя или администратора 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loginButton_Click(object sender, EventArgs e)
        {
            if (choice.Text.Equals("Пользователь"))
            {
                if (loginField.Text == string.Empty || loginField.Text.Equals("Введите логин..."))
                {
                    MessageBox.Show("Пустое поле для логина");
                    return;
                }
                if (passwordField.Text == string.Empty || passwordField.Text.Equals("Введите пароль..."))
                {
                    MessageBox.Show("Пустое поле для пароля");
                    return;
                }
                try
                {
                    using (var context = new AcquaintanceSqlContext())
                    {
                        var account = UserAuthorization(loginField.Text, passwordField.Text);//Метод для проверки логина и пароля
                        if (account == null)
                        {
                            MessageBox.Show("Вы ввели неверно логин или пароль");
                            return;
                        }
                        try
                        {
                            using (var context2 = new AcquaintanceSqlContext())
                            {
                                var person = context2.Users.FirstOrDefault(r => r.Id.Equals(account.Id));
                                if (person == null)
                                {
                                    MessageBox.Show("Не удалось найти пользователя");
                                    return;
                                }
                                if (account != null && person == null)
                                {
                                    MessageBox.Show("Вы не можете войти через пользователя");
                                    return;
                                }
                                this.Hide();
                                HomeForm homeForm = new HomeForm();
                                CurrentUser.currentUser = person;
                                homeForm.Show();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    logger.Fatal("Ошибка в подключении базы данных");
                }
            }
            else if(choice.Text.Equals("Администратор"))
            {
                using (var context = new AcquaintanceSqlContext())
                {
                    var account = UserAuthorization(loginField.Text, passwordField.Text);
                    if(account == null)
                    {
                        MessageBox.Show("Неверно введены логин или пароль");
                        return;
                    }
                    using (var context2 = new AcquaintanceSqlContext())
                    {
                        var admin = context2.Administrators.FirstOrDefault(r => r.Id.Equals(account.Id));
                        if(account != null && admin == null)
                        {
                            MessageBox.Show("Вы не можете войти через администратора");
                            return;
                        }
                        this.Hide();
                        AdministratorForm administratorForm = new AdministratorForm();
                        administratorForm.Show();
                    }
                }
            }
            else
            {
                MessageBox.Show("Выберите аккаунт пользователя или администратора");
                return;
            }

        }
        /// <summary>
        /// Перекидывает на форму регистрации пользователя
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void registrButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrForm form = new RegistrForm();
            form.Show();
        }
        /// <summary>
        /// Конпка для сворачивания приложения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CollapseButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        /// <summary>
        /// Кнопка для закрытия приложения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseButton_Click(object sender, EventArgs e)
        {
            //
            logger.Debug("Выход из приложения");
            Application.Exit();
        }
    }
}
