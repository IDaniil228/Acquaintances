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
    public partial class RegistrForm2 : Form
    {
        public RegistrForm2()
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

        private void nameField_Enter(object sender, EventArgs e)
        {
            if (nameField.Text.Equals("Введите имя..."))
            {
                nameField.Text = string.Empty;
                nameField.ForeColor = Color.Black;
            }
        }

        private void nameField_Leave(object sender, EventArgs e)
        {
            if (nameField.Text.Equals(string.Empty))
            {
                nameField.ForeColor = Color.Gray;
                nameField.Text = "Введите имя...";
            }
        }

        private void surnameField_Enter(object sender, EventArgs e)
        {
            if (surnameField.Text.Equals("Введите фамилию..."))
            {
                surnameField.Text = string.Empty;
                surnameField.ForeColor = Color.Black;
            }
        }

        private void surnameField_Leave(object sender, EventArgs e)
        {
            if (surnameField.Text.Equals(string.Empty))
            {
                surnameField.ForeColor = Color.Gray;
                surnameField.Text = "Введите фамилию...";
            }
        }

        private void BirhdayFields_Enter(object sender, EventArgs e)
        {
            if (BirhdayFields.Text.Equals("Введите дату рождения..."))
            {
                BirhdayFields.Text = string.Empty;
                BirhdayFields.ForeColor = Color.Black;
            }
        }

        private void BirhdayFields_Leave(object sender, EventArgs e)
        {
            if (BirhdayFields.Text.Equals(string.Empty))
            {
                BirhdayFields.ForeColor = Color.Gray;
                BirhdayFields.Text = "Введите дату рождения...";
            }
        }

        private void cityField_Enter(object sender, EventArgs e)
        {
            if (cityField.Text.Equals("Введите город проживания..."))
            {
                cityField.Text = string.Empty;
                cityField.ForeColor = Color.Black;
            }
        }

        private void cityField_Leave(object sender, EventArgs e)
        {
            if (cityField.Text.Equals(string.Empty))
            {
                cityField.ForeColor = Color.Gray;
                cityField.Text = "Введите город проживания...";
            }
        }

        private void registrButton_Click(object sender, EventArgs e)
        {
            /*
            if(nameField.Text == string.Empty)
            {
                MessageBox.Show("Поле для имени обязательно для заполнения");
                return;
            }
            if(surnameField.Text == string.Empty)
            {
                MessageBox.Show("Поле для фамилии обязательно для заполнения");
                return;
            }
            using (var context = new AcquaintanceSqlContext())
            {
                User user = new User();
                RegistrForm registrForm = new RegistrForm();
                user.Id = registrForm.account.Id;
                MessageBox.Show(user.Id);
            }
            */
        }
    }
}
