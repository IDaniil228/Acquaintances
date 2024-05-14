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
            backButton = new Button();
            Name_1 = new DataGridViewTextBoxColumn();
            Age_1 = new DataGridViewTextBoxColumn();
            Сoincidences = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)boyPhoto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GeneralDataGridView).BeginInit();
            SuspendLayout();
            // 
            // entryLabel
            // 
            resources.ApplyResources(entryLabel, "entryLabel");
            entryLabel.BackColor = Color.Magenta;
            entryLabel.ForeColor = SystemColors.ButtonHighlight;
            entryLabel.Name = "entryLabel";
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
            // GeneralDataGridView
            // 
            resources.ApplyResources(GeneralDataGridView, "GeneralDataGridView");
            GeneralDataGridView.AllowUserToAddRows = false;
            GeneralDataGridView.BackgroundColor = Color.White;
            GeneralDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GeneralDataGridView.Columns.AddRange(new DataGridViewColumn[] { Name_1, Age_1, Сoincidences });
            GeneralDataGridView.Name = "GeneralDataGridView";
            GeneralDataGridView.CellDoubleClick += GeneralDataGridView_CellDoubleClick;
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
            // 
            // Name_1
            // 
            Name_1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(Name_1, "Name_1");
            Name_1.Name = "Name_1";
            // 
            // Age_1
            // 
            resources.ApplyResources(Age_1, "Age_1");
            Age_1.Name = "Age_1";
            // 
            // Сoincidences
            // 
            resources.ApplyResources(Сoincidences, "Сoincidences");
            Сoincidences.Name = "Сoincidences";
            // 
            // GeneralForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(backButton);
            Controls.Add(GeneralDataGridView);
            Controls.Add(BtnSize);
            Controls.Add(boyPhoto);
            Controls.Add(CollapseButton);
            Controls.Add(CloseButton);
            Controls.Add(entryLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "GeneralForm";
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