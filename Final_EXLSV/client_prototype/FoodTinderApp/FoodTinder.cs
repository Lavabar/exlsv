using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech;
using System.Speech.Recognition;
using System.Net.Sockets;
using System.Net;

namespace FoodTinderApp
{
    public partial class StartPage : Form
    {

        public StartPage()
        {
            InitializeComponent();
            genderComboBox.SelectedIndex = 0;
            dailyActivityComboBox.SelectedIndex = 0;
        }

        private void proceedButton_Click(object sender, EventArgs e)
        {
            if(nameTextBox.Text.Trim() == "" || ageTextBox.Text.Trim() == "" || weightTextBox.Text.Trim() == "")
            {
                MessageBox.Show("Неверно введены данные!");
                return;
            }
            User.Name = nameTextBox.Text;
            User.Gender = genderComboBox.SelectedItem.ToString() == "Мужчина" ? true : false;
            User.Age = Convert.ToInt32(ageTextBox.Text);
            User.Weight = Convert.ToInt32(weightTextBox.Text);
            User.dailyActivity = dailyActivityComboBox.SelectedItem.ToString();
            FoodTinder_p2 secondPage = new FoodTinder_p2();
            this.Hide();
            secondPage.Show();
            }

        private void StartPage_Load(object sender, EventArgs e)
        {
            Inform.OpenConn();
            Inform.SendSome("0");
            User.ID = Convert.ToInt32(Inform.RecieveMessage());
            
        }
    }
}
