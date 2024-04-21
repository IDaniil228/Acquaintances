namespace HeartFluttering
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            girlPhoto = new PictureBox();
            boyPhoto = new PictureBox();
            CollapseButton = new Button();
            CloseButton = new Button();
            entryLabel = new Label();
            label2 = new Label();
            favoritesButton = new Button();
            recommendButton = new Button();
            searchButton = new Button();
            button4 = new Button();
            closeAccount = new Button();
            panel1 = new Panel();
            redactionPhotoButton = new Button();
            photoField = new PictureBox();
            redactionButton = new Button();
            numberLabel = new Label();
            emailLabel = new Label();
            numberField = new Label();
            emailField = new Label();
            sexField = new Label();
            cityField = new Label();
            BirhdayField = new Label();
            surnameField = new Label();
            nameField = new Label();
            sexLabel = new Label();
            cityLabel = new Label();
            nameLabel = new Label();
            BirhdayButton = new Label();
            surnameLabel = new Label();
            comboBox1 = new ComboBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)girlPhoto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)boyPhoto).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)photoField).BeginInit();
            SuspendLayout();
            // 
            // girlPhoto
            // 
            girlPhoto.BackColor = Color.Fuchsia;
            girlPhoto.Image = (Image)resources.GetObject("girlPhoto.Image");
            girlPhoto.Location = new Point(648, 18);
            girlPhoto.Name = "girlPhoto";
            girlPhoto.Size = new Size(76, 69);
            girlPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            girlPhoto.TabIndex = 40;
            girlPhoto.TabStop = false;
            // 
            // boyPhoto
            // 
            boyPhoto.BackColor = Color.Fuchsia;
            boyPhoto.Image = (Image)resources.GetObject("boyPhoto.Image");
            boyPhoto.Location = new Point(72, 19);
            boyPhoto.Name = "boyPhoto";
            boyPhoto.Size = new Size(75, 69);
            boyPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            boyPhoto.TabIndex = 39;
            boyPhoto.TabStop = false;
            // 
            // CollapseButton
            // 
            CollapseButton.Anchor = AnchorStyles.Bottom;
            CollapseButton.BackColor = Color.Fuchsia;
            CollapseButton.FlatAppearance.BorderSize = 0;
            CollapseButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            CollapseButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            CollapseButton.FlatStyle = FlatStyle.Flat;
            CollapseButton.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            CollapseButton.ForeColor = Color.White;
            CollapseButton.Location = new Point(730, 0);
            CollapseButton.Name = "CollapseButton";
            CollapseButton.Size = new Size(35, 23);
            CollapseButton.TabIndex = 38;
            CollapseButton.Text = "—";
            CollapseButton.UseVisualStyleBackColor = false;
            CollapseButton.Click += CollapseButton_Click;
            // 
            // CloseButton
            // 
            CloseButton.BackColor = Color.Fuchsia;
            CloseButton.FlatAppearance.BorderSize = 0;
            CloseButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            CloseButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            CloseButton.FlatStyle = FlatStyle.Flat;
            CloseButton.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            CloseButton.ForeColor = Color.White;
            CloseButton.Location = new Point(761, 0);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(35, 23);
            CloseButton.TabIndex = 37;
            CloseButton.Text = "X";
            CloseButton.UseVisualStyleBackColor = false;
            CloseButton.Click += CloseButton_Click;
            // 
            // entryLabel
            // 
            entryLabel.BackColor = Color.Magenta;
            entryLabel.Dock = DockStyle.Top;
            entryLabel.Font = new Font("Segoe Print", 36F, FontStyle.Regular, GraphicsUnit.Point, 204);
            entryLabel.ForeColor = SystemColors.ButtonHighlight;
            entryLabel.Location = new Point(0, 0);
            entryLabel.Name = "entryLabel";
            entryLabel.Size = new Size(796, 90);
            entryLabel.TabIndex = 36;
            entryLabel.Text = "Трепетание сердца";
            entryLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = Color.Fuchsia;
            label2.Location = new Point(209, 88);
            label2.Name = "label2";
            label2.Size = new Size(10, 363);
            label2.TabIndex = 41;
            // 
            // favoritesButton
            // 
            favoritesButton.BackColor = Color.Fuchsia;
            favoritesButton.BackgroundImageLayout = ImageLayout.None;
            favoritesButton.FlatAppearance.BorderSize = 0;
            favoritesButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            favoritesButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            favoritesButton.FlatStyle = FlatStyle.Flat;
            favoritesButton.Font = new Font("Segoe Print", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            favoritesButton.ForeColor = Color.White;
            favoritesButton.Location = new Point(7, 120);
            favoritesButton.Name = "favoritesButton";
            favoritesButton.Size = new Size(196, 43);
            favoritesButton.TabIndex = 42;
            favoritesButton.Text = "Избранное";
            favoritesButton.UseVisualStyleBackColor = false;
            favoritesButton.Click += favoritesButton_Click;
            // 
            // recommendButton
            // 
            recommendButton.BackColor = Color.Fuchsia;
            recommendButton.BackgroundImageLayout = ImageLayout.None;
            recommendButton.FlatAppearance.BorderSize = 0;
            recommendButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            recommendButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            recommendButton.FlatStyle = FlatStyle.Flat;
            recommendButton.Font = new Font("Segoe Print", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            recommendButton.ForeColor = Color.White;
            recommendButton.Location = new Point(7, 183);
            recommendButton.Name = "recommendButton";
            recommendButton.Size = new Size(196, 43);
            recommendButton.TabIndex = 43;
            recommendButton.Text = "Рекомендации";
            recommendButton.UseVisualStyleBackColor = false;
            recommendButton.Click += recommendButton_Click;
            // 
            // searchButton
            // 
            searchButton.BackColor = Color.Fuchsia;
            searchButton.BackgroundImageLayout = ImageLayout.None;
            searchButton.FlatAppearance.BorderSize = 0;
            searchButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            searchButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            searchButton.FlatStyle = FlatStyle.Flat;
            searchButton.Font = new Font("Segoe Print", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            searchButton.ForeColor = Color.White;
            searchButton.Location = new Point(7, 243);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(196, 43);
            searchButton.TabIndex = 44;
            searchButton.Text = "Поиск пары";
            searchButton.UseVisualStyleBackColor = false;
            searchButton.Click += searchButton_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Fuchsia;
            button4.BackgroundImageLayout = ImageLayout.None;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button4.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe Print", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button4.ForeColor = Color.White;
            button4.Location = new Point(7, 304);
            button4.Name = "button4";
            button4.Size = new Size(196, 43);
            button4.TabIndex = 45;
            button4.Text = "Уведомления";
            button4.UseVisualStyleBackColor = false;
            // 
            // closeAccount
            // 
            closeAccount.BackColor = Color.Fuchsia;
            closeAccount.BackgroundImageLayout = ImageLayout.None;
            closeAccount.FlatAppearance.BorderSize = 0;
            closeAccount.FlatAppearance.MouseDownBackColor = Color.Transparent;
            closeAccount.FlatAppearance.MouseOverBackColor = Color.Transparent;
            closeAccount.FlatStyle = FlatStyle.Flat;
            closeAccount.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            closeAccount.ForeColor = Color.White;
            closeAccount.Location = new Point(55, 421);
            closeAccount.Name = "closeAccount";
            closeAccount.Size = new Size(98, 30);
            closeAccount.TabIndex = 46;
            closeAccount.Text = "Выход";
            closeAccount.UseVisualStyleBackColor = false;
            closeAccount.Click += closeAccount_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(redactionPhotoButton);
            panel1.Controls.Add(photoField);
            panel1.Controls.Add(redactionButton);
            panel1.Controls.Add(numberLabel);
            panel1.Controls.Add(emailLabel);
            panel1.Controls.Add(numberField);
            panel1.Controls.Add(emailField);
            panel1.Controls.Add(sexField);
            panel1.Controls.Add(cityField);
            panel1.Controls.Add(BirhdayField);
            panel1.Controls.Add(surnameField);
            panel1.Controls.Add(nameField);
            panel1.Controls.Add(sexLabel);
            panel1.Controls.Add(cityLabel);
            panel1.Controls.Add(nameLabel);
            panel1.Controls.Add(BirhdayButton);
            panel1.Controls.Add(surnameLabel);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(219, 88);
            panel1.Name = "panel1";
            panel1.Size = new Size(577, 363);
            panel1.TabIndex = 47;
            // 
            // redactionPhotoButton
            // 
            redactionPhotoButton.BackColor = Color.Fuchsia;
            redactionPhotoButton.BackgroundImageLayout = ImageLayout.None;
            redactionPhotoButton.FlatAppearance.BorderSize = 0;
            redactionPhotoButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            redactionPhotoButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            redactionPhotoButton.FlatStyle = FlatStyle.Flat;
            redactionPhotoButton.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            redactionPhotoButton.ForeColor = Color.White;
            redactionPhotoButton.Location = new Point(6, 224);
            redactionPhotoButton.Name = "redactionPhotoButton";
            redactionPhotoButton.Size = new Size(155, 30);
            redactionPhotoButton.TabIndex = 73;
            redactionPhotoButton.Text = "Изменить";
            redactionPhotoButton.UseVisualStyleBackColor = false;
            redactionPhotoButton.Click += redactionPhotoButton_Click;
            // 
            // photoField
            // 
            photoField.Image = (Image)resources.GetObject("photoField.Image");
            photoField.Location = new Point(6, 69);
            photoField.Name = "photoField";
            photoField.Size = new Size(155, 149);
            photoField.SizeMode = PictureBoxSizeMode.StretchImage;
            photoField.TabIndex = 72;
            photoField.TabStop = false;
            // 
            // redactionButton
            // 
            redactionButton.BackColor = Color.Fuchsia;
            redactionButton.BackgroundImageLayout = ImageLayout.None;
            redactionButton.FlatAppearance.BorderSize = 0;
            redactionButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            redactionButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            redactionButton.FlatStyle = FlatStyle.Flat;
            redactionButton.Font = new Font("Segoe Print", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            redactionButton.ForeColor = Color.White;
            redactionButton.Location = new Point(383, 322);
            redactionButton.Name = "redactionButton";
            redactionButton.Size = new Size(191, 38);
            redactionButton.TabIndex = 71;
            redactionButton.Text = "Редактировать";
            redactionButton.UseVisualStyleBackColor = false;
            redactionButton.Click += redactionButton_Click;
            // 
            // numberLabel
            // 
            numberLabel.AutoSize = true;
            numberLabel.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            numberLabel.Location = new Point(144, 276);
            numberLabel.Name = "numberLabel";
            numberLabel.Size = new Size(167, 24);
            numberLabel.TabIndex = 70;
            numberLabel.Text = "Номер телефона";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            emailLabel.Location = new Point(245, 237);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(68, 24);
            emailLabel.TabIndex = 69;
            emailLabel.Text = "Почта";
            // 
            // numberField
            // 
            numberField.BackColor = Color.FromArgb(255, 230, 255);
            numberField.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            numberField.ForeColor = Color.Black;
            numberField.Location = new Point(330, 276);
            numberField.Name = "numberField";
            numberField.Size = new Size(235, 24);
            numberField.TabIndex = 68;
            // 
            // emailField
            // 
            emailField.BackColor = Color.FromArgb(255, 230, 255);
            emailField.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            emailField.ForeColor = Color.Black;
            emailField.Location = new Point(330, 238);
            emailField.Name = "emailField";
            emailField.Size = new Size(235, 24);
            emailField.TabIndex = 67;
            // 
            // sexField
            // 
            sexField.BackColor = Color.FromArgb(255, 230, 255);
            sexField.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            sexField.ForeColor = Color.Black;
            sexField.Location = new Point(330, 202);
            sexField.Name = "sexField";
            sexField.Size = new Size(235, 24);
            sexField.TabIndex = 66;
            // 
            // cityField
            // 
            cityField.BackColor = Color.FromArgb(255, 230, 255);
            cityField.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cityField.ForeColor = Color.Black;
            cityField.Location = new Point(330, 166);
            cityField.Name = "cityField";
            cityField.Size = new Size(235, 24);
            cityField.TabIndex = 65;
            // 
            // BirhdayField
            // 
            BirhdayField.BackColor = Color.FromArgb(255, 230, 255);
            BirhdayField.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            BirhdayField.ForeColor = Color.Black;
            BirhdayField.Location = new Point(330, 130);
            BirhdayField.Name = "BirhdayField";
            BirhdayField.Size = new Size(235, 24);
            BirhdayField.TabIndex = 64;
            // 
            // surnameField
            // 
            surnameField.BackColor = Color.FromArgb(255, 230, 255);
            surnameField.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            surnameField.ForeColor = Color.Black;
            surnameField.Location = new Point(330, 95);
            surnameField.Name = "surnameField";
            surnameField.Size = new Size(235, 24);
            surnameField.TabIndex = 63;
            // 
            // nameField
            // 
            nameField.BackColor = Color.FromArgb(255, 230, 255);
            nameField.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            nameField.ForeColor = Color.Black;
            nameField.Location = new Point(330, 60);
            nameField.Name = "nameField";
            nameField.Size = new Size(235, 24);
            nameField.TabIndex = 62;
            // 
            // sexLabel
            // 
            sexLabel.AutoSize = true;
            sexLabel.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            sexLabel.Location = new Point(262, 201);
            sexLabel.Name = "sexLabel";
            sexLabel.Size = new Size(49, 24);
            sexLabel.TabIndex = 61;
            sexLabel.Text = "Пол";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            cityLabel.Location = new Point(247, 165);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new Size(64, 24);
            cityLabel.TabIndex = 60;
            cityLabel.Text = "Город";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            nameLabel.Location = new Point(262, 60);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(51, 24);
            nameLabel.TabIndex = 59;
            nameLabel.Text = "Имя";
            // 
            // BirhdayButton
            // 
            BirhdayButton.AutoSize = true;
            BirhdayButton.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            BirhdayButton.Location = new Point(162, 130);
            BirhdayButton.Name = "BirhdayButton";
            BirhdayButton.Size = new Size(151, 24);
            BirhdayButton.TabIndex = 58;
            BirhdayButton.Text = "Дата рождения";
            // 
            // surnameLabel
            // 
            surnameLabel.AutoSize = true;
            surnameLabel.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            surnameLabel.Location = new Point(212, 95);
            surnameLabel.Name = "surnameLabel";
            surnameLabel.Size = new Size(101, 24);
            surnameLabel.TabIndex = 57;
            surnameLabel.Text = "Фамилия";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(453, 5);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(124, 23);
            comboBox1.TabIndex = 56;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(142, 2);
            label1.Name = "label1";
            label1.Size = new Size(291, 64);
            label1.TabIndex = 1;
            label1.Text = "Мой профиль";
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(796, 451);
            Controls.Add(panel1);
            Controls.Add(closeAccount);
            Controls.Add(button4);
            Controls.Add(searchButton);
            Controls.Add(recommendButton);
            Controls.Add(favoritesButton);
            Controls.Add(label2);
            Controls.Add(girlPhoto);
            Controls.Add(boyPhoto);
            Controls.Add(CollapseButton);
            Controls.Add(CloseButton);
            Controls.Add(entryLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "HomeForm";
            Text = "HomeForm";
            Load += HomeForm_Load;
            ((System.ComponentModel.ISupportInitialize)girlPhoto).EndInit();
            ((System.ComponentModel.ISupportInitialize)boyPhoto).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)photoField).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox girlPhoto;
        private PictureBox boyPhoto;
        private Button CollapseButton;
        private Button CloseButton;
        private Label entryLabel;
        private Label label2;
        private Button favoritesButton;
        private Button recommendButton;
        private Button searchButton;
        private Button button4;
        private Button closeAccount;
        private Panel panel1;
        private Label numberLabel;
        private Label emailLabel;
        public Label numberField;
        public Label emailField;
        public Label sexField;
        public Label cityField;
        public Label BirhdayField;
        public Label surnameField;
        public Label nameField;
        private Label sexLabel;
        private Label cityLabel;
        private Label nameLabel;
        private Label BirhdayButton;
        private Label surnameLabel;
        private ComboBox comboBox1;
        private Label label1;
        private Button redactionPhotoButton;
        private Button redactionButton;
        public PictureBox photoField;
    }
}