using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeartFluttering
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }
        public User user;

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CollapseButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void closeAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }

        private void redactionButton_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            EditingForm editingForm = new EditingForm();
            editingForm.nameField.Text = user.Name;
            editingForm.nameField.ForeColor = Color.Black;
            editingForm.surnameField.Text = user.Surname;
            editingForm.surnameField.ForeColor = Color.Black;
            if(user.DateOfBirth != null)
            {
                editingForm.birhdayField.Text = user.DateOfBirth;
                editingForm.birhdayField.ForeColor = Color.Black;
            }
            if (user.City != null) 
            {
                editingForm.cityField.Text = user.City;
                editingForm.cityField.ForeColor = Color.Black;
            }
            if(user.Sex != null)
            {
                if(user.Sex == 1)
                {
                    editingForm.sexMenButton.Checked = true;
                }
                else
                {
                    editingForm.sexWomenButton.Checked = true;
                }
            }
            if (user.Mail != null) 
            {
                editingForm.emailField.Text = user.Mail;
                editingForm.emailField.ForeColor = Color.Black;
            }
            if(user.Number != null)
            {
                editingForm.numberField.Text = user.Number;
                editingForm.numberField.ForeColor = Color.Black;
            }
            editingForm.user = user;
            editingForm.ShowDialog();
            
        }
    }
}
