namespace FoodTinderApp
{
    partial class FoodTinder_p4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FoodTinder_p4));
            this.productLabel_p4 = new System.Windows.Forms.Label();
            this.pictureBox_p4 = new System.Windows.Forms.PictureBox();
            this.ccalLabel_p4 = new System.Windows.Forms.Label();
            this.proteinsLabel_p4 = new System.Windows.Forms.Label();
            this.fatsLabel_p4 = new System.Windows.Forms.Label();
            this.uglevodiLabel_p4 = new System.Windows.Forms.Label();
            this.containLabel_p4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_p4)).BeginInit();
            this.SuspendLayout();
            // 
            // productLabel_p4
            // 
            this.productLabel_p4.AutoSize = true;
            this.productLabel_p4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.productLabel_p4.Location = new System.Drawing.Point(19, 26);
            this.productLabel_p4.Name = "productLabel_p4";
            this.productLabel_p4.Size = new System.Drawing.Size(128, 37);
            this.productLabel_p4.TabIndex = 0;
            this.productLabel_p4.Text = "Product";
            // 
            // pictureBox_p4
            // 
            this.pictureBox_p4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox_p4.Location = new System.Drawing.Point(26, 81);
            this.pictureBox_p4.Name = "pictureBox_p4";
            this.pictureBox_p4.Size = new System.Drawing.Size(280, 279);
            this.pictureBox_p4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_p4.TabIndex = 1;
            this.pictureBox_p4.TabStop = false;
            // 
            // ccalLabel_p4
            // 
            this.ccalLabel_p4.AutoSize = true;
            this.ccalLabel_p4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ccalLabel_p4.Location = new System.Drawing.Point(119, 384);
            this.ccalLabel_p4.Name = "ccalLabel_p4";
            this.ccalLabel_p4.Size = new System.Drawing.Size(67, 25);
            this.ccalLabel_p4.TabIndex = 2;
            this.ccalLabel_p4.Text = "Ккал: ";
            // 
            // proteinsLabel_p4
            // 
            this.proteinsLabel_p4.AutoSize = true;
            this.proteinsLabel_p4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.proteinsLabel_p4.Location = new System.Drawing.Point(12, 425);
            this.proteinsLabel_p4.Name = "proteinsLabel_p4";
            this.proteinsLabel_p4.Size = new System.Drawing.Size(74, 25);
            this.proteinsLabel_p4.TabIndex = 3;
            this.proteinsLabel_p4.Text = "Белки:";
            // 
            // fatsLabel_p4
            // 
            this.fatsLabel_p4.AutoSize = true;
            this.fatsLabel_p4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.fatsLabel_p4.Location = new System.Drawing.Point(119, 425);
            this.fatsLabel_p4.Name = "fatsLabel_p4";
            this.fatsLabel_p4.Size = new System.Drawing.Size(73, 25);
            this.fatsLabel_p4.TabIndex = 4;
            this.fatsLabel_p4.Text = "Жиры:";
            // 
            // uglevodiLabel_p4
            // 
            this.uglevodiLabel_p4.AutoSize = true;
            this.uglevodiLabel_p4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.uglevodiLabel_p4.Location = new System.Drawing.Point(227, 425);
            this.uglevodiLabel_p4.Name = "uglevodiLabel_p4";
            this.uglevodiLabel_p4.Size = new System.Drawing.Size(55, 25);
            this.uglevodiLabel_p4.TabIndex = 5;
            this.uglevodiLabel_p4.Text = "Угл.:";
            // 
            // containLabel_p4
            // 
            this.containLabel_p4.AutoSize = true;
            this.containLabel_p4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.containLabel_p4.Location = new System.Drawing.Point(2, 466);
            this.containLabel_p4.Name = "containLabel_p4";
            this.containLabel_p4.Size = new System.Drawing.Size(75, 22);
            this.containLabel_p4.TabIndex = 6;
            this.containLabel_p4.Text = "Состав:";
            // 
            // FoodTinder_p4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 584);
            this.Controls.Add(this.containLabel_p4);
            this.Controls.Add(this.uglevodiLabel_p4);
            this.Controls.Add(this.fatsLabel_p4);
            this.Controls.Add(this.proteinsLabel_p4);
            this.Controls.Add(this.ccalLabel_p4);
            this.Controls.Add(this.pictureBox_p4);
            this.Controls.Add(this.productLabel_p4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FoodTinder_p4";
            this.Text = "Fourth Page";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FoodTinder_p4_FormClosed);
            this.Load += new System.EventHandler(this.FoodTinder_p4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_p4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label productLabel_p4;
        private System.Windows.Forms.PictureBox pictureBox_p4;
        private System.Windows.Forms.Label ccalLabel_p4;
        private System.Windows.Forms.Label proteinsLabel_p4;
        private System.Windows.Forms.Label fatsLabel_p4;
        private System.Windows.Forms.Label uglevodiLabel_p4;
        private System.Windows.Forms.Label containLabel_p4;
    }
}