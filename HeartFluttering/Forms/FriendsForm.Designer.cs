namespace HeartFluttering.Forms
{
    partial class FriendsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FriendsForm));
            entryLabel = new Label();
            label1 = new Label();
            CurrentFriendDataGridView = new DataGridView();
            Name_1 = new DataGridViewTextBoxColumn();
            Age_1 = new DataGridViewTextBoxColumn();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SearchNameTextBox = new TextBox();
            AgeTextBox = new TextBox();
            SearchFriendsDataGridView = new DataGridView();
            Name_2 = new DataGridViewTextBoxColumn();
            Age_2 = new DataGridViewTextBoxColumn();
            BtnSize = new Button();
            CollapseButton = new Button();
            CloseButton = new Button();
            panel1 = new Panel();
            BtnGeneral = new Button();
            ((System.ComponentModel.ISupportInitialize)CurrentFriendDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SearchFriendsDataGridView).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // entryLabel
            // 
            resources.ApplyResources(entryLabel, "entryLabel");
            entryLabel.BackColor = Color.Magenta;
            entryLabel.ForeColor = SystemColors.ButtonHighlight;
            entryLabel.Name = "entryLabel";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // CurrentFriendDataGridView
            // 
            resources.ApplyResources(CurrentFriendDataGridView, "CurrentFriendDataGridView");
            CurrentFriendDataGridView.BackgroundColor = Color.White;
            CurrentFriendDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CurrentFriendDataGridView.Columns.AddRange(new DataGridViewColumn[] { Name_1, Age_1 });
            CurrentFriendDataGridView.Name = "CurrentFriendDataGridView";
            CurrentFriendDataGridView.CellDoubleClick += CurrentFriendDataGridView_CellDoubleClick;
            // 
            // Name_1
            // 
            Name_1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(Name_1, "Name_1");
            Name_1.Name = "Name_1";
            // 
            // Age_1
            // 
            Age_1.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            resources.ApplyResources(Age_1, "Age_1");
            Age_1.Name = "Age_1";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.Name = "label4";
            // 
            // SearchNameTextBox
            // 
            resources.ApplyResources(SearchNameTextBox, "SearchNameTextBox");
            SearchNameTextBox.Name = "SearchNameTextBox";
            SearchNameTextBox.TextChanged += SearchNameTextBox_TextChanged;
            // 
            // AgeTextBox
            // 
            resources.ApplyResources(AgeTextBox, "AgeTextBox");
            AgeTextBox.Name = "AgeTextBox";
            AgeTextBox.TextChanged += AgeTextBox_TextChanged;
            // 
            // SearchFriendsDataGridView
            // 
            resources.ApplyResources(SearchFriendsDataGridView, "SearchFriendsDataGridView");
            SearchFriendsDataGridView.BackgroundColor = Color.White;
            SearchFriendsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SearchFriendsDataGridView.Columns.AddRange(new DataGridViewColumn[] { Name_2, Age_2 });
            SearchFriendsDataGridView.Name = "SearchFriendsDataGridView";
            SearchFriendsDataGridView.CellDoubleClick += SearchFriendsDataGridView_CellDoubleClick;
            // 
            // Name_2
            // 
            Name_2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(Name_2, "Name_2");
            Name_2.Name = "Name_2";
            // 
            // Age_2
            // 
            resources.ApplyResources(Age_2, "Age_2");
            Age_2.Name = "Age_2";
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
            // panel1
            // 
            resources.ApplyResources(panel1, "panel1");
            panel1.Controls.Add(BtnGeneral);
            panel1.Name = "panel1";
            // 
            // BtnGeneral
            // 
            resources.ApplyResources(BtnGeneral, "BtnGeneral");
            BtnGeneral.BackColor = Color.Fuchsia;
            BtnGeneral.FlatAppearance.BorderSize = 0;
            BtnGeneral.FlatAppearance.MouseDownBackColor = Color.FromArgb(212, 22, 207);
            BtnGeneral.FlatAppearance.MouseOverBackColor = Color.FromArgb(249, 158, 246);
            BtnGeneral.ForeColor = Color.White;
            BtnGeneral.Name = "BtnGeneral";
            BtnGeneral.UseVisualStyleBackColor = false;
            BtnGeneral.Click += BtnGeneral_Click;
            // 
            // FriendsForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(BtnSize);
            Controls.Add(CollapseButton);
            Controls.Add(CloseButton);
            Controls.Add(SearchFriendsDataGridView);
            Controls.Add(AgeTextBox);
            Controls.Add(SearchNameTextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(CurrentFriendDataGridView);
            Controls.Add(label1);
            Controls.Add(entryLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FriendsForm";
            Load += Friends_Load;
            ((System.ComponentModel.ISupportInitialize)CurrentFriendDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)SearchFriendsDataGridView).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label entryLabel;
        private Label label1;
        private DataGridView CurrentFriendDataGridView;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox SearchNameTextBox;
        private TextBox AgeTextBox;
        private DataGridView SearchFriendsDataGridView;
        private Button BtnSize;
        private Button CollapseButton;
        private Button CloseButton;
        private Panel panel1;
        private Button BtnGeneral;
        private DataGridViewTextBoxColumn Name_1;
        private DataGridViewTextBoxColumn Age_1;
        private DataGridViewTextBoxColumn Name_2;
        private DataGridViewTextBoxColumn Age_2;
    }
}