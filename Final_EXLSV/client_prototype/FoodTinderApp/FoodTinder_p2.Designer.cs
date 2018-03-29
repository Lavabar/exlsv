namespace FoodTinderApp
{
    partial class FoodTinder_p2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FoodTinder_p2));
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.productName = new System.Windows.Forms.Label();
            this.unlikeButton = new System.Windows.Forms.Button();
            this.likeButton = new System.Windows.Forms.Button();
            this.countLabel = new System.Windows.Forms.Label();
            this.microPicBox = new System.Windows.Forms.PictureBox();
            this.arrowPicBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.microPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrowPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.Location = new System.Drawing.Point(44, 78);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(248, 245);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // productName
            // 
            this.productName.AutoSize = true;
            this.productName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.productName.Location = new System.Drawing.Point(67, 339);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(137, 36);
            this.productName.TabIndex = 1;
            this.productName.Text = "Продукт";
            // 
            // unlikeButton
            // 
            this.unlikeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.unlikeButton.Location = new System.Drawing.Point(44, 399);
            this.unlikeButton.Name = "unlikeButton";
            this.unlikeButton.Size = new System.Drawing.Size(101, 75);
            this.unlikeButton.TabIndex = 3;
            this.unlikeButton.Text = "✖";
            this.unlikeButton.UseVisualStyleBackColor = true;
            this.unlikeButton.Click += new System.EventHandler(this.unlikeButton_Click);
            // 
            // likeButton
            // 
            this.likeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.likeButton.Location = new System.Drawing.Point(191, 399);
            this.likeButton.Name = "likeButton";
            this.likeButton.Size = new System.Drawing.Size(101, 75);
            this.likeButton.TabIndex = 4;
            this.likeButton.Text = "❤";
            this.likeButton.UseVisualStyleBackColor = true;
            this.likeButton.Click += new System.EventHandler(this.likeButton_Click);
            // 
            // countLabel
            // 
            this.countLabel.AutoSize = true;
            this.countLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countLabel.Location = new System.Drawing.Point(151, 17);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(43, 46);
            this.countLabel.TabIndex = 5;
            this.countLabel.Text = "5";
            // 
            // microPicBox
            // 
            this.microPicBox.Image = ((System.Drawing.Image)(resources.GetObject("microPicBox.Image")));
            this.microPicBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("microPicBox.InitialImage")));
            this.microPicBox.Location = new System.Drawing.Point(121, 484);
            this.microPicBox.Name = "microPicBox";
            this.microPicBox.Size = new System.Drawing.Size(83, 88);
            this.microPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.microPicBox.TabIndex = 7;
            this.microPicBox.TabStop = false;
            this.microPicBox.Click += new System.EventHandler(this.microPicBox_Click);
            // 
            // arrowPicBox
            // 
            this.arrowPicBox.Image = global::FoodTinderApp.Properties.Resources.arrow;
            this.arrowPicBox.Location = new System.Drawing.Point(263, 12);
            this.arrowPicBox.Name = "arrowPicBox";
            this.arrowPicBox.Size = new System.Drawing.Size(63, 51);
            this.arrowPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.arrowPicBox.TabIndex = 8;
            this.arrowPicBox.TabStop = false;
            this.arrowPicBox.Click += new System.EventHandler(this.arrowPicBox_Click);
            // 
            // FoodTinder_p2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 584);
            this.Controls.Add(this.arrowPicBox);
            this.Controls.Add(this.microPicBox);
            this.Controls.Add(this.countLabel);
            this.Controls.Add(this.likeButton);
            this.Controls.Add(this.unlikeButton);
            this.Controls.Add(this.productName);
            this.Controls.Add(this.pictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FoodTinder_p2";
            this.Text = "Second Page";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FoodTinder_p2_FormClosing);
            this.Load += new System.EventHandler(this.FoodTinder_p2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.microPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrowPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label productName;
        private System.Windows.Forms.Button unlikeButton;
        private System.Windows.Forms.Button likeButton;
        private System.Windows.Forms.Label countLabel;
        private System.Windows.Forms.PictureBox microPicBox;
        private System.Windows.Forms.PictureBox arrowPicBox;
    }
}