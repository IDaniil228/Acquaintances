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
            // redactionButton
            // 
            resources.ApplyResources(redactionButton, "redactionButton");
            redactionButton.BackColor = Color.Fuchsia;
            redactionButton.FlatAppearance.BorderSize = 0;
            redactionButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(212, 22, 207);
            redactionButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(249, 158, 246);
            redactionButton.ForeColor = Color.White;
            redactionButton.Name = "redactionButton";
            redactionButton.UseVisualStyleBackColor = false;
            redactionButton.Click += redactionButton_Click;
            // 
            // backButton
            // 
            resources.ApplyResources(backButton, "backButton");
            backButton.BackColor = Color.Fuchsia;
            backButton.FlatAppearance.BorderSize = 0;
            backButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(212, 22, 207);
            backButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(249, 158, 246);
            backButton.ForeColor = Color.White;
            backButton.Name = "backButton";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // nameField
            // 
            resources.ApplyResources(nameField, "nameField");
            nameField.BackColor = Color.FromArgb(255, 230, 255);
            nameField.ForeColor = Color.Gray;
            nameField.Name = "nameField";
            nameField.Enter += nameField_Enter;
            nameField.Leave += nameField_Leave;
            // 
            // surnameField
            // 
            resources.ApplyResources(surnameField, "surnameField");
            surnameField.BackColor = Color.FromArgb(255, 230, 255);
            surnameField.ForeColor = Color.Gray;
            surnameField.Name = "surnameField";
            surnameField.Enter += surnameField_Enter;
            surnameField.Leave += surnameField_Leave;
            // 
            // cityField
            // 
            resources.ApplyResources(cityField, "cityField");
            cityField.BackColor = Color.FromArgb(255, 230, 255);
            cityField.ForeColor = Color.Gray;
            cityField.Name = "cityField";
            cityField.Enter += cityField_Enter;
            cityField.Leave += cityField_Leave;
            // 
            // emailField
            // 
            resources.ApplyResources(emailField, "emailField");
            emailField.BackColor = Color.FromArgb(255, 230, 255);
            emailField.ForeColor = Color.Gray;
            emailField.Name = "emailField";
            emailField.Enter += emailField_Enter;
            emailField.Leave += emailField_Leave;
            // 
            // numberField
            // 
            resources.ApplyResources(numberField, "numberField");
            numberField.BackColor = Color.FromArgb(255, 230, 255);
            numberField.ForeColor = Color.Gray;
            numberField.Name = "numberField";
            numberField.Enter += numberField_Enter;
            numberField.Leave += numberField_Leave;
            // 
            // birhdayField
            // 
            resources.ApplyResources(birhdayField, "birhdayField");
            birhdayField.CalendarMonthBackground = Color.White;
            birhdayField.CalendarTitleBackColor = Color.FromArgb(128, 255, 255);
            birhdayField.Name = "birhdayField";
            // 
            // sexMenButton
            // 
            resources.ApplyResources(sexMenButton, "sexMenButton");
            sexMenButton.BackColor = Color.FromArgb(255, 230, 255);
            sexMenButton.Name = "sexMenButton";
            sexMenButton.TabStop = true;
            sexMenButton.UseVisualStyleBackColor = false;
            // 
            // sexWomenButton
            // 
            resources.ApplyResources(sexWomenButton, "sexWomenButton");
            sexWomenButton.BackColor = Color.FromArgb(255, 230, 255);
            sexWomenButton.Name = "sexWomenButton";
            sexWomenButton.TabStop = true;
            sexWomenButton.UseVisualStyleBackColor = false;
            // 
            // EditingForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
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
            MouseDown += EditingForm_MouseDown;
            MouseMove += EditingForm_MouseMove;
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