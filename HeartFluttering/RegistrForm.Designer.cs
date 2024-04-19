namespace HeartFluttering
{
    partial class RegistrForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrForm));
            girlPhoto = new PictureBox();
            boyPhoto = new PictureBox();
            CollapseButton = new Button();
            CloseButton = new Button();
            entryLabel = new Label();
            loginLabel = new Label();
            LoginField = new TextBox();
            passwordLabel2 = new Label();
            password2Field = new TextBox();
            passwordLabel = new Label();
            passwordField = new TextBox();
            loginButton = new Button();
            sexWomenButton = new RadioButton();
            sexMenButton = new RadioButton();
            sexLabel = new Label();
            cityField = new TextBox();
            cityLabel = new Label();
            nameLabel = new Label();
            nameField = new TextBox();
            BirhdayLabel = new Label();
            surnameLabel = new Label();
            surnameField = new TextBox();
            BirhdayFields = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)girlPhoto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)boyPhoto).BeginInit();
            SuspendLayout();
            // 
            // girlPhoto
            // 
            girlPhoto.BackColor = Color.Fuchsia;
            girlPhoto.Image = (Image)resources.GetObject("girlPhoto.Image");
            girlPhoto.Location = new Point(609, 19);
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
            boyPhoto.Location = new Point(117, 19);
            boyPhoto.Name = "boyPhoto";
            boyPhoto.Size = new Size(76, 69);
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
            CollapseButton.Location = new Point(745, 0);
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
            CloseButton.Location = new Point(776, 0);
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
            entryLabel.Size = new Size(811, 88);
            entryLabel.TabIndex = 36;
            entryLabel.Text = "Регистрация";
            entryLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            loginLabel.Location = new Point(50, 130);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(80, 26);
            loginLabel.TabIndex = 46;
            loginLabel.Text = "Логин";
            // 
            // LoginField
            // 
            LoginField.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            LoginField.ForeColor = Color.Gray;
            LoginField.Location = new Point(50, 159);
            LoginField.Name = "LoginField";
            LoginField.Size = new Size(326, 32);
            LoginField.TabIndex = 45;
            LoginField.Text = "Введите логин...";
            LoginField.Enter += LoginField_Enter;
            LoginField.Leave += LoginField_Leave;
            // 
            // passwordLabel2
            // 
            passwordLabel2.AutoSize = true;
            passwordLabel2.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            passwordLabel2.Location = new Point(50, 280);
            passwordLabel2.Name = "passwordLabel2";
            passwordLabel2.Size = new Size(219, 26);
            passwordLabel2.TabIndex = 44;
            passwordLabel2.Text = "Повторный пароль";
            // 
            // password2Field
            // 
            password2Field.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            password2Field.ForeColor = Color.Gray;
            password2Field.Location = new Point(50, 309);
            password2Field.Name = "password2Field";
            password2Field.Size = new Size(326, 32);
            password2Field.TabIndex = 43;
            password2Field.Text = "Введите повторно пароль...";
            password2Field.Enter += password2Field_Enter;
            password2Field.Leave += password2Field_Leave;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            passwordLabel.Location = new Point(50, 206);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(93, 26);
            passwordLabel.TabIndex = 42;
            passwordLabel.Text = "Пароль";
            // 
            // passwordField
            // 
            passwordField.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            passwordField.ForeColor = Color.Gray;
            passwordField.Location = new Point(50, 235);
            passwordField.Name = "passwordField";
            passwordField.Size = new Size(326, 32);
            passwordField.TabIndex = 41;
            passwordField.Text = "Введите пароль...";
            passwordField.Enter += passwordField_Enter;
            passwordField.Leave += passwordField_Leave;
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.Fuchsia;
            loginButton.BackgroundImageLayout = ImageLayout.None;
            loginButton.FlatAppearance.BorderSize = 0;
            loginButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            loginButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.Font = new Font("Segoe Print", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            loginButton.ForeColor = Color.White;
            loginButton.Location = new Point(281, 394);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(266, 44);
            loginButton.TabIndex = 47;
            loginButton.Text = "Зарегистрироваться";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // sexWomenButton
            // 
            sexWomenButton.AutoSize = true;
            sexWomenButton.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            sexWomenButton.Location = new Point(681, 344);
            sexWomenButton.Name = "sexWomenButton";
            sexWomenButton.Size = new Size(47, 27);
            sexWomenButton.TabIndex = 67;
            sexWomenButton.TabStop = true;
            sexWomenButton.Text = "Ж";
            sexWomenButton.UseVisualStyleBackColor = true;
            // 
            // sexMenButton
            // 
            sexMenButton.AutoSize = true;
            sexMenButton.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            sexMenButton.Location = new Point(619, 344);
            sexMenButton.Name = "sexMenButton";
            sexMenButton.Size = new Size(46, 27);
            sexMenButton.TabIndex = 66;
            sexMenButton.TabStop = true;
            sexMenButton.Text = "M";
            sexMenButton.UseVisualStyleBackColor = true;
            // 
            // sexLabel
            // 
            sexLabel.AutoSize = true;
            sexLabel.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            sexLabel.Location = new Point(467, 343);
            sexLabel.Name = "sexLabel";
            sexLabel.Size = new Size(144, 24);
            sexLabel.TabIndex = 65;
            sexLabel.Text = "Выберите пол";
            // 
            // cityField
            // 
            cityField.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cityField.Location = new Point(467, 307);
            cityField.Name = "cityField";
            cityField.Size = new Size(297, 29);
            cityField.TabIndex = 64;
            cityField.Text = "Введите город проживания...";
            cityField.Enter += cityField_Enter;
            cityField.Leave += cityField_Leave;
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            cityLabel.Location = new Point(467, 280);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new Size(64, 24);
            cityLabel.TabIndex = 63;
            cityLabel.Text = "Город";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            nameLabel.Location = new Point(467, 103);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(51, 24);
            nameLabel.TabIndex = 62;
            nameLabel.Text = "Имя";
            // 
            // nameField
            // 
            nameField.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            nameField.Location = new Point(467, 130);
            nameField.Name = "nameField";
            nameField.Size = new Size(297, 29);
            nameField.TabIndex = 61;
            nameField.Text = "Введите имя...";
            nameField.Enter += nameField_Enter;
            nameField.Leave += nameField_Leave;
            // 
            // BirhdayLabel
            // 
            BirhdayLabel.AutoSize = true;
            BirhdayLabel.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            BirhdayLabel.Location = new Point(467, 221);
            BirhdayLabel.Name = "BirhdayLabel";
            BirhdayLabel.Size = new Size(151, 24);
            BirhdayLabel.TabIndex = 60;
            BirhdayLabel.Text = "Дата рождения";
            // 
            // surnameLabel
            // 
            surnameLabel.AutoSize = true;
            surnameLabel.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            surnameLabel.Location = new Point(467, 162);
            surnameLabel.Name = "surnameLabel";
            surnameLabel.Size = new Size(101, 24);
            surnameLabel.TabIndex = 58;
            surnameLabel.Text = "Фамилия";
            // 
            // surnameField
            // 
            surnameField.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            surnameField.Location = new Point(467, 189);
            surnameField.Name = "surnameField";
            surnameField.Size = new Size(297, 29);
            surnameField.TabIndex = 57;
            surnameField.Text = "Введите фамилию...";
            surnameField.Enter += surnameField_Enter;
            surnameField.Leave += surnameField_Leave;
            // 
            // BirhdayFields
            // 
            BirhdayFields.CalendarFont = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            BirhdayFields.Location = new Point(467, 248);
            BirhdayFields.Name = "BirhdayFields";
            BirhdayFields.Size = new Size(297, 23);
            BirhdayFields.TabIndex = 68;
            // 
            // RegistrForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(811, 450);
            Controls.Add(BirhdayFields);
            Controls.Add(sexWomenButton);
            Controls.Add(sexMenButton);
            Controls.Add(sexLabel);
            Controls.Add(cityField);
            Controls.Add(cityLabel);
            Controls.Add(nameLabel);
            Controls.Add(nameField);
            Controls.Add(BirhdayLabel);
            Controls.Add(surnameLabel);
            Controls.Add(surnameField);
            Controls.Add(loginButton);
            Controls.Add(loginLabel);
            Controls.Add(LoginField);
            Controls.Add(passwordLabel2);
            Controls.Add(password2Field);
            Controls.Add(passwordLabel);
            Controls.Add(passwordField);
            Controls.Add(girlPhoto);
            Controls.Add(boyPhoto);
            Controls.Add(CollapseButton);
            Controls.Add(CloseButton);
            Controls.Add(entryLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegistrForm";
            Text = "RegistrForm";
            ((System.ComponentModel.ISupportInitialize)girlPhoto).EndInit();
            ((System.ComponentModel.ISupportInitialize)boyPhoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox girlPhoto;
        private PictureBox boyPhoto;
        private Button CollapseButton;
        private Button CloseButton;
        private Label entryLabel;
        private Label loginLabel;
        private TextBox LoginField;
        private Label passwordLabel2;
        private TextBox password2Field;
        private Label passwordLabel;
        private TextBox passwordField;
        private Button loginButton;
        private RadioButton sexWomenButton;
        private RadioButton sexMenButton;
        private Label sexLabel;
        private TextBox cityField;
        private Label cityLabel;
        private Label nameLabel;
        private TextBox nameField;
        private Label BirhdayLabel;
        private Label surnameLabel;
        private TextBox surnameField;
        public DateTimePicker BirhdayFields;
    }
}