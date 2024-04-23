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

namespace HeartFluttering
{
    public partial class UserProfileForm : Form
    {
        public UserProfileForm()
        {
            InitializeComponent();
        }
        public User thisUsers;
        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CollapseButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            using (var context = new AcquaintanceSqlContext())
            {
                var users = context.Users.Where(r => !r.IdUsers.Equals(CurrentUser.currentUser.IdUsers));
                var sortedUsers = users.OrderByDescending(u => u.Likes).ToList();
                CurrentUsers.currentUsers = sortedUsers;
                DataTable table = new DataTable();
                table.Columns.Add("Место", typeof(int));
                table.Columns.Add("Имя", typeof(string));
                table.Columns.Add("Фамилия", typeof(string));
                table.Columns.Add("Лайки", typeof(int));
                for (int i = 0; i < sortedUsers.Count; i++)
                {
                    table.Rows.Add((i + 1), sortedUsers[i].Name, sortedUsers[i].Surname, sortedUsers[i].Likes);
                }
                RecommenForm recommenForm = new RecommenForm();
                RecommenTable.thisTable = table;
                this.Hide();
                recommenForm.Show();
            }
        }
        private void backButton2_Click(object sender, EventArgs e)
        {
            using (var context = new AcquaintanceSqlContext())
            {
                List<User> anotherUsers = new List<User>();
                if (CurrentUser.currentUser.AnotherAccounts != null)
                {
                    foreach (string idUser in CurrentUser.currentUser.AnotherAccounts.Split(','))
                    {
                        var favoritesUsers = context.Users.FirstOrDefault(r => r.IdUsers.Equals(idUser));
                        if (favoritesUsers != null)
                        {
                            anotherUsers.Add(favoritesUsers);
                        }
                    }
                }
                CurrentUsers.currentUsers = anotherUsers;
                DataTable table = new DataTable();
                table.Columns.Add("Номер", typeof(int));
                table.Columns.Add("Имя", typeof(string));
                table.Columns.Add("Фамилия", typeof(string));
                table.Columns.Add("Лайки", typeof(int));
                for (int i = 0; i < anotherUsers.Count; i++)
                {
                    table.Rows.Add((i + 1), anotherUsers[i].Name, anotherUsers[i].Surname, anotherUsers[i].Likes);
                }
                ChosenOneForm chosenOneForm = new ChosenOneForm();
                FavoritesTable.favoritTable = table;
                this.Hide();
                chosenOneForm.Show();
            }
        }
        private void backButton3_Click(object sender, EventArgs e)
        {
            using (var context = new AcquaintanceSqlContext())
            {
                List<User> anotherUsers = new List<User>();
                if (CurrentUser.currentUser.Notifications != null)
                {
                    foreach (string idUser in CurrentUser.currentUser.Notifications.Split(','))
                    {
                        var favoritesUsers = context.Users.FirstOrDefault(r => r.IdUsers.Equals(idUser));
                        if (favoritesUsers != null)
                        {
                            anotherUsers.Add(favoritesUsers);
                        }
                    }
                }
                CurrentUsers.currentUsers = anotherUsers;
                DataTable table = new DataTable();
                table.Columns.Add("Номер", typeof(int));
                table.Columns.Add("Имя", typeof(string));
                table.Columns.Add("Фамилия", typeof(string));
                table.Columns.Add("Лайки", typeof(int));
                for (int i = 0; i < anotherUsers.Count; i++)
                {
                    table.Rows.Add((i + 1), anotherUsers[i].Name, anotherUsers[i].Surname, anotherUsers[i].Likes);
                }
                NotificationForm notificationForm = new NotificationForm();
                NotificationTable.notificationTable = table;
                this.Hide();
                notificationForm.Show();
            }
        }
        private void likeAccount_Click(object sender, EventArgs e)
        {
            using (var context = new AcquaintanceSqlContext())
            {
                var currUsers = context.Users.FirstOrDefault(r => r.IdUsers.Equals(CurrentUser.currentUser.IdUsers));
                var anotherUser = context.Users.FirstOrDefault(r => r.IdUsers.Equals(thisUsers.IdUsers));
                if (currUsers.AnotherAccounts != null)
                {
                    if (currUsers.AnotherAccounts.Split(',').Contains(anotherUser.IdUsers))
                    {
                        MessageBox.Show("Этот пользователь уже был оценён вами");
                        return;
                    }
                }
                if (currUsers == null)
                {
                    MessageBox.Show("Ошибка в добавлении пользователя");
                    return;
                }
                if (anotherUser == null)
                {
                    MessageBox.Show("Ошибка в добавлении пользователя");
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
                context.SaveChanges();
                MessageBox.Show("Данный пользователь был добавлен в избранное");
            }
        }
        private void likeAccount2_Click(object sender, EventArgs e)
        {
            using (var context = new AcquaintanceSqlContext())
            {
                var currUsers = context.Users.FirstOrDefault(r => r.IdUsers.Equals(CurrentUser.currentUser.IdUsers));
                var anotherUser = context.Users.FirstOrDefault(r => r.IdUsers.Equals(thisUsers.IdUsers));
                if (currUsers.AnotherAccounts != null)
                {
                    if (currUsers.AnotherAccounts.Split(',').Contains(anotherUser.IdUsers))
                    {
                        MessageBox.Show("Этот пользователь уже был оценён вами");
                        return;
                    }
                }
                if (currUsers == null)
                {
                    MessageBox.Show("Ошибка в добавлении пользователя");
                    return;
                }
                if (anotherUser == null)
                {
                    MessageBox.Show("Ошибка в добавлении пользователя");
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
                context.SaveChanges();
                MessageBox.Show("Данный пользователь был добавлен в избранное");
            }
        }
        private void UserProfileForm_Load(object sender, EventArgs e)
        {
            nameField.Text = thisUsers.Name;
            surnameField.Text = thisUsers.Surname;
            birthdayField.Text = thisUsers.DateOfBirth;
            cityField.Text = thisUsers.City;
            if (thisUsers.Sex == 1)
            {
                selField.Text = "Мужской";
            }
            else
            {
                selField.Text = "Женский";
            }
            mailField.Text = thisUsers.Mail;
            numberField.Text = thisUsers.Number;
            if (thisUsers.Photo != null)
            {
                MemoryStream memoryStream = new MemoryStream(thisUsers.Photo);
                Photo.Image = Image.FromStream(memoryStream);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            using (var context = new AcquaintanceSqlContext())
            {
                var currUsers = context.Users.FirstOrDefault(r => r.IdUsers.Equals(CurrentUser.currentUser.IdUsers));
                var anotherUser = context.Users.FirstOrDefault(r => r.IdUsers.Equals(thisUsers.IdUsers));
                if (currUsers == null)
                {
                    MessageBox.Show("Ошибка в добавлении пользователя");
                    return;
                }
                if (anotherUser == null)
                {
                    MessageBox.Show("Ошибка в добавлении пользователя");
                    return;
                }
                if (currUsers.AnotherAccounts != null)
                {
                    if (currUsers.AnotherAccounts.Equals(anotherUser.IdUsers))
                    {
                        currUsers.AnotherAccounts = null;
                    }
                    else
                    {
                        currUsers.AnotherAccounts = currUsers.AnotherAccounts.Replace($"{anotherUser.IdUsers}" + ",", "").Replace("," + $"{anotherUser.IdUsers}", "").Replace($"{anotherUser.IdUsers}", "");
                    }
                }
                if (anotherUser.Notifications != null)
                {
                    if (anotherUser.Notifications.Equals(currUsers.IdUsers))
                    {
                        anotherUser.Notifications = null;
                    }
                    else
                    {
                        anotherUser.Notifications = anotherUser.Notifications.Replace($"{currUsers.IdUsers}" + ",", "").Replace("," + $"{currUsers.IdUsers}", "").Replace($"{currUsers.IdUsers}", "");
                    }
                }
                anotherUser.Likes--;
                CurrentUser.currentUser = currUsers;
                context.SaveChanges();
                MessageBox.Show("Данный пользователь удалён");
            }
        }
    }
}
