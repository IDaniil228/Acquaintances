using HeartFluttering.Classes;
using HeartFluttering.Forms;
using HeartFluttering.Resources.Localization.ChooseOneForm;
using NLog;
using System.Globalization;

namespace HeartFluttering
{
    public partial class NotificationForm : Form
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

        public NotificationForm()
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
        /// Кнопка сворачивания приложения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CollapseButton_Click(object sender, EventArgs e)
        {
            logger.Trace("Сворачивание приложения");
            this.WindowState = FormWindowState.Minimized;
        }
        /// <summary>
        /// Получение пользователя по двойному нажатию по строке таблицы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                try
                {
                    using (var context = new AcquaintanceSqlContext())
                    {
                        var person = context.Users.FirstOrDefault(r => r.IdUsers.Equals(CurrentUser.currentUser.IdUsers));
                        DataGridViewRow selectedRow = listUsers.Rows[e.RowIndex];
                        int position = (int)selectedRow.Cells[InscriptionsFavorites.Number].Value;
                        logger.Info($"Получение пользователя по {position} позиции");
                        User selectedUser = CurrentUsers.currentUsers[position - 1];
                        UserProfileForm form = new UserProfileForm();
                        if (person.Notifications != null)
                        {
                            if (person.Notifications.Split(',').Contains(selectedUser.IdUsers))
                            {
                                if (person.AnotherAccounts != null)
                                {
                                    foreach (string anotheracc in CurrentUser.currentUser.AnotherAccounts.Split(','))
                                    {
                                        if (!person.Notifications.Equals(anotheracc))
                                        {
                                            form.likeAccount2.Enabled = true;
                                            form.likeAccount2.Visible = true;
                                        }
                                    }
                                }
                                else
                                {
                                    form.likeAccount2.Enabled = true;
                                    form.likeAccount2.Visible = true;
                                }
                            }
                        }
                        form.thisUsers = selectedUser;
                        form.backButton3.Enabled = true;
                        form.backButton3.Visible = true;
                        logger.Trace("Открытие профиля выбранного пользователя");
                        this.Hide();
                        form.ShowDialog();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    logger.Fatal("Ошибка в подключении к базе данных");
                }
            }
        }
        /// <summary>
        /// Метод, который обновляет таблицу, если были изменения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NotificationForm_Load(object sender, EventArgs e)
        {
            logger.Trace("Обновлении таблицы с уведомлениями");
            listUsers.DataSource = NotificationTable.notificationTable;
            using (var context = new AcquaintanceSqlContext())
            {
                var currentUser = context.Users.FirstOrDefault(x => x.IdUsers ==
                CurrentUser.currentUser.IdUsers);
                var idFriends = currentUser.NotificationsFriend.Split(",");
                DateTimeFormatInfo provider = new DateTimeFormatInfo();
                provider.ShortDatePattern = "dd.MM.yyyy";
                foreach (string id in idFriends)
                {
                    var friend = context.Users.FirstOrDefault(x => x.IdUsers == id);
                    if (friend != null)
                    {
                        int age = DateTime.Now.Year - DateTime.ParseExact(friend.DateOfBirth, "dd.MM.yyyy", provider).Year;
                        FriendDataGridView.Rows.Add($"{friend.Surname} {friend.Name}", age);
                    }
                }
            }

        }
        /// <summary>
        /// Конпка для перехода в главную форму
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backButton_Click(object sender, EventArgs e)
        {
            logger.Trace("Кнопка для перехода в главную форму");
            this.Hide();
            HomeForm homeForm = new HomeForm();
            homeForm.ShowDialog();
        }
        /// <summary>
        /// Устанавливаем новое значение положения для формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NotificationForm_MouseMove(object sender, MouseEventArgs e)
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
        private void NotificationForm_MouseDown(object sender, MouseEventArgs e)
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

        private void FriendDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string userName = FriendDataGridView.Rows[e.RowIndex].Cells["Name_1"].Value.ToString();
            int userAge = (int)FriendDataGridView.Rows[e.RowIndex].Cells["Age_1"].Value;
            using (var context = new AcquaintanceSqlContext())
            {
                DateTimeFormatInfo provider = new DateTimeFormatInfo();
                provider.ShortDatePattern = "dd.MM.yyyy";
                var user = context.Users.Where(x => x.Surname + " " + x.Name == userName).ToList();
                if (user.Count != 0)
                {
                    foreach (var person in user)
                    {
                        if (DateTime.Now.Year - DateTime.ParseExact(person.DateOfBirth,
                            "dd.MM.yyyy", provider).Year == userAge)
                        {
                            FriendProfileForm friendProfileForm = new FriendProfileForm();
                            friendProfileForm.BtnAdd.Visible = true;
                            friendProfileForm.BtnAdd.Enabled = true;
                            friendProfileForm.fromNotification = true;
                            friendProfileForm.User = person;
                            friendProfileForm.Show();
                            Hide();
                            break;
                        }
                    }

                }
            }
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
