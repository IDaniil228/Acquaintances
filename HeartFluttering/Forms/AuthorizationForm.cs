using HeartFluttering.Classes;
using HeartFluttering.Resources.Localization;
using NLog;
using System.Drawing.Text;

namespace HeartFluttering
{
    public partial class AuthorizationForm : Form
    {
        private bool flag = false;
        private int currentIndex;
        private static Logger logger = LogManager.GetCurrentClassLogger();
        public AuthorizationForm()
        {
            InitializeComponent();
            loginField.ForeColor = Color.Gray;
            passwordField.ForeColor = Color.Gray;
        }
        /// <summary>
        /// Ïðè íàæàòèè íà ñòðîêó ëîãèíà, ïîäñêàçêà ïðîïàäàåò
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loginField_Enter(object sender, EventArgs e)
        {
            if (loginField.Text.Equals(Inscriptions.Login))
            {
                loginField.Text = string.Empty;
                loginField.ForeColor = Color.Black;
            }
        }
        /// <summary>
        /// Ïðè îòæàòèè ñòðîêè ëîãèíà, ïîäñêàçêà ïîÿâëÿåòñÿ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loginField_Leave(object sender, EventArgs e)
        {
            if (loginField.Text.Equals(string.Empty))
            {
                loginField.ForeColor = Color.Gray;
                loginField.Text = Inscriptions.Login;
            }
        }
        /// <summary>
        /// Ïðè íàæàòèè íà ñòðîêó ïàðîëÿ, ïîäñêàçêà ïðîïàäàåò
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
        /// Ïðè îòæàòèè ñòðîêè ïàðîëÿ, ïîäñêàçêà ïîÿâëÿåòñÿ
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
        /// Ìåòîä, êîòîðûé âîçâðàùàåò äàííûå ïîëüçîâàòåëÿ ïî ëîãèíó è ïàðîëÿ
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
        /// Äàííàÿ êíîïêà ïîçâîëÿåòñÿ âîéòè â àêêàóíò äëÿ ïîëüçîâàòåëÿ èëè àäìèíèñòðàòîðà 
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
                using (var context = new AcquaintanceSqlContext())
                {
                    var account = UserAuthorization(loginField.Text, passwordField.Text);//Метод для проверки логина и пароля
                    if (account == null)
                    {
                        MessageBox.Show(Inscriptions.MessageWrongData);
                        return;
                    }
                    using (var context2 = new AcquaintanceSqlContext())
                    {
                        var person = context2.Users.FirstOrDefault(r => r.Id.Equals(account.Id));
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
                        this.Hide();
                        HomeForm homeForm = new HomeForm();
                        CurrentUser.currentUser = person;
                        homeForm.Show();
                    }
                }

            }
            else if (choice.Text.Equals(Inscriptions.Admin))
            {
                using (var context = new AcquaintanceSqlContext())
                {
                    var account = UserAuthorization(loginField.Text, passwordField.Text);
                    if (account == null)
                    {
                        MessageBox.Show(Inscriptions.MessageWrongData);
                        return;
                    }
                    using (var context2 = new AcquaintanceSqlContext())
                    {
                        var admin = context2.Administrators.FirstOrDefault(r => r.Id.Equals(account.Id));
                        if (account != null && admin == null)
                        {
                            MessageBox.Show(Inscriptions.MessageCantEnterLikeAdmin);
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
                MessageBox.Show(Inscriptions.MessageChooseRole);
                return;
            }

        }
        /// <summary>
        /// Ïåðåêèäûâàåò íà ôîðìó ðåãèñòðàöèè ïîëüçîâàòåëÿ
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
        /// Êîíïêà äëÿ ñâîðà÷èâàíèÿ ïðèëîæåíèÿ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CollapseButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        /// <summary>
        /// Êíîïêà äëÿ çàêðûòèÿ ïðèëîæåíèÿ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseButton_Click(object sender, EventArgs e)
        {
            logger.Debug("Âûõîä èç ïðèëîæåíèÿ");
            Application.Exit();
        }
        /// <summary>
        /// Çàãðóçêà îêíà àâòîðèçàöèè
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AuthorizationForm_Load(object sender, EventArgs e)
        {
            choice.Items.Add(Inscriptions.User);
            choice.Items.Add(Inscriptions.Admin);
            loginField.Text = Inscriptions.Login;
            passwordField.Text = Inscriptions.Password;
            flag = false;
            LanguageComboBox.SelectedIndex = 0;
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
            loginField.Text = Inscriptions.Login;
            passwordField.Text = Inscriptions.Password;
            choice.Items.Clear();
            choice.Items.Add(Inscriptions.User);
            choice.Items.Add(Inscriptions.Admin);
        }
    }
}
