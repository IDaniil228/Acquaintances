using HeartFluttering.Classes;
using HeartFluttering.Forms;
using HeartFluttering.Resources.Localization.ChooseOneForm;
using HeartFluttering.Resources.Localization.UserProfileForm;
using NLog;
using System.Data;
using System.Globalization;

namespace HeartFluttering
{
    public partial class UserProfileForm : Form
    {
        private bool maximize = false;
        /// <summary>
        /// Местоположение формы
        /// </summary>
        private Point lastPoint;
        /// <summary>
        /// Создаём экземпляр класса для логирования
        /// </summary>
        private static Logger logger = LogManager.GetCurrentClassLogger();
        public UserProfileForm()
        {
            InitializeComponent();
            logger.Info("Инициализация данных");
        }
        public User thisUsers;
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
            logger.Trace("Сворачивание приложения");
            this.WindowState = FormWindowState.Minimized;
        }
        /// <summary>
        /// Кнопка для перехода в таблицу рекомендаций
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backButton_Click(object sender, EventArgs e)
        {
            using (var context = new AcquaintanceSqlContext())
            {
                var users = context.Users.Where(r => !r.IdUsers.Equals(CurrentUser.currentUser.IdUsers) && r.Sex != CurrentUser.currentUser.Sex);
                logger.Info("Получение всех пользователей, кроме текущего");
                var sortedUsers = users.OrderByDescending(u => u.Likes).ToList();
                logger.Info("Сортировка пользователей по количеству лайков");
                CurrentUsers.currentUsers = sortedUsers;
                DataTable table = new DataTable();
                table.Columns.Add(InscriptionsFavorites.Number, typeof(int));
                table.Columns.Add(InscriptionsFavorites.Name, typeof(string));
                table.Columns.Add(InscriptionsFavorites.Surname, typeof(string));
                table.Columns.Add(InscriptionsFavorites.Age, typeof(int));
                table.Columns.Add(InscriptionsFavorites.Likes, typeof(int));
                DateTimeFormatInfo provider = new DateTimeFormatInfo();
                provider.ShortDatePattern = "dd.MM.yyyy";
                for (int i = 0; i < sortedUsers.Count; i++)
                {
                    int age = DateTime.Now.Year - DateTime.ParseExact(sortedUsers[i].DateOfBirth, "dd.MM.yyyy", provider).Year;
                    table.Rows.Add((i + 1), sortedUsers[i].Name, sortedUsers[i].Surname, age, sortedUsers[i].Likes);
                    if (i == 5)
                    {
                        break;
                    }
                }
                RecommenForm recommenForm = new RecommenForm();
                RecommenTable.thisTable = table;
                logger.Trace("Открытие формы рекомендации");
                this.Hide();
                recommenForm.Show();
            }
        }
        /// <summary>
        /// Кнопка для перехода в таблицу избранное
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backButton2_Click(object sender, EventArgs e)
        {
            using (var context = new AcquaintanceSqlContext())
            {
                List<User> anotherUsers = new List<User>();
                if (CurrentUser.currentUser.AnotherAccounts != null)
                {
                    foreach (string idUser in CurrentUser.currentUser.AnotherAccounts.Split(','))
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
                ChosenOneForm chosenOneForm = new ChosenOneForm();
                FavoritesTable.favoritTable = table;
                logger.Trace("Открытие формы избранное");
                this.Hide();
                chosenOneForm.Show();
            }
        }
        /// <summary>
        /// Кнопка для перехода в таблицу уведомления
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backButton3_Click(object sender, EventArgs e)
        {
            using (var context = new AcquaintanceSqlContext())
            {
                List<User> anotherUsers = new List<User>();
                if (CurrentUser.currentUser.Notifications != null)
                {
                    foreach (string idUser in CurrentUser.currentUser.Notifications.Split(','))
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
                table.Columns.Add(InscriptionsFavorites.Age, typeof(int));
                table.Columns.Add(InscriptionsFavorites.Likes, typeof(int));
                DateTimeFormatInfo provider = new DateTimeFormatInfo();
                provider.ShortDatePattern = "dd.MM.yyyy";
                for (int i = 0; i < anotherUsers.Count; i++)
                {
                    int age = DateTime.Now.Year - DateTime.ParseExact(anotherUsers[i].DateOfBirth, "dd.MM.yyyy", provider).Year;
                    table.Rows.Add((i + 1), anotherUsers[i].Name, anotherUsers[i].Surname, age, anotherUsers[i].Likes);
                }
                NotificationForm notificationForm = new NotificationForm();
                NotificationTable.notificationTable = table;
                logger.Trace("Открытие формы уведомления");
                this.Hide();
                notificationForm.Show();
            }
        }
        /// <summary>
        /// Кнопка для добавления аккаунта в избранное
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void likeAccount_Click(object sender, EventArgs e)
        {
            using (var context = new AcquaintanceSqlContext())
            {
                var currUsers = context.Users.FirstOrDefault(r => r.IdUsers.Equals(CurrentUser.currentUser.IdUsers));
                logger.Info("Получение текущего пользователя");
                var anotherUser = context.Users.FirstOrDefault(r => r.IdUsers.Equals(thisUsers.IdUsers));
                logger.Info("Получение выбранного пользователя");
                if (currUsers.AnotherAccounts != null)
                {
                    if (currUsers.AnotherAccounts.Split(',').Contains(anotherUser.IdUsers))
                    {
                        MessageBox.Show(InscriptionsUserProfile.AlreadyLike);
                        return;
                    }
                }
                if (currUsers == null)
                {
                    MessageBox.Show(InscriptionsUserProfile.Error);
                    return;
                }
                if (anotherUser == null)
                {
                    MessageBox.Show(InscriptionsUserProfile.Error);
                    return;
                }
                if (currUsers.AnotherAccounts == null)
                {
                    currUsers.AnotherAccounts = anotherUser.IdUsers;
                }
                else
                {
                    currUsers.AnotherAccounts += "," + anotherUser.IdUsers;
                }
                if (anotherUser.Notifications == null)
                {
                    anotherUser.Notifications = currUsers.IdUsers;
                }
                else
                {
                    anotherUser.Notifications += "," + currUsers.IdUsers;
                }
                anotherUser.Likes++;
                CurrentUser.currentUser = currUsers;
                logger.Debug("Сохранение изменений в базу данных");
                context.SaveChanges();
                MessageBox.Show(InscriptionsUserProfile.AlreadyAdded);
            }
        }
        /// <summary>
        /// Кнопка для добавления аккаунта в избранное 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void likeAccount2_Click(object sender, EventArgs e)
        {
            using (var context = new AcquaintanceSqlContext())
            {
                var currUsers = context.Users.FirstOrDefault(r => r.IdUsers.Equals(CurrentUser.currentUser.IdUsers));
                logger.Info("Получение текущего пользователя");
                var anotherUser = context.Users.FirstOrDefault(r => r.IdUsers.Equals(thisUsers.IdUsers));
                logger.Info("Получение выбранного пользователя");
                if (currUsers.AnotherAccounts != null)
                {
                    if (currUsers.AnotherAccounts.Split(',').Contains(anotherUser.IdUsers))
                    {
                        MessageBox.Show(InscriptionsUserProfile.AlreadyLike);
                        return;
                    }
                }
                if (currUsers == null)
                {
                    MessageBox.Show(InscriptionsUserProfile.Error);
                    return;
                }
                if (anotherUser == null)
                {
                    MessageBox.Show(InscriptionsUserProfile.Error);
                    return;
                }
                if (currUsers.AnotherAccounts == null)
                {
                    currUsers.AnotherAccounts = anotherUser.IdUsers;
                }
                else
                {
                    currUsers.AnotherAccounts += "," + anotherUser.IdUsers;
                }
                if (anotherUser.Notifications == null)
                {
                    anotherUser.Notifications = currUsers.IdUsers;
                }
                else
                {
                    anotherUser.Notifications += "," + currUsers.IdUsers;
                }
                anotherUser.Likes += 1;
                CurrentUser.currentUser = currUsers;
                logger.Debug("Сохранение изменений в базу данных");
                context.SaveChanges();
                MessageBox.Show(InscriptionsUserProfile.AlreadyAdded);
            }
        }
        /// <summary>
        /// Загрузка данных в профиль выбранного пользователя
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UserProfileForm_Load(object sender, EventArgs e)
        {
            nameField.Text = thisUsers.Name;
            surnameField.Text = thisUsers.Surname;
            birthdayField.Text = thisUsers.DateOfBirth;
            cityField.Text = thisUsers.City;
            if (thisUsers.Sex == 1)
            {
                selField.Text = InscriptionsUserProfile.Man;
            }
            else
            {
                selField.Text = InscriptionsUserProfile.Women;
            }
            mailField.Text = thisUsers.Mail;
            numberField.Text = thisUsers.Number;
            if (thisUsers.Photo != null)
            {
                MemoryStream memoryStream = new MemoryStream(thisUsers.Photo);
                Photo.Image = Image.FromStream(memoryStream);
            }
        }
        /// <summary>
        /// Кнопка удаления аккаунта из избранного
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteButton_Click(object sender, EventArgs e)
        {
            using (var context = new AcquaintanceSqlContext())
            {
                var currUsers = context.Users.FirstOrDefault(r => r.IdUsers.Equals(CurrentUser.currentUser.IdUsers));
                logger.Info("Получение текущего пользователя");
                var anotherUser = context.Users.FirstOrDefault(r => r.IdUsers.Equals(thisUsers.IdUsers));
                logger.Info("Получение выбранного пользователя");
                if (currUsers == null)
                {
                    MessageBox.Show(InscriptionsUserProfile.Error);
                    return;
                }
                if (anotherUser == null)
                {
                    MessageBox.Show(InscriptionsUserProfile.Error);
                    return;
                }
                if (currUsers.AnotherAccounts != null)
                {
                    if (currUsers.AnotherAccounts.Equals(anotherUser.IdUsers))
                    {
                        currUsers.AnotherAccounts = null;
                    }
                    else
                    {
                        currUsers.AnotherAccounts = currUsers.AnotherAccounts.Replace($"{anotherUser.IdUsers}" + ",", "").Replace("," + $"{anotherUser.IdUsers}", "").Replace($"{anotherUser.IdUsers}", "");
                    }
                }
                if (anotherUser.Notifications != null)
                {
                    if (anotherUser.Notifications.Equals(currUsers.IdUsers))
                    {
                        anotherUser.Notifications = null;
                    }
                    else
                    {
                        anotherUser.Notifications = anotherUser.Notifications.Replace($"{currUsers.IdUsers}" + ",", "").Replace("," + $"{currUsers.IdUsers}", "").Replace($"{currUsers.IdUsers}", "");
                    }
                }
                anotherUser.Likes--;
                CurrentUser.currentUser = currUsers;
                logger.Debug("Сохранение изменений в базу данных");
                context.SaveChanges();
                MessageBox.Show(InscriptionsUserProfile.Delete);
            }
        }
        /// <summary>
        /// Устанавливаем новое значение положения для формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProfilePanel_MouseMove(object sender, MouseEventArgs e)
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
        private void ProfilePanel_MouseDown(object sender, MouseEventArgs e)
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

        private void BtnExitDefault_Click(object sender, EventArgs e)
        {
            GeneralForm generalForm = new GeneralForm();
            Hide();
            generalForm.Show();
        }
    }
}
