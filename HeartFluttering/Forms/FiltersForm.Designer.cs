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
            resources.ApplyResources(girlPhoto, "girlPhoto");
            girlPhoto.BackColor = Color.Fuchsia;
            girlPhoto.Name = "girlPhoto";
            girlPhoto.TabStop = false;
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
            // entryLabel
            // 
            resources.ApplyResources(entryLabel, "entryLabel");
            entryLabel.BackColor = Color.Magenta;
            entryLabel.ForeColor = SystemColors.ButtonHighlight;
            entryLabel.Name = "entryLabel";
            // 
            // panel1
            // 
            resources.ApplyResources(panel1, "panel1");
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
            panel1.Name = "panel1";
            // 
            // FiltersButton
            // 
            resources.ApplyResources(FiltersButton, "FiltersButton");
            FiltersButton.BackColor = Color.Fuchsia;
            FiltersButton.FlatAppearance.BorderSize = 0;
            FiltersButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(212, 22, 207);
            FiltersButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(249, 158, 246);
            FiltersButton.ForeColor = Color.White;
            FiltersButton.Name = "FiltersButton";
            FiltersButton.UseVisualStyleBackColor = false;
            FiltersButton.Click += FiltersButton_Click;
            // 
            // FinalAgeField
            // 
            resources.ApplyResources(FinalAgeField, "FinalAgeField");
            FinalAgeField.Name = "FinalAgeField";
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.Name = "label4";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // sexWomenButton
            // 
            resources.ApplyResources(sexWomenButton, "sexWomenButton");
            sexWomenButton.Name = "sexWomenButton";
            sexWomenButton.TabStop = true;
            sexWomenButton.UseVisualStyleBackColor = true;
            // 
            // sexMenButton
            // 
            resources.ApplyResources(sexMenButton, "sexMenButton");
            sexMenButton.Name = "sexMenButton";
            sexMenButton.TabStop = true;
            sexMenButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // cityField
            // 
            resources.ApplyResources(cityField, "cityField");
            cityField.Name = "cityField";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // passwondLabel
            // 
            resources.ApplyResources(passwondLabel, "passwondLabel");
            passwondLabel.Name = "passwondLabel";
            // 
            // InitialAgeField
            // 
            resources.ApplyResources(InitialAgeField, "InitialAgeField");
            InitialAgeField.Name = "InitialAgeField";
            // 
            // FiltersForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel1);
            Controls.Add(girlPhoto);
            Controls.Add(boyPhoto);
            Controls.Add(CollapseButton);
            Controls.Add(CloseButton);
            Controls.Add(entryLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FiltersForm";
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