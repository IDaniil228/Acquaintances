namespace HeartFluttering
{
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
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
                    var account = context.Accounts.FirstOrDefault(r => r.Login.Equals(loginField.Text) && r.Password.Equals(password));
                    if(account == null)
                    {
                        MessageBox.Show("Вы ввели неверно логин или пароль");
                        return;
                    }
                    
                    string id = account.Id;
                    using (var context2 = new AcquaintanceSqlContext())
                    {
                        var person = context2.Users.FirstOrDefault(r => r.Id.Equals(id));
                        if(person == null)
                        {
                            MessageBox.Show("Не удалось найти пользователя");
                            return;
                        }
                        this.Hide();
                        HomeForm homeForm = new HomeForm();
                        if (person.Name != null)
                        {
                            homeForm.nameField.Text = person.Name;
                            homeForm.nameField.ForeColor = Color.Black;
                        }
                        else
                        {
                            homeForm.nameField.Text = "Не заполнено";
                        }

                        if (person.Surname != null)
                        {
                            homeForm.surnameField.Text = person.Surname;
                            homeForm.surnameField.ForeColor = Color.Black;
                        }
                        else
                        {
                            homeForm.surnameField.Text = "Не заполнено";
                        }

                        if (person.DateOfBirth != null)
                        {
                            homeForm.BirhdayField.Text = person.DateOfBirth.ToString();
                            homeForm.BirhdayField.ForeColor = Color.Black;
                        }
                        else
                        {
                            homeForm.BirhdayField.Text = "Не заполнено";
                        }

                        if (person.City != null)
                        {
                            homeForm.cityField.Text = person.City;
                            homeForm.cityField.ForeColor = Color.Black;
                        }
                        else
                        {
                            homeForm.cityField.Text = "Не заполнено";
                        }

                        if (person.Sex != null)
                        {
                            if (person.Sex == 1)
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

                        if (person.Mail != null)
                        {
                            homeForm.emailField.Text = person.Mail;
                            homeForm.emailField.ForeColor = Color.Black;
                        }
                        else
                        {
                            homeForm.emailField.Text = "Не заполнено";
                        }

                        if (person.Number != null)
                        {
                            homeForm.numberField.Text = person.Number;
                            homeForm.numberField.ForeColor = Color.Black;
                        }
                        else
                        {
                            homeForm.numberField.Text = person.Number;
                        }

                        if (person.Photo != null)
                        {
                            MemoryStream memoryStream = new MemoryStream(person.Photo);
                            homeForm.photoField.Image = Image.FromStream(memoryStream);
                        }
                        CurrentUser.currentUser = person;
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
                    var account = context.Accounts.FirstOrDefault(r => r.Login.Equals(loginField.Text) && r.Password.Equals(password));
                    if(account == null)
                    {
                        MessageBox.Show("Неверно введены логин или пароль");
                    }
                    string id = account.Id;
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
