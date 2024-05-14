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
    public partial class GeneralForm : Form
    {
        List<string> аddedId = new List<string>();
        bool maximize = false;
        public GeneralForm()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Hide();
            FriendsForm friendsForm = new FriendsForm();
            friendsForm.Show();
        }

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

        private void CollapseButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void GeneralForm_Load(object sender, EventArgs e)
        {
            using (var context = new AcquaintanceSqlContext())
            {
                аddedId.Clear();
                var currentUser = context.Users.FirstOrDefault(x => x.IdUsers ==
                CurrentUser.currentUser.IdUsers);
                var idFavorites = currentUser.AnotherAccounts.Split(',');
                var idFriends = currentUser.Friends.Split(',');
                foreach (var idFavorite in idFavorites)
                {
                    if (idFavorite == string.Empty)
                    {
                        continue;
                    }
                    int count = 0;
                    foreach (var idFriend in idFriends)
                    {
                        if (idFriend == string.Empty)
                        {
                            continue;
                        }
                        var friend = context.Users.FirstOrDefault(x => x.IdUsers == idFriend);
                        if (friend.AnotherAccounts.Contains(idFavorite))
                        {
                            count++;
                            continue;
                        }
                    }
                    аddedId.Add(idFavorite);
                    var user = context.Users.FirstOrDefault(x => x.IdUsers == idFavorite);
                    DateTimeFormatInfo provider = new DateTimeFormatInfo();
                    provider.ShortDatePattern = "dd.MM.yyyy";
                    int age = DateTime.Now.Year - DateTime.ParseExact(user.DateOfBirth, "dd.MM.yyyy", provider).Year;
                    GeneralDataGridView.Rows.Add($"{user.Surname} {user.Name}", age, count);
                }
                GeneralDataGridView.Sort(GeneralDataGridView.Columns[2], ListSortDirection.Descending);
                foreach (var idFriend in idFriends)
                {
                    if (idFriend == string.Empty)
                    {
                        continue;
                    }
                    var friend = context.Users.FirstOrDefault(x => x.IdUsers == idFriend);
                    foreach (var favoriteOfFriend in friend.AnotherAccounts.Split(','))
                    {
                        if (favoriteOfFriend == string.Empty)
                        {
                            continue;
                        }
                        if (аddedId.Contains(favoriteOfFriend))
                        {
                            continue;
                        }
                        if (!currentUser.AnotherAccounts.Contains(favoriteOfFriend))
                        {
                            var user = context.Users.FirstOrDefault(x => x.IdUsers == favoriteOfFriend);
                            DateTimeFormatInfo provider = new DateTimeFormatInfo();
                            provider.ShortDatePattern = "dd.MM.yyyy";
                            int age = DateTime.Now.Year - DateTime.ParseExact(user.DateOfBirth, "dd.MM.yyyy", provider).Year;
                            GeneralDataGridView.Rows.Add($"{user.Surname} {user.Name}", age, $"У {friend.Name}");
                            аddedId.Add(favoriteOfFriend);
                        }
                    }
                }
            }
        }

        private void GeneralDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string userName = GeneralDataGridView.Rows[e.RowIndex].Cells["Name_1"].Value.ToString();
            using (var context = new AcquaintanceSqlContext())
            {
                foreach (var id in аddedId)
                {
                    var user = context.Users.FirstOrDefault(x => x.IdUsers == id &&
                    x.Surname + " " + x.Name == userName);
                    if (user != null)
                    {
                        UserProfileForm form = new UserProfileForm();
                        form.thisUsers = user;
                        form.BtnExitDefault.Enabled = true;
                        form.BtnExitDefault.Visible = true;
                        form.deleteButton.Enabled = true;
                        form.deleteButton.Visible = true;
                        Hide();
                        form.Show();
                        break;
                    }
                }
            }
        }
    }
}
