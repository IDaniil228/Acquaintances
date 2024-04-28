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
using HeartFluttering.Resources.Localization.ChooseOneForm;
using NLog;

namespace HeartFluttering
{
    public partial class ChosenOneForm : Form
    {
        /// <summary>
        /// Местоположение формы
        /// </summary>
        private Point lastPoint;
        /// <summary>
        /// Создаём экземпляр класса для логирования
        /// </summary>
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
            try
            {
                using (var context = new AcquaintanceSqlContext())
                {
                    var person = context.Users.FirstOrDefault(r => r.IdUsers.Equals(CurrentUser.currentUser.IdUsers));
                    if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                    {
                        DataGridViewRow selectedRow = listUsers.Rows[e.RowIndex];
                        int position = 0;
                        position = (int)selectedRow.Cells[InscriptionsFavorites.Number].Value;
                        logger.Info($"Получении пользователя по {position} позиции в таблице");
                        User selectedUser = CurrentUsers.currentUsers[position - 1];
                        UserProfileForm form = new UserProfileForm();
                        if (person.AnotherAccounts != null)
                        {
                            if (person.AnotherAccounts.Split(',').Contains(selectedUser.IdUsers))
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                logger.Fatal("Ошибка в подключении к базе данных");
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
        /// <summary>
        /// Устанавливаем новое местоположение для формы
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
        /// Присваиваем новое местоположение для формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void entryLabel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        /// <summary>
        /// Устанавливаем новое местоположение для формы
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
        /// Присваиваем новое местоположение для формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void girlPhoto_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        /// <summary>
        /// Устанавливаем новое местоположение для формы
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
        /// Присваиваем новое местоположение для формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void boyPhoto_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        /// <summary>
        /// Устанавливаем новое местоположение для формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChosenOneForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        /// <summary>
        /// Присваиваем новое местоположение для формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChosenOneForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
    }
}
