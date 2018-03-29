using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Speech;
using System.Speech.Recognition;
using System.Windows.Forms;

namespace FoodTinderApp
{
    public partial class FoodTinder_p2 : Form
    {
        string response = "";
        bool worked = false;
        SpeechRecognizer speechrec;
        List<string> filesInDir = Directory.GetFiles(@"pics\", "*.jpg").ToList<string>();
        int count = 0, tmp = 0;
        Random rnd = new Random();
        public FoodTinder_p2()
        {
            InitializeComponent();
            try
            {
                speechrec.SpeechRecognized += speechrec_SpeechRecognized;
            }
            catch (Exception) { }
        }

        void speechrec_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            if(e.Result.Text == "yes")
            {
                response += rnd.Next(1, 12).ToString();
                Inform.SendSome(response.Length.ToString());
                Inform.SendSome(response);
                response = "";
                GetNextProduct();
            }
            else
            {
                response += "-" + rnd.Next(1, 12);
                Inform.SendSome(response.Length.ToString());
                Inform.SendSome(response);
                response = "";
                GetNextProduct();
            }
        }

        private void FoodTinder_p2_Load(object sender, EventArgs e)
        {
            DataBase.openConnection();
            DataBase.SendFirstQuery();
            DataBase.closeConnection();
            try
            {
                speechrec = new SpeechRecognizer();
            }
            catch (Exception) { }
            Inform.SendSome("1");
            try
            {
                var choices = new Choices();
                choices.Add("yes");
                choices.Add("no");
                var gb = new GrammarBuilder(choices);
                var g = new Grammar(gb);
                speechrec.LoadGrammar(g);
            }
            catch (Exception) { }                
            arrowPicBox.Hide();
            GetNextProduct();
        }

        private void likeButton_Click(object sender, EventArgs e)
        {
            response += rnd.Next(1, 12).ToString();
            Inform.SendSome(response.Length.ToString());
            Inform.SendSome(response);
            response = "";
            GetNextProduct();
        }

        private void unlikeButton_Click(object sender, EventArgs e)
        {
            response += "-" + rnd.Next(1,12);
            Inform.SendSome(response.Length.ToString());
            Inform.SendSome(response);
            response = "";
            GetNextProduct();
        }

        private void GetNextProduct()
        {
            if (count >= 10) arrowPicBox.Show();
            countLabel.Text = count.ToString();
            count++;
            tmp = rnd.Next(0, User.list_p2.Count);
            pictureBox.ImageLocation = @"pics\" + User.list_p2[tmp].Name.Replace("-", " ") + ".jpg";
            productName.Text = User.list_p2[tmp].Name.Replace("-", " ");
            User.list_p2.Remove(User.list_p2[tmp]);
            if(User.list_p2.Count == 0)
            {
                Inform.SendSome("0");
                try
                {
                    speechrec.Enabled = false;
                }
                catch (Exception) { }  
                likeButton.Hide();
                unlikeButton.Hide();
                arrowPicBox.Show();
                microPicBox.Hide();

            }
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            speechrec.Enabled = false;
            FoodTinder_p3 thirdPage = new FoodTinder_p3();
            this.Hide();
            thirdPage.Show();

        }

        private void microPicBox_Click(object sender, EventArgs e)
        {
            try
            {
                if (speechrec.Enabled == false)
                {
                    speechrec.Enabled = true;
                    microPicBox.ImageLocation = @"pics\micro\micro.png";
                }
                else
                {
                    speechrec.Enabled = false;
                    microPicBox.ImageLocation = @"pics\micro\micro.png";
                }
            }
            catch (Exception) { }
        }

        private void arrowPicBox_Click(object sender, EventArgs e)
        {
            try
            {
                speechrec.Enabled = false;
            }
            catch (Exception) { }
            FoodTinder_p3 thirdPage = new FoodTinder_p3();
            this.Hide();
            thirdPage.Show();
        }

        private void FoodTinder_p2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
