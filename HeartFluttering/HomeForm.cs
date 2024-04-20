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
            editingForm.nameField.Text = CurrentUser.currentUser.Name;
            editingForm.nameField.ForeColor = Color.Black;
            editingForm.surnameField.Text = CurrentUser.currentUser.Surname;
            editingForm.surnameField.ForeColor = Color.Black;
            if (CurrentUser.currentUser.DateOfBirth != null)
            {
                editingForm.birhdayField.Text = CurrentUser.currentUser.DateOfBirth;
                editingForm.birhdayField.ForeColor = Color.Black;
            }
            if (CurrentUser.currentUser.City != null)
            {
                editingForm.cityField.Text = CurrentUser.currentUser.City;
                editingForm.cityField.ForeColor = Color.Black;
            }
            if (CurrentUser.currentUser.Sex != null)
            {
                if (CurrentUser.currentUser.Sex == 1)
                {
                    editingForm.sexMenButton.Checked = true;
                }
                else
                {
                    editingForm.sexWomenButton.Checked = true;
                }
            }
            if (CurrentUser.currentUser.Mail != null)
            {
                editingForm.emailField.Text = CurrentUser.currentUser.Mail;
                editingForm.emailField.ForeColor = Color.Black;
            }
            if (CurrentUser.currentUser.Number != null)
            {
                editingForm.numberField.Text = CurrentUser.currentUser.Number;
                editingForm.numberField.ForeColor = Color.Black;
            }
            editingForm.user = CurrentUser.currentUser;
            editingForm.ShowDialog();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            
            nameField.Text = CurrentUser.currentUser.Name;
            surnameField.Text = CurrentUser.currentUser.Surname;
            BirhdayField.Text = CurrentUser.currentUser.DateOfBirth;
            cityField.Text = CurrentUser.currentUser.City;
            if (CurrentUser.currentUser.Sex == 1)
            {
                sexField.Text = "Мужской";
            }
            if (CurrentUser.currentUser.Sex == 0)
            {
                sexField.Text = "Женский";
            }
            emailField.Text = CurrentUser.currentUser.Mail;
            numberField.Text = CurrentUser.currentUser.Number;
            if (CurrentUser.currentUser.Photo != null)
            {
                MemoryStream memoryStream = new MemoryStream(CurrentUser.currentUser.Photo);
                photoField.Image = Image.FromStream(memoryStream);
            }
        }

        private void redactionPhotoButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.png;*.jpeg;*.gif;*.raw;*.jpg)|*.png;*.jpeg;*.gif;*.raw|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    photoField.Image = new Bitmap(openFileDialog.FileName);
                }
                catch
                {
                    MessageBox.Show("Невозможно загрузить эту картинку", "Ошибка загрузки", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            byte[] imageBytes;
            using (var context = new AcquaintanceSqlContext())
            {
                var person = context.Users.FirstOrDefault(r => r.Id.Equals(CurrentUser.currentUser.Id));
                if (person == null)
                {
                    MessageBox.Show("Пользователь не найден");
                    return;
                }
                using (MemoryStream ms = new MemoryStream())
                {
                    photoField.Image.Save(ms, photoField.Image.RawFormat);
                    imageBytes = ms.ToArray();
                }
                CurrentUser.currentUser.Photo = imageBytes;
                person.Photo = CurrentUser.currentUser.Photo;
                context.SaveChanges();
            }
        }
    }
}
