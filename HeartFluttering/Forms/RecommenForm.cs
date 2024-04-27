using HeartFluttering.Classes;
using Microsoft.VisualBasic.ApplicationServices;
using NLog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeartFluttering
{
    public partial class RecommenForm : Form
    {
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
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = listUsers.Rows[e.RowIndex];
                int position = (int)selectedRow.Cells["Место"].Value;
                logger.Info($"Получение пользователя по {position} позиции");
                Classes.User selectedUser = CurrentUsers.currentUsers[position - 1];
                UserProfileForm form = new UserProfileForm();
                if (CurrentUser.currentUser.AnotherAccounts != null)
                {
                    if (!CurrentUser.currentUser.AnotherAccounts.Split(',').Contains(selectedUser.IdUsers))
                    {
                        form.likeAccount.Enabled = true;
                        form.likeAccount.Visible = true;
                    }
                }
                if (CurrentUser.currentUser.AnotherAccounts == null)
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
    }
}
