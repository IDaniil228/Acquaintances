namespace HeartFluttering
{
    partial class PhotoUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhotoUserForm));
            photoField = new PictureBox();
            PanelInfo = new Panel();
            BirhdayField = new Label();
            BirhdayLabel = new Label();
            nameField = new Label();
            nameLabel = new Label();
            FunctionalPanel = new Panel();
            likeAccount = new PictureBox();
            startButton = new Button();
            homeButton = new Button();
            changeFiltersButton = new Button();
            nextAccount = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)photoField).BeginInit();
            PanelInfo.SuspendLayout();
            FunctionalPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)likeAccount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nextAccount).BeginInit();
            SuspendLayout();
            // 
            // photoField
            // 
            resources.ApplyResources(photoField, "photoField");
            photoField.Name = "photoField";
            photoField.TabStop = false;
            photoField.MouseDown += photoField_MouseDown;
            photoField.MouseMove += photoField_MouseMove;
            // 
            // PanelInfo
            // 
            resources.ApplyResources(PanelInfo, "PanelInfo");
            PanelInfo.BackColor = Color.White;
            PanelInfo.Controls.Add(BirhdayField);
            PanelInfo.Controls.Add(BirhdayLabel);
            PanelInfo.Controls.Add(nameField);
            PanelInfo.Controls.Add(nameLabel);
            PanelInfo.Name = "PanelInfo";
            PanelInfo.MouseDown += PanelInfo_MouseDown;
            PanelInfo.MouseMove += PanelInfo_MouseMove;
            // 
            // BirhdayField
            // 
            resources.ApplyResources(BirhdayField, "BirhdayField");
            BirhdayField.BackColor = Color.FromArgb(255, 230, 255);
            BirhdayField.ForeColor = Color.Black;
            BirhdayField.Name = "BirhdayField";
            // 
            // BirhdayLabel
            // 
            resources.ApplyResources(BirhdayLabel, "BirhdayLabel");
            BirhdayLabel.Name = "BirhdayLabel";
            // 
            // nameField
            // 
            resources.ApplyResources(nameField, "nameField");
            nameField.BackColor = Color.FromArgb(255, 230, 255);
            nameField.ForeColor = Color.Black;
            nameField.Name = "nameField";
            // 
            // nameLabel
            // 
            resources.ApplyResources(nameLabel, "nameLabel");
            nameLabel.Name = "nameLabel";
            // 
            // FunctionalPanel
            // 
            resources.ApplyResources(FunctionalPanel, "FunctionalPanel");
            FunctionalPanel.Controls.Add(likeAccount);
            FunctionalPanel.Controls.Add(startButton);
            FunctionalPanel.Controls.Add(homeButton);
            FunctionalPanel.Controls.Add(changeFiltersButton);
            FunctionalPanel.Controls.Add(nextAccount);
            FunctionalPanel.Name = "FunctionalPanel";
            FunctionalPanel.MouseDown += FunctionalPanel_MouseDown;
            FunctionalPanel.MouseMove += FunctionalPanel_MouseMove;
            // 
            // likeAccount
            // 
            resources.ApplyResources(likeAccount, "likeAccount");
            likeAccount.Name = "likeAccount";
            likeAccount.TabStop = false;
            likeAccount.Click += likeAccount_Click;
            // 
            // startButton
            // 
            resources.ApplyResources(startButton, "startButton");
            startButton.BackColor = Color.Fuchsia;
            startButton.FlatAppearance.BorderSize = 0;
            startButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(212, 22, 207);
            startButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(249, 158, 246);
            startButton.ForeColor = Color.White;
            startButton.Name = "startButton";
            startButton.UseVisualStyleBackColor = false;
            startButton.Click += startButton_Click;
            // 
            // homeButton
            // 
            resources.ApplyResources(homeButton, "homeButton");
            homeButton.BackColor = Color.Fuchsia;
            homeButton.FlatAppearance.BorderSize = 0;
            homeButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(212, 22, 207);
            homeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(249, 158, 246);
            homeButton.ForeColor = Color.White;
            homeButton.Name = "homeButton";
            homeButton.UseVisualStyleBackColor = false;
            homeButton.Click += homeButton_Click;
            // 
            // changeFiltersButton
            // 
            resources.ApplyResources(changeFiltersButton, "changeFiltersButton");
            changeFiltersButton.BackColor = Color.Fuchsia;
            changeFiltersButton.FlatAppearance.BorderSize = 0;
            changeFiltersButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(212, 22, 207);
            changeFiltersButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(249, 158, 246);
            changeFiltersButton.ForeColor = Color.White;
            changeFiltersButton.Name = "changeFiltersButton";
            changeFiltersButton.UseVisualStyleBackColor = false;
            changeFiltersButton.Click += changeFiltersButton_Click;
            // 
            // nextAccount
            // 
            resources.ApplyResources(nextAccount, "nextAccount");
            nextAccount.Name = "nextAccount";
            nextAccount.TabStop = false;
            nextAccount.Click += nextAccount_Click;
            // 
            // PhotoUserForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(FunctionalPanel);
            Controls.Add(PanelInfo);
            Controls.Add(photoField);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PhotoUserForm";
            ((System.ComponentModel.ISupportInitialize)photoField).EndInit();
            PanelInfo.ResumeLayout(false);
            PanelInfo.PerformLayout();
            FunctionalPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)likeAccount).EndInit();
            ((System.ComponentModel.ISupportInitialize)nextAccount).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox photoField;
        private Panel PanelInfo;
        private Label BirhdayField;
        private Label BirhdayLabel;
        private Label nameField;
        private Label nameLabel;
        private Panel FunctionalPanel;
        private Button homeButton;
        private Button changeFiltersButton;
        private PictureBox nextAccount;
        private Button startButton;
        public PictureBox likeAccount;
    }
}