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
            Photo = new PictureBox();
            panel1 = new Panel();
            BirhdayField = new Label();
            BirhdayLabel = new Label();
            nameField = new Label();
            nameLabel = new Label();
            panel2 = new Panel();
            homeButton = new Button();
            changeFiltersButton = new Button();
            nextAccount = new PictureBox();
            likeAccount = new PictureBox();
            startButton = new Button();
            ((System.ComponentModel.ISupportInitialize)Photo).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nextAccount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)likeAccount).BeginInit();
            SuspendLayout();
            // 
            // Photo
            // 
            Photo.Image = (Image)resources.GetObject("Photo.Image");
            Photo.Location = new Point(1, 1);
            Photo.Name = "Photo";
            Photo.Size = new Size(411, 299);
            Photo.SizeMode = PictureBoxSizeMode.StretchImage;
            Photo.TabIndex = 73;
            Photo.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(BirhdayField);
            panel1.Controls.Add(BirhdayLabel);
            panel1.Controls.Add(nameField);
            panel1.Controls.Add(nameLabel);
            panel1.Location = new Point(1, 300);
            panel1.Name = "panel1";
            panel1.Size = new Size(411, 100);
            panel1.TabIndex = 74;
            // 
            // BirhdayField
            // 
            BirhdayField.BackColor = Color.FromArgb(255, 230, 255);
            BirhdayField.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            BirhdayField.ForeColor = Color.Black;
            BirhdayField.Location = new Point(130, 60);
            BirhdayField.Name = "BirhdayField";
            BirhdayField.Size = new Size(235, 24);
            BirhdayField.TabIndex = 49;
            // 
            // BirhdayLabel
            // 
            BirhdayLabel.AutoSize = true;
            BirhdayLabel.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            BirhdayLabel.Location = new Point(12, 58);
            BirhdayLabel.Name = "BirhdayLabel";
            BirhdayLabel.Size = new Size(103, 26);
            BirhdayLabel.TabIndex = 48;
            BirhdayLabel.Text = "Возраст ";
            // 
            // nameField
            // 
            nameField.BackColor = Color.FromArgb(255, 230, 255);
            nameField.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            nameField.ForeColor = Color.Black;
            nameField.Location = new Point(130, 19);
            nameField.Name = "nameField";
            nameField.Size = new Size(235, 24);
            nameField.TabIndex = 47;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            nameLabel.Location = new Point(33, 17);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(60, 26);
            nameLabel.TabIndex = 46;
            nameLabel.Text = "Имя";
            // 
            // panel2
            // 
            panel2.Controls.Add(startButton);
            panel2.Controls.Add(homeButton);
            panel2.Controls.Add(changeFiltersButton);
            panel2.Controls.Add(nextAccount);
            panel2.Controls.Add(likeAccount);
            panel2.Location = new Point(1, 402);
            panel2.Name = "panel2";
            panel2.Size = new Size(411, 122);
            panel2.TabIndex = 75;
            // 
            // homeButton
            // 
            homeButton.BackColor = Color.Fuchsia;
            homeButton.BackgroundImageLayout = ImageLayout.None;
            homeButton.FlatAppearance.BorderSize = 0;
            homeButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            homeButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            homeButton.FlatStyle = FlatStyle.Flat;
            homeButton.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            homeButton.ForeColor = Color.White;
            homeButton.Location = new Point(130, 88);
            homeButton.Name = "homeButton";
            homeButton.Size = new Size(144, 31);
            homeButton.TabIndex = 6;
            homeButton.Text = "Мой профиль";
            homeButton.UseVisualStyleBackColor = false;
            // 
            // changeFiltersButton
            // 
            changeFiltersButton.BackColor = Color.Fuchsia;
            changeFiltersButton.BackgroundImageLayout = ImageLayout.None;
            changeFiltersButton.FlatAppearance.BorderSize = 0;
            changeFiltersButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            changeFiltersButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            changeFiltersButton.FlatStyle = FlatStyle.Flat;
            changeFiltersButton.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            changeFiltersButton.ForeColor = Color.White;
            changeFiltersButton.Location = new Point(101, 47);
            changeFiltersButton.Name = "changeFiltersButton";
            changeFiltersButton.Size = new Size(200, 35);
            changeFiltersButton.TabIndex = 5;
            changeFiltersButton.Text = "Изменить фильтры";
            changeFiltersButton.UseVisualStyleBackColor = false;
            // 
            // nextAccount
            // 
            nextAccount.Image = (Image)resources.GetObject("nextAccount.Image");
            nextAccount.Location = new Point(307, 28);
            nextAccount.Name = "nextAccount";
            nextAccount.Size = new Size(98, 72);
            nextAccount.SizeMode = PictureBoxSizeMode.StretchImage;
            nextAccount.TabIndex = 4;
            nextAccount.TabStop = false;
            nextAccount.Visible = false;
            // 
            // likeAccount
            // 
            likeAccount.Image = (Image)resources.GetObject("likeAccount.Image");
            likeAccount.Location = new Point(12, 28);
            likeAccount.Name = "likeAccount";
            likeAccount.Size = new Size(87, 72);
            likeAccount.SizeMode = PictureBoxSizeMode.StretchImage;
            likeAccount.TabIndex = 3;
            likeAccount.TabStop = false;
            likeAccount.Visible = false;
            // 
            // startButton
            // 
            startButton.BackColor = Color.Fuchsia;
            startButton.BackgroundImageLayout = ImageLayout.None;
            startButton.FlatAppearance.BorderSize = 0;
            startButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            startButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            startButton.FlatStyle = FlatStyle.Flat;
            startButton.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            startButton.ForeColor = Color.White;
            startButton.Location = new Point(152, 10);
            startButton.Name = "startButton";
            startButton.Size = new Size(98, 31);
            startButton.TabIndex = 7;
            startButton.Text = "Начать";
            startButton.UseVisualStyleBackColor = false;
            // 
            // PhotoUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(414, 525);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(Photo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PhotoUserForm";
            Text = "PhotoUserForm";
            ((System.ComponentModel.ISupportInitialize)Photo).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nextAccount).EndInit();
            ((System.ComponentModel.ISupportInitialize)likeAccount).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox Photo;
        private Panel panel1;
        private Label BirhdayField;
        private Label BirhdayLabel;
        private Label nameField;
        private Label nameLabel;
        private Panel panel2;
        private Button homeButton;
        private Button changeFiltersButton;
        private PictureBox nextAccount;
        private PictureBox likeAccount;
        private Button startButton;
    }
}