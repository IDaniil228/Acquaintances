namespace HeartFluttering
{
    partial class RegistrForm2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrForm2));
            girlPhoto = new PictureBox();
            boyPhoto = new PictureBox();
            CollapseButton = new Button();
            CloseButton = new Button();
            entryLabel = new Label();
            sexWomenButton = new RadioButton();
            sexMenButtun = new RadioButton();
            sexLabel = new Label();
            cityField = new TextBox();
            cityLabel = new Label();
            nameLabel = new Label();
            nameField = new TextBox();
            BirhdayLabel = new Label();
            BirhdayFields = new TextBox();
            surnameLabel = new Label();
            surnameField = new TextBox();
            registrButton = new Button();
            ((System.ComponentModel.ISupportInitialize)girlPhoto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)boyPhoto).BeginInit();
            SuspendLayout();
            // 
            // girlPhoto
            // 
            girlPhoto.BackColor = Color.Fuchsia;
            girlPhoto.Image = (Image)resources.GetObject("girlPhoto.Image");
            girlPhoto.Location = new Point(348, 30);
            girlPhoto.Name = "girlPhoto";
            girlPhoto.Size = new Size(63, 58);
            girlPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            girlPhoto.TabIndex = 45;
            girlPhoto.TabStop = false;
            // 
            // boyPhoto
            // 
            boyPhoto.BackColor = Color.Fuchsia;
            boyPhoto.Image = (Image)resources.GetObject("boyPhoto.Image");
            boyPhoto.Location = new Point(12, 30);
            boyPhoto.Name = "boyPhoto";
            boyPhoto.Size = new Size(63, 58);
            boyPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            boyPhoto.TabIndex = 44;
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
            CollapseButton.Location = new Point(355, 0);
            CollapseButton.Name = "CollapseButton";
            CollapseButton.Size = new Size(35, 23);
            CollapseButton.TabIndex = 43;
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
            CloseButton.Location = new Point(388, 0);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(35, 23);
            CloseButton.TabIndex = 42;
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
            entryLabel.Size = new Size(423, 88);
            entryLabel.TabIndex = 41;
            entryLabel.Text = "Регистрация";
            entryLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // sexWomenButton
            // 
            sexWomenButton.AutoSize = true;
            sexWomenButton.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            sexWomenButton.Location = new Point(286, 352);
            sexWomenButton.Name = "sexWomenButton";
            sexWomenButton.Size = new Size(47, 27);
            sexWomenButton.TabIndex = 56;
            sexWomenButton.TabStop = true;
            sexWomenButton.Text = "Ж";
            sexWomenButton.UseVisualStyleBackColor = true;
            // 
            // sexMenButtun
            // 
            sexMenButtun.AutoSize = true;
            sexMenButtun.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            sexMenButtun.Location = new Point(224, 352);
            sexMenButtun.Name = "sexMenButtun";
            sexMenButtun.Size = new Size(46, 27);
            sexMenButtun.TabIndex = 55;
            sexMenButtun.TabStop = true;
            sexMenButtun.Text = "M";
            sexMenButtun.UseVisualStyleBackColor = true;
            // 
            // sexLabel
            // 
            sexLabel.AutoSize = true;
            sexLabel.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            sexLabel.Location = new Point(72, 351);
            sexLabel.Name = "sexLabel";
            sexLabel.Size = new Size(144, 24);
            sexLabel.TabIndex = 54;
            sexLabel.Text = "Выберите пол";
            // 
            // cityField
            // 
            cityField.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cityField.Location = new Point(72, 315);
            cityField.Name = "cityField";
            cityField.Size = new Size(297, 29);
            cityField.TabIndex = 53;
            cityField.Text = "Введите город проживания...";
            cityField.Enter += cityField_Enter;
            cityField.Leave += cityField_Leave;
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            cityLabel.Location = new Point(72, 288);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new Size(64, 24);
            cityLabel.TabIndex = 52;
            cityLabel.Text = "Город";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            nameLabel.Location = new Point(72, 111);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(51, 24);
            nameLabel.TabIndex = 51;
            nameLabel.Text = "Имя";
            // 
            // nameField
            // 
            nameField.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            nameField.Location = new Point(72, 138);
            nameField.Name = "nameField";
            nameField.Size = new Size(297, 29);
            nameField.TabIndex = 50;
            nameField.Text = "Введите имя...";
            nameField.Enter += nameField_Enter;
            nameField.Leave += nameField_Leave;
            // 
            // BirhdayLabel
            // 
            BirhdayLabel.AutoSize = true;
            BirhdayLabel.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            BirhdayLabel.Location = new Point(72, 229);
            BirhdayLabel.Name = "BirhdayLabel";
            BirhdayLabel.Size = new Size(151, 24);
            BirhdayLabel.TabIndex = 49;
            BirhdayLabel.Text = "Дата рождения";
            // 
            // BirhdayFields
            // 
            BirhdayFields.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            BirhdayFields.Location = new Point(72, 256);
            BirhdayFields.Name = "BirhdayFields";
            BirhdayFields.Size = new Size(297, 29);
            BirhdayFields.TabIndex = 48;
            BirhdayFields.Text = "Введите дату рождения...";
            BirhdayFields.Enter += BirhdayFields_Enter;
            BirhdayFields.Leave += BirhdayFields_Leave;
            // 
            // surnameLabel
            // 
            surnameLabel.AutoSize = true;
            surnameLabel.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            surnameLabel.Location = new Point(72, 170);
            surnameLabel.Name = "surnameLabel";
            surnameLabel.Size = new Size(101, 24);
            surnameLabel.TabIndex = 47;
            surnameLabel.Text = "Фамилия";
            // 
            // surnameField
            // 
            surnameField.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            surnameField.Location = new Point(72, 197);
            surnameField.Name = "surnameField";
            surnameField.Size = new Size(297, 29);
            surnameField.TabIndex = 46;
            surnameField.Text = "Введите фамилию...";
            surnameField.Enter += surnameField_Enter;
            surnameField.Leave += surnameField_Leave;
            // 
            // registrButton
            // 
            registrButton.BackColor = Color.Fuchsia;
            registrButton.BackgroundImageLayout = ImageLayout.None;
            registrButton.FlatAppearance.BorderSize = 0;
            registrButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            registrButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            registrButton.FlatStyle = FlatStyle.Flat;
            registrButton.Font = new Font("Segoe Print", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            registrButton.ForeColor = Color.White;
            registrButton.Location = new Point(95, 394);
            registrButton.Name = "registrButton";
            registrButton.Size = new Size(224, 58);
            registrButton.TabIndex = 57;
            registrButton.Text = "Готово";
            registrButton.UseVisualStyleBackColor = false;
            registrButton.Click += registrButton_Click;
            // 
            // RegistrForm2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(423, 474);
            Controls.Add(registrButton);
            Controls.Add(sexWomenButton);
            Controls.Add(sexMenButtun);
            Controls.Add(sexLabel);
            Controls.Add(cityField);
            Controls.Add(cityLabel);
            Controls.Add(nameLabel);
            Controls.Add(nameField);
            Controls.Add(BirhdayLabel);
            Controls.Add(BirhdayFields);
            Controls.Add(surnameLabel);
            Controls.Add(surnameField);
            Controls.Add(girlPhoto);
            Controls.Add(boyPhoto);
            Controls.Add(CollapseButton);
            Controls.Add(CloseButton);
            Controls.Add(entryLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegistrForm2";
            Text = "RegistrForm2";
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
        private RadioButton sexWomenButton;
        private RadioButton sexMenButtun;
        private Label sexLabel;
        private TextBox cityField;
        private Label cityLabel;
        private Label nameLabel;
        private TextBox nameField;
        private Label BirhdayLabel;
        private TextBox BirhdayFields;
        private Label surnameLabel;
        private TextBox surnameField;
        private Button registrButton;
    }
}