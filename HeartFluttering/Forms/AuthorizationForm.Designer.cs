namespace HeartFluttering
{
    partial class AuthorizationForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthorizationForm));
            entryLabel = new Label();
            CloseButton = new Button();
            CollapseButton = new Button();
            label1 = new Label();
            choice = new ComboBox();
            LanguageComboBox = new ComboBox();
            passwondLabel = new Label();
            passwordField = new TextBox();
            loginLabel = new Label();
            loginField = new TextBox();
            loginButton = new Button();
            registrButton = new Button();
            boyPhoto = new PictureBox();
            girlPhoto = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)boyPhoto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)girlPhoto).BeginInit();
            SuspendLayout();
            // 
            // entryLabel
            // 
            resources.ApplyResources(entryLabel, "entryLabel");
            entryLabel.BackColor = Color.Magenta;
            entryLabel.ForeColor = SystemColors.ButtonHighlight;
            entryLabel.Name = "entryLabel";
            // 
            // CloseButton
            // 
            resources.ApplyResources(CloseButton, "CloseButton");
            CloseButton.BackColor = Color.Fuchsia;
            CloseButton.CausesValidation = false;
            CloseButton.FlatAppearance.BorderSize = 0;
            CloseButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(212, 22, 207);
            CloseButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(249, 158, 246);
            CloseButton.ForeColor = Color.White;
            CloseButton.Name = "CloseButton";
            CloseButton.UseVisualStyleBackColor = false;
            CloseButton.Click += CloseButton_Click;
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
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // choice
            // 
            resources.ApplyResources(choice, "choice");
            choice.DropDownStyle = ComboBoxStyle.DropDownList;
            choice.FormattingEnabled = true;
            choice.Items.AddRange(new object[] { resources.GetString("choice.Items"), resources.GetString("choice.Items1") });
            choice.Name = "choice";
            // 
            // LanguageComboBox
            // 
            resources.ApplyResources(LanguageComboBox, "LanguageComboBox");
            LanguageComboBox.BackColor = Color.White;
            LanguageComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            LanguageComboBox.FormattingEnabled = true;
            LanguageComboBox.Items.AddRange(new object[] { resources.GetString("LanguageComboBox.Items"), resources.GetString("LanguageComboBox.Items1") });
            LanguageComboBox.Name = "LanguageComboBox";
            LanguageComboBox.SelectedIndexChanged += LanguageComboBox_SelectedIndexChanged;
            // 
            // passwondLabel
            // 
            resources.ApplyResources(passwondLabel, "passwondLabel");
            passwondLabel.Name = "passwondLabel";
            // 
            // passwordField
            // 
            resources.ApplyResources(passwordField, "passwordField");
            passwordField.Name = "passwordField";
            passwordField.Enter += passwordField_Enter;
            passwordField.Leave += passwordField_Leave;
            // 
            // loginLabel
            // 
            resources.ApplyResources(loginLabel, "loginLabel");
            loginLabel.Name = "loginLabel";
            // 
            // loginField
            // 
            resources.ApplyResources(loginField, "loginField");
            loginField.Name = "loginField";
            loginField.Enter += loginField_Enter;
            loginField.Leave += loginField_Leave;
            // 
            // loginButton
            // 
            resources.ApplyResources(loginButton, "loginButton");
            loginButton.BackColor = Color.Magenta;
            loginButton.FlatAppearance.BorderSize = 0;
            loginButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(212, 22, 207);
            loginButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(249, 158, 246);
            loginButton.ForeColor = Color.White;
            loginButton.Name = "loginButton";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // registrButton
            // 
            resources.ApplyResources(registrButton, "registrButton");
            registrButton.BackColor = Color.Transparent;
            registrButton.FlatAppearance.BorderSize = 0;
            registrButton.ForeColor = Color.Purple;
            registrButton.Name = "registrButton";
            registrButton.UseVisualStyleBackColor = false;
            registrButton.Click += registrButton_Click;
            // 
            // boyPhoto
            // 
            resources.ApplyResources(boyPhoto, "boyPhoto");
            boyPhoto.BackColor = Color.Fuchsia;
            boyPhoto.Name = "boyPhoto";
            boyPhoto.TabStop = false;
            // 
            // girlPhoto
            // 
            resources.ApplyResources(girlPhoto, "girlPhoto");
            girlPhoto.BackColor = Color.Fuchsia;
            girlPhoto.Name = "girlPhoto";
            girlPhoto.TabStop = false;
            // 
            // AuthorizationForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(girlPhoto);
            Controls.Add(boyPhoto);
            Controls.Add(registrButton);
            Controls.Add(loginButton);
            Controls.Add(label1);
            Controls.Add(choice);
            Controls.Add(LanguageComboBox);
            Controls.Add(passwondLabel);
            Controls.Add(passwordField);
            Controls.Add(loginLabel);
            Controls.Add(loginField);
            Controls.Add(CollapseButton);
            Controls.Add(CloseButton);
            Controls.Add(entryLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AuthorizationForm";
            Load += AuthorizationForm_Load;
            ((System.ComponentModel.ISupportInitialize)boyPhoto).EndInit();
            ((System.ComponentModel.ISupportInitialize)girlPhoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label entryLabel;
        private Button CloseButton;
        private Button CollapseButton;
        private Label label1;
        private ComboBox choice;
        private ComboBox LanguageComboBox;
        private Label passwondLabel;
        private TextBox passwordField;
        private Label loginLabel;
        private TextBox loginField;
        private Button loginButton;
        private Button registrButton;
        private PictureBox boyPhoto;
        private PictureBox girlPhoto;
    }
}
