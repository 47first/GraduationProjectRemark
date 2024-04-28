
namespace WinFormsApplication.Pages
{
    partial class ServicesPage
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
            splitContainer = new SplitContainer();
            label2 = new Label();
            label1 = new Label();
            servicesContainer = new FlowLayoutPanel();
            notFoundLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
            splitContainer.Panel1.SuspendLayout();
            splitContainer.Panel2.SuspendLayout();
            splitContainer.SuspendLayout();
            servicesContainer.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer
            // 
            splitContainer.Dock = DockStyle.Fill;
            splitContainer.FixedPanel = FixedPanel.Panel1;
            splitContainer.IsSplitterFixed = true;
            splitContainer.Location = new Point(0, 0);
            splitContainer.Name = "splitContainer";
            splitContainer.Orientation = Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            splitContainer.Panel1.BackColor = Color.RoyalBlue;
            splitContainer.Panel1.Controls.Add(label2);
            splitContainer.Panel1.Controls.Add(label1);
            // 
            // splitContainer.Panel2
            // 
            splitContainer.Panel2.Controls.Add(servicesContainer);
            splitContainer.Size = new Size(788, 529);
            splitContainer.SplitterDistance = 35;
            splitContainer.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(70, 11);
            label2.Name = "label2";
            label2.Size = new Size(226, 15);
            label2.TabIndex = 3;
            label2.Text = "Здесь вы можете забронировать место";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(7, 6);
            label1.Name = "label1";
            label1.Size = new Size(63, 21);
            label1.TabIndex = 2;
            label1.Text = "Услуги";
            // 
            // servicesContainer
            // 
            servicesContainer.AutoScroll = true;
            servicesContainer.Controls.Add(notFoundLabel);
            servicesContainer.Dock = DockStyle.Fill;
            servicesContainer.FlowDirection = FlowDirection.TopDown;
            servicesContainer.Location = new Point(0, 0);
            servicesContainer.Margin = new Padding(0);
            servicesContainer.Name = "servicesContainer";
            servicesContainer.Padding = new Padding(10, 0, 10, 10);
            servicesContainer.Size = new Size(788, 490);
            servicesContainer.TabIndex = 1;
            servicesContainer.WrapContents = false;
            // 
            // notFoundLabel
            // 
            notFoundLabel.AutoSize = true;
            notFoundLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            notFoundLabel.ForeColor = SystemColors.WindowFrame;
            notFoundLabel.Location = new Point(13, 0);
            notFoundLabel.Name = "notFoundLabel";
            notFoundLabel.Size = new Size(330, 21);
            notFoundLabel.TabIndex = 0;
            notFoundLabel.Text = "Ни одной услуги еще не было добавлено!";
            // 
            // ServicesPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer);
            Name = "ServicesPage";
            Size = new Size(788, 529);
            splitContainer.Panel1.ResumeLayout(false);
            splitContainer.Panel1.PerformLayout();
            splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
            splitContainer.ResumeLayout(false);
            servicesContainer.ResumeLayout(false);
            servicesContainer.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer;
        private Label label2;
        private Label label1;
        private FlowLayoutPanel servicesContainer;
        private Label notFoundLabel;
    }
}
