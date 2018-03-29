namespace FoodTinderApp
{
    partial class FoodTinder_p3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FoodTinder_p3));
            this.breakfastLabel = new System.Windows.Forms.Button();
            this.lunchButton = new System.Windows.Forms.Button();
            this.dinnerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // breakfastLabel
            // 
            this.breakfastLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.breakfastLabel.Location = new System.Drawing.Point(12, 43);
            this.breakfastLabel.Name = "breakfastLabel";
            this.breakfastLabel.Size = new System.Drawing.Size(314, 115);
            this.breakfastLabel.TabIndex = 0;
            this.breakfastLabel.Text = "Завтрак";
            this.breakfastLabel.UseVisualStyleBackColor = true;
            this.breakfastLabel.Click += new System.EventHandler(this.breakfastLabel_Click);
            // 
            // lunchButton
            // 
            this.lunchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lunchButton.Location = new System.Drawing.Point(12, 228);
            this.lunchButton.Name = "lunchButton";
            this.lunchButton.Size = new System.Drawing.Size(314, 115);
            this.lunchButton.TabIndex = 1;
            this.lunchButton.Text = "Обед";
            this.lunchButton.UseVisualStyleBackColor = true;
            this.lunchButton.Click += new System.EventHandler(this.lunchButton_Click);
            // 
            // dinnerButton
            // 
            this.dinnerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.dinnerButton.Location = new System.Drawing.Point(12, 417);
            this.dinnerButton.Name = "dinnerButton";
            this.dinnerButton.Size = new System.Drawing.Size(314, 115);
            this.dinnerButton.TabIndex = 2;
            this.dinnerButton.Text = "Ужин";
            this.dinnerButton.UseVisualStyleBackColor = true;
            this.dinnerButton.Click += new System.EventHandler(this.dinnerButton_Click);
            // 
            // FoodTinder_p3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 584);
            this.Controls.Add(this.dinnerButton);
            this.Controls.Add(this.lunchButton);
            this.Controls.Add(this.breakfastLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FoodTinder_p3";
            this.Text = "Third Page";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FoodTinder_p3_FormClosed);
            this.Load += new System.EventHandler(this.FoodTinder_p3_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button breakfastLabel;
        private System.Windows.Forms.Button lunchButton;
        private System.Windows.Forms.Button dinnerButton;
    }
}