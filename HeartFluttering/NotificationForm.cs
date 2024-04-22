using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeartFluttering
{
    public partial class NotificationForm : Form
    {
        public NotificationForm()
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

        private void listUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = listUsers.Rows[e.RowIndex];
                int position = (int)selectedRow.Cells["Номер"].Value;
                User selectedUser = CurrentUsers.currentUsers[position - 1];
                UserProfileForm form = new UserProfileForm();
                if (CurrentUser.currentUser.Notifications != null)
                {
                    if (!CurrentUser.currentUser.Notifications.Split(',').Contains(selectedUser.IdUsers))
                    {
                        form.likeAccount2.Enabled = true;
                        form.likeAccount2.Visible = true;
                    }
                }
                if (CurrentUser.currentUser.Notifications == null)
                {
                    form.likeAccount2.Enabled = true;
                    form.likeAccount2.Visible = true;
                }
                form.thisUsers = selectedUser;
                form.backButton3.Enabled = true;
                form.backButton3.Visible = true;
                this.Hide();
                form.ShowDialog();
            }
        }

        private void NotificationForm_Load(object sender, EventArgs e)
        {
            listUsers.DataSource = NotificationTable.notificationTable;
        }
    }
}
