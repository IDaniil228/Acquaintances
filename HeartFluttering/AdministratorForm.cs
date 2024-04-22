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
    public partial class AdministratorForm : Form
    {
        public AdministratorForm()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CollapseButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void AdministratorForm_Load(object sender, EventArgs e)
        {
            using (var context = new AcquaintanceSqlContext())
            {
                int position = 1;
                var users = context.Users;
                DataTable table = new DataTable();
                table.Columns.Add("Номер", typeof(int));
                table.Columns.Add("Имя", typeof(string));
                table.Columns.Add("Фамилия", typeof(string));
                foreach (var user in users)
                {
                    table.Rows.Add((position), user.Name, user.Surname);
                    position++;
                }
                CurrentUsers.currentUsers = users.ToList();
                listUsers.DataSource = table;
            }
        }
        private void listUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = listUsers.Rows[e.RowIndex];
                int position = (int)selectedRow.Cells["Номер"].Value;
                User selectedUser;
                if (CurrentUsers.currentUsers[position - 1] != null)
                {
                    selectedUser = CurrentUsers.currentUsers[position - 1];
                }
                else
                {
                    MessageBox.Show("Такого пользователя не существует");
                    return;
                }
                if (selectedUser != null)
                {
                    nameField.Text = selectedUser.Name;
                    surnameField.Text = selectedUser.Surname;
                    birhdayField.Text = selectedUser.DateOfBirth;
                    cityField.Text = selectedUser.City;
                    if (selectedUser.Sex == 1)
                    {
                        sexField.Text = "Мужской";
                    }
                    if (selectedUser.Sex == 0)
                    {
                        sexField.Text = "Женский";
                    }
                    emailField.Text = selectedUser.Mail;
                    numberField.Text = selectedUser.Number;
                    if (selectedUser.Photo != null)
                    {
                        MemoryStream memoryStream = new MemoryStream(selectedUser.Photo);
                        Photo.Image = Image.FromStream(memoryStream);
                    }
                    else
                    {
                        Photo.Image = null;
                    }
                }
                CurrentUser.currentUser = selectedUser;
            }
        }

        private void searchLine_TextChanged(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Номер", typeof(int));
            table.Columns.Add("Имя", typeof(string));
            table.Columns.Add("Фамилия", typeof(string));
            using (var context = new AcquaintanceSqlContext())
            {
                string usersNames = searchLine.Text;
                var users = context.Users.ToList();
                if (users != null)
                {
                    for (int i = 0; i < users.Count; i++)
                    {
                        if (users[i].Name != null && users[i].Surname != null)
                        {
                            if (users[i].Name.StartsWith(usersNames) && usersNames != string.Empty)
                            {
                                table.Rows.Add((i + 1), users[i].Name, users[i].Surname);
                            }
                            else if (users[i].Surname.StartsWith(usersNames) && usersNames != string.Empty)
                            {
                                table.Rows.Add((i + 1), users[i].Name, users[i].Surname);
                            }
                        }
                    }
                }
                listUsers.DataSource = table;
            }
        }

        private void deleteAccountButton_Click(object sender, EventArgs e)
        {
            using (var context = new AcquaintanceSqlContext())
            {
                if(CurrentUser.currentUser != null)
                {
                    var user = context.Users.FirstOrDefault(r => CurrentUser.currentUser.IdUsers.Equals(r.IdUsers));
                    if (user == null)
                    {
                        MessageBox.Show("Такого пользователя не существует");
                        return;
                    }
                    context.Remove(user);
                    context.SaveChanges();
                    MessageBox.Show("Данный пользователь был удалён");
                }
                else
                {
                    MessageBox.Show("Такого пользователя не существует");
                    return;
                }
                int position = 1;
                var users = context.Users;
                DataTable table = new DataTable();
                table.Columns.Add("Номер", typeof(int));
                table.Columns.Add("Имя", typeof(string));
                table.Columns.Add("Фамилия", typeof(string));
                foreach (var user in users)
                {
                    table.Rows.Add((position), user.Name, user.Surname);
                    position++;
                }
                CurrentUsers.currentUsers = users.ToList();
                listUsers.DataSource = table;
            }
        }
    }
}
