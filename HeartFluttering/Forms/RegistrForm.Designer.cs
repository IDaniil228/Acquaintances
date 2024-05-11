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
            loginButton = new Button();
            BtnSize = new Button();
            panel1 = new Panel();
            loginLabel = new Label();
            LoginField = new TextBox();
            passwordLabel2 = new Label();
            password2Field = new TextBox();
            passwordLabel = new Label();
            passwordField = new TextBox();
            panel2 = new Panel();
            BirhdayFields = new DateTimePicker();
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
            ((System.ComponentModel.ISupportInitialize)girlPhoto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)boyPhoto).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
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
            // panel1
            // 
            resources.ApplyResources(panel1, "panel1");
            panel1.Controls.Add(loginLabel);
            panel1.Controls.Add(LoginField);
            panel1.Controls.Add(passwordLabel2);
            panel1.Controls.Add(password2Field);
            panel1.Controls.Add(passwordLabel);
            panel1.Controls.Add(passwordField);
            panel1.Name = "panel1";
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
            // panel2
            // 
            resources.ApplyResources(panel2, "panel2");
            panel2.Controls.Add(BirhdayFields);
            panel2.Controls.Add(sexWomenButton);
            panel2.Controls.Add(sexMenButton);
            panel2.Controls.Add(sexLabel);
            panel2.Controls.Add(cityField);
            panel2.Controls.Add(cityLabel);
            panel2.Controls.Add(nameLabel);
            panel2.Controls.Add(nameField);
            panel2.Controls.Add(BirhdayLabel);
            panel2.Controls.Add(surnameLabel);
            panel2.Controls.Add(surnameField);
            panel2.Name = "panel2";
            // 
            // BirhdayFields
            // 
            resources.ApplyResources(BirhdayFields, "BirhdayFields");
            BirhdayFields.Name = "BirhdayFields";
            BirhdayFields.Enter += BirhdayFields_Enter;
            BirhdayFields.Leave += BirhdayFields_Leave;
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
            // RegistrForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(loginButton);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(BtnSize);
            Controls.Add(girlPhoto);
            Controls.Add(boyPhoto);
            Controls.Add(CollapseButton);
            Controls.Add(CloseButton);
            Controls.Add(entryLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegistrForm";
            FormClosed += RegistrForm_FormClosed;
            MouseDown += RegistrForm_MouseDown;
            MouseMove += RegistrForm_MouseMove;
            ((System.ComponentModel.ISupportInitialize)girlPhoto).EndInit();
            ((System.ComponentModel.ISupportInitialize)boyPhoto).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox girlPhoto;
        private PictureBox boyPhoto;
        private Button CollapseButton;
        private Button CloseButton;
        private Label entryLabel;
        private Button loginButton;
        private Button BtnSize;
        private Panel panel1;
        private Label loginLabel;
        private TextBox LoginField;
        private Label passwordLabel2;
        private TextBox password2Field;
        private Label passwordLabel;
        private TextBox passwordField;
        private Panel panel2;
        public DateTimePicker BirhdayFields;
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
    }
}