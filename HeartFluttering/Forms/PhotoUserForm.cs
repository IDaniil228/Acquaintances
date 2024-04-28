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
using HeartFluttering.Resources.Localization.PhotoUserForm;
using NLog;

namespace HeartFluttering
{
    public partial class PhotoUserForm : Form
    {
        /// <summary>
        /// Местоположение формы
        /// </summary>
        private Point lastPoint;
        /// <summary>
        /// Создаём экземпляр класса для логирования
        /// </summary>
        private static Logger logger = LogManager.GetCurrentClassLogger();
        public PhotoUserForm()
        {
            InitializeComponent();
            logger.Info("Инициализация данных");
        }
        public List<User> currentUsers;
        private int count = 0;
        /// <summary>
        /// Кнопка, которая переводит пользователя в главную форму
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void homeButton_Click(object sender, EventArgs e)
        {
            logger.Trace("Переход в главную форму");
            this.Hide();
            HomeForm homeForm = new HomeForm();
            homeForm.ShowDialog();
        }
        /// <summary>
        /// Кнопка, которая позволяет пользователю перейти к фильтрам
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void changeFiltersButton_Click(object sender, EventArgs e)
        {
            logger.Trace("Открытие форму с фильтрами");
            this.Hide();
            FiltersForm filtersForm = new FiltersForm();
            filtersForm.ShowDialog();
        }
        /// <summary>
        /// Конпка запуска поиска других пользователей
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void startButton_Click(object sender, EventArgs e)
        {
            if (currentUsers.Count == 0)
            {
                MessageBox.Show(InscriptionsPhotoUser.ChangeFilter);
                return;
            }
            likeAccount.Enabled = true;
            likeAccount.Visible = true;
            nextAccount.Enabled = true;
            nextAccount.Visible = true;
            startButton.Enabled = false;
            startButton.Visible = false;
            nameField.Text = currentUsers[count].Name;
            BirhdayField.Text = currentUsers[count].DateOfBirth;
            if (currentUsers[count].Photo != null)
            {
                MemoryStream memoryStream = new MemoryStream(currentUsers[count].Photo);
                photoField.Image = Image.FromStream(memoryStream);
            }
        }
        /// <summary>
        /// Кнопка, который показывает слудующий аккаунт
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nextAccount_Click(object sender, EventArgs e)
        {
            if (currentUsers.Count - 1 > count)
            {
                count++;
                nameField.Text = currentUsers[count].Name;
                BirhdayField.Text = currentUsers[count].DateOfBirth;
                if (currentUsers[count].Photo != null)
                {
                    MemoryStream memoryStream = new MemoryStream(currentUsers[count].Photo);
                    photoField.Image = Image.FromStream(memoryStream);
                }
                else
                {
                    photoField.Image = null;
                }
            }
            else
            {
                MessageBox.Show(InscriptionsPhotoUser.IsEnd);
                return;
            }
        }
        /// <summary>
        /// Кнопка, которая добавляет аккаунт другого пользователя в избранное
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void likeAccount_Click(object sender, EventArgs e)
        {
            if (currentUsers.Count > count)
            {
                using (var context = new AcquaintanceSqlContext())
                {
                    var currUsers = context.Users.FirstOrDefault(r => r.IdUsers.Equals(CurrentUser.currentUser.IdUsers));
                    logger.Info("Получение текущего пользователя");
                    var anotherUser = context.Users.FirstOrDefault(r => r.IdUsers.Equals(currentUsers[count].IdUsers));
                    logger.Info("Получения пользователя, который удовлетворяет фильтрам");
                    if (currUsers.AnotherAccounts != null)
                    {
                        if (currUsers.AnotherAccounts.Split(',').Contains(anotherUser.IdUsers))
                        {
                            MessageBox.Show(InscriptionsPhotoUser.AlreadyLiked);
                            return;
                        }
                    }
                    if (currUsers == null)
                    {
                        MessageBox.Show(InscriptionsPhotoUser.Error);
                        return;
                    }
                    if (anotherUser == null)
                    {
                        MessageBox.Show(InscriptionsPhotoUser.Error);
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
                    if (currentUsers.Count - 1 > count)
                    {
                        count++;
                        nameField.Text = currentUsers[count].Name;
                        BirhdayField.Text = currentUsers[count].DateOfBirth;
                        if (currentUsers[count].Photo != null)
                        {
                            MemoryStream memoryStream = new MemoryStream(currentUsers[count].Photo);
                            photoField.Image = Image.FromStream(memoryStream);
                        }
                        else
                        {
                            photoField.Image = null;
                        }
                    }
                    else
                    {
                        MessageBox.Show(InscriptionsPhotoUser.ChangeFilter);
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show(InscriptionsPhotoUser.IsEnd);
                return;
            }
        }
        /// <summary>
        /// Устанавливаем новое значение положения для формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void photoField_MouseMove(object sender, MouseEventArgs e)
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
        private void photoField_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        /// <summary>
        /// Устанавливаем новое значение положения для формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PanelInfo_MouseMove(object sender, MouseEventArgs e)
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
        private void PanelInfo_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        /// <summary>
        /// Устанавливаем новое значение положения для формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FunctionalPanel_MouseMove(object sender, MouseEventArgs e)
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
        private void FunctionalPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
    }
}
