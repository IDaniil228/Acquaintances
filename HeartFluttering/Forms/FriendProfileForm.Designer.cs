namespace HeartFluttering.Forms
{
    partial class FriendProfileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FriendProfileForm));
            likeAccount2 = new PictureBox();
            BtnAdd = new Button();
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
            BtnSize = new Button();
            girlPhoto = new PictureBox();
            boyPhoto = new PictureBox();
            CollapseButton = new Button();
            CloseButton = new Button();
            entryLabel = new Label();
            BtnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)likeAccount2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)likeAccount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Photo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)girlPhoto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)boyPhoto).BeginInit();
            SuspendLayout();
            // 
            // likeAccount2
            // 
            likeAccount2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            likeAccount2.Enabled = false;
            likeAccount2.Image = (Image)resources.GetObject("likeAccount2.Image");
            likeAccount2.ImeMode = ImeMode.NoControl;
            likeAccount2.Location = new Point(694, 468);
            likeAccount2.Margin = new Padding(3, 4, 3, 4);
            likeAccount2.Name = "likeAccount2";
            likeAccount2.Size = new Size(72, 72);
            likeAccount2.SizeMode = PictureBoxSizeMode.StretchImage;
            likeAccount2.TabIndex = 96;
            likeAccount2.TabStop = false;
            likeAccount2.Visible = false;
            // 
            // BtnAdd
            // 
            BtnAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnAdd.BackColor = Color.Fuchsia;
            BtnAdd.BackgroundImageLayout = ImageLayout.None;
            BtnAdd.Enabled = false;
            BtnAdd.FlatAppearance.BorderSize = 0;
            BtnAdd.FlatAppearance.MouseDownBackColor = Color.FromArgb(212, 22, 207);
            BtnAdd.FlatAppearance.MouseOverBackColor = Color.FromArgb(249, 158, 246);
            BtnAdd.FlatStyle = FlatStyle.Flat;
            BtnAdd.Font = new Font("Segoe Print", 12F);
            BtnAdd.ForeColor = Color.White;
            BtnAdd.ImeMode = ImeMode.NoControl;
            BtnAdd.Location = new Point(508, 565);
            BtnAdd.Margin = new Padding(3, 4, 3, 4);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(154, 52);
            BtnAdd.TabIndex = 93;
            BtnAdd.Text = "Добавить";
            BtnAdd.UseVisualStyleBackColor = false;
            BtnAdd.Visible = false;
            BtnAdd.Click += BtnAdd_Click;
            // 
            // likeAccount
            // 
            likeAccount.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            likeAccount.Enabled = false;
            likeAccount.Image = (Image)resources.GetObject("likeAccount.Image");
            likeAccount.ImeMode = ImeMode.NoControl;
            likeAccount.Location = new Point(694, 468);
            likeAccount.Margin = new Padding(3, 4, 3, 4);
            likeAccount.Name = "likeAccount";
            likeAccount.Size = new Size(72, 72);
            likeAccount.SizeMode = PictureBoxSizeMode.StretchImage;
            likeAccount.TabIndex = 92;
            likeAccount.TabStop = false;
            likeAccount.Visible = false;
            // 
            // backButton
            // 
            backButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            backButton.BackColor = Color.Fuchsia;
            backButton.BackgroundImageLayout = ImageLayout.None;
            backButton.FlatAppearance.BorderSize = 0;
            backButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(212, 22, 207);
            backButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(249, 158, 246);
            backButton.FlatStyle = FlatStyle.Flat;
            backButton.Font = new Font("Segoe Print", 12F);
            backButton.ForeColor = Color.White;
            backButton.ImeMode = ImeMode.NoControl;
            backButton.Location = new Point(0, 565);
            backButton.Margin = new Padding(3, 4, 3, 4);
            backButton.Name = "backButton";
            backButton.Size = new Size(170, 52);
            backButton.TabIndex = 91;
            backButton.Text = "Назад";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label14.AutoSize = true;
            label14.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold);
            label14.ImeMode = ImeMode.NoControl;
            label14.Location = new Point(179, 485);
            label14.Name = "label14";
            label14.Size = new Size(213, 31);
            label14.TabIndex = 90;
            label14.Text = "Номер телефона";
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label13.AutoSize = true;
            label13.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold);
            label13.ImeMode = ImeMode.NoControl;
            label13.Location = new Point(295, 433);
            label13.Name = "label13";
            label13.Size = new Size(89, 31);
            label13.TabIndex = 89;
            label13.Text = "Почта";
            // 
            // numberField
            // 
            numberField.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            numberField.BackColor = Color.FromArgb(255, 230, 255);
            numberField.Font = new Font("Times New Roman", 15.75F);
            numberField.ForeColor = Color.Black;
            numberField.ImeMode = ImeMode.NoControl;
            numberField.Location = new Point(396, 484);
            numberField.Name = "numberField";
            numberField.Size = new Size(256, 32);
            numberField.TabIndex = 88;
            // 
            // mailField
            // 
            mailField.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            mailField.BackColor = Color.FromArgb(255, 230, 255);
            mailField.Font = new Font("Times New Roman", 15.75F);
            mailField.ForeColor = Color.Black;
            mailField.ImeMode = ImeMode.NoControl;
            mailField.Location = new Point(396, 434);
            mailField.Name = "mailField";
            mailField.Size = new Size(256, 32);
            mailField.TabIndex = 87;
            // 
            // selField
            // 
            selField.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            selField.BackColor = Color.FromArgb(255, 230, 255);
            selField.Font = new Font("Times New Roman", 15.75F);
            selField.ForeColor = Color.Black;
            selField.ImeMode = ImeMode.NoControl;
            selField.Location = new Point(396, 386);
            selField.Name = "selField";
            selField.Size = new Size(256, 32);
            selField.TabIndex = 86;
            // 
            // cityField
            // 
            cityField.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cityField.BackColor = Color.FromArgb(255, 230, 255);
            cityField.Font = new Font("Times New Roman", 15.75F);
            cityField.ForeColor = Color.Black;
            cityField.ImeMode = ImeMode.NoControl;
            cityField.Location = new Point(396, 338);
            cityField.Name = "cityField";
            cityField.Size = new Size(256, 32);
            cityField.TabIndex = 85;
            // 
            // birthdayField
            // 
            birthdayField.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            birthdayField.BackColor = Color.FromArgb(255, 230, 255);
            birthdayField.Font = new Font("Times New Roman", 15.75F);
            birthdayField.ForeColor = Color.Black;
            birthdayField.ImeMode = ImeMode.NoControl;
            birthdayField.Location = new Point(396, 290);
            birthdayField.Name = "birthdayField";
            birthdayField.Size = new Size(256, 32);
            birthdayField.TabIndex = 84;
            // 
            // surnameField
            // 
            surnameField.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            surnameField.BackColor = Color.FromArgb(255, 230, 255);
            surnameField.Font = new Font("Times New Roman", 15.75F);
            surnameField.ForeColor = Color.Black;
            surnameField.ImeMode = ImeMode.NoControl;
            surnameField.Location = new Point(396, 243);
            surnameField.Name = "surnameField";
            surnameField.Size = new Size(256, 32);
            surnameField.TabIndex = 83;
            // 
            // nameField
            // 
            nameField.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nameField.BackColor = Color.FromArgb(255, 230, 255);
            nameField.Font = new Font("Times New Roman", 15.75F);
            nameField.ForeColor = Color.Black;
            nameField.ImeMode = ImeMode.NoControl;
            nameField.Location = new Point(396, 196);
            nameField.Name = "nameField";
            nameField.Size = new Size(256, 32);
            nameField.TabIndex = 82;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold);
            label3.ImeMode = ImeMode.NoControl;
            label3.Location = new Point(314, 385);
            label3.Name = "label3";
            label3.Size = new Size(64, 31);
            label3.TabIndex = 81;
            label3.Text = "Пол";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold);
            label4.ImeMode = ImeMode.NoControl;
            label4.Location = new Point(297, 337);
            label4.Name = "label4";
            label4.Size = new Size(85, 31);
            label4.TabIndex = 80;
            label4.Text = "Город";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold);
            label5.ImeMode = ImeMode.NoControl;
            label5.Location = new Point(314, 197);
            label5.Name = "label5";
            label5.Size = new Size(68, 31);
            label5.TabIndex = 79;
            label5.Text = "Имя";
            // 
            // passwondLabel
            // 
            passwondLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            passwondLabel.AutoSize = true;
            passwondLabel.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold);
            passwondLabel.ImeMode = ImeMode.NoControl;
            passwondLabel.Location = new Point(200, 291);
            passwondLabel.Name = "passwondLabel";
            passwondLabel.Size = new Size(200, 31);
            passwondLabel.TabIndex = 78;
            passwondLabel.Text = "Дата рождения";
            // 
            // loginLabel
            // 
            loginLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            loginLabel.AutoSize = true;
            loginLabel.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold);
            loginLabel.ImeMode = ImeMode.NoControl;
            loginLabel.Location = new Point(257, 244);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(132, 31);
            loginLabel.TabIndex = 77;
            loginLabel.Text = "Фамилия";
            // 
            // Photo
            // 
            Photo.Image = (Image)resources.GetObject("Photo.Image");
            Photo.ImeMode = ImeMode.NoControl;
            Photo.Location = new Point(12, 200);
            Photo.Margin = new Padding(3, 4, 3, 4);
            Photo.Name = "Photo";
            Photo.Size = new Size(177, 199);
            Photo.SizeMode = PictureBoxSizeMode.StretchImage;
            Photo.TabIndex = 76;
            Photo.TabStop = false;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe Print", 27.75F);
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(0, 117);
            label1.Name = "label1";
            label1.Size = new Size(664, 79);
            label1.TabIndex = 97;
            label1.Text = "Профиль";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BtnSize
            // 
            BtnSize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSize.BackColor = Color.Fuchsia;
            BtnSize.FlatAppearance.BorderSize = 0;
            BtnSize.FlatAppearance.MouseDownBackColor = Color.FromArgb(212, 22, 207);
            BtnSize.FlatAppearance.MouseOverBackColor = Color.FromArgb(249, 158, 246);
            BtnSize.FlatStyle = FlatStyle.Flat;
            BtnSize.Font = new Font("Segoe UI", 12F);
            BtnSize.ForeColor = Color.White;
            BtnSize.ImeMode = ImeMode.NoControl;
            BtnSize.Location = new Point(600, -3);
            BtnSize.Name = "BtnSize";
            BtnSize.Size = new Size(34, 35);
            BtnSize.TabIndex = 103;
            BtnSize.Text = "▭";
            BtnSize.UseVisualStyleBackColor = false;
            // 
            // girlPhoto
            // 
            girlPhoto.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            girlPhoto.BackColor = Color.Fuchsia;
            girlPhoto.Image = (Image)resources.GetObject("girlPhoto.Image");
            girlPhoto.ImeMode = ImeMode.NoControl;
            girlPhoto.Location = new Point(580, 40);
            girlPhoto.Margin = new Padding(3, 4, 3, 4);
            girlPhoto.Name = "girlPhoto";
            girlPhoto.Size = new Size(72, 77);
            girlPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            girlPhoto.TabIndex = 102;
            girlPhoto.TabStop = false;
            // 
            // boyPhoto
            // 
            boyPhoto.BackColor = Color.Fuchsia;
            boyPhoto.Image = (Image)resources.GetObject("boyPhoto.Image");
            boyPhoto.ImeMode = ImeMode.NoControl;
            boyPhoto.Location = new Point(12, 40);
            boyPhoto.Margin = new Padding(3, 4, 3, 4);
            boyPhoto.Name = "boyPhoto";
            boyPhoto.Size = new Size(72, 77);
            boyPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            boyPhoto.TabIndex = 101;
            boyPhoto.TabStop = false;
            // 
            // CollapseButton
            // 
            CollapseButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CollapseButton.BackColor = Color.Fuchsia;
            CollapseButton.FlatAppearance.BorderSize = 0;
            CollapseButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(212, 22, 207);
            CollapseButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(249, 158, 246);
            CollapseButton.FlatStyle = FlatStyle.Flat;
            CollapseButton.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            CollapseButton.ForeColor = Color.White;
            CollapseButton.ImeMode = ImeMode.NoControl;
            CollapseButton.Location = new Point(563, 1);
            CollapseButton.Margin = new Padding(3, 4, 3, 4);
            CollapseButton.Name = "CollapseButton";
            CollapseButton.Size = new Size(40, 31);
            CollapseButton.TabIndex = 100;
            CollapseButton.Text = "—";
            CollapseButton.UseVisualStyleBackColor = false;
            CollapseButton.Click += CollapseButton_Click;
            // 
            // CloseButton
            // 
            CloseButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CloseButton.BackColor = Color.Fuchsia;
            CloseButton.FlatAppearance.BorderSize = 0;
            CloseButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(212, 22, 207);
            CloseButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(249, 158, 246);
            CloseButton.FlatStyle = FlatStyle.Flat;
            CloseButton.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            CloseButton.ForeColor = Color.White;
            CloseButton.ImeMode = ImeMode.NoControl;
            CloseButton.Location = new Point(622, 1);
            CloseButton.Margin = new Padding(3, 4, 3, 4);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(40, 31);
            CloseButton.TabIndex = 99;
            CloseButton.Text = "X";
            CloseButton.UseVisualStyleBackColor = false;
            CloseButton.Click += CloseButton_Click;
            // 
            // entryLabel
            // 
            entryLabel.BackColor = Color.Magenta;
            entryLabel.Dock = DockStyle.Top;
            entryLabel.Font = new Font("Segoe Print", 27.75F);
            entryLabel.ForeColor = SystemColors.ButtonHighlight;
            entryLabel.ImeMode = ImeMode.NoControl;
            entryLabel.Location = new Point(0, 0);
            entryLabel.Name = "entryLabel";
            entryLabel.Size = new Size(664, 117);
            entryLabel.TabIndex = 98;
            entryLabel.Text = "Трепетание сердца";
            entryLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BtnDelete
            // 
            BtnDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnDelete.BackColor = Color.Fuchsia;
            BtnDelete.BackgroundImageLayout = ImageLayout.None;
            BtnDelete.Enabled = false;
            BtnDelete.FlatAppearance.BorderSize = 0;
            BtnDelete.FlatAppearance.MouseDownBackColor = Color.FromArgb(212, 22, 207);
            BtnDelete.FlatAppearance.MouseOverBackColor = Color.FromArgb(249, 158, 246);
            BtnDelete.FlatStyle = FlatStyle.Flat;
            BtnDelete.Font = new Font("Segoe Print", 12F);
            BtnDelete.ForeColor = Color.White;
            BtnDelete.ImeMode = ImeMode.NoControl;
            BtnDelete.Location = new Point(510, 565);
            BtnDelete.Margin = new Padding(3, 4, 3, 4);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(154, 52);
            BtnDelete.TabIndex = 104;
            BtnDelete.Text = "Удалить";
            BtnDelete.UseVisualStyleBackColor = false;
            BtnDelete.Visible = false;
            BtnDelete.Click += BtnDelete_Click;
            // 
            // FriendProfileForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(664, 617);
            Controls.Add(BtnDelete);
            Controls.Add(BtnSize);
            Controls.Add(girlPhoto);
            Controls.Add(boyPhoto);
            Controls.Add(CollapseButton);
            Controls.Add(CloseButton);
            Controls.Add(entryLabel);
            Controls.Add(label1);
            Controls.Add(likeAccount2);
            Controls.Add(BtnAdd);
            Controls.Add(likeAccount);
            Controls.Add(backButton);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(numberField);
            Controls.Add(mailField);
            Controls.Add(selField);
            Controls.Add(cityField);
            Controls.Add(birthdayField);
            Controls.Add(surnameField);
            Controls.Add(nameField);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(passwondLabel);
            Controls.Add(loginLabel);
            Controls.Add(Photo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FriendProfileForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += FriendProfileForm_Load;
            ((System.ComponentModel.ISupportInitialize)likeAccount2).EndInit();
            ((System.ComponentModel.ISupportInitialize)likeAccount).EndInit();
            ((System.ComponentModel.ISupportInitialize)Photo).EndInit();
            ((System.ComponentModel.ISupportInitialize)girlPhoto).EndInit();
            ((System.ComponentModel.ISupportInitialize)boyPhoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public PictureBox likeAccount2;
        public Button BtnAdd;
        public PictureBox likeAccount;
        public Button backButton;
        private Label label14;
        private Label label13;
        private Label numberField;
        private Label mailField;
        private Label selField;
        private Label cityField;
        private Label birthdayField;
        private Label surnameField;
        private Label nameField;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label passwondLabel;
        private Label loginLabel;
        private PictureBox Photo;
        private Label label1;
        private Button BtnSize;
        private PictureBox girlPhoto;
        private PictureBox boyPhoto;
        private Button CollapseButton;
        private Button CloseButton;
        private Label entryLabel;
        public Button BtnDelete;
    }
}