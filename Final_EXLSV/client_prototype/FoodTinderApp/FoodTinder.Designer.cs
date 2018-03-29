namespace FoodTinderApp
{
    partial class StartPage
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartPage));
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.introduceLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.GenderAgeLabel = new System.Windows.Forms.Label();
            this.dailyActivityComboBox = new System.Windows.Forms.ComboBox();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.proceedButton = new System.Windows.Forms.Button();
            this.weightLabel = new System.Windows.Forms.Label();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.dailyActivityTextBox = new System.Windows.Forms.Label();
            this.kgLabel = new System.Windows.Forms.Label();
            this.yearsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.welcomeLabel.Location = new System.Drawing.Point(31, 32);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(275, 32);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Добро пожаловать!";
            // 
            // introduceLabel
            // 
            this.introduceLabel.AutoSize = true;
            this.introduceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.introduceLabel.Location = new System.Drawing.Point(23, 76);
            this.introduceLabel.Name = "introduceLabel";
            this.introduceLabel.Size = new System.Drawing.Size(294, 26);
            this.introduceLabel.TabIndex = 1;
            this.introduceLabel.Text = "Пожалуйста представьтесь";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(28, 130);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(289, 26);
            this.nameTextBox.TabIndex = 2;
            // 
            // GenderAgeLabel
            // 
            this.GenderAgeLabel.AutoSize = true;
            this.GenderAgeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GenderAgeLabel.Location = new System.Drawing.Point(23, 201);
            this.GenderAgeLabel.Name = "GenderAgeLabel";
            this.GenderAgeLabel.Size = new System.Drawing.Size(294, 26);
            this.GenderAgeLabel.TabIndex = 3;
            this.GenderAgeLabel.Text = "Укажите ваш пол и возраст";
            // 
            // dailyActivityComboBox
            // 
            this.dailyActivityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dailyActivityComboBox.FormattingEnabled = true;
            this.dailyActivityComboBox.Items.AddRange(new object[] {
            "Низкая",
            "Средняя",
            "Высокая"});
            this.dailyActivityComboBox.Location = new System.Drawing.Point(94, 450);
            this.dailyActivityComboBox.Name = "dailyActivityComboBox";
            this.dailyActivityComboBox.Size = new System.Drawing.Size(135, 28);
            this.dailyActivityComboBox.TabIndex = 4;
            // 
            // genderComboBox
            // 
            this.genderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Items.AddRange(new object[] {
            "Мужской",
            "Женский"});
            this.genderComboBox.Location = new System.Drawing.Point(28, 244);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(121, 28);
            this.genderComboBox.TabIndex = 5;
            // 
            // ageTextBox
            // 
            this.ageTextBox.Location = new System.Drawing.Point(207, 244);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(38, 26);
            this.ageTextBox.TabIndex = 6;
            // 
            // proceedButton
            // 
            this.proceedButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.proceedButton.Location = new System.Drawing.Point(114, 519);
            this.proceedButton.Name = "proceedButton";
            this.proceedButton.Size = new System.Drawing.Size(87, 53);
            this.proceedButton.TabIndex = 7;
            this.proceedButton.Text = "OK";
            this.proceedButton.UseVisualStyleBackColor = true;
            this.proceedButton.Click += new System.EventHandler(this.proceedButton_Click);
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.weightLabel.Location = new System.Drawing.Point(100, 289);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(98, 26);
            this.weightLabel.TabIndex = 8;
            this.weightLabel.Text = "Ваш вес";
            // 
            // weightTextBox
            // 
            this.weightTextBox.Location = new System.Drawing.Point(114, 334);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(35, 26);
            this.weightTextBox.TabIndex = 9;
            // 
            // dailyActivityTextBox
            // 
            this.dailyActivityTextBox.AutoSize = true;
            this.dailyActivityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dailyActivityTextBox.Location = new System.Drawing.Point(28, 393);
            this.dailyActivityTextBox.Name = "dailyActivityTextBox";
            this.dailyActivityTextBox.Size = new System.Drawing.Size(278, 26);
            this.dailyActivityTextBox.TabIndex = 10;
            this.dailyActivityTextBox.Text = "Активность в течение дня";
            // 
            // kgLabel
            // 
            this.kgLabel.AutoSize = true;
            this.kgLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kgLabel.Location = new System.Drawing.Point(155, 332);
            this.kgLabel.Name = "kgLabel";
            this.kgLabel.Size = new System.Drawing.Size(31, 26);
            this.kgLabel.TabIndex = 11;
            this.kgLabel.Text = "кг";
            // 
            // yearsLabel
            // 
            this.yearsLabel.AutoSize = true;
            this.yearsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yearsLabel.Location = new System.Drawing.Point(251, 244);
            this.yearsLabel.Name = "yearsLabel";
            this.yearsLabel.Size = new System.Drawing.Size(47, 26);
            this.yearsLabel.TabIndex = 12;
            this.yearsLabel.Text = "лет";
            // 
            // StartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 584);
            this.Controls.Add(this.yearsLabel);
            this.Controls.Add(this.kgLabel);
            this.Controls.Add(this.dailyActivityTextBox);
            this.Controls.Add(this.weightTextBox);
            this.Controls.Add(this.weightLabel);
            this.Controls.Add(this.proceedButton);
            this.Controls.Add(this.ageTextBox);
            this.Controls.Add(this.genderComboBox);
            this.Controls.Add(this.dailyActivityComboBox);
            this.Controls.Add(this.GenderAgeLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.introduceLabel);
            this.Controls.Add(this.welcomeLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StartPage";
            this.Text = "First Page";
            this.Load += new System.EventHandler(this.StartPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label introduceLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label GenderAgeLabel;
        private System.Windows.Forms.ComboBox dailyActivityComboBox;
        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.Button proceedButton;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.Label dailyActivityTextBox;
        private System.Windows.Forms.Label kgLabel;
        private System.Windows.Forms.Label yearsLabel;
    }
}

