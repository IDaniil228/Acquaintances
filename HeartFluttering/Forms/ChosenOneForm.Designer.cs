namespace HeartFluttering
{
    partial class ChosenOneForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChosenOneForm));
            girlPhoto = new PictureBox();
            boyPhoto = new PictureBox();
            CollapseButton = new Button();
            CloseButton = new Button();
            entryLabel = new Label();
            listUsers = new DataGridView();
            backButton = new Button();
            ((System.ComponentModel.ISupportInitialize)girlPhoto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)boyPhoto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)listUsers).BeginInit();
            SuspendLayout();
            // 
            // girlPhoto
            // 
            girlPhoto.BackColor = Color.Fuchsia;
            girlPhoto.Image = (Image)resources.GetObject("girlPhoto.Image");
            girlPhoto.Location = new Point(307, 29);
            girlPhoto.Name = "girlPhoto";
            girlPhoto.Size = new Size(63, 58);
            girlPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            girlPhoto.TabIndex = 40;
            girlPhoto.TabStop = false;
            // 
            // boyPhoto
            // 
            boyPhoto.BackColor = Color.Fuchsia;
            boyPhoto.Image = (Image)resources.GetObject("boyPhoto.Image");
            boyPhoto.Location = new Point(34, 29);
            boyPhoto.Name = "boyPhoto";
            boyPhoto.Size = new Size(63, 58);
            boyPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            boyPhoto.TabIndex = 39;
            boyPhoto.TabStop = false;
            // 
            // CollapseButton
            // 
            CollapseButton.Anchor = AnchorStyles.Bottom;
            CollapseButton.BackColor = Color.Fuchsia;
            CollapseButton.FlatAppearance.BorderSize = 0;
            CollapseButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(212, 22, 207);
            CollapseButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(249, 158, 246);
            CollapseButton.FlatStyle = FlatStyle.Flat;
            CollapseButton.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            CollapseButton.ForeColor = Color.White;
            CollapseButton.Location = new Point(334, 0);
            CollapseButton.Name = "CollapseButton";
            CollapseButton.Size = new Size(35, 23);
            CollapseButton.TabIndex = 38;
            CollapseButton.Text = "—";
            CollapseButton.UseVisualStyleBackColor = false;
            CollapseButton.Click += CollapseButton_Click;
            // 
            // CloseButton
            // 
            CloseButton.BackColor = Color.Fuchsia;
            CloseButton.FlatAppearance.BorderSize = 0;
            CloseButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(212, 22, 207);
            CloseButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(249, 158, 246);
            CloseButton.FlatStyle = FlatStyle.Flat;
            CloseButton.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            CloseButton.ForeColor = Color.White;
            CloseButton.Location = new Point(367, 0);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(35, 23);
            CloseButton.TabIndex = 37;
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
            entryLabel.Size = new Size(402, 88);
            entryLabel.TabIndex = 36;
            entryLabel.Text = "Избранное";
            entryLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // listUsers
            // 
            listUsers.AllowUserToAddRows = false;
            listUsers.BackgroundColor = Color.White;
            listUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            listUsers.Location = new Point(0, 83);
            listUsers.Name = "listUsers";
            listUsers.Size = new Size(403, 358);
            listUsers.TabIndex = 47;
            listUsers.CellDoubleClick += listUsers_CellDoubleClick;
            // 
            // backButton
            // 
            backButton.BackColor = Color.Fuchsia;
            backButton.BackgroundImageLayout = ImageLayout.None;
            backButton.FlatAppearance.BorderSize = 0;
            backButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(212, 22, 207);
            backButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(249, 158, 246);
            backButton.FlatStyle = FlatStyle.Flat;
            backButton.Font = new Font("Segoe Print", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            backButton.ForeColor = Color.White;
            backButton.Location = new Point(134, 439);
            backButton.Name = "backButton";
            backButton.Size = new Size(130, 34);
            backButton.TabIndex = 58;
            backButton.Text = "Назад";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // ChosenOneForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(402, 472);
            Controls.Add(backButton);
            Controls.Add(listUsers);
            Controls.Add(girlPhoto);
            Controls.Add(boyPhoto);
            Controls.Add(CollapseButton);
            Controls.Add(CloseButton);
            Controls.Add(entryLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ChosenOneForm";
            Text = "ChosenOneForm";
            Load += ChosenOneForm_Load;
            ((System.ComponentModel.ISupportInitialize)girlPhoto).EndInit();
            ((System.ComponentModel.ISupportInitialize)boyPhoto).EndInit();
            ((System.ComponentModel.ISupportInitialize)listUsers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox girlPhoto;
        private PictureBox boyPhoto;
        private Button CollapseButton;
        private Button CloseButton;
        private Label entryLabel;
        public DataGridView listUsers;
        private Button backButton;
    }
}