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

namespace HeartFluttering
{
    public partial class RecommenForm : Form
    {
        public RecommenForm()
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
                int position = (int)selectedRow.Cells["Место"].Value;
                User selectedUser = CurrentUsers.currentUsers[position - 1];
                UserProfileForm form = new UserProfileForm();
                if(CurrentUser.currentUser.AnotherAccounts != null)
                {
                    if (!CurrentUser.currentUser.AnotherAccounts.Split(',').Contains(selectedUser.IdUsers))
                    {
                        form.likeAccount.Enabled = true;
                        form.likeAccount.Visible = true;
                    }
                }
                if(CurrentUser.currentUser.AnotherAccounts == null)
                {
                    form.likeAccount.Enabled = true;
                    form.likeAccount.Visible = true;
                }
                form.thisUsers = selectedUser;
                form.backButton.Enabled = true;
                form.backButton.Visible = true;
                this.Hide();
                form.ShowDialog();
            }
        }

        private void RecommenForm_Load(object sender, EventArgs e)
        {
            listUsers.DataSource = RecommenTable.thisTable;
        }
    }
}
