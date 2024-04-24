using Microsoft.VisualBasic.ApplicationServices;
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
using User = HeartFluttering.Classes.User;

namespace HeartFluttering
{
    public partial class AdministratorForm : Form
    {
        
        private int position = 1;
        private string warning = "Такого пользователя не существует";
        public AdministratorForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Кнопка закрытия приложения
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
        /// Загрузка данных в форму для админа
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AdministratorForm_Load(object sender, EventArgs e)
        {
            using (var context = new AcquaintanceSqlContext())
            {
                var users = context.Users;
                DataTable table = AdministratorTable.GetDataTable();
                foreach (var user in users)
                {
                    table.Rows.Add((position), user.Name, user.Surname);
                    position++;
                }
                CurrentUsers.currentUsers = users.ToList();
                listUsers.DataSource = table;
            }
        }
        /// <summary>
        /// По двойному клику, высвечивается профиль пользователя
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                    MessageBox.Show(warning);
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
        /// <summary>
        /// Строка поиска по имени и фамилии
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void searchLine_TextChanged(object sender, EventArgs e)
        {
            DataTable table = AdministratorTable.GetDataTable();
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
                            if (users[i].Name.StartsWith(usersNames))
                            {
                                table.Rows.Add((i + 1), users[i].Name, users[i].Surname);
                            }
                            else if (users[i].Surname.StartsWith(usersNames))
                            {
                                table.Rows.Add((i + 1), users[i].Name, users[i].Surname);
                            }
                        }
                    }
                }
                listUsers.DataSource = table;
            }
        }
        /// <summary>
        /// Метод, который возвращает пользователя по его ID
        /// </summary>
        /// <param name="idUser"></param>
        /// <returns></returns>
        private User GettingUserById(string idUser)
        {
            using (var context = new AcquaintanceSqlContext())
            {
                if(CurrentUser.currentUser != null)
                {
                    var user = context.Users.FirstOrDefault(r => idUser.Equals(r.IdUsers));
                    return user;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Метод который возвращает аккаунт по ID пользователя
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        private Account GettingAccountById(User user)
        {
            using (var context = new AcquaintanceSqlContext())
            {
                if(CurrentUser.currentUser != null)
                {
                    var account = context.Accounts.FirstOrDefault(r => r.Id.Equals(user.Id));
                    return account;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Конпка для удалении пользователя
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteAccountButton_Click(object sender, EventArgs e)
        {
            using (var context = new AcquaintanceSqlContext())
            {
                if(CurrentUser.currentUser != null)
                {
                    var user = GettingUserById(CurrentUser.currentUser.IdUsers);
                    if (user == null)
                    {
                        MessageBox.Show(warning);
                        return;
                    }
                    var account = GettingAccountById(user);
                    if (account == null)
                    {
                        MessageBox.Show(warning);
                        return;
                    }
                    context.Remove(user);
                    context.Remove(account);
                    context.SaveChanges();
                    MessageBox.Show("Данный пользователь был удалён");
                }
                else
                {
                    MessageBox.Show(warning);
                    return;
                }
                var users = context.Users;
                DataTable table = AdministratorTable.GetDataTable();
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
