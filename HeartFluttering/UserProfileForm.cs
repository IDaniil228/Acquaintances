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
            this.Hide();
            RecommenForm recommenForm = new RecommenForm();
            recommenForm.ShowDialog();
        }
        private void likeAccount_Click(object sender, EventArgs e)
        {
            using(var context = new AcquaintanceSqlContext())
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
    }
}
