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
            numberField = new Label();
            emailField = new Label();
            sexField = new Label();
            cityField = new Label();
            birhdayField = new Label();
            surnameField = new Label();
            nameField = new Label();
            sexLabel = new Label();
            cityLabel = new Label();
            nameLabel = new Label();
            birhdayLabel = new Label();
            surnameLabel = new Label();
            redactionButton = new Button();
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
            CollapseButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            CollapseButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            CollapseButton.FlatStyle = FlatStyle.Flat;
            CollapseButton.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            CollapseButton.ForeColor = Color.White;
            CollapseButton.Location = new Point(404, 0);
            CollapseButton.Name = "CollapseButton";
            CollapseButton.Size = new Size(35, 23);
            CollapseButton.TabIndex = 38;
            CollapseButton.Text = "—";
            CollapseButton.UseVisualStyleBackColor = false;
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
            CloseButton.Location = new Point(435, 0);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(35, 23);
            CloseButton.TabIndex = 37;
            CloseButton.Text = "X";
            CloseButton.UseVisualStyleBackColor = false;
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
            // numberField
            // 
            numberField.BackColor = Color.FromArgb(255, 230, 255);
            numberField.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            numberField.ForeColor = Color.Gray;
            numberField.Location = new Point(204, 350);
            numberField.Name = "numberField";
            numberField.Size = new Size(235, 24);
            numberField.TabIndex = 81;
            numberField.Text = "Номер телефона";
            // 
            // emailField
            // 
            emailField.BackColor = Color.FromArgb(255, 230, 255);
            emailField.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            emailField.ForeColor = Color.Gray;
            emailField.Location = new Point(204, 312);
            emailField.Name = "emailField";
            emailField.Size = new Size(235, 24);
            emailField.TabIndex = 80;
            emailField.Text = "Почта";
            // 
            // sexField
            // 
            sexField.BackColor = Color.FromArgb(255, 230, 255);
            sexField.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            sexField.ForeColor = Color.Gray;
            sexField.Location = new Point(204, 276);
            sexField.Name = "sexField";
            sexField.Size = new Size(235, 24);
            sexField.TabIndex = 79;
            sexField.Text = "Пол";
            // 
            // cityField
            // 
            cityField.BackColor = Color.FromArgb(255, 230, 255);
            cityField.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cityField.ForeColor = Color.Gray;
            cityField.Location = new Point(204, 240);
            cityField.Name = "cityField";
            cityField.Size = new Size(235, 24);
            cityField.TabIndex = 78;
            cityField.Text = "Город";
            // 
            // birhdayField
            // 
            birhdayField.BackColor = Color.FromArgb(255, 230, 255);
            birhdayField.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            birhdayField.ForeColor = Color.Gray;
            birhdayField.Location = new Point(204, 204);
            birhdayField.Name = "birhdayField";
            birhdayField.Size = new Size(235, 24);
            birhdayField.TabIndex = 77;
            birhdayField.Text = "Дата рождения";
            // 
            // surnameField
            // 
            surnameField.BackColor = Color.FromArgb(255, 230, 255);
            surnameField.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            surnameField.ForeColor = Color.Gray;
            surnameField.Location = new Point(204, 169);
            surnameField.Name = "surnameField";
            surnameField.Size = new Size(235, 24);
            surnameField.TabIndex = 76;
            surnameField.Text = "Фамилия";
            // 
            // nameField
            // 
            nameField.BackColor = Color.FromArgb(255, 230, 255);
            nameField.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            nameField.ForeColor = Color.Gray;
            nameField.Location = new Point(204, 134);
            nameField.Name = "nameField";
            nameField.Size = new Size(235, 24);
            nameField.TabIndex = 75;
            nameField.Text = "Имя";
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
            redactionButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            redactionButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            redactionButton.FlatStyle = FlatStyle.Flat;
            redactionButton.Font = new Font("Segoe Print", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            redactionButton.ForeColor = Color.White;
            redactionButton.Location = new Point(103, 425);
            redactionButton.Name = "redactionButton";
            redactionButton.Size = new Size(264, 40);
            redactionButton.TabIndex = 84;
            redactionButton.Text = "Редактировать";
            redactionButton.UseVisualStyleBackColor = false;
            // 
            // EditingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(470, 477);
            Controls.Add(redactionButton);
            Controls.Add(numberLabel);
            Controls.Add(emailLabel);
            Controls.Add(numberField);
            Controls.Add(emailField);
            Controls.Add(sexField);
            Controls.Add(cityField);
            Controls.Add(birhdayField);
            Controls.Add(surnameField);
            Controls.Add(nameField);
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
        private Label numberField;
        private Label emailField;
        private Label sexField;
        private Label cityField;
        private Label birhdayField;
        private Label surnameField;
        private Label nameField;
        private Label sexLabel;
        private Label cityLabel;
        private Label nameLabel;
        private Label birhdayLabel;
        private Label surnameLabel;
        private Button redactionButton;
    }
}