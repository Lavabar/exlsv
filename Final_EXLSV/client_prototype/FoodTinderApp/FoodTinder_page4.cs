using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodTinderApp
{
    public partial class FoodTinder_p4 : Form
    {
        Random rnd = new Random();
        public FoodTinder_p4()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FoodTinder_p4_Load(object sender, EventArgs e)
        {
                    productLabel_p4.Text = User.finalEat.Name;
                    pictureBox_p4.ImageLocation = @"pics\" + User.finalEat.Name + ".jpg" ;
                    ccalLabel_p4.Text = $"Ккал: {rnd.Next(100,500)}";
                    proteinsLabel_p4.Text = $"Белки: {rnd.Next(10,30)}";
                    fatsLabel_p4.Text = $"Жиры: {rnd.Next(10,30)}";
                    uglevodiLabel_p4.Text = $"Угл.: {rnd.Next(10,30)}";
                    containLabel_p4.Text = "Состав: -";
        }

        private void FoodTinder_p4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
