﻿using System;
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
    public partial class ChosenOneForm : Form
    {
        public ChosenOneForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Кнопка для закрытия приложения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// Кнопка для сворачивания приложения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CollapseButton_Click(object sender, EventArgs e)
        {
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
                int position = (int)selectedRow.Cells["Номер"].Value;
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
            listUsers.DataSource = FavoritesTable.favoritTable;
        }
        /// <summary>
        /// Кнопка для перехода в главную форму
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeForm homeForm = new HomeForm();
            homeForm.ShowDialog();
        }
    }
}
