namespace HeartFluttering.Forms
{
    partial class VkForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VkForm));
            passwondLabel = new Label();
            passwordField = new TextBox();
            loginLabel = new Label();
            loginField = new TextBox();
            loginButton = new Button();
            BntSIngIn = new Button();
            ShowPassword = new CheckBox();
            SuspendLayout();
            // 
            // passwondLabel
            // 
            resources.ApplyResources(passwondLabel, "passwondLabel");
            passwondLabel.Name = "passwondLabel";
            // 
            // passwordField
            // 
            resources.ApplyResources(passwordField, "passwordField");
            passwordField.ForeColor = Color.Black;
            passwordField.Name = "passwordField";
            passwordField.UseSystemPasswordChar = true;
            // 
            // loginLabel
            // 
            resources.ApplyResources(loginLabel, "loginLabel");
            loginLabel.Name = "loginLabel";
            // 
            // loginField
            // 
            resources.ApplyResources(loginField, "loginField");
            loginField.ForeColor = Color.Black;
            loginField.Name = "loginField";
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
            // BntSIngIn
            // 
            resources.ApplyResources(BntSIngIn, "BntSIngIn");
            BntSIngIn.BackColor = Color.Magenta;
            BntSIngIn.FlatAppearance.BorderSize = 0;
            BntSIngIn.FlatAppearance.MouseDownBackColor = Color.FromArgb(212, 22, 207);
            BntSIngIn.FlatAppearance.MouseOverBackColor = Color.FromArgb(249, 158, 246);
            BntSIngIn.ForeColor = Color.White;
            BntSIngIn.Name = "BntSIngIn";
            BntSIngIn.UseVisualStyleBackColor = false;
            BntSIngIn.Click += BntSIngIn_Click;
            // 
            // ShowPassword
            // 
            resources.ApplyResources(ShowPassword, "ShowPassword");
            ShowPassword.Name = "ShowPassword";
            ShowPassword.UseVisualStyleBackColor = true;
            ShowPassword.CheckedChanged += ShowPassword_CheckedChanged;
            // 
            // VkForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(ShowPassword);
            Controls.Add(BntSIngIn);
            Controls.Add(loginButton);
            Controls.Add(passwondLabel);
            Controls.Add(passwordField);
            Controls.Add(loginLabel);
            Controls.Add(loginField);
            FormBorderStyle = FormBorderStyle.None;
            Name = "VkForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label passwondLabel;
        private TextBox passwordField;
        private Label loginLabel;
        private TextBox loginField;
        private Button loginButton;
        private Button BntSIngIn;
        private CheckBox ShowPassword;
    }
}