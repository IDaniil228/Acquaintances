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
        /// ��� ������� �� ������ ������, ��������� ���������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loginField_Enter(object sender, EventArgs e)
        {
            if (loginField.Text.Equals("������� �����..."))
            {
                loginField.Text = string.Empty;
                loginField.ForeColor = Color.Black;
            }
        }
        /// <summary>
        /// ��� ������� ������ ������, ��������� ����������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loginField_Leave(object sender, EventArgs e)
        {
            if (loginField.Text.Equals(string.Empty))
            {
                loginField.ForeColor = Color.Gray;
                loginField.Text = "������� �����...";
            }
        }
        /// <summary>
        /// ��� ������� �� ������ ������, ��������� ���������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void passwordField_Enter(object sender, EventArgs e)
        {
            if (passwordField.Text.Equals("������� ������..."))
            {
                passwordField.Text = string.Empty;
                passwordField.ForeColor = Color.Black;
            }
        }
        /// <summary>
        /// ��� ������� ������ ������, ��������� ����������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void passwordField_Leave(object sender, EventArgs e)
        {
            if (passwordField.Text.Equals(string.Empty))
            {
                passwordField.ForeColor = Color.Gray;
                passwordField.Text = "������� ������...";
            }
        }
        /// <summary>
        /// �����, ������� ���������� ������ ������������ �� ������ � ������
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
        /// ������ ������ ����������� ����� � ������� ��� ������������ ��� �������������� 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loginButton_Click(object sender, EventArgs e)
        {
            if (choice.Text.Equals("������������"))
            {
                if (loginField.Text == string.Empty || loginField.Text.Equals("������� �����..."))
                {
                    MessageBox.Show("������ ���� ��� ������");
                    return;
                }
                if (passwordField.Text == string.Empty || passwordField.Text.Equals("������� ������..."))
                {
                    MessageBox.Show("������ ���� ��� ������");
                    return;
                }
                try
                {
                    using (var context = new AcquaintanceSqlContext())
                    {
                        var account = UserAuthorization(loginField.Text, passwordField.Text);//����� ��� �������� ������ � ������
                        if (account == null)
                        {
                            MessageBox.Show("�� ����� ������� ����� ��� ������");
                            return;
                        }
                        try
                        {
                            using (var context2 = new AcquaintanceSqlContext())
                            {
                                var person = context2.Users.FirstOrDefault(r => r.Id.Equals(account.Id));
                                if (person == null)
                                {
                                    MessageBox.Show("�� ������� ����� ������������");
                                    return;
                                }
                                if (account != null && person == null)
                                {
                                    MessageBox.Show("�� �� ������ ����� ����� ������������");
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
                    logger.Fatal("������ � ����������� ���� ������");
                }
            }
            else if(choice.Text.Equals("�������������"))
            {
                using (var context = new AcquaintanceSqlContext())
                {
                    var account = UserAuthorization(loginField.Text, passwordField.Text);
                    if(account == null)
                    {
                        MessageBox.Show("������� ������� ����� ��� ������");
                        return;
                    }
                    using (var context2 = new AcquaintanceSqlContext())
                    {
                        var admin = context2.Administrators.FirstOrDefault(r => r.Id.Equals(account.Id));
                        if(account != null && admin == null)
                        {
                            MessageBox.Show("�� �� ������ ����� ����� ��������������");
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
                MessageBox.Show("�������� ������� ������������ ��� ��������������");
                return;
            }

        }
        /// <summary>
        /// ������������ �� ����� ����������� ������������
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
        /// ������ ��� ������������ ����������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CollapseButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        /// <summary>
        /// ������ ��� �������� ����������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseButton_Click(object sender, EventArgs e)
        {
            //
            logger.Debug("����� �� ����������");
            Application.Exit();
        }
    }
}
