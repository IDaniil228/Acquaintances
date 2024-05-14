namespace HeartFluttering.Forms
{
    partial class GeneralForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeneralForm));
            entryLabel = new Label();
            BtnSize = new Button();
            boyPhoto = new PictureBox();
            CollapseButton = new Button();
            CloseButton = new Button();
            GeneralDataGridView = new DataGridView();
            Name_1 = new DataGridViewTextBoxColumn();
            Age_1 = new DataGridViewTextBoxColumn();
            Сoincidences = new DataGridViewTextBoxColumn();
            backButton = new Button();
            ((System.ComponentModel.ISupportInitialize)boyPhoto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GeneralDataGridView).BeginInit();
            SuspendLayout();
            // 
            // entryLabel
            // 
            entryLabel.BackColor = Color.Magenta;
            entryLabel.Dock = DockStyle.Top;
            entryLabel.Font = new Font("Segoe Print", 36F);
            entryLabel.ForeColor = SystemColors.ButtonHighlight;
            entryLabel.ImeMode = ImeMode.NoControl;
            entryLabel.Location = new Point(0, 0);
            entryLabel.Name = "entryLabel";
            entryLabel.Size = new Size(490, 120);
            entryLabel.TabIndex = 37;
            entryLabel.Text = "Общее";
            entryLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BtnSize
            // 
            BtnSize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSize.BackColor = Color.Fuchsia;
            BtnSize.FlatAppearance.BorderSize = 0;
            BtnSize.FlatAppearance.MouseDownBackColor = Color.FromArgb(212, 22, 207);
            BtnSize.FlatAppearance.MouseOverBackColor = Color.FromArgb(249, 158, 246);
            BtnSize.FlatStyle = FlatStyle.Flat;
            BtnSize.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            BtnSize.ForeColor = Color.White;
            BtnSize.ImeMode = ImeMode.NoControl;
            BtnSize.Location = new Point(426, -1);
            BtnSize.Margin = new Padding(3, 4, 3, 4);
            BtnSize.Name = "BtnSize";
            BtnSize.Size = new Size(25, 34);
            BtnSize.TabIndex = 54;
            BtnSize.Text = "▭";
            BtnSize.UseVisualStyleBackColor = false;
            BtnSize.Click += BtnSize_Click;
            // 
            // boyPhoto
            // 
            boyPhoto.BackColor = Color.Fuchsia;
            boyPhoto.Image = (Image)resources.GetObject("boyPhoto.Image");
            boyPhoto.ImeMode = ImeMode.NoControl;
            boyPhoto.Location = new Point(-259, 32);
            boyPhoto.Margin = new Padding(3, 4, 3, 4);
            boyPhoto.Name = "boyPhoto";
            boyPhoto.Size = new Size(86, 92);
            boyPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            boyPhoto.TabIndex = 52;
            boyPhoto.TabStop = false;
            // 
            // CollapseButton
            // 
            CollapseButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CollapseButton.BackColor = Color.Fuchsia;
            CollapseButton.FlatAppearance.BorderSize = 0;
            CollapseButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(212, 22, 207);
            CollapseButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(249, 158, 246);
            CollapseButton.FlatStyle = FlatStyle.Flat;
            CollapseButton.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            CollapseButton.ForeColor = Color.White;
            CollapseButton.ImeMode = ImeMode.NoControl;
            CollapseButton.Location = new Point(395, 4);
            CollapseButton.Margin = new Padding(3, 4, 3, 4);
            CollapseButton.Name = "CollapseButton";
            CollapseButton.Size = new Size(25, 31);
            CollapseButton.TabIndex = 51;
            CollapseButton.Text = "—";
            CollapseButton.UseVisualStyleBackColor = false;
            CollapseButton.Click += CollapseButton_Click;
            // 
            // CloseButton
            // 
            CloseButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CloseButton.BackColor = Color.Fuchsia;
            CloseButton.FlatAppearance.BorderSize = 0;
            CloseButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(212, 22, 207);
            CloseButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(249, 158, 246);
            CloseButton.FlatStyle = FlatStyle.Flat;
            CloseButton.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            CloseButton.ForeColor = Color.White;
            CloseButton.ImeMode = ImeMode.NoControl;
            CloseButton.Location = new Point(450, 4);
            CloseButton.Margin = new Padding(3, 4, 3, 4);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(40, 31);
            CloseButton.TabIndex = 50;
            CloseButton.Text = "X";
            CloseButton.UseVisualStyleBackColor = false;
            CloseButton.Click += CloseButton_Click;
            // 
            // GeneralDataGridView
            // 
            GeneralDataGridView.AllowUserToAddRows = false;
            GeneralDataGridView.BackgroundColor = Color.White;
            GeneralDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GeneralDataGridView.Columns.AddRange(new DataGridViewColumn[] { Name_1, Age_1, Сoincidences });
            GeneralDataGridView.Dock = DockStyle.Top;
            GeneralDataGridView.Location = new Point(0, 120);
            GeneralDataGridView.Margin = new Padding(3, 5, 3, 5);
            GeneralDataGridView.Name = "GeneralDataGridView";
            GeneralDataGridView.RowHeadersWidth = 51;
            GeneralDataGridView.Size = new Size(490, 393);
            GeneralDataGridView.TabIndex = 58;
            // 
            // Name_1
            // 
            Name_1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Name_1.HeaderText = "Имя";
            Name_1.MinimumWidth = 6;
            Name_1.Name = "Name_1";
            // 
            // Age_1
            // 
            Age_1.HeaderText = "Возраст ";
            Age_1.MinimumWidth = 6;
            Age_1.Name = "Age_1";
            Age_1.Width = 70;
            // 
            // Сoincidences
            // 
            Сoincidences.HeaderText = "Совпадения";
            Сoincidences.MinimumWidth = 6;
            Сoincidences.Name = "Сoincidences";
            Сoincidences.Width = 95;
            // 
            // backButton
            // 
            backButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            backButton.BackColor = Color.Fuchsia;
            backButton.BackgroundImageLayout = ImageLayout.None;
            backButton.FlatAppearance.BorderSize = 0;
            backButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(212, 22, 207);
            backButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(249, 158, 246);
            backButton.FlatStyle = FlatStyle.Flat;
            backButton.Font = new Font("Segoe Print", 18F);
            backButton.ForeColor = Color.White;
            backButton.ImeMode = ImeMode.NoControl;
            backButton.Location = new Point(144, 518);
            backButton.Margin = new Padding(3, 5, 3, 5);
            backButton.Name = "backButton";
            backButton.Size = new Size(188, 69);
            backButton.TabIndex = 59;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = false;
            // 
            // GeneralForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(490, 592);
            Controls.Add(backButton);
            Controls.Add(GeneralDataGridView);
            Controls.Add(BtnSize);
            Controls.Add(boyPhoto);
            Controls.Add(CollapseButton);
            Controls.Add(CloseButton);
            Controls.Add(entryLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "GeneralForm";
            Text = "GeneralForm";
            Load += GeneralForm_Load;
            ((System.ComponentModel.ISupportInitialize)boyPhoto).EndInit();
            ((System.ComponentModel.ISupportInitialize)GeneralDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label entryLabel;
        private Button BtnSize;
        private PictureBox boyPhoto;
        private Button CollapseButton;
        private Button CloseButton;
        public DataGridView GeneralDataGridView;
        private Button backButton;
        private DataGridViewTextBoxColumn Name_1;
        private DataGridViewTextBoxColumn Age_1;
        private DataGridViewTextBoxColumn Сoincidences;
    }
}