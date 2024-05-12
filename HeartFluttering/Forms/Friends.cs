using HeartFluttering.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeartFluttering.Forms
{
    public partial class Friends : Form
    {
        private bool maximize = false;
        public Friends()
        {
            InitializeComponent();
        }
        private void Friends_Load(object sender, EventArgs e)
        {
            using (var context = new AcquaintanceSqlContext())
            {
                var currentUser = context.Users.FirstOrDefault(x => x.IdUsers == 
                CurrentUser.currentUser.IdUsers);
            }
        }
        /// <summary>
        /// Закрытие формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseButton_Click(object sender, EventArgs e)
        {
            HomeForm homeForm = new HomeForm();
            homeForm.Show();
            Hide();
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


    }
}
