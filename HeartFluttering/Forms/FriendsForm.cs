using HeartFluttering.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeartFluttering.Forms
{
    public partial class FriendsForm : Form
    {
        private bool maximize = false;

        public FriendsForm()
        {
            InitializeComponent();
        }
        private void Friends_Load(object sender, EventArgs e)
        {
            using (var context = new AcquaintanceSqlContext())
            {
                var currentUser = context.Users.FirstOrDefault(x => x.IdUsers ==
                CurrentUser.currentUser.IdUsers);
                if (currentUser.Friends != null)
                {
                    string[] idFriends = currentUser.Friends.Split(",");
                    DateTimeFormatInfo provider = new DateTimeFormatInfo();
                    provider.ShortDatePattern = "dd.MM.yyyy";
                    foreach (string id in idFriends)
                    {
                        var friend = context.Users.FirstOrDefault(x => x.IdUsers == id);
                        if (friend != null)
                        {
                            int age = DateTime.Now.Year - DateTime.ParseExact(friend.DateOfBirth, "dd.MM.yyyy", provider).Year;
                            CurrentFriendDataGridView.Rows.Add($"{friend.Surname} {friend.Name}", age);
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Закрытие формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseButton_Click(object sender, EventArgs e)
        {
            Hide();
            HomeForm homeForm = new HomeForm();
            homeForm.Show();
        }
        /// <summary>
        /// Сворачивание приложения 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CollapseButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }
        /// <summary>
        /// Открытие формы на весь экран
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSize_Click(object sender, EventArgs e)
        {
            if (!maximize)
            {
                WindowState = FormWindowState.Maximized;
                maximize = true;
            }
            else
            {
                WindowState = FormWindowState.Normal;
                maximize = false;
            }
        }
        private void SearchNameTextBox_TextChanged(object sender, EventArgs e)
        {
            using (var context = new AcquaintanceSqlContext())
            {
                SearchFriendsDataGridView.Rows.Clear();
                DateTimeFormatInfo provider = new DateTimeFormatInfo();
                provider.ShortDatePattern = "dd.MM.yyyy";
                var users = new List<User> ();
                if (CurrentUser.currentUser.Friends != null)
                {
                    string[] idFriends = CurrentUser.currentUser.Friends.Split(",");
                    users = context.Users.Where(x => x.Sex == CurrentUser.currentUser.Sex &&
                    !idFriends.Contains(x.IdUsers) && x.IdUsers != CurrentUser.currentUser.IdUsers).ToList();
                }
                else 
                {
                    users = context.Users.Where(x => x.Sex == CurrentUser.currentUser.Sex &&
                    x.IdUsers != CurrentUser.currentUser.IdUsers).ToList();
                }
                foreach (var user in users)
                {
                    int age = DateTime.Now.Year - DateTime.ParseExact(user.DateOfBirth, "dd.MM.yyyy", provider).Year;
                    var name = $"{user.Surname} {user.Name}";
                    if (AgeTextBox.Text != string.Empty && SearchNameTextBox.Text == string.Empty)
                    {
                        if (age.ToString() == AgeTextBox.Text)
                        {
                            SearchFriendsDataGridView.Rows.Add(name, age);
                        }
                    }
                    if (name.ToUpper().StartsWith(SearchNameTextBox.Text.ToUpper()) && SearchNameTextBox.Text != string.Empty)
                    {
                        if (AgeTextBox.Text == string.Empty)
                        {
                            SearchFriendsDataGridView.Rows.Add(name, age);
                        }
                        else
                        {
                            if (Convert.ToInt32(AgeTextBox.Text) == age)
                            {
                                SearchFriendsDataGridView.Rows.Add(name, age);
                            }
                        }

                    }
                }
            }
        }
        private void AgeTextBox_TextChanged(object sender, EventArgs e)
        {
            SearchNameTextBox_TextChanged(sender, e);
        }

        private void SearchFriendsDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string userName = SearchFriendsDataGridView.Rows[e.RowIndex].Cells["Name_2"].Value.ToString();
            int userAge = (int)SearchFriendsDataGridView.Rows[e.RowIndex].Cells["Age_2"].Value;
            using (var context = new AcquaintanceSqlContext())
            {
                DateTimeFormatInfo provider = new DateTimeFormatInfo();
                provider.ShortDatePattern = "dd.MM.yyyy";
                var user = context.Users.Where(x => x.Surname + " " + x.Name == userName).ToList();
                if (user.Count != 0)
                {
                    foreach (var person in user)
                    {
                        if (DateTime.Now.Year - DateTime.ParseExact(person.DateOfBirth,
                            "dd.MM.yyyy", provider).Year == userAge)
                        {
                            FriendProfileForm friendProfileForm = new FriendProfileForm();
                            friendProfileForm.BtnAdd.Visible = true;
                            friendProfileForm.BtnAdd.Enabled = true;
                            friendProfileForm.User = person;
                            friendProfileForm.Show();
                            Hide();
                            break;
                        }
                    }

                }
            }
        }

        private void CurrentFriendDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string userName = CurrentFriendDataGridView.Rows[e.RowIndex].Cells["Name_1"].Value.ToString();
            int userAge = (int)CurrentFriendDataGridView.Rows[e.RowIndex].Cells["Age_1"].Value;
            using (var context = new AcquaintanceSqlContext())
            {
                DateTimeFormatInfo provider = new DateTimeFormatInfo();
                provider.ShortDatePattern = "dd.MM.yyyy";
                var user = context.Users.Where(x => x.Surname + " " + x.Name == userName).ToList();
                if (user.Count != 0)
                {
                    foreach (var person in user)
                    {
                        if (DateTime.Now.Year - DateTime.ParseExact(person.DateOfBirth,
                            "dd.MM.yyyy", provider).Year == userAge)
                        {
                            FriendProfileForm friendProfileForm = new FriendProfileForm();
                            friendProfileForm.BtnDelete.Enabled = true;
                            friendProfileForm.BtnDelete.Visible = true;
                            friendProfileForm.User = person;
                            friendProfileForm.Show();
                            Hide();
                            break;
                        }
                    }

                }
            }
        }
    }
}
