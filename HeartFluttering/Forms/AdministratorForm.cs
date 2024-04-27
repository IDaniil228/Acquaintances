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

using NLog;
using HeartFluttering.Resources.Localization.AdminForms;

namespace HeartFluttering
{
    public partial class AdministratorForm : Form
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        private string warning = InscriptionsAdmin.Warning;
        private DataTable GetDataTable()
        {
            DataTable table = new DataTable();
            table.Columns.Add(InscriptionsAdmin.Number, typeof(int));
            table.Columns.Add(InscriptionsAdmin.Name, typeof(string));
            table.Columns.Add(InscriptionsAdmin.Surname, typeof(string));
            return table;
        }
        public AdministratorForm()
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
        /// Загрузка данных в форму для админа
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AdministratorForm_Load(object sender, EventArgs e)
        {
            int position = 1;
            try
            {
                using (var context = new AcquaintanceSqlContext())
                {
                    var users = context.Users;
                    logger.Info("Получение всех пользователей из базы данных");
                    DataTable table = GetDataTable();
                    foreach (var user in users)
                    {
                        table.Rows.Add((position), user.Name, user.Surname);
                        position++;
                    }
                    CurrentUsers.currentUsers = users.ToList();
                    listUsers.DataSource = table;
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
                logger.Fatal("Ошибка подключения к базе данных");
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
                logger.Info($"Получение пользователя по {position} позиции");
                if (selectedUser != null)
                {
                    nameField.Text = selectedUser.Name;
                    surnameField.Text = selectedUser.Surname;
                    birhdayField.Text = selectedUser.DateOfBirth;
                    cityField.Text = selectedUser.City;
                    if (selectedUser.Sex == 1)
                    {
                        sexField.Text = InscriptionsAdmin.Man;
                    }
                    if (selectedUser.Sex == 0)
                    {
                        sexField.Text = InscriptionsAdmin.Women;
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
            DataTable table = GetDataTable();
            try
            {
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
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
                logger.Fatal("Ошибка подключения к базе данных");
            }
        }
        /// <summary>
        /// Метод, который возвращает пользователя по его ID
        /// </summary>
        /// <param name="idUser"></param>
        /// <returns></returns>
        private User GettingUserById(string idUser) // Для тестирования
        {
            try
            {
                using (var context = new AcquaintanceSqlContext())
                {
                    if (CurrentUser.currentUser != null)
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                logger.Fatal("Ошибка подключения к базе данных");
                return null;
            }
        }
        /// <summary>
        /// Метод который возвращает аккаунт по ID пользователя
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        private Account GettingAccountById(User user) // Для тестирования
        {
            try
            {
                using (var context = new AcquaintanceSqlContext())
                {
                    if (CurrentUser.currentUser != null)
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                logger.Fatal("Ошибка подключения к базе данных");
                return null;
            }
        }
        /// <summary>
        /// Конопка для удалении пользователя
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteAccountButton_Click(object sender, EventArgs e)
        {
            int position = 1;
            try
            {
                using (var context = new AcquaintanceSqlContext())
                {
                    if (CurrentUser.currentUser != null)
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
                        logger.Debug($"Удален пользователь по Id: {user.IdUsers}");
                        context.Remove(user);
                        context.Remove(account);
                        context.SaveChanges();
                        MessageBox.Show(InscriptionsAdmin.Delete);
                    }
                    else
                    {
                        MessageBox.Show(warning);
                        return;
                    }
                    var users = context.Users;
                    logger.Info("Получение всех пользователей из базы данных");
                    DataTable table = GetDataTable();
                    foreach (var user in users)
                    {
                        table.Rows.Add((position), user.Name, user.Surname);
                        position++;
                    }
                    CurrentUsers.currentUsers = users.ToList();
                    listUsers.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                logger.Fatal("Ошибка подключения к базе данных");
            }
        }
    }
}
