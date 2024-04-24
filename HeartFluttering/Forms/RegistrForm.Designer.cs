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
            resources.ApplyResources(girlPhoto, "girlPhoto");
            girlPhoto.BackColor = Color.Fuchsia;
            girlPhoto.Name = "girlPhoto";
            girlPhoto.TabStop = false;
            // 
            // boyPhoto
            // 
            resources.ApplyResources(boyPhoto, "boyPhoto");
            boyPhoto.BackColor = Color.Fuchsia;
            boyPhoto.Name = "boyPhoto";
            boyPhoto.TabStop = false;
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
            // 
            // loginLabel
            // 
            resources.ApplyResources(loginLabel, "loginLabel");
            loginLabel.Name = "loginLabel";
            // 
            // LoginField
            // 
            resources.ApplyResources(LoginField, "LoginField");
            LoginField.ForeColor = Color.Gray;
            LoginField.Name = "LoginField";
            LoginField.Enter += LoginField_Enter;
            LoginField.Leave += LoginField_Leave;
            // 
            // passwordLabel2
            // 
            resources.ApplyResources(passwordLabel2, "passwordLabel2");
            passwordLabel2.Name = "passwordLabel2";
            // 
            // password2Field
            // 
            resources.ApplyResources(password2Field, "password2Field");
            password2Field.ForeColor = Color.Gray;
            password2Field.Name = "password2Field";
            password2Field.Enter += password2Field_Enter;
            password2Field.Leave += password2Field_Leave;
            // 
            // passwordLabel
            // 
            resources.ApplyResources(passwordLabel, "passwordLabel");
            passwordLabel.Name = "passwordLabel";
            // 
            // passwordField
            // 
            resources.ApplyResources(passwordField, "passwordField");
            passwordField.ForeColor = Color.Gray;
            passwordField.Name = "passwordField";
            passwordField.Enter += passwordField_Enter;
            passwordField.Leave += passwordField_Leave;
            // 
            // loginButton
            // 
            resources.ApplyResources(loginButton, "loginButton");
            loginButton.BackColor = Color.Fuchsia;
            loginButton.FlatAppearance.BorderSize = 0;
            loginButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(212, 22, 207);
            loginButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(249, 158, 246);
            loginButton.ForeColor = Color.White;
            loginButton.Name = "loginButton";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // sexWomenButton
            // 
            resources.ApplyResources(sexWomenButton, "sexWomenButton");
            sexWomenButton.Name = "sexWomenButton";
            sexWomenButton.TabStop = true;
            sexWomenButton.UseVisualStyleBackColor = true;
            // 
            // sexMenButton
            // 
            resources.ApplyResources(sexMenButton, "sexMenButton");
            sexMenButton.Name = "sexMenButton";
            sexMenButton.TabStop = true;
            sexMenButton.UseVisualStyleBackColor = true;
            // 
            // sexLabel
            // 
            resources.ApplyResources(sexLabel, "sexLabel");
            sexLabel.Name = "sexLabel";
            // 
            // cityField
            // 
            resources.ApplyResources(cityField, "cityField");
            cityField.ForeColor = Color.Gray;
            cityField.Name = "cityField";
            cityField.Enter += cityField_Enter;
            cityField.Leave += cityField_Leave;
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
            // nameField
            // 
            resources.ApplyResources(nameField, "nameField");
            nameField.ForeColor = Color.Gray;
            nameField.Name = "nameField";
            nameField.Enter += nameField_Enter;
            nameField.Leave += nameField_Leave;
            // 
            // BirhdayLabel
            // 
            resources.ApplyResources(BirhdayLabel, "BirhdayLabel");
            BirhdayLabel.Name = "BirhdayLabel";
            // 
            // surnameLabel
            // 
            resources.ApplyResources(surnameLabel, "surnameLabel");
            surnameLabel.Name = "surnameLabel";
            // 
            // surnameField
            // 
            resources.ApplyResources(surnameField, "surnameField");
            surnameField.ForeColor = Color.Gray;
            surnameField.Name = "surnameField";
            surnameField.Enter += surnameField_Enter;
            surnameField.Leave += surnameField_Leave;
            // 
            // BirhdayFields
            // 
            resources.ApplyResources(BirhdayFields, "BirhdayFields");
            BirhdayFields.Name = "BirhdayFields";
            // 
            // RegistrForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
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