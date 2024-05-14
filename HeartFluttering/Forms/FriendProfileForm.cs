using HeartFluttering.Classes;
using HeartFluttering.Resources.Localization.FriendProfileForm;
using HeartFluttering.Resources.Localization.PhotoUserForm;
using HeartFluttering.Resources.Localization.UserProfileForm;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeartFluttering.Forms
{
    public partial class FriendProfileForm : Form
    {
        public User User;
        public bool fromNotification = false;
        public FriendProfileForm()
        {
            InitializeComponent();
        }

        private void CollapseButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            if (!fromNotification)
            {
                Hide();
                FriendsForm form = new FriendsForm();
                form.Show();
            }
            else
            {
                Hide();
                NotificationForm form = new NotificationForm();
                form.Show();
            }
        }

        private void FriendProfileForm_Load(object sender, EventArgs e)
        {
            nameField.Text = User.Name;
            surnameField.Text = User.Surname;
            birthdayField.Text = User.DateOfBirth;
            cityField.Text = User.City;
            if (User.Sex == 1)
            {
                selField.Text = InscriptionsUserProfile.Man;
            }
            else
            {
                selField.Text = InscriptionsUserProfile.Women;
            }
            mailField.Text = User.Mail;
            numberField.Text = User.Number;
            if (User.Photo != null)
            {
                MemoryStream memoryStream = new MemoryStream(User.Photo);
                Photo.Image = Image.FromStream(memoryStream);
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            if (!fromNotification)
            {
                Hide();
                FriendsForm form = new FriendsForm();
                form.Show();
            }
            else 
            {
                Hide();
                NotificationForm form = new NotificationForm();
                form.Show();
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            using (var context = new AcquaintanceSqlContext())
            {
                if (!fromNotification)
                {
                    var thisUser = context.Users.FirstOrDefault(x => x.IdUsers == User.IdUsers);
                    if (thisUser != null)
                    {
                        if (thisUser.NotificationsFriend != null &&
                            thisUser.NotificationsFriend.Contains(CurrentUser.currentUser.IdUsers))
                        {
                            MessageBox.Show(InscriptionsFriendProfile.AddFriend);
                        }
                        else
                        {
                            thisUser.NotificationsFriend += $"{CurrentUser.currentUser.IdUsers},";
                            MessageBox.Show(InscriptionsFriendProfile.AddFriend);
                            context.SaveChanges();
                        }
                    }
                }
                else 
                {
                    var currentUser = context.Users.FirstOrDefault(x => x.IdUsers == 
                    CurrentUser.currentUser.IdUsers);
                    if (currentUser.Friends.Contains($"{User.IdUsers}"))
                    {
                        MessageBox.Show(InscriptionsFriendProfile.AddFriendDone);
                    }
                    else 
                    {
                        currentUser.Friends += $"{User.IdUsers},";
                        currentUser.NotificationsFriend = currentUser.NotificationsFriend.Replace($"{User.IdUsers},", "");
                        var user = context.Users.FirstOrDefault(x => x.IdUsers == User.IdUsers);
                        user.NotificationsFriend = user.NotificationsFriend.Replace($"{currentUser.IdUsers},", "");
                        user.Friends += $"{currentUser.IdUsers},";
                        MessageBox.Show(InscriptionsFriendProfile.AddFriendDone);
                        context.SaveChanges();
                    }

                }
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            using (var context = new AcquaintanceSqlContext())
            {
                var currentUser = context.Users.FirstOrDefault(x => x.IdUsers == CurrentUser.currentUser.IdUsers);
                currentUser.Friends = currentUser.Friends.Replace($"{User.IdUsers},", "");
                CurrentUser.currentUser = currentUser;
                var otherUser = context.Users.FirstOrDefault(x => x.IdUsers == User.IdUsers);
                otherUser.Friends = otherUser.Friends.Replace($"{CurrentUser.currentUser.IdUsers},", "");
                context.SaveChanges();
            }  
            MessageBox.Show(InscriptionsFriendProfile.DeleteFriend);
            Hide();
            FriendsForm friendsForm = new FriendsForm();
            friendsForm.Show();
        }
    }
}
