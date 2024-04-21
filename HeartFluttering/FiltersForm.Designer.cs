namespace HeartFluttering
{
    partial class FiltersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FiltersForm));
            girlPhoto = new PictureBox();
            boyPhoto = new PictureBox();
            CollapseButton = new Button();
            CloseButton = new Button();
            entryLabel = new Label();
            panel1 = new Panel();
            FiltersButton = new Button();
            FinalAgeField = new TextBox();
            label4 = new Label();
            label1 = new Label();
            sexWomenButton = new RadioButton();
            sexMenButton = new RadioButton();
            label3 = new Label();
            cityField = new TextBox();
            label2 = new Label();
            passwondLabel = new Label();
            InitialAgeField = new TextBox();
            ((System.ComponentModel.ISupportInitialize)girlPhoto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)boyPhoto).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // girlPhoto
            // 
            girlPhoto.BackColor = Color.Fuchsia;
            girlPhoto.Image = (Image)resources.GetObject("girlPhoto.Image");
            girlPhoto.Location = new Point(340, 21);
            girlPhoto.Name = "girlPhoto";
            girlPhoto.Size = new Size(63, 58);
            girlPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            girlPhoto.TabIndex = 45;
            girlPhoto.TabStop = false;
            // 
            // boyPhoto
            // 
            boyPhoto.BackColor = Color.Fuchsia;
            boyPhoto.Image = (Image)resources.GetObject("boyPhoto.Image");
            boyPhoto.Location = new Point(60, 21);
            boyPhoto.Name = "boyPhoto";
            boyPhoto.Size = new Size(63, 58);
            boyPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            boyPhoto.TabIndex = 44;
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
            CollapseButton.Location = new Point(405, 0);
            CollapseButton.Name = "CollapseButton";
            CollapseButton.Size = new Size(35, 23);
            CollapseButton.TabIndex = 43;
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
            CloseButton.Location = new Point(437, 0);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(35, 23);
            CloseButton.TabIndex = 42;
            CloseButton.Text = "X";
            CloseButton.UseVisualStyleBackColor = false;
            CloseButton.Click += CloseButton_Click;
            // 
            // entryLabel
            // 
            entryLabel.BackColor = Color.Magenta;
            entryLabel.Dock = DockStyle.Top;
            entryLabel.Font = new Font("Segoe Print", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            entryLabel.ForeColor = SystemColors.ButtonHighlight;
            entryLabel.Location = new Point(0, 0);
            entryLabel.Name = "entryLabel";
            entryLabel.Size = new Size(472, 98);
            entryLabel.TabIndex = 41;
            entryLabel.Text = "Фильтры";
            entryLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(FiltersButton);
            panel1.Controls.Add(FinalAgeField);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(sexWomenButton);
            panel1.Controls.Add(sexMenButton);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(cityField);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(passwondLabel);
            panel1.Controls.Add(InitialAgeField);
            panel1.Location = new Point(0, 91);
            panel1.Name = "panel1";
            panel1.Size = new Size(472, 320);
            panel1.TabIndex = 46;
            // 
            // FiltersButton
            // 
            FiltersButton.BackColor = Color.Fuchsia;
            FiltersButton.BackgroundImageLayout = ImageLayout.None;
            FiltersButton.FlatAppearance.BorderSize = 0;
            FiltersButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            FiltersButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            FiltersButton.FlatStyle = FlatStyle.Flat;
            FiltersButton.Font = new Font("Segoe Print", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FiltersButton.ForeColor = Color.White;
            FiltersButton.Location = new Point(105, 268);
            FiltersButton.Name = "FiltersButton";
            FiltersButton.Size = new Size(255, 49);
            FiltersButton.TabIndex = 75;
            FiltersButton.Text = "Установить";
            FiltersButton.UseVisualStyleBackColor = false;
            FiltersButton.Click += FiltersButton_Click;
            // 
            // FinalAgeField
            // 
            FinalAgeField.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FinalAgeField.Location = new Point(292, 64);
            FinalAgeField.Name = "FinalAgeField";
            FinalAgeField.Size = new Size(85, 29);
            FinalAgeField.TabIndex = 74;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(240, 64);
            label4.Name = "label4";
            label4.Size = new Size(35, 24);
            label4.TabIndex = 73;
            label4.Text = "До";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(90, 64);
            label1.Name = "label1";
            label1.Size = new Size(35, 24);
            label1.TabIndex = 72;
            label1.Text = "От";
            // 
            // sexWomenButton
            // 
            sexWomenButton.AutoSize = true;
            sexWomenButton.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            sexWomenButton.Location = new Point(302, 208);
            sexWomenButton.Name = "sexWomenButton";
            sexWomenButton.Size = new Size(47, 27);
            sexWomenButton.TabIndex = 71;
            sexWomenButton.TabStop = true;
            sexWomenButton.Text = "Ж";
            sexWomenButton.UseVisualStyleBackColor = true;
            // 
            // sexMenButton
            // 
            sexMenButton.AutoSize = true;
            sexMenButton.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            sexMenButton.Location = new Point(240, 208);
            sexMenButton.Name = "sexMenButton";
            sexMenButton.Size = new Size(46, 27);
            sexMenButton.TabIndex = 70;
            sexMenButton.TabStop = true;
            sexMenButton.Text = "M";
            sexMenButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(90, 208);
            label3.Name = "label3";
            label3.Size = new Size(144, 24);
            label3.TabIndex = 69;
            label3.Text = "Выберите пол";
            // 
            // cityField
            // 
            cityField.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cityField.Location = new Point(90, 150);
            cityField.Name = "cityField";
            cityField.Size = new Size(297, 29);
            cityField.TabIndex = 68;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(90, 107);
            label2.Name = "label2";
            label2.Size = new Size(64, 24);
            label2.TabIndex = 67;
            label2.Text = "Город";
            // 
            // passwondLabel
            // 
            passwondLabel.AutoSize = true;
            passwondLabel.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            passwondLabel.Location = new Point(90, 24);
            passwondLabel.Name = "passwondLabel";
            passwondLabel.Size = new Size(85, 24);
            passwondLabel.TabIndex = 66;
            passwondLabel.Text = "Возраст";
            // 
            // InitialAgeField
            // 
            InitialAgeField.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            InitialAgeField.Location = new Point(136, 64);
            InitialAgeField.Name = "InitialAgeField";
            InitialAgeField.Size = new Size(85, 29);
            InitialAgeField.TabIndex = 65;
            // 
            // FiltersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(472, 411);
            Controls.Add(panel1);
            Controls.Add(girlPhoto);
            Controls.Add(boyPhoto);
            Controls.Add(CollapseButton);
            Controls.Add(CloseButton);
            Controls.Add(entryLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FiltersForm";
            Text = "FiltersForm";
            Load += FiltersForm_Load;
            ((System.ComponentModel.ISupportInitialize)girlPhoto).EndInit();
            ((System.ComponentModel.ISupportInitialize)boyPhoto).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox girlPhoto;
        private PictureBox boyPhoto;
        private Button CollapseButton;
        private Button CloseButton;
        private Label entryLabel;
        private Panel panel1;
        private Button FiltersButton;
        private TextBox FinalAgeField;
        private Label label4;
        private Label label1;
        private RadioButton sexWomenButton;
        private RadioButton sexMenButton;
        private Label label3;
        private TextBox cityField;
        private Label label2;
        private Label passwondLabel;
        private TextBox InitialAgeField;
    }
}