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
            AdminPanel = new Panel();
            deleteAccountButton = new Button();
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
            BtnSize = new Button();
            ((System.ComponentModel.ISupportInitialize)girlPhoto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)boyPhoto).BeginInit();
            AdminPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Photo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)listUsers).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.BackColor = Color.Fuchsia;
            label2.Name = "label2";
            // 
            // girlPhoto
            // 
            resources.ApplyResources(girlPhoto, "girlPhoto");
            girlPhoto.BackColor = Color.Fuchsia;
            girlPhoto.Name = "girlPhoto";
            girlPhoto.TabStop = false;
            girlPhoto.MouseDown += girlPhoto_MouseDown;
            girlPhoto.MouseMove += girlPhoto_MouseMove;
            // 
            // boyPhoto
            // 
            resources.ApplyResources(boyPhoto, "boyPhoto");
            boyPhoto.BackColor = Color.Fuchsia;
            boyPhoto.Name = "boyPhoto";
            boyPhoto.TabStop = false;
            boyPhoto.MouseDown += boyPhoto_MouseDown;
            boyPhoto.MouseMove += boyPhoto_MouseMove;
            // 
            // CollapseButton
            // 
            resources.ApplyResources(CollapseButton, "CollapseButton");
            CollapseButton.BackColor = Color.Fuchsia;
            CollapseButton.FlatAppearance.BorderSize = 0;
            CollapseButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(212, 22, 207);
            CollapseButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(249, 158, 246);
            CollapseButton.ForeColor = Color.White;
            CollapseButton.Name = "CollapseButton";
            CollapseButton.UseVisualStyleBackColor = false;
            CollapseButton.Click += CollapseButton_Click;
            // 
            // CloseButton
            // 
            resources.ApplyResources(CloseButton, "CloseButton");
            CloseButton.BackColor = Color.Fuchsia;
            CloseButton.FlatAppearance.BorderSize = 0;
            CloseButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(212, 22, 207);
            CloseButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(249, 158, 246);
            CloseButton.ForeColor = Color.White;
            CloseButton.Name = "CloseButton";
            CloseButton.UseVisualStyleBackColor = false;
            CloseButton.Click += CloseButton_Click;
            // 
            // entryLabel
            // 
            resources.ApplyResources(entryLabel, "entryLabel");
            entryLabel.BackColor = Color.Magenta;
            entryLabel.ForeColor = SystemColors.ButtonHighlight;
            entryLabel.Name = "entryLabel";
            entryLabel.MouseDown += entryLabel_MouseDown;
            entryLabel.MouseMove += entryLabel_MouseMove;
            // 
            // usersLabel
            // 
            resources.ApplyResources(usersLabel, "usersLabel");
            usersLabel.Name = "usersLabel";
            // 
            // AdminPanel
            // 
            resources.ApplyResources(AdminPanel, "AdminPanel");
            AdminPanel.Controls.Add(deleteAccountButton);
            AdminPanel.Controls.Add(numberLabel);
            AdminPanel.Controls.Add(emailLabel);
            AdminPanel.Controls.Add(numberField);
            AdminPanel.Controls.Add(emailField);
            AdminPanel.Controls.Add(sexField);
            AdminPanel.Controls.Add(cityField);
            AdminPanel.Controls.Add(birhdayField);
            AdminPanel.Controls.Add(surnameField);
            AdminPanel.Controls.Add(nameField);
            AdminPanel.Controls.Add(sexLabel);
            AdminPanel.Controls.Add(cityLabel);
            AdminPanel.Controls.Add(nameLabel);
            AdminPanel.Controls.Add(birhdayLabel);
            AdminPanel.Controls.Add(surnameLabel);
            AdminPanel.Controls.Add(Photo);
            AdminPanel.Controls.Add(profileLabel);
            AdminPanel.Name = "AdminPanel";
            AdminPanel.MouseDown += AdminPanel_MouseDown;
            AdminPanel.MouseMove += AdminPanel_MouseMove;
            // 
            // deleteAccountButton
            // 
            resources.ApplyResources(deleteAccountButton, "deleteAccountButton");
            deleteAccountButton.BackColor = Color.Fuchsia;
            deleteAccountButton.FlatAppearance.BorderSize = 0;
            deleteAccountButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(212, 22, 207);
            deleteAccountButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(249, 158, 246);
            deleteAccountButton.ForeColor = Color.White;
            deleteAccountButton.Name = "deleteAccountButton";
            deleteAccountButton.UseVisualStyleBackColor = false;
            deleteAccountButton.Click += deleteAccountButton_Click;
            // 
            // numberLabel
            // 
            resources.ApplyResources(numberLabel, "numberLabel");
            numberLabel.Name = "numberLabel";
            // 
            // emailLabel
            // 
            resources.ApplyResources(emailLabel, "emailLabel");
            emailLabel.Name = "emailLabel";
            // 
            // numberField
            // 
            resources.ApplyResources(numberField, "numberField");
            numberField.BackColor = Color.FromArgb(255, 230, 255);
            numberField.ForeColor = Color.Black;
            numberField.Name = "numberField";
            // 
            // emailField
            // 
            resources.ApplyResources(emailField, "emailField");
            emailField.BackColor = Color.FromArgb(255, 230, 255);
            emailField.ForeColor = Color.Black;
            emailField.Name = "emailField";
            // 
            // sexField
            // 
            resources.ApplyResources(sexField, "sexField");
            sexField.BackColor = Color.FromArgb(255, 230, 255);
            sexField.ForeColor = Color.Black;
            sexField.Name = "sexField";
            // 
            // cityField
            // 
            resources.ApplyResources(cityField, "cityField");
            cityField.BackColor = Color.FromArgb(255, 230, 255);
            cityField.ForeColor = Color.Black;
            cityField.Name = "cityField";
            // 
            // birhdayField
            // 
            resources.ApplyResources(birhdayField, "birhdayField");
            birhdayField.BackColor = Color.FromArgb(255, 230, 255);
            birhdayField.ForeColor = Color.Black;
            birhdayField.Name = "birhdayField";
            // 
            // surnameField
            // 
            resources.ApplyResources(surnameField, "surnameField");
            surnameField.BackColor = Color.FromArgb(255, 230, 255);
            surnameField.ForeColor = Color.Black;
            surnameField.Name = "surnameField";
            // 
            // nameField
            // 
            resources.ApplyResources(nameField, "nameField");
            nameField.BackColor = Color.FromArgb(255, 230, 255);
            nameField.ForeColor = Color.Black;
            nameField.Name = "nameField";
            // 
            // sexLabel
            // 
            resources.ApplyResources(sexLabel, "sexLabel");
            sexLabel.Name = "sexLabel";
            // 
            // cityLabel
            // 
            resources.ApplyResources(cityLabel, "cityLabel");
            cityLabel.Name = "cityLabel";
            // 
            // nameLabel
            // 
            resources.ApplyResources(nameLabel, "nameLabel");
            nameLabel.Name = "nameLabel";
            // 
            // birhdayLabel
            // 
            resources.ApplyResources(birhdayLabel, "birhdayLabel");
            birhdayLabel.Name = "birhdayLabel";
            // 
            // surnameLabel
            // 
            resources.ApplyResources(surnameLabel, "surnameLabel");
            surnameLabel.Name = "surnameLabel";
            // 
            // Photo
            // 
            resources.ApplyResources(Photo, "Photo");
            Photo.Name = "Photo";
            Photo.TabStop = false;
            // 
            // profileLabel
            // 
            resources.ApplyResources(profileLabel, "profileLabel");
            profileLabel.Name = "profileLabel";
            // 
            // searchLine
            // 
            resources.ApplyResources(searchLine, "searchLine");
            searchLine.Name = "searchLine";
            searchLine.TextChanged += searchLine_TextChanged;
            // 
            // listUsers
            // 
            resources.ApplyResources(listUsers, "listUsers");
            listUsers.AllowUserToAddRows = false;
            listUsers.BackgroundColor = Color.White;
            listUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            listUsers.Name = "listUsers";
            listUsers.ReadOnly = true;
            listUsers.CellDoubleClick += listUsers_CellDoubleClick;
            // 
            // BtnSize
            // 
            resources.ApplyResources(BtnSize, "BtnSize");
            BtnSize.BackColor = Color.Fuchsia;
            BtnSize.FlatAppearance.BorderSize = 0;
            BtnSize.FlatAppearance.MouseDownBackColor = Color.FromArgb(212, 22, 207);
            BtnSize.FlatAppearance.MouseOverBackColor = Color.FromArgb(249, 158, 246);
            BtnSize.ForeColor = Color.White;
            BtnSize.Name = "BtnSize";
            BtnSize.UseVisualStyleBackColor = false;
            BtnSize.Click += BtnSize_Click;
            // 
            // AdministratorForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(BtnSize);
            Controls.Add(listUsers);
            Controls.Add(searchLine);
            Controls.Add(AdminPanel);
            Controls.Add(usersLabel);
            Controls.Add(label2);
            Controls.Add(girlPhoto);
            Controls.Add(boyPhoto);
            Controls.Add(CollapseButton);
            Controls.Add(CloseButton);
            Controls.Add(entryLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdministratorForm";
            Load += AdministratorForm_Load;
            MouseDown += AdministratorForm_MouseDown;
            MouseMove += AdministratorForm_MouseMove;
            ((System.ComponentModel.ISupportInitialize)girlPhoto).EndInit();
            ((System.ComponentModel.ISupportInitialize)boyPhoto).EndInit();
            AdminPanel.ResumeLayout(false);
            AdminPanel.PerformLayout();
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
        private Panel AdminPanel;
        private Button deleteAccountButton;
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
        private Button BtnSize;
    }
}