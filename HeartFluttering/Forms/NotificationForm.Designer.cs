namespace HeartFluttering
{
    partial class NotificationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotificationForm));
            girlPhoto = new PictureBox();
            boyPhoto = new PictureBox();
            CollapseButton = new Button();
            CloseButton = new Button();
            entryLabel = new Label();
            backButton = new Button();
            listUsers = new DataGridView();
            label1 = new Label();
            FriendDataGridView = new DataGridView();
            Name_1 = new DataGridViewTextBoxColumn();
            Age_1 = new DataGridViewTextBoxColumn();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)girlPhoto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)boyPhoto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)listUsers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FriendDataGridView).BeginInit();
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
            // listUsers
            // 
            resources.ApplyResources(listUsers, "listUsers");
            listUsers.AllowUserToAddRows = false;
            listUsers.BackgroundColor = Color.White;
            listUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            listUsers.Name = "listUsers";
            listUsers.CellDoubleClick += listUsers_CellDoubleClick;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.ForeColor = Color.Black;
            label1.Name = "label1";
            // 
            // FriendDataGridView
            // 
            resources.ApplyResources(FriendDataGridView, "FriendDataGridView");
            FriendDataGridView.AllowUserToAddRows = false;
            FriendDataGridView.BackgroundColor = Color.White;
            FriendDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            FriendDataGridView.Columns.AddRange(new DataGridViewColumn[] { Name_1, Age_1 });
            FriendDataGridView.Name = "FriendDataGridView";
            FriendDataGridView.CellDoubleClick += FriendDataGridView_CellContentDoubleClick;
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
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // NotificationForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(backButton);
            Controls.Add(girlPhoto);
            Controls.Add(boyPhoto);
            Controls.Add(CollapseButton);
            Controls.Add(CloseButton);
            Controls.Add(FriendDataGridView);
            Controls.Add(label2);
            Controls.Add(listUsers);
            Controls.Add(label1);
            Controls.Add(entryLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "NotificationForm";
            Load += NotificationForm_Load;
            MouseDown += NotificationForm_MouseDown;
            MouseMove += NotificationForm_MouseMove;
            ((System.ComponentModel.ISupportInitialize)girlPhoto).EndInit();
            ((System.ComponentModel.ISupportInitialize)boyPhoto).EndInit();
            ((System.ComponentModel.ISupportInitialize)listUsers).EndInit();
            ((System.ComponentModel.ISupportInitialize)FriendDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox girlPhoto;
        private PictureBox boyPhoto;
        private Button CollapseButton;
        private Button CloseButton;
        private Label entryLabel;
        private Button backButton;
        public DataGridView listUsers;
        private Label label1;
        public DataGridView FriendDataGridView;
        private DataGridViewTextBoxColumn Name_1;
        private DataGridViewTextBoxColumn Age_1;
        private Label label2;
    }
}