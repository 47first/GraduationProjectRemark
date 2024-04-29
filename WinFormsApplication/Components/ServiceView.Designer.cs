namespace WinFormsApplication.Components
{
    partial class ServiceView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServiceView));
            titleLabel = new Label();
            splitContainer1 = new SplitContainer();
            requestButton = new Button();
            categoryLabel = new Label();
            updateButton = new Button();
            deleteButton = new Button();
            descriptionLabel = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.BackColor = Color.Transparent;
            titleLabel.Dock = DockStyle.Top;
            titleLabel.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 204);
            titleLabel.ForeColor = SystemColors.InactiveCaptionText;
            titleLabel.Location = new Point(5, 5);
            titleLabel.Margin = new Padding(10, 0, 10, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(541, 35);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Название название название название название название название название  название название название название название название название название название название название название название название";
            titleLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.FixedPanel = FixedPanel.Panel2;
            splitContainer1.IsSplitterFixed = true;
            splitContainer1.Location = new Point(5, 40);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(requestButton);
            splitContainer1.Panel1.Controls.Add(categoryLabel);
            splitContainer1.Panel1.Controls.Add(updateButton);
            splitContainer1.Panel1.Controls.Add(deleteButton);
            splitContainer1.Panel1.Controls.Add(descriptionLabel);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(pictureBox1);
            splitContainer1.Size = new Size(541, 136);
            splitContainer1.SplitterDistance = 351;
            splitContainer1.TabIndex = 1;
            // 
            // requestButton
            // 
            requestButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            requestButton.BackColor = Color.RoyalBlue;
            requestButton.FlatStyle = FlatStyle.Popup;
            requestButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            requestButton.ForeColor = SystemColors.ButtonHighlight;
            requestButton.Location = new Point(3, 103);
            requestButton.Name = "requestButton";
            requestButton.Size = new Size(91, 30);
            requestButton.TabIndex = 4;
            requestButton.Text = "Запросить";
            requestButton.UseVisualStyleBackColor = false;
            // 
            // categoryLabel
            // 
            categoryLabel.AllowDrop = true;
            categoryLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            categoryLabel.AutoSize = true;
            categoryLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            categoryLabel.Location = new Point(3, 0);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new Size(113, 20);
            categoryLabel.TabIndex = 1;
            categoryLabel.Text = "Категория: {0}";
            // 
            // updateButton
            // 
            updateButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            updateButton.BackColor = Color.RoyalBlue;
            updateButton.FlatStyle = FlatStyle.Popup;
            updateButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            updateButton.ForeColor = SystemColors.ButtonHighlight;
            updateButton.Location = new Point(265, 103);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(75, 30);
            updateButton.TabIndex = 2;
            updateButton.Text = "Обновить";
            updateButton.UseVisualStyleBackColor = false;
            updateButton.Click += updateButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            deleteButton.BackColor = Color.RoyalBlue;
            deleteButton.FlatStyle = FlatStyle.Popup;
            deleteButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            deleteButton.ForeColor = SystemColors.ButtonHighlight;
            deleteButton.Location = new Point(184, 103);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(75, 30);
            deleteButton.TabIndex = 3;
            deleteButton.Text = "Удалить";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // descriptionLabel
            // 
            descriptionLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            descriptionLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            descriptionLabel.ForeColor = SystemColors.InactiveCaptionText;
            descriptionLabel.Location = new Point(5, 13);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(337, 87);
            descriptionLabel.TabIndex = 0;
            descriptionLabel.Text = resources.GetString("descriptionLabel.Text");
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaption;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Images.people;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(186, 136);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // ServiceView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Zoom;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(splitContainer1);
            Controls.Add(titleLabel);
            MinimumSize = new Size(550, 180);
            Name = "ServiceView";
            Padding = new Padding(5);
            Size = new Size(551, 181);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label titleLabel;
        private SplitContainer splitContainer1;
        private PictureBox pictureBox1;
        private Label descriptionLabel;
        private Label categoryLabel;
        private Button updateButton;
        private Button deleteButton;
        private Button requestButton;
    }
}
