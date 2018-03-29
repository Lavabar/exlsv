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
    public partial class FoodTinder_p3 : Form
    { 
        int gotCategory = -1, tmp = -1;
        string nameOfProduct;
        Random rnd = new Random();
        public FoodTinder_p3()
        {
            InitializeComponent();
        }

        private void breakfastLabel_Click(object sender, EventArgs e)
        {
            User.ChoicedMeal = 0;
            FoodTinder_p4 fourthPage = new FoodTinder_p4();
            this.Hide();
            fourthPage.Show();
        }

        private void lunchButton_Click(object sender, EventArgs e)
        {
            User.ChoicedMeal = 1;
            FoodTinder_p4 fourthPage = new FoodTinder_p4();
            this.Hide();
            fourthPage.Show();
        }

        private void dinnerButton_Click(object sender, EventArgs e)
        {
            User.ChoicedMeal = 2;
            FoodTinder_p4 fourthPage = new FoodTinder_p4();
            this.Hide();
            fourthPage.Show();
        }

        private void FoodTinder_p3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void FoodTinder_p3_Load(object sender, EventArgs e)
        {
            Inform.SendSome("0");
            nameOfProduct = Inform.RecieveMessage();
            Inform.CloseConn();
            if (nameOfProduct.ToString().Replace("\0","").Length == 3) gotCategory = Convert.ToInt32(nameOfProduct[0].ToString() + "" + nameOfProduct[1].ToString());
            else if (nameOfProduct.ToString().Replace("\0","").Length == 2) gotCategory = Convert.ToInt32(nameOfProduct[0].ToString());
            var result = User.list_p2.Select(x => x).Where(x => x.typeOfProduct == gotCategory).ToList();
            int tmp = result.Count();
            tmp = rnd.Next(0,tmp);
            User.finalEat = result[tmp];
        }
    }
}
