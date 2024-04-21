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
    public partial class PhotoUserForm : Form
    {
        public PhotoUserForm()
        {
            InitializeComponent();
        }
        public List<User> currentUsers;
        private int count = 0;
        private void homeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeForm homeForm = new HomeForm();
            homeForm.ShowDialog();
        }

        private void changeFiltersButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            FiltersForm filtersForm = new FiltersForm();
            filtersForm.ShowDialog();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (currentUsers.Count == 0)
            {
                MessageBox.Show("Пользователей с такими фильтрами нет, попробуйте поменять фильтры");
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
                MessageBox.Show("Пользователей с такими фильтрами больше нет");
                return;
            }
        }

        private void likeAccount_Click(object sender, EventArgs e)
        {
            if(currentUsers.Count > count)
            {
                using(var context = new AcquaintanceSqlContext())
                {
                    var currUsers = context.Users.FirstOrDefault(r => r.IdUsers.Equals(CurrentUser.currentUser.IdUsers));
                    var anotherUser = context.Users.FirstOrDefault(r => r.IdUsers.Equals(currentUsers[count].IdUsers));

                    if(currUsers == null)
                    {
                        MessageBox.Show("Ошибка в добавлении пользователя");
                        return;
                    }
                    if(anotherUser == null)
                    {
                        MessageBox.Show("Ошибка в добавлении пользователя");
                        return;
                    }
                    if(currUsers.AnotherAccounts == null)
                    {
                        currUsers.AnotherAccounts = anotherUser.IdUsers;
                    }
                    else
                    {
                        currUsers.AnotherAccounts += "," + anotherUser.IdUsers;
                    }
                    if(anotherUser.Notifications == null)
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
                        MessageBox.Show("Данный пользователь добавлен успешно" + 
                            "\nБольше пользователей нет, поменяйте фильтры");
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("Пользователей с такими фильтрами больше нет");
                return;
            }
        }
    }
}
