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
            likeAccount = new PictureBox();
            nextAccount = new PictureBox();
            button1 = new Button();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)Photo).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)likeAccount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nextAccount).BeginInit();
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
            BirhdayField.ForeColor = Color.Gray;
            BirhdayField.Location = new Point(130, 60);
            BirhdayField.Name = "BirhdayField";
            BirhdayField.Size = new Size(235, 24);
            BirhdayField.TabIndex = 49;
            BirhdayField.Text = "Возраст";
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
            nameField.ForeColor = Color.Gray;
            nameField.Location = new Point(130, 19);
            nameField.Name = "nameField";
            nameField.Size = new Size(235, 24);
            nameField.TabIndex = 47;
            nameField.Text = "Имя";
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
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(nextAccount);
            panel2.Controls.Add(likeAccount);
            panel2.Location = new Point(1, 402);
            panel2.Name = "panel2";
            panel2.Size = new Size(411, 93);
            panel2.TabIndex = 75;
            // 
            // likeAccount
            // 
            likeAccount.Image = (Image)resources.GetObject("likeAccount.Image");
            likeAccount.Location = new Point(12, 9);
            likeAccount.Name = "likeAccount";
            likeAccount.Size = new Size(87, 72);
            likeAccount.SizeMode = PictureBoxSizeMode.StretchImage;
            likeAccount.TabIndex = 3;
            likeAccount.TabStop = false;
            // 
            // nextAccount
            // 
            nextAccount.Image = (Image)resources.GetObject("nextAccount.Image");
            nextAccount.Location = new Point(303, 9);
            nextAccount.Name = "nextAccount";
            nextAccount.Size = new Size(98, 72);
            nextAccount.SizeMode = PictureBoxSizeMode.StretchImage;
            nextAccount.TabIndex = 4;
            nextAccount.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Fuchsia;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.ForeColor = Color.White;
            button1.Location = new Point(101, 9);
            button1.Name = "button1";
            button1.Size = new Size(200, 35);
            button1.TabIndex = 5;
            button1.Text = "Изменить фильтры";
            button1.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.Fuchsia;
            button5.BackgroundImageLayout = ImageLayout.None;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button5.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button5.ForeColor = Color.White;
            button5.Location = new Point(152, 50);
            button5.Name = "button5";
            button5.Size = new Size(98, 31);
            button5.TabIndex = 6;
            button5.Text = "Назад";
            button5.UseVisualStyleBackColor = false;
            // 
            // PhotoUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(414, 495);
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
            ((System.ComponentModel.ISupportInitialize)likeAccount).EndInit();
            ((System.ComponentModel.ISupportInitialize)nextAccount).EndInit();
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
        private Button button5;
        private Button button1;
        private PictureBox nextAccount;
        private PictureBox likeAccount;
    }
}