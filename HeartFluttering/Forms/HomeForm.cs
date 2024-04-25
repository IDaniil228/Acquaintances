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
using HeartFluttering.Classes;


namespace HeartFluttering
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Кнопка для закрытия приложения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// Кнопка для сворачивания приложения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CollapseButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        /// <summary>
        /// Кнопка для выхода из аккаунта
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void closeAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            AuthorizationForm form = new AuthorizationForm();
            form.Show();
        }
        /// <summary>
        /// Кнопка для открытия редактировния
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Кнопка для загрузке данных в главном профиле
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Кнопка для замены фотографии пользователя
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Кнопка для открытии фильтров
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void searchButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            FiltersForm filtersForm = new FiltersForm();
            filtersForm.ShowDialog();
        }
        /// <summary>
        /// Кнопка для открытия рекомендации
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void recommendButton_Click(object sender, EventArgs e)
        {
            using (var context = new AcquaintanceSqlContext())
            {
                var users = context.Users.Where(r => !r.IdUsers.Equals(CurrentUser.currentUser.IdUsers));
                var sortedUsers = users.OrderByDescending(u => u.Likes).ToList();
                CurrentUsers.currentUsers = sortedUsers;
                DataTable table = new DataTable();
                table.Columns.Add("Место", typeof(int));
                table.Columns.Add("Имя", typeof(string));
                table.Columns.Add("Фамилия", typeof(string));
                table.Columns.Add("Лайки", typeof(int));
                for (int i = 0; i < sortedUsers.Count; i++)
                {
                    table.Rows.Add((i + 1), sortedUsers[i].Name, sortedUsers[i].Surname, sortedUsers[i].Likes);
                }
                RecommenForm recommenForm = new RecommenForm();
                recommenForm.listUsers.DataSource = table;
                RecommenTable.thisTable = table;
                this.Hide();
                recommenForm.Show();
            }
        }
        /// <summary>
        /// Кнопка для просмотра пользователей, которые были добавлены в избранное
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void favoritesButton_Click(object sender, EventArgs e)
        {
            using (var context = new AcquaintanceSqlContext())
            {
                List<User> anotherUsers = new List<User>();
                if (CurrentUser.currentUser.AnotherAccounts != null)
                {
                    foreach (string idUser in CurrentUser.currentUser.AnotherAccounts.Split(','))
                    {
                        var favoritesUsers = context.Users.FirstOrDefault(r => r.IdUsers.Equals(idUser));
                        if (favoritesUsers != null)
                        {
                            anotherUsers.Add(favoritesUsers);
                        }
                    }
                }
                CurrentUsers.currentUsers = anotherUsers;
                DataTable table = new DataTable();
                table.Columns.Add("Номер", typeof(int));
                table.Columns.Add("Имя", typeof(string));
                table.Columns.Add("Фамилия", typeof(string));
                table.Columns.Add("Лайки", typeof(int));
                for (int i = 0; i < anotherUsers.Count; i++)
                {
                    table.Rows.Add((i + 1), anotherUsers[i].Name, anotherUsers[i].Surname, anotherUsers[i].Likes);
                }
                ChosenOneForm chosenOneForm = new ChosenOneForm();
                chosenOneForm.listUsers.DataSource = table;
                FavoritesTable.favoritTable = table;
                this.Hide();
                chosenOneForm.Show();
            }
        }
        /// <summary>
        /// Кнопка просмотра уведомлений
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void notificationButton_Click(object sender, EventArgs e)
        {
            using (var context = new AcquaintanceSqlContext())
            {
                List<User> anotherUsers = new List<User>();
                if (CurrentUser.currentUser.Notifications != null)
                {
                    foreach (string idUser in CurrentUser.currentUser.Notifications.Split(','))
                    {
                        var favoritesUsers = context.Users.FirstOrDefault(r => r.IdUsers.Equals(idUser));
                        if (favoritesUsers != null)
                        {
                            anotherUsers.Add(favoritesUsers);
                        }
                    }
                }
                CurrentUsers.currentUsers = anotherUsers;
                DataTable table = new DataTable();
                table.Columns.Add("Номер", typeof(int));
                table.Columns.Add("Имя", typeof(string));
                table.Columns.Add("Фамилия", typeof(string));
                table.Columns.Add("Лайки", typeof(int));
                for (int i = 0; i < anotherUsers.Count; i++)
                {
                    table.Rows.Add((i + 1), anotherUsers[i].Name, anotherUsers[i].Surname, anotherUsers[i].Likes);
                }
                NotificationForm notificationForm = new NotificationForm();
                notificationForm.listUsers.DataSource = table;
                NotificationTable.notificationTable = table;
                this.Hide();
                notificationForm.Show();
            }
        }

        private void nameLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
