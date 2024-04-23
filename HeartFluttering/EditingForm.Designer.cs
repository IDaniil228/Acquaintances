namespace HeartFluttering
{
    partial class EditingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditingForm));
            girlPhoto = new PictureBox();
            boyPhoto = new PictureBox();
            CollapseButton = new Button();
            CloseButton = new Button();
            entryLabel = new Label();
            numberLabel = new Label();
            emailLabel = new Label();
            sexLabel = new Label();
            cityLabel = new Label();
            nameLabel = new Label();
            birhdayLabel = new Label();
            surnameLabel = new Label();
            redactionButton = new Button();
            backButton = new Button();
            nameField = new TextBox();
            surnameField = new TextBox();
            cityField = new TextBox();
            emailField = new TextBox();
            numberField = new TextBox();
            birhdayField = new DateTimePicker();
            sexMenButton = new RadioButton();
            sexWomenButton = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)girlPhoto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)boyPhoto).BeginInit();
            SuspendLayout();
            // 
            // girlPhoto
            // 
            girlPhoto.BackColor = Color.Fuchsia;
            girlPhoto.Image = (Image)resources.GetObject("girlPhoto.Image");
            girlPhoto.Location = new Point(395, 29);
            girlPhoto.Name = "girlPhoto";
            girlPhoto.Size = new Size(63, 58);
            girlPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            girlPhoto.TabIndex = 40;
            girlPhoto.TabStop = false;
            // 
            // boyPhoto
            // 
            boyPhoto.BackColor = Color.Fuchsia;
            boyPhoto.Image = (Image)resources.GetObject("boyPhoto.Image");
            boyPhoto.Location = new Point(0, 29);
            boyPhoto.Name = "boyPhoto";
            boyPhoto.Size = new Size(63, 58);
            boyPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            boyPhoto.TabIndex = 39;
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
            CollapseButton.Location = new Point(404, 0);
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
            CloseButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(212, 22, 207);
            CloseButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(249, 158, 246);
            CloseButton.FlatStyle = FlatStyle.Flat;
            CloseButton.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            CloseButton.ForeColor = Color.White;
            CloseButton.Location = new Point(435, 0);
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
            entryLabel.Font = new Font("Segoe Print", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            entryLabel.ForeColor = SystemColors.ButtonHighlight;
            entryLabel.Location = new Point(0, 0);
            entryLabel.Name = "entryLabel";
            entryLabel.Size = new Size(470, 88);
            entryLabel.TabIndex = 36;
            entryLabel.Text = "Редактирование";
            entryLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // numberLabel
            // 
            numberLabel.AutoSize = true;
            numberLabel.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            numberLabel.Location = new Point(18, 350);
            numberLabel.Name = "numberLabel";
            numberLabel.Size = new Size(167, 24);
            numberLabel.TabIndex = 83;
            numberLabel.Text = "Номер телефона";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            emailLabel.Location = new Point(119, 311);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(68, 24);
            emailLabel.TabIndex = 82;
            emailLabel.Text = "Почта";
            // 
            // sexLabel
            // 
            sexLabel.AutoSize = true;
            sexLabel.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            sexLabel.Location = new Point(136, 275);
            sexLabel.Name = "sexLabel";
            sexLabel.Size = new Size(49, 24);
            sexLabel.TabIndex = 74;
            sexLabel.Text = "Пол";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            cityLabel.Location = new Point(121, 239);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new Size(64, 24);
            cityLabel.TabIndex = 73;
            cityLabel.Text = "Город";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            nameLabel.Location = new Point(136, 134);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(51, 24);
            nameLabel.TabIndex = 72;
            nameLabel.Text = "Имя";
            // 
            // birhdayLabel
            // 
            birhdayLabel.AutoSize = true;
            birhdayLabel.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            birhdayLabel.Location = new Point(36, 204);
            birhdayLabel.Name = "birhdayLabel";
            birhdayLabel.Size = new Size(151, 24);
            birhdayLabel.TabIndex = 71;
            birhdayLabel.Text = "Дата рождения";
            // 
            // surnameLabel
            // 
            surnameLabel.AutoSize = true;
            surnameLabel.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            surnameLabel.Location = new Point(86, 169);
            surnameLabel.Name = "surnameLabel";
            surnameLabel.Size = new Size(101, 24);
            surnameLabel.TabIndex = 70;
            surnameLabel.Text = "Фамилия";
            // 
            // redactionButton
            // 
            redactionButton.BackColor = Color.Fuchsia;
            redactionButton.BackgroundImageLayout = ImageLayout.None;
            redactionButton.FlatAppearance.BorderSize = 0;
            redactionButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(212, 22, 207);
            redactionButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(249, 158, 246);
            redactionButton.FlatStyle = FlatStyle.Flat;
            redactionButton.Font = new Font("Segoe Print", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            redactionButton.ForeColor = Color.White;
            redactionButton.Location = new Point(103, 392);
            redactionButton.Name = "redactionButton";
            redactionButton.Size = new Size(264, 40);
            redactionButton.TabIndex = 84;
            redactionButton.Text = "Редактировать";
            redactionButton.UseVisualStyleBackColor = false;
            redactionButton.Click += redactionButton_Click;
            // 
            // backButton
            // 
            backButton.BackColor = Color.Fuchsia;
            backButton.BackgroundImageLayout = ImageLayout.None;
            backButton.FlatAppearance.BorderSize = 0;
            backButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(212, 22, 207);
            backButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(249, 158, 246);
            backButton.FlatStyle = FlatStyle.Flat;
            backButton.Font = new Font("Segoe Print", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            backButton.ForeColor = Color.White;
            backButton.Location = new Point(172, 449);
            backButton.Name = "backButton";
            backButton.Size = new Size(127, 27);
            backButton.TabIndex = 85;
            backButton.Text = "Назад";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // nameField
            // 
            nameField.BackColor = Color.FromArgb(255, 230, 255);
            nameField.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            nameField.ForeColor = Color.Gray;
            nameField.Location = new Point(204, 133);
            nameField.Name = "nameField";
            nameField.Size = new Size(254, 29);
            nameField.TabIndex = 86;
            nameField.Text = "Не заполнено...";
            nameField.Enter += nameField_Enter;
            nameField.Leave += nameField_Leave;
            // 
            // surnameField
            // 
            surnameField.BackColor = Color.FromArgb(255, 230, 255);
            surnameField.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            surnameField.ForeColor = Color.Gray;
            surnameField.Location = new Point(204, 169);
            surnameField.Name = "surnameField";
            surnameField.Size = new Size(254, 29);
            surnameField.TabIndex = 87;
            surnameField.Text = "Не заполнено...";
            surnameField.Enter += surnameField_Enter;
            surnameField.Leave += surnameField_Leave;
            // 
            // cityField
            // 
            cityField.BackColor = Color.FromArgb(255, 230, 255);
            cityField.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cityField.ForeColor = Color.Gray;
            cityField.Location = new Point(204, 239);
            cityField.Name = "cityField";
            cityField.Size = new Size(254, 29);
            cityField.TabIndex = 89;
            cityField.Text = "Не заполнено...";
            cityField.Enter += cityField_Enter;
            cityField.Leave += cityField_Leave;
            // 
            // emailField
            // 
            emailField.BackColor = Color.FromArgb(255, 230, 255);
            emailField.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            emailField.ForeColor = Color.Gray;
            emailField.Location = new Point(204, 311);
            emailField.Name = "emailField";
            emailField.Size = new Size(254, 29);
            emailField.TabIndex = 91;
            emailField.Text = "Не заполнено...";
            emailField.Enter += emailField_Enter;
            emailField.Leave += emailField_Leave;
            // 
            // numberField
            // 
            numberField.BackColor = Color.FromArgb(255, 230, 255);
            numberField.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            numberField.ForeColor = Color.Gray;
            numberField.Location = new Point(204, 346);
            numberField.Name = "numberField";
            numberField.Size = new Size(254, 29);
            numberField.TabIndex = 92;
            numberField.Text = "Не заполнено...";
            numberField.Enter += numberField_Enter;
            numberField.Leave += numberField_Leave;
            // 
            // birhdayField
            // 
            birhdayField.CalendarMonthBackground = Color.White;
            birhdayField.CalendarTitleBackColor = Color.FromArgb(128, 255, 255);
            birhdayField.Location = new Point(204, 205);
            birhdayField.Name = "birhdayField";
            birhdayField.Size = new Size(254, 23);
            birhdayField.TabIndex = 93;
            // 
            // sexMenButton
            // 
            sexMenButton.AutoSize = true;
            sexMenButton.BackColor = Color.FromArgb(255, 230, 255);
            sexMenButton.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            sexMenButton.Location = new Point(255, 275);
            sexMenButton.Name = "sexMenButton";
            sexMenButton.Size = new Size(44, 25);
            sexMenButton.TabIndex = 94;
            sexMenButton.TabStop = true;
            sexMenButton.Text = "M";
            sexMenButton.UseVisualStyleBackColor = false;
            // 
            // sexWomenButton
            // 
            sexWomenButton.AutoSize = true;
            sexWomenButton.BackColor = Color.FromArgb(255, 230, 255);
            sexWomenButton.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            sexWomenButton.Location = new Point(349, 275);
            sexWomenButton.Name = "sexWomenButton";
            sexWomenButton.Size = new Size(45, 25);
            sexWomenButton.TabIndex = 95;
            sexWomenButton.TabStop = true;
            sexWomenButton.Text = "Ж";
            sexWomenButton.UseVisualStyleBackColor = false;
            // 
            // EditingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(470, 477);
            Controls.Add(sexWomenButton);
            Controls.Add(sexMenButton);
            Controls.Add(birhdayField);
            Controls.Add(numberField);
            Controls.Add(emailField);
            Controls.Add(cityField);
            Controls.Add(surnameField);
            Controls.Add(nameField);
            Controls.Add(backButton);
            Controls.Add(redactionButton);
            Controls.Add(numberLabel);
            Controls.Add(emailLabel);
            Controls.Add(sexLabel);
            Controls.Add(cityLabel);
            Controls.Add(nameLabel);
            Controls.Add(birhdayLabel);
            Controls.Add(surnameLabel);
            Controls.Add(girlPhoto);
            Controls.Add(boyPhoto);
            Controls.Add(CollapseButton);
            Controls.Add(CloseButton);
            Controls.Add(entryLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EditingForm";
            Text = "EditingForm";
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
        private Label numberLabel;
        private Label emailLabel;
        private Label sexLabel;
        private Label cityLabel;
        private Label nameLabel;
        private Label birhdayLabel;
        private Label surnameLabel;
        private Button redactionButton;
        private Button backButton;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox5;
        public TextBox nameField;
        public TextBox surnameField;
        public TextBox cityField;
        public TextBox emailField;
        public TextBox numberField;
        public DateTimePicker birhdayField;
        private DateTimePicker dateTimePicker1;
        public RadioButton sexMenButton;
        public RadioButton sexWomenButton;
    }
}