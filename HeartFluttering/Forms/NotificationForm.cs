using HeartFluttering.Classes;
using HeartFluttering.Resources.Localization.ChooseOneForm;
using NLog;

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
    }
}
