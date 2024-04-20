using Microsoft.VisualBasic;
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
    public partial class FiltersForm : Form
    {
        public FiltersForm()
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

        private void FiltersButton_Click(object sender, EventArgs e)
        {
            if(InitialAgeField.Text == null)
            {
                MessageBox.Show("Заполните поле для фильтрации возраста");
                return;
            }
            if(FinalAgeField.Text == null)
            {
                MessageBox.Show("Заполните поле для фильтрации возраста");
                return;
            }
            if(InitialAgeField.Text != null)
            {
                foreach (char symbol in InitialAgeField.Text)
                {
                    if (!Char.IsNumber(symbol))
                    {
                        MessageBox.Show("В поле для возраста должны быть только числа");
                        return;
                    }
                }
            }
            int InitialAge = Convert.ToInt32(InitialAgeField.Text);
            foreach (char symbol in FinalAgeField.Text)
            {
                if (!Char.IsNumber(symbol))
                {
                    MessageBox.Show("В поле для возраста должны быть только числа");
                    return;
                }
            }
            int FinalAge = Convert.ToInt32(FinalAgeField.Text);
            AllCities allCities = new AllCities();
            if(cityField.Text != null)
            {
                if (!allCities.getCities().Contains(cityField.Text.ToLower()))
                {
                    MessageBox.Show("Такого города не существует");
                    return;
                }
            }
            int age = FinalAge - InitialAge;
            if(age < 0)
            {
                MessageBox.Show("Возраст не может быть отрицательным");
                return;
            }
            if(sexMenButton.Checked == false && sexWomenButton.Checked == false)
            {
                MessageBox.Show("Выберите пол");
                return;
            }
            //string city = cityField.Text.ToLower();


            if(cityField.Text == null && sexMenButton.Checked == true)
            {
                using (var context = new AcquaintanceSqlContext())
                {
                    var users = context.Users.Where(r => r.Sex == 1);
                    foreach (User user in users)
                    {
                        try
                        {
                            if ((DateTime.Now.Year - DateTime.Parse(user.DateOfBirth).Year) >= InitialAge &&
                            (DateTime.Now.Year - DateTime.Parse(user.DateOfBirth).Year) <= FinalAge)
                            {
                                CurrentUsers.currentUsers.Add(user);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            return;
                        }
                    }
                }
            }
            if (cityField.Text == null && sexWomenButton.Checked == true)
            {
                using (var context = new AcquaintanceSqlContext())
                {
                    var users = context.Users.Where(r => r.Sex == 0);
                    foreach (User user in users)
                    {
                        try
                        {
                            if ((DateTime.Now.Year - DateTime.Parse(user.DateOfBirth).Year) >= InitialAge &&
                            (DateTime.Now.Year - DateTime.Parse(user.DateOfBirth).Year) <= FinalAge)
                            {
                                CurrentUsers.currentUsers.Add(user);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            return;
                        }
                    }
                }
            }
            if(cityField.Text != null && sexMenButton.Checked == true)
            {
                using (var context = new AcquaintanceSqlContext())
                {
                    var users = context.Users.Where(r => r.Sex == 1 && r.City.Equals(cityField.Text));
                    foreach (User user in users)
                    {
                        try
                        {
                            if ((DateTime.Now.Year - DateTime.Parse(user.DateOfBirth).Year) >= InitialAge &&
                            (DateTime.Now.Year - DateTime.Parse(user.DateOfBirth).Year) <= FinalAge)
                            {
                                CurrentUsers.currentUsers.Add(user);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            return;
                        }
                    }
                }
            }
            if(cityField.Text != null && sexWomenButton.Checked == true)
            {
                using (var context = new AcquaintanceSqlContext())
                {
                    var users = context.Users.Where(r => r.Sex == 0 && r.City.Equals(cityField.Text));
                    foreach (User user in users)
                    {
                        try
                        {
                            if ((DateTime.Now.Year - DateTime.Parse(user.DateOfBirth).Year) >= InitialAge &&
                            (DateTime.Now.Year - DateTime.Parse(user.DateOfBirth).Year) <= FinalAge)
                            {
                                CurrentUsers.currentUsers.Add(user);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            return;
                        }
                    }
                }
            }
        }
    }
}
