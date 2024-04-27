using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HeartFluttering.Classes;
using NLog;

namespace HeartFluttering
{
    public partial class NotificationForm : Form
    {
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
                DataGridViewRow selectedRow = listUsers.Rows[e.RowIndex];
                int position = (int)selectedRow.Cells["Номер"].Value;
                logger.Info($"Получение пользователя по {position} позиции");
                User selectedUser = CurrentUsers.currentUsers[position - 1];
                UserProfileForm form = new UserProfileForm();
                if (CurrentUser.currentUser.Notifications != null)
                {
                    if (CurrentUser.currentUser.Notifications.Split(',').Contains(selectedUser.IdUsers))
                    {
                        if (CurrentUser.currentUser.AnotherAccounts != null)
                        {
                            foreach (string anotheracc in CurrentUser.currentUser.AnotherAccounts.Split(','))
                            {
                                if (!CurrentUser.currentUser.Notifications.Equals(anotheracc))
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
    }
}
