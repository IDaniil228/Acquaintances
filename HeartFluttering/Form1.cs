namespace HeartFluttering
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            loginField.ForeColor = Color.Gray;
            passwordField.ForeColor = Color.Gray;
        }

        private void loginField_Enter(object sender, EventArgs e)
        {
            if (loginField.Text.Equals("Введите логин..."))
            {
                loginField.Text = string.Empty;
                loginField.ForeColor = Color.Black;
            }
        }

        private void loginField_Leave(object sender, EventArgs e)
        {
            if (loginField.Text.Equals(string.Empty))
            {
                loginField.ForeColor = Color.Gray;
                loginField.Text = "Введите логин...";
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
                using (var context = new AcquaintanceSqlContext())
                {
                    Hash hash = new Hash();
                    string password = hash.CalculateMD5Hash(passwordField.Text);
                    var account = context.Accounts.Where(r => r.Login.Equals(loginField.Text) && r.Password.Equals(password));
                    List<Account> list = new List<Account>();
                    foreach (Account account1 in account)
                    {
                        list.Add(account1);
                    }
                    if (list.Count == 0)
                    {
                        MessageBox.Show("Вы ввели неверно логин или пароль");
                        return;
                    }
                    string id = list[0].Id;
                    using (var context2 = new AcquaintanceSqlContext())
                    {
                        var person = context2.Users.Where(r => r.Id.Equals(id));
                        this.Hide();
                        HomeForm homeForm = new HomeForm();
                        List<User> users = new List<User>();
                        foreach (User user in person)
                        {
                            users.Add(user);
                        }
                        if (users[0].Name != null)
                        {
                            homeForm.nameField.Text = users[0].Name;
                            homeForm.nameField.ForeColor = Color.Black;
                        }
                        else
                        {
                            homeForm.nameField.Text = "Не заполнено";
                        }

                        if (users[0].Surname != null)
                        {
                            homeForm.surnameField.Text = users[0].Surname;
                            homeForm.surnameField.ForeColor = Color.Black;
                        }
                        else
                        {
                            homeForm.surnameField.Text = "Не заполнено";
                        }

                        if (users[0].DateOfBirth != null)
                        {
                            homeForm.BirhdayField.Text = users[0].DateOfBirth.ToString();
                            homeForm.BirhdayField.ForeColor = Color.Black;
                        }
                        else
                        {
                            homeForm.BirhdayField.Text = "Не заполнено";
                        }

                        if (users[0].City != null)
                        {
                            homeForm.cityField.Text = users[0].City;
                            homeForm.cityField.ForeColor = Color.Black;
                        }
                        else
                        {
                            homeForm.cityField.Text = "Не заполнено";
                        }

                        if (users[0].Sex != null)
                        {
                            if (users[0].Sex == 1)
                            {
                                homeForm.sexField.Text = "Мужской";
                                homeForm.sexField.ForeColor = Color.Black;
                            }
                            else
                            {
                                homeForm.sexField.Text = "Женский";
                                homeForm.sexField.ForeColor = Color.Black;
                            }
                        }
                        else
                        {
                            homeForm.sexField.Text = "Не заполнено";
                        }

                        if (users[0].Mail != null)
                        {
                            homeForm.emailField.Text = users[0].Mail;
                            homeForm.emailField.ForeColor = Color.Black;
                        }
                        else
                        {
                            homeForm.emailField.Text = "Не заполнено";
                        }

                        if (users[0].Number != null)
                        {
                            homeForm.numberField.Text = users[0].Number;
                            homeForm.numberField.ForeColor = Color.Black;
                        }
                        else
                        {
                            homeForm.numberField.Text = users[0].Number;
                        }

                        if (users[0].Photo != null)
                        {
                            MemoryStream memoryStream = new MemoryStream(users[0].Photo);
                            homeForm.photoField.Image = Image.FromStream(memoryStream);
                        }
                        homeForm.user = users[0];
                        homeForm.Show();
                    }
                }

            }
            else
            {
                using (var context = new AcquaintanceSqlContext())
                {
                    Hash hash = new Hash();
                    string password = hash.CalculateMD5Hash(passwordField.Text);
                    var account = context.Accounts.Where(r => r.Login.Equals(loginField.Text) && r.Password.Equals(password));
                    List<Account> list = new List<Account>();
                    foreach (Account account1 in account)
                    {
                        list.Add(account1);
                    }
                    if (list.Count == 0)
                    {
                        MessageBox.Show("Вы ввели неверно логин или пароль");
                        return;
                    }
                    string id = list[0].Id;
                    using (var context2 = new AcquaintanceSqlContext())
                    {
                        var admin = context2.Administrators.Where(r => r.Id.Equals(id));
                        this.Hide();
                        AdministratorForm administratorForm = new AdministratorForm();
                        List<Administrator> admins = new List<Administrator>();
                        foreach (Administrator administrator in admin)
                        {
                            admins.Add(administrator);
                        }
                        administratorForm.Show();
                    }

                }


            }

        }

        private void registrButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrForm form = new RegistrForm();
            form.Show();
        }

        private void CollapseButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
