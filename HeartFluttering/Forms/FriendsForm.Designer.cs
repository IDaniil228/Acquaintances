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
            entryLabel = new Label();
            label1 = new Label();
            CurrentFriendDataGridView = new DataGridView();
            Name_1 = new DataGridViewTextBoxColumn();
            Age = new DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)CurrentFriendDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SearchFriendsDataGridView).BeginInit();
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
            entryLabel.Size = new Size(534, 116);
            entryLabel.TabIndex = 43;
            entryLabel.Text = "Друзья";
            entryLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe Print", 14F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(0, 116);
            label1.Name = "label1";
            label1.Size = new Size(534, 43);
            label1.TabIndex = 44;
            label1.Text = "Ваши друзья";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CurrentFriendDataGridView
            // 
            CurrentFriendDataGridView.BackgroundColor = Color.White;
            CurrentFriendDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CurrentFriendDataGridView.Columns.AddRange(new DataGridViewColumn[] { Name_1, Age });
            CurrentFriendDataGridView.Dock = DockStyle.Top;
            CurrentFriendDataGridView.Location = new Point(0, 159);
            CurrentFriendDataGridView.Name = "CurrentFriendDataGridView";
            CurrentFriendDataGridView.RowHeadersWidth = 51;
            CurrentFriendDataGridView.Size = new Size(534, 133);
            CurrentFriendDataGridView.TabIndex = 45;
            // 
            // Name_1
            // 
            Name_1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Name_1.HeaderText = "Имя";
            Name_1.MinimumWidth = 6;
            Name_1.Name = "Name_1";
            // 
            // Age
            // 
            Age.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Age.HeaderText = "Возраст";
            Age.MinimumWidth = 6;
            Age.Name = "Age";
            Age.Width = 125;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe Print", 14F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(0, 292);
            label2.Name = "label2";
            label2.Size = new Size(534, 43);
            label2.TabIndex = 46;
            label2.Text = "Поиск друга";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label3.Font = new Font("Segoe Print", 14F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(0, 335);
            label3.Name = "label3";
            label3.Size = new Size(223, 48);
            label3.TabIndex = 47;
            label3.Text = "Фамилия и имя";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label4.Font = new Font("Segoe Print", 14F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(71, 375);
            label4.Name = "label4";
            label4.Size = new Size(137, 43);
            label4.TabIndex = 48;
            label4.Text = "Возраст";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SearchNameTextBox
            // 
            SearchNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            SearchNameTextBox.Location = new Point(214, 349);
            SearchNameTextBox.Name = "SearchNameTextBox";
            SearchNameTextBox.Size = new Size(308, 27);
            SearchNameTextBox.TabIndex = 49;
            SearchNameTextBox.TextChanged += SearchNameTextBox_TextChanged;
            // 
            // AgeTextBox
            // 
            AgeTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            AgeTextBox.Location = new Point(214, 386);
            AgeTextBox.MaxLength = 3;
            AgeTextBox.Name = "AgeTextBox";
            AgeTextBox.Size = new Size(78, 27);
            AgeTextBox.TabIndex = 50;
            AgeTextBox.TextChanged += this.AgeTextBox_TextChanged;
            // 
            // SearchFriendsDataGridView
            // 
            SearchFriendsDataGridView.BackgroundColor = Color.White;
            SearchFriendsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SearchFriendsDataGridView.Columns.AddRange(new DataGridViewColumn[] { Name_2, Age_2 });
            SearchFriendsDataGridView.Dock = DockStyle.Bottom;
            SearchFriendsDataGridView.Location = new Point(0, 437);
            SearchFriendsDataGridView.Name = "SearchFriendsDataGridView";
            SearchFriendsDataGridView.RowHeadersWidth = 51;
            SearchFriendsDataGridView.Size = new Size(534, 186);
            SearchFriendsDataGridView.TabIndex = 51;
            // 
            // Name_2
            // 
            Name_2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Name_2.HeaderText = "Имя";
            Name_2.MinimumWidth = 6;
            Name_2.Name = "Name_2";
            // 
            // Age_2
            // 
            Age_2.HeaderText = "Возраст";
            Age_2.MinimumWidth = 6;
            Age_2.Name = "Age_2";
            Age_2.Width = 125;
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
            BtnSize.Location = new Point(470, -5);
            BtnSize.Margin = new Padding(3, 4, 3, 4);
            BtnSize.Name = "BtnSize";
            BtnSize.Size = new Size(25, 34);
            BtnSize.TabIndex = 54;
            BtnSize.Text = "▭";
            BtnSize.UseVisualStyleBackColor = false;
            BtnSize.Click += BtnSize_Click;
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
            CollapseButton.Location = new Point(439, 0);
            CollapseButton.Margin = new Padding(3, 4, 3, 4);
            CollapseButton.Name = "CollapseButton";
            CollapseButton.Size = new Size(25, 31);
            CollapseButton.TabIndex = 53;
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
            CloseButton.Location = new Point(494, 0);
            CloseButton.Margin = new Padding(3, 4, 3, 4);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(40, 31);
            CloseButton.TabIndex = 52;
            CloseButton.Text = "X";
            CloseButton.UseVisualStyleBackColor = false;
            CloseButton.Click += CloseButton_Click;
            // 
            // FriendsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(534, 623);
            Controls.Add(BtnSize);
            Controls.Add(CollapseButton);
            Controls.Add(CloseButton);
            Controls.Add(SearchFriendsDataGridView);
            Controls.Add(AgeTextBox);
            Controls.Add(SearchNameTextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(CurrentFriendDataGridView);
            Controls.Add(label1);
            Controls.Add(entryLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FriendsForm";
            Text = "Friends";
            Load += Friends_Load;
            ((System.ComponentModel.ISupportInitialize)CurrentFriendDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)SearchFriendsDataGridView).EndInit();
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
        private DataGridViewTextBoxColumn Name_1;
        private DataGridViewTextBoxColumn Age;
        private DataGridViewTextBoxColumn Name_2;
        private DataGridViewTextBoxColumn Age_2;
    }
}