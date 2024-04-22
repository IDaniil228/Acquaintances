namespace HeartFluttering
{
    partial class AdministratorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministratorForm));
            label2 = new Label();
            girlPhoto = new PictureBox();
            boyPhoto = new PictureBox();
            CollapseButton = new Button();
            CloseButton = new Button();
            entryLabel = new Label();
            usersLabel = new Label();
            panel1 = new Panel();
            deleteAccountButton = new Button();
            comboBox1 = new ComboBox();
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
            Photo = new PictureBox();
            profileLabel = new Label();
            searchLine = new TextBox();
            listUsers = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)girlPhoto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)boyPhoto).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Photo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)listUsers).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.BackColor = Color.Fuchsia;
            label2.Location = new Point(288, 87);
            label2.Name = "label2";
            label2.Size = new Size(10, 342);
            label2.TabIndex = 47;
            // 
            // girlPhoto
            // 
            girlPhoto.BackColor = Color.Fuchsia;
            girlPhoto.Image = (Image)resources.GetObject("girlPhoto.Image");
            girlPhoto.Location = new Point(699, 12);
            girlPhoto.Name = "girlPhoto";
            girlPhoto.Size = new Size(76, 66);
            girlPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            girlPhoto.TabIndex = 46;
            girlPhoto.TabStop = false;
            // 
            // boyPhoto
            // 
            boyPhoto.BackColor = Color.Fuchsia;
            boyPhoto.Image = (Image)resources.GetObject("boyPhoto.Image");
            boyPhoto.Location = new Point(114, 12);
            boyPhoto.Name = "boyPhoto";
            boyPhoto.Size = new Size(75, 66);
            boyPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            boyPhoto.TabIndex = 45;
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
            CollapseButton.Location = new Point(828, 0);
            CollapseButton.Name = "CollapseButton";
            CollapseButton.Size = new Size(35, 20);
            CollapseButton.TabIndex = 44;
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
            CloseButton.Location = new Point(860, 0);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(35, 20);
            CloseButton.TabIndex = 43;
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
            entryLabel.Size = new Size(895, 87);
            entryLabel.TabIndex = 42;
            entryLabel.Text = "Трепетание сердца";
            entryLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // usersLabel
            // 
            usersLabel.AutoSize = true;
            usersLabel.Font = new Font("Segoe Print", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            usersLabel.Location = new Point(31, 87);
            usersLabel.Name = "usersLabel";
            usersLabel.Size = new Size(235, 50);
            usersLabel.TabIndex = 48;
            usersLabel.Text = "Пользователи";
            // 
            // panel1
            // 
            panel1.Controls.Add(deleteAccountButton);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(numberLabel);
            panel1.Controls.Add(emailLabel);
            panel1.Controls.Add(numberField);
            panel1.Controls.Add(emailField);
            panel1.Controls.Add(sexField);
            panel1.Controls.Add(cityField);
            panel1.Controls.Add(birhdayField);
            panel1.Controls.Add(surnameField);
            panel1.Controls.Add(nameField);
            panel1.Controls.Add(sexLabel);
            panel1.Controls.Add(cityLabel);
            panel1.Controls.Add(nameLabel);
            panel1.Controls.Add(birhdayLabel);
            panel1.Controls.Add(surnameLabel);
            panel1.Controls.Add(Photo);
            panel1.Controls.Add(profileLabel);
            panel1.Location = new Point(299, 87);
            panel1.Name = "panel1";
            panel1.Size = new Size(596, 342);
            panel1.TabIndex = 49;
            // 
            // deleteAccountButton
            // 
            deleteAccountButton.BackColor = Color.Fuchsia;
            deleteAccountButton.BackgroundImageLayout = ImageLayout.None;
            deleteAccountButton.FlatAppearance.BorderSize = 0;
            deleteAccountButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            deleteAccountButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            deleteAccountButton.FlatStyle = FlatStyle.Flat;
            deleteAccountButton.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            deleteAccountButton.ForeColor = Color.White;
            deleteAccountButton.Location = new Point(0, 308);
            deleteAccountButton.Name = "deleteAccountButton";
            deleteAccountButton.Size = new Size(252, 34);
            deleteAccountButton.TabIndex = 73;
            deleteAccountButton.Text = "Заблокировать аккаунт";
            deleteAccountButton.UseVisualStyleBackColor = false;
            deleteAccountButton.Click += deleteAccountButton_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(460, 5);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(124, 23);
            comboBox1.TabIndex = 72;
            // 
            // numberLabel
            // 
            numberLabel.AutoSize = true;
            numberLabel.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            numberLabel.Location = new Point(163, 281);
            numberLabel.Name = "numberLabel";
            numberLabel.Size = new Size(167, 24);
            numberLabel.TabIndex = 71;
            numberLabel.Text = "Номер телефона";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            emailLabel.Location = new Point(264, 242);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(68, 24);
            emailLabel.TabIndex = 70;
            emailLabel.Text = "Почта";
            // 
            // numberField
            // 
            numberField.BackColor = Color.FromArgb(255, 230, 255);
            numberField.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            numberField.ForeColor = Color.Black;
            numberField.Location = new Point(349, 281);
            numberField.Name = "numberField";
            numberField.Size = new Size(235, 24);
            numberField.TabIndex = 69;
            // 
            // emailField
            // 
            emailField.BackColor = Color.FromArgb(255, 230, 255);
            emailField.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            emailField.ForeColor = Color.Black;
            emailField.Location = new Point(349, 243);
            emailField.Name = "emailField";
            emailField.Size = new Size(235, 24);
            emailField.TabIndex = 68;
            // 
            // sexField
            // 
            sexField.BackColor = Color.FromArgb(255, 230, 255);
            sexField.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            sexField.ForeColor = Color.Black;
            sexField.Location = new Point(349, 207);
            sexField.Name = "sexField";
            sexField.Size = new Size(235, 24);
            sexField.TabIndex = 67;
            // 
            // cityField
            // 
            cityField.BackColor = Color.FromArgb(255, 230, 255);
            cityField.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cityField.ForeColor = Color.Black;
            cityField.Location = new Point(349, 171);
            cityField.Name = "cityField";
            cityField.Size = new Size(235, 24);
            cityField.TabIndex = 66;
            // 
            // birhdayField
            // 
            birhdayField.BackColor = Color.FromArgb(255, 230, 255);
            birhdayField.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            birhdayField.ForeColor = Color.Black;
            birhdayField.Location = new Point(349, 135);
            birhdayField.Name = "birhdayField";
            birhdayField.Size = new Size(235, 24);
            birhdayField.TabIndex = 65;
            // 
            // surnameField
            // 
            surnameField.BackColor = Color.FromArgb(255, 230, 255);
            surnameField.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            surnameField.ForeColor = Color.Black;
            surnameField.Location = new Point(349, 100);
            surnameField.Name = "surnameField";
            surnameField.Size = new Size(235, 24);
            surnameField.TabIndex = 64;
            // 
            // nameField
            // 
            nameField.BackColor = Color.FromArgb(255, 230, 255);
            nameField.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            nameField.ForeColor = Color.Black;
            nameField.Location = new Point(349, 65);
            nameField.Name = "nameField";
            nameField.Size = new Size(235, 24);
            nameField.TabIndex = 63;
            // 
            // sexLabel
            // 
            sexLabel.AutoSize = true;
            sexLabel.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            sexLabel.Location = new Point(281, 206);
            sexLabel.Name = "sexLabel";
            sexLabel.Size = new Size(49, 24);
            sexLabel.TabIndex = 62;
            sexLabel.Text = "Пол";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            cityLabel.Location = new Point(266, 170);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new Size(64, 24);
            cityLabel.TabIndex = 61;
            cityLabel.Text = "Город";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            nameLabel.Location = new Point(281, 65);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(51, 24);
            nameLabel.TabIndex = 60;
            nameLabel.Text = "Имя";
            // 
            // birhdayLabel
            // 
            birhdayLabel.AutoSize = true;
            birhdayLabel.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            birhdayLabel.Location = new Point(181, 135);
            birhdayLabel.Name = "birhdayLabel";
            birhdayLabel.Size = new Size(151, 24);
            birhdayLabel.TabIndex = 59;
            birhdayLabel.Text = "Дата рождения";
            // 
            // surnameLabel
            // 
            surnameLabel.AutoSize = true;
            surnameLabel.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            surnameLabel.Location = new Point(231, 100);
            surnameLabel.Name = "surnameLabel";
            surnameLabel.Size = new Size(101, 24);
            surnameLabel.TabIndex = 58;
            surnameLabel.Text = "Фамилия";
            // 
            // Photo
            // 
            Photo.Image = (Image)resources.GetObject("Photo.Image");
            Photo.Location = new Point(20, 69);
            Photo.Name = "Photo";
            Photo.Size = new Size(155, 149);
            Photo.SizeMode = PictureBoxSizeMode.StretchImage;
            Photo.TabIndex = 57;
            Photo.TabStop = false;
            // 
            // profileLabel
            // 
            profileLabel.AutoSize = true;
            profileLabel.Font = new Font("Segoe Print", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            profileLabel.Location = new Point(149, 0);
            profileLabel.Name = "profileLabel";
            profileLabel.Size = new Size(198, 64);
            profileLabel.TabIndex = 56;
            profileLabel.Text = "Профиль";
            // 
            // searchLine
            // 
            searchLine.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            searchLine.Location = new Point(0, 143);
            searchLine.Name = "searchLine";
            searchLine.Size = new Size(287, 29);
            searchLine.TabIndex = 50;
            searchLine.TextChanged += searchLine_TextChanged;
            // 
            // listUsers
            // 
            listUsers.AllowUserToAddRows = false;
            listUsers.BackgroundColor = Color.White;
            listUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            listUsers.Location = new Point(0, 173);
            listUsers.Name = "listUsers";
            listUsers.ReadOnly = true;
            listUsers.Size = new Size(287, 256);
            listUsers.TabIndex = 59;
            listUsers.CellDoubleClick += listUsers_CellDoubleClick;
            // 
            // AdministratorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(895, 428);
            Controls.Add(listUsers);
            Controls.Add(searchLine);
            Controls.Add(panel1);
            Controls.Add(usersLabel);
            Controls.Add(label2);
            Controls.Add(girlPhoto);
            Controls.Add(boyPhoto);
            Controls.Add(CollapseButton);
            Controls.Add(CloseButton);
            Controls.Add(entryLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdministratorForm";
            Text = "AdministratorForm";
            Load += AdministratorForm_Load;
            ((System.ComponentModel.ISupportInitialize)girlPhoto).EndInit();
            ((System.ComponentModel.ISupportInitialize)boyPhoto).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Photo).EndInit();
            ((System.ComponentModel.ISupportInitialize)listUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private PictureBox girlPhoto;
        private PictureBox boyPhoto;
        private Button CollapseButton;
        private Button CloseButton;
        private Label entryLabel;
        private Label usersLabel;
        private Panel panel1;
        private Button deleteAccountButton;
        private ComboBox comboBox1;
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
        private PictureBox Photo;
        private Label profileLabel;
        private TextBox searchLine;
        public DataGridView listUsers;
    }
}