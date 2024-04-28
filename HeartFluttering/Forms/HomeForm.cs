using HeartFluttering.Classes;
using HeartFluttering.Resources.Localization.ChooseOneForm;
using NLog;
using System.Data;


namespace HeartFluttering
{
    public partial class HomeForm : Form
    {
        /// <summary>
        /// Местоположение формы
        /// </summary>
        private Point lastPoint;
        /// <summary>
        /// Создаём экземпляр класса для логирования
        /// </summary>
        private static Logger logger = LogManager.GetCurrentClassLogger();
        public HomeForm()
        {
            InitializeComponent();
            logger.Info("Инициализация данных");
        }
        /// <summary>
        /// Кнопка для закрытия приложения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseButton_Click(object sender, EventArgs e)
        {
            logger.Trace("Закрытие приложения");
            Application.Exit();
        }
        /// <summary>
        /// Кнопка для сворачивания приложения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CollapseButton_Click(object sender, EventArgs e)
        {
            logger.Trace("Сворачение приложения");
            this.WindowState = FormWindowState.Minimized;
        }
        /// <summary>
        /// Кнопка для выхода из аккаунта
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void closeAccount_Click(object sender, EventArgs e)
        {
            logger.Trace("Переход в форму входа");
            this.Hide();
            AuthorizationForm form = new AuthorizationForm();
            form.Show();
        }
        /// <summary>
        /// Кнопка для открытия редактировния
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void redactionButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditingForm editingForm = new EditingForm();
            editingForm.nameField.Text = CurrentUser.currentUser.Name;
            editingForm.nameField.ForeColor = Color.Black;
            editingForm.surnameField.Text = CurrentUser.currentUser.Surname;
            editingForm.surnameField.ForeColor = Color.Black;
            if (CurrentUser.currentUser.DateOfBirth != null)
            {
                editingForm.birhdayField.Text = CurrentUser.currentUser.DateOfBirth;
                editingForm.birhdayField.ForeColor = Color.Black;
            }
            if (CurrentUser.currentUser.City != null)
            {
                editingForm.cityField.Text = CurrentUser.currentUser.City;
                editingForm.cityField.ForeColor = Color.Black;
            }
            if (CurrentUser.currentUser.Sex != null)
            {
                if (CurrentUser.currentUser.Sex == 1)
                {
                    editingForm.sexMenButton.Checked = true;
                }
                else
                {
                    editingForm.sexWomenButton.Checked = true;
                }
            }
            if (CurrentUser.currentUser.Mail != null)
            {
                editingForm.emailField.Text = CurrentUser.currentUser.Mail;
                editingForm.emailField.ForeColor = Color.Black;
            }
            if (CurrentUser.currentUser.Number != null)
            {
                editingForm.numberField.Text = CurrentUser.currentUser.Number;
                editingForm.numberField.ForeColor = Color.Black;
            }
            editingForm.user = CurrentUser.currentUser;
            logger.Trace("Открытие формы редактирования");
            editingForm.ShowDialog();
        }
        /// <summary>
        /// Кнопка для загрузке данных в главном профиле
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HomeForm_Load(object sender, EventArgs e)
        {
            logger.Info("Загрузка данных в главной формы");
            nameField.Text = CurrentUser.currentUser.Name;
            surnameField.Text = CurrentUser.currentUser.Surname;
            BirhdayField.Text = CurrentUser.currentUser.DateOfBirth;
            cityField.Text = CurrentUser.currentUser.City;
            if (CurrentUser.currentUser.Sex == 1)
            {
                sexField.Text = "Мужской";
            }
            if (CurrentUser.currentUser.Sex == 0)
            {
                sexField.Text = "Женский";
            }
            emailField.Text = CurrentUser.currentUser.Mail;
            numberField.Text = CurrentUser.currentUser.Number;
            if (CurrentUser.currentUser.Photo != null)
            {
                MemoryStream memoryStream = new MemoryStream(CurrentUser.currentUser.Photo);
                photoField.Image = Image.FromStream(memoryStream);
            }
        }
        /// <summary>
        /// Кнопка для замены фотографии пользователя
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void redactionPhotoButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.png;*.jpeg;*.gif;*.raw;*.jpg)|*.png;*.jpeg;*.gif;*.raw|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    photoField.Image = new Bitmap(openFileDialog.FileName);
                }
                catch
                {
                    MessageBox.Show("Невозможно загрузить эту картинку", "Ошибка загрузки", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            byte[] imageBytes;
            try
            {
                using (var context = new AcquaintanceSqlContext())
                {
                    var person = context.Users.FirstOrDefault(r => r.IdUsers.Equals(CurrentUser.currentUser.IdUsers));
                    logger.Warn("Получение текущего пользователя по");
                    if (person == null)
                    {
                        MessageBox.Show("Пользователь не найден");
                        return;
                    }
                    using (MemoryStream ms = new MemoryStream())
                    {
                        photoField.Image.Save(ms, photoField.Image.RawFormat);
                        imageBytes = ms.ToArray();
                    }
                    CurrentUser.currentUser.Photo = imageBytes;
                    person.Photo = CurrentUser.currentUser.Photo;
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
        /// Кнопка для открытии фильтров
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void searchButton_Click(object sender, EventArgs e)
        {
            logger.Trace("Открытие формы для фильтров");
            this.Hide();
            FiltersForm filtersForm = new FiltersForm();
            filtersForm.ShowDialog();
        }
        /// <summary>
        /// Кнопка для открытия рекомендации
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void recommendButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new AcquaintanceSqlContext())
                {
                    var users = context.Users.Where(r => !r.IdUsers.Equals(CurrentUser.currentUser.IdUsers));
                    logger.Info("Получение всех пользователей, кроме текущего пользователя");
                    var sortedUsers = users.OrderByDescending(u => u.Likes).ToList();
                    logger.Info("Сортировка всех пользователей по лайкам");
                    CurrentUsers.currentUsers = sortedUsers;
                    DataTable table = new DataTable();
                    table.Columns.Add(InscriptionsFavorites.Number, typeof(int));
                    table.Columns.Add(InscriptionsFavorites.Name, typeof(string));
                    table.Columns.Add(InscriptionsFavorites.Surname, typeof(string));
                    table.Columns.Add(InscriptionsFavorites.Likes, typeof(int));
                    for (int i = 0; i < sortedUsers.Count; i++)
                    {
                        table.Rows.Add((i + 1), sortedUsers[i].Name, sortedUsers[i].Surname, sortedUsers[i].Likes);
                    }
                    RecommenForm recommenForm = new RecommenForm();
                    recommenForm.listUsers.DataSource = table;
                    logger.Info("Создание таблицы для формы рекомендации");
                    RecommenTable.thisTable = table;
                    logger.Trace("Открытие формы рекомендации");
                    this.Hide();
                    recommenForm.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                logger.Fatal("Ошибка в подключение к базе данных");
            }
        }
        /// <summary>
        /// Кнопка для просмотра пользователей, которые были добавлены в избранное
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void favoritesButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new AcquaintanceSqlContext())
                {
                    List<User> anotherUsers = new List<User>();
                    var person = context.Users.FirstOrDefault(r => r.IdUsers.Equals(CurrentUser.currentUser.IdUsers));
                    if (CurrentUser.currentUser.AnotherAccounts != null)
                    {
                        foreach (string idUser in person.AnotherAccounts.Split(','))
                        {
                            var favoritesUsers = context.Users.FirstOrDefault(r => r.IdUsers.Equals(idUser));
                            if (favoritesUsers != null)
                            {
                                anotherUsers.Add(favoritesUsers);
                            }
                        }
                    }
                    CurrentUsers.currentUsers = anotherUsers;
                    DataTable table = new DataTable();
                    table.Columns.Add(InscriptionsFavorites.Number, typeof(int));
                    table.Columns.Add(InscriptionsFavorites.Name, typeof(string));
                    table.Columns.Add(InscriptionsFavorites.Surname, typeof(string));
                    table.Columns.Add(InscriptionsFavorites.Likes, typeof(int));
                    for (int i = 0; i < anotherUsers.Count; i++)
                    {
                        table.Rows.Add(i + 1, anotherUsers[i].Name, anotherUsers[i].Surname, anotherUsers[i].Likes);
                    }
                    ChosenOneForm chosenOneForm = new ChosenOneForm();
                    logger.Info("Создание таблицы для формы избранное");
                    chosenOneForm.listUsers.DataSource = table;
                    FavoritesTable.favoritTable = table;
                    logger.Trace("Открытие формы избранное");
                    this.Hide();
                    chosenOneForm.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                logger.Fatal("Ошибка в подключение к базе данных");
            }
        }
        /// <summary>
        /// Кнопка просмотра уведомлений
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void notificationButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new AcquaintanceSqlContext())
                {
                    List<User> anotherUsers = new List<User>();
                    var person = context.Users.FirstOrDefault(r => r.IdUsers.Equals(CurrentUser.currentUser.IdUsers));
                    if (person.Notifications != null)
                    {
                        foreach (string idUser in person.Notifications.Split(','))
                        {
                            var favoritesUsers = context.Users.FirstOrDefault(r => r.IdUsers.Equals(idUser));
                            if (favoritesUsers != null)
                            {
                                anotherUsers.Add(favoritesUsers);
                            }
                        }
                    }
                    CurrentUsers.currentUsers = anotherUsers;
                    DataTable table = new DataTable();
                    table.Columns.Add(InscriptionsFavorites.Number, typeof(int));
                    table.Columns.Add(InscriptionsFavorites.Name, typeof(string));
                    table.Columns.Add(InscriptionsFavorites.Surname, typeof(string));
                    table.Columns.Add(InscriptionsFavorites.Likes, typeof(int));
                    for (int i = 0; i < anotherUsers.Count; i++)
                    {
                        table.Rows.Add((i + 1), anotherUsers[i].Name, anotherUsers[i].Surname, anotherUsers[i].Likes);
                    }
                    NotificationForm notificationForm = new NotificationForm();
                    notificationForm.listUsers.DataSource = table;
                    logger.Info("Создание таблицы для формы уведомления");
                    NotificationTable.notificationTable = table;
                    logger.Trace("Открытие формы уведомления");
                    this.Hide();
                    notificationForm.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                logger.Fatal("Ошибка в подключение к базе данных");
            }
        }
        /// <summary>
        /// Устанавливаем новое значение положения для формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HomePanel_MouseMove(object sender, MouseEventArgs e)
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
        private void HomePanel_MouseDown(object sender, MouseEventArgs e)
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
        private void HomeForm_MouseMove(object sender, MouseEventArgs e)
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
        private void HomeForm_MouseDown(object sender, MouseEventArgs e)
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
