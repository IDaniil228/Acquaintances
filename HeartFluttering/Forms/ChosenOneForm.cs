using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HeartFluttering.Classes;
using NLog;

namespace HeartFluttering
{
    public partial class ChosenOneForm : Form
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        public ChosenOneForm()
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
            logger.Trace("Сворачивание приложения");
            this.WindowState = FormWindowState.Minimized;
        }
        /// <summary>
        /// Просмотр пользователя по двойному клику по таблице
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = listUsers.Rows[e.RowIndex];
                /*
                int position = 0;
                if(selectedRow.Cells["Номер"].Value == null)
                {
                    position = (int)selectedRow.Cells["Number"].Value;
                }
                if(selectedRow.Cells["Number"].Value == null)
                {
                    position = (int)selectedRow.Cells["Номер"].Value;
                }
                */
                int position = 0;
                position = (int)selectedRow.Cells["Номер"].Value;
                logger.Info($"Получении пользователя по {position} позиции в таблице");
                User selectedUser = CurrentUsers.currentUsers[position - 1];
                UserProfileForm form = new UserProfileForm();
                if (CurrentUser.currentUser.AnotherAccounts != null)
                {
                    if (CurrentUser.currentUser.AnotherAccounts.Split(',').Contains(selectedUser.IdUsers))
                    {
                        form.deleteButton.Enabled = true;
                        form.deleteButton.Visible = true;
                    }
                }
                form.backButton2.Enabled = true;
                form.backButton2.Visible = true;
                form.thisUsers = selectedUser;
                this.Hide();
                logger.Trace("Открытие карточки пользователя");
                form.ShowDialog();
            }
        }
        /// <summary>
        /// Обновление таблицы пользователей, которые находятся в избранных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChosenOneForm_Load(object sender, EventArgs e)
        {
            logger.Trace("Обновление таблици");
            listUsers.DataSource = FavoritesTable.favoritTable;
        }
        /// <summary>
        /// Кнопка для перехода в главную форму
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backButton_Click(object sender, EventArgs e)
        {
            logger.Trace("Открытие главной формы");
            this.Hide();
            HomeForm homeForm = new HomeForm();
            homeForm.ShowDialog();
        }
    }
}
