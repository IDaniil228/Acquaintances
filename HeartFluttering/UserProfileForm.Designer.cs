namespace HeartFluttering
{
    partial class UserProfileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserProfileForm));
            girlPhoto = new PictureBox();
            boyPhoto = new PictureBox();
            CollapseButton = new Button();
            CloseButton = new Button();
            entryLabel = new Label();
            panel1 = new Panel();
            likeAccount2 = new PictureBox();
            backButton3 = new Button();
            backButton2 = new Button();
            deleteButton = new Button();
            likeAccount = new PictureBox();
            backButton = new Button();
            label14 = new Label();
            label13 = new Label();
            numberField = new Label();
            mailField = new Label();
            selField = new Label();
            cityField = new Label();
            birthdayField = new Label();
            surnameField = new Label();
            nameField = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            passwondLabel = new Label();
            loginLabel = new Label();
            Photo = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)girlPhoto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)boyPhoto).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)likeAccount2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)likeAccount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Photo).BeginInit();
            SuspendLayout();
            // 
            // girlPhoto
            // 
            girlPhoto.BackColor = Color.Fuchsia;
            girlPhoto.Image = (Image)resources.GetObject("girlPhoto.Image");
            girlPhoto.Location = new Point(484, 29);
            girlPhoto.Name = "girlPhoto";
            girlPhoto.Size = new Size(63, 58);
            girlPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            girlPhoto.TabIndex = 50;
            girlPhoto.TabStop = false;
            // 
            // boyPhoto
            // 
            boyPhoto.BackColor = Color.Fuchsia;
            boyPhoto.Image = (Image)resources.GetObject("boyPhoto.Image");
            boyPhoto.Location = new Point(28, 30);
            boyPhoto.Name = "boyPhoto";
            boyPhoto.Size = new Size(63, 58);
            boyPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            boyPhoto.TabIndex = 49;
            boyPhoto.TabStop = false;
            // 
            // CollapseButton
            // 
            CollapseButton.Anchor = AnchorStyles.Bottom;
            CollapseButton.BackColor = Color.Fuchsia;
            CollapseButton.FlatAppearance.BorderSize = 0;
            CollapseButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(212, 22, 207);
            CollapseButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(249, 158, 246);
            CollapseButton.FlatStyle = FlatStyle.Flat;
            CollapseButton.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            CollapseButton.ForeColor = Color.White;
            CollapseButton.Location = new Point(513, 0);
            CollapseButton.Name = "CollapseButton";
            CollapseButton.Size = new Size(35, 23);
            CollapseButton.TabIndex = 48;
            CollapseButton.Text = "—";
            CollapseButton.UseVisualStyleBackColor = false;
            CollapseButton.Click += CollapseButton_Click;
            // 
            // CloseButton
            // 
            CloseButton.BackColor = Color.Fuchsia;
            CloseButton.FlatAppearance.BorderSize = 0;
            CloseButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(212, 22, 207);
            CloseButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(249, 158, 246);
            CloseButton.FlatStyle = FlatStyle.Flat;
            CloseButton.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            CloseButton.ForeColor = Color.White;
            CloseButton.Location = new Point(544, 0);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(35, 23);
            CloseButton.TabIndex = 47;
            CloseButton.Text = "X";
            CloseButton.UseVisualStyleBackColor = false;
            CloseButton.Click += CloseButton_Click;
            // 
            // entryLabel
            // 
            entryLabel.BackColor = Color.Magenta;
            entryLabel.Dock = DockStyle.Top;
            entryLabel.Font = new Font("Segoe Print", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            entryLabel.ForeColor = SystemColors.ButtonHighlight;
            entryLabel.Location = new Point(0, 0);
            entryLabel.Name = "entryLabel";
            entryLabel.Size = new Size(581, 88);
            entryLabel.TabIndex = 46;
            entryLabel.Text = "Трепетание сердца";
            entryLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(likeAccount2);
            panel1.Controls.Add(backButton3);
            panel1.Controls.Add(backButton2);
            panel1.Controls.Add(deleteButton);
            panel1.Controls.Add(likeAccount);
            panel1.Controls.Add(backButton);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(numberField);
            panel1.Controls.Add(mailField);
            panel1.Controls.Add(selField);
            panel1.Controls.Add(cityField);
            panel1.Controls.Add(birthdayField);
            panel1.Controls.Add(surnameField);
            panel1.Controls.Add(nameField);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(passwondLabel);
            panel1.Controls.Add(loginLabel);
            panel1.Controls.Add(Photo);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 91);
            panel1.Name = "panel1";
            panel1.Size = new Size(581, 372);
            panel1.TabIndex = 51;
            // 
            // likeAccount2
            // 
            likeAccount2.Enabled = false;
            likeAccount2.Image = (Image)resources.GetObject("likeAccount2.Image");
            likeAccount2.Location = new Point(513, 318);
            likeAccount2.Name = "likeAccount2";
            likeAccount2.Size = new Size(63, 54);
            likeAccount2.SizeMode = PictureBoxSizeMode.StretchImage;
            likeAccount2.TabIndex = 75;
            likeAccount2.TabStop = false;
            likeAccount2.Visible = false;
            likeAccount2.Click += likeAccount2_Click;
            // 
            // backButton3
            // 
            backButton3.BackColor = Color.Fuchsia;
            backButton3.BackgroundImageLayout = ImageLayout.None;
            backButton3.Enabled = false;
            backButton3.FlatAppearance.BorderSize = 0;
            backButton3.FlatAppearance.MouseDownBackColor = Color.FromArgb(212, 22, 207);
            backButton3.FlatAppearance.MouseOverBackColor = Color.FromArgb(249, 158, 246);
            backButton3.FlatStyle = FlatStyle.Flat;
            backButton3.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            backButton3.ForeColor = Color.White;
            backButton3.Location = new Point(3, 330);
            backButton3.Name = "backButton3";
            backButton3.Size = new Size(149, 39);
            backButton3.TabIndex = 74;
            backButton3.Text = "Назад";
            backButton3.UseVisualStyleBackColor = false;
            backButton3.Visible = false;
            backButton3.Click += backButton3_Click;
            // 
            // backButton2
            // 
            backButton2.BackColor = Color.Fuchsia;
            backButton2.BackgroundImageLayout = ImageLayout.None;
            backButton2.Enabled = false;
            backButton2.FlatAppearance.BorderSize = 0;
            backButton2.FlatAppearance.MouseDownBackColor = Color.FromArgb(212, 22, 207);
            backButton2.FlatAppearance.MouseOverBackColor = Color.FromArgb(249, 158, 246);
            backButton2.FlatStyle = FlatStyle.Flat;
            backButton2.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            backButton2.ForeColor = Color.White;
            backButton2.Location = new Point(3, 330);
            backButton2.Name = "backButton2";
            backButton2.Size = new Size(149, 39);
            backButton2.TabIndex = 73;
            backButton2.Text = "Назад";
            backButton2.UseVisualStyleBackColor = false;
            backButton2.Visible = false;
            backButton2.Click += backButton2_Click;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.Fuchsia;
            deleteButton.BackgroundImageLayout = ImageLayout.None;
            deleteButton.Enabled = false;
            deleteButton.FlatAppearance.BorderSize = 0;
            deleteButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(212, 22, 207);
            deleteButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(249, 158, 246);
            deleteButton.FlatStyle = FlatStyle.Flat;
            deleteButton.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            deleteButton.ForeColor = Color.White;
            deleteButton.Location = new Point(432, 333);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(149, 39);
            deleteButton.TabIndex = 72;
            deleteButton.Text = "Удалить";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Visible = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // likeAccount
            // 
            likeAccount.Enabled = false;
            likeAccount.Image = (Image)resources.GetObject("likeAccount.Image");
            likeAccount.Location = new Point(513, 318);
            likeAccount.Name = "likeAccount";
            likeAccount.Size = new Size(63, 54);
            likeAccount.SizeMode = PictureBoxSizeMode.StretchImage;
            likeAccount.TabIndex = 71;
            likeAccount.TabStop = false;
            likeAccount.Visible = false;
            likeAccount.Click += likeAccount_Click;
            // 
            // backButton
            // 
            backButton.BackColor = Color.Fuchsia;
            backButton.BackgroundImageLayout = ImageLayout.None;
            backButton.Enabled = false;
            backButton.FlatAppearance.BorderSize = 0;
            backButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(212, 22, 207);
            backButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(249, 158, 246);
            backButton.FlatStyle = FlatStyle.Flat;
            backButton.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            backButton.ForeColor = Color.White;
            backButton.Location = new Point(3, 330);
            backButton.Name = "backButton";
            backButton.Size = new Size(149, 39);
            backButton.TabIndex = 70;
            backButton.Text = "Назад";
            backButton.UseVisualStyleBackColor = false;
            backButton.Visible = false;
            backButton.Click += backButton_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label14.Location = new Point(157, 280);
            label14.Name = "label14";
            label14.Size = new Size(167, 24);
            label14.TabIndex = 69;
            label14.Text = "Номер телефона";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label13.Location = new Point(258, 241);
            label13.Name = "label13";
            label13.Size = new Size(68, 24);
            label13.TabIndex = 68;
            label13.Text = "Почта";
            // 
            // numberField
            // 
            numberField.BackColor = Color.FromArgb(255, 230, 255);
            numberField.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            numberField.ForeColor = Color.Black;
            numberField.Location = new Point(343, 280);
            numberField.Name = "numberField";
            numberField.Size = new Size(235, 24);
            numberField.TabIndex = 67;
            // 
            // mailField
            // 
            mailField.BackColor = Color.FromArgb(255, 230, 255);
            mailField.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            mailField.ForeColor = Color.Black;
            mailField.Location = new Point(343, 242);
            mailField.Name = "mailField";
            mailField.Size = new Size(235, 24);
            mailField.TabIndex = 66;
            // 
            // selField
            // 
            selField.BackColor = Color.FromArgb(255, 230, 255);
            selField.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            selField.ForeColor = Color.Black;
            selField.Location = new Point(343, 206);
            selField.Name = "selField";
            selField.Size = new Size(235, 24);
            selField.TabIndex = 65;
            // 
            // cityField
            // 
            cityField.BackColor = Color.FromArgb(255, 230, 255);
            cityField.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cityField.ForeColor = Color.Black;
            cityField.Location = new Point(343, 170);
            cityField.Name = "cityField";
            cityField.Size = new Size(235, 24);
            cityField.TabIndex = 64;
            // 
            // birthdayField
            // 
            birthdayField.BackColor = Color.FromArgb(255, 230, 255);
            birthdayField.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            birthdayField.ForeColor = Color.Black;
            birthdayField.Location = new Point(343, 134);
            birthdayField.Name = "birthdayField";
            birthdayField.Size = new Size(235, 24);
            birthdayField.TabIndex = 63;
            // 
            // surnameField
            // 
            surnameField.BackColor = Color.FromArgb(255, 230, 255);
            surnameField.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            surnameField.ForeColor = Color.Black;
            surnameField.Location = new Point(343, 99);
            surnameField.Name = "surnameField";
            surnameField.Size = new Size(235, 24);
            surnameField.TabIndex = 62;
            // 
            // nameField
            // 
            nameField.BackColor = Color.FromArgb(255, 230, 255);
            nameField.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            nameField.ForeColor = Color.Black;
            nameField.Location = new Point(343, 64);
            nameField.Name = "nameField";
            nameField.Size = new Size(235, 24);
            nameField.TabIndex = 61;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(275, 205);
            label3.Name = "label3";
            label3.Size = new Size(49, 24);
            label3.TabIndex = 60;
            label3.Text = "Пол";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(260, 169);
            label4.Name = "label4";
            label4.Size = new Size(64, 24);
            label4.TabIndex = 59;
            label4.Text = "Город";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.Location = new Point(275, 64);
            label5.Name = "label5";
            label5.Size = new Size(51, 24);
            label5.TabIndex = 58;
            label5.Text = "Имя";
            // 
            // passwondLabel
            // 
            passwondLabel.AutoSize = true;
            passwondLabel.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            passwondLabel.Location = new Point(175, 134);
            passwondLabel.Name = "passwondLabel";
            passwondLabel.Size = new Size(151, 24);
            passwondLabel.TabIndex = 57;
            passwondLabel.Text = "Дата рождения";
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            loginLabel.Location = new Point(225, 99);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(101, 24);
            loginLabel.TabIndex = 56;
            loginLabel.Text = "Фамилия";
            // 
            // Photo
            // 
            Photo.Image = (Image)resources.GetObject("Photo.Image");
            Photo.Location = new Point(14, 68);
            Photo.Name = "Photo";
            Photo.Size = new Size(155, 149);
            Photo.SizeMode = PictureBoxSizeMode.StretchImage;
            Photo.TabIndex = 55;
            Photo.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(175, 0);
            label1.Name = "label1";
            label1.Size = new Size(198, 64);
            label1.TabIndex = 54;
            label1.Text = "Профиль";
            // 
            // UserProfileForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(581, 463);
            Controls.Add(panel1);
            Controls.Add(girlPhoto);
            Controls.Add(boyPhoto);
            Controls.Add(CollapseButton);
            Controls.Add(CloseButton);
            Controls.Add(entryLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserProfileForm";
            Text = "UserProfileForm";
            Load += UserProfileForm_Load;
            ((System.ComponentModel.ISupportInitialize)girlPhoto).EndInit();
            ((System.ComponentModel.ISupportInitialize)boyPhoto).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)likeAccount2).EndInit();
            ((System.ComponentModel.ISupportInitialize)likeAccount).EndInit();
            ((System.ComponentModel.ISupportInitialize)Photo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox girlPhoto;
        private PictureBox boyPhoto;
        private Button CollapseButton;
        private Button CloseButton;
        private Label entryLabel;
        private Panel panel1;
        private Label label14;
        private Label label13;
        private Label numberField;
        private Label mailField;
        private Label selField;
        private Label cityField;
        private Label birthdayField;
        private Label surnameField;
        private Label label6;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label passwondLabel;
        private Label loginLabel;
        private PictureBox Photo;
        private Label label1;
        public PictureBox likeAccount;
        private Label nameField;
        private PictureBox pictureBox1;
        public Button deleteButton;
        public Button backButton;
        public Button backButton2;
        public PictureBox likeAccount2;
        public Button backButton3;
    }
}