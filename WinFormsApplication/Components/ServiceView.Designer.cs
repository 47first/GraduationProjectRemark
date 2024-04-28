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
            pictureBox1 = new PictureBox();
            descriptionLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.Dock = DockStyle.Top;
            titleLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            titleLabel.Location = new Point(5, 5);
            titleLabel.Margin = new Padding(10, 0, 10, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(413, 27);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Название название название название название название название название  название название название название название название название название название название название название название название";
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.IsSplitterFixed = true;
            splitContainer1.Location = new Point(5, 32);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(descriptionLabel);
            splitContainer1.Size = new Size(413, 146);
            splitContainer1.SplitterDistance = 137;
            splitContainer1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ScrollBar;
            pictureBox1.BackgroundImage = Properties.Images.quit;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(137, 146);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // descriptionLabel
            // 
            descriptionLabel.Dock = DockStyle.Fill;
            descriptionLabel.Location = new Point(0, 0);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(272, 146);
            descriptionLabel.TabIndex = 0;
            descriptionLabel.Text = resources.GetString("descriptionLabel.Text");
            // 
            // ServiceView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            BackgroundImageLayout = ImageLayout.Zoom;
            Controls.Add(splitContainer1);
            Controls.Add(titleLabel);
            MinimumSize = new Size(420, 180);
            Name = "ServiceView";
            Padding = new Padding(5);
            Size = new Size(423, 183);
            splitContainer1.Panel1.ResumeLayout(false);
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
    }
}
