using HeartFluttering.Classes;
using HeartFluttering.Resources.Localization.ChooseOneForm;
using HeartFluttering.Resources.Localization.ReccommenForm;
using Microsoft.VisualBasic.Devices;
using NLog;
using System.Diagnostics;
using System.Globalization;
using System.Net;
using System.Net.Http;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;

namespace HeartFluttering
{
    public partial class RecommenForm : Form
    {
        public List<User> users = new List<User>();
        /// <summary>
        /// Местоположение формы
        /// </summary>
        private Point lastPoint;
        /// <summary>
        /// Создаём экземпляр класса для логирования
        /// </summary>
        private static Logger logger = LogManager.GetCurrentClassLogger();
        public RecommenForm()
        {
            InitializeComponent();
            logger.Info("Инициализация данных");
        }
        /// <summary>
        /// Кнопка закрытия приложения
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
        /// Получение пользователя по двойному клику по таблице
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            using (var context = new AcquaintanceSqlContext())
            {
                try
                {
                    var person = context.Users.FirstOrDefault(r => r.IdUsers.Equals(CurrentUser.currentUser.IdUsers));
                    if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                    {
                        DataGridViewRow selectedRow = listUsers.Rows[e.RowIndex];
                        int position = (int)selectedRow.Cells[InscriptionsFavorites.Number].Value;
                        logger.Info($"Получение пользователя по {position} позиции");
                        User selectedUser = CurrentUsers.currentUsers[position - 1];
                        UserProfileForm form = new UserProfileForm();
                        if (person.AnotherAccounts != null)
                        {
                            if (!person.AnotherAccounts.Split(',').Contains(selectedUser.IdUsers))
                            {
                                form.likeAccount.Enabled = true;
                                form.likeAccount.Visible = true;
                            }
                        }
                        if (person.AnotherAccounts == null)
                        {
                            form.likeAccount.Enabled = true;
                            form.likeAccount.Visible = true;
                        }
                        form.thisUsers = selectedUser;
                        form.backButton.Enabled = true;
                        form.backButton.Visible = true;
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
        /// Метод, который обновляет таблицу, если в ней произошли изменения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RecommenForm_Load(object sender, EventArgs e)
        {
            logger.Trace("Обновление таблицы, если та была изменена");
            listUsers.DataSource = RecommenTable.thisTable;
        }
        /// <summary>
        /// Переход в главную форму
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backButton_Click(object sender, EventArgs e)
        {
            logger.Trace("Переход в главную форму");
            this.Hide();
            HomeForm homeForm = new HomeForm();
            homeForm.ShowDialog();
        }
        /// <summary>
        /// Устанавливаем новое значение положения для формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RecommenForm_MouseMove(object sender, MouseEventArgs e)
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
        private void RecommenForm_MouseDown(object sender, MouseEventArgs e)
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

        private void BtnSendEmail_ClickAsync(object sender, EventArgs e)
        {
            var mail = CurrentUser.currentUser.Mail;
            if (mail == null)
            {
                MessageBox.Show(InscriptionsReccommendForm.NotMail);
                return;
            }
            var names = new StringBuilder();
            using (var context = new AcquaintanceSqlContext())
            {
                foreach (var user in users)
                {
                    var uset_1 = context.Users.FirstOrDefault(x => x.IdUsers == user.IdUsers);
                    var provider = new DateTimeFormatInfo();
                    provider.ShortDatePattern = "dd.MM.yyyy";
                    int age = DateTime.Now.Year - DateTime.ParseExact(user.DateOfBirth,
                         "dd.MM.yyyy", provider).Year;
                    names.AppendLine($"{uset_1.Surname}" +
                        $"{uset_1.Name} - {age} лет  Почта - {user.Mail}");
                }
            }

            var from = new MailAddress("heartfluttering@inbox.ru", "HeartFluttering");
            var to = new MailAddress(mail);
            var msg = new MailMessage(from, to);
            msg.Subject = "Рекомендации";
            msg.Body = names.ToString();
            var smtp = new SmtpClient("smtp.inbox.ru", 587);
            smtp.Credentials = new NetworkCredential("heartfluttering@inbox.ru", "uaH1kbiw8geeFpwFJLAq\r\n");
            smtp.EnableSsl = true;
            smtp.Send(msg);
            MessageBox.Show(InscriptionsReccommendForm.Mail);
        }
    }
}
