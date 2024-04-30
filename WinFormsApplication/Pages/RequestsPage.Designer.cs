namespace WinFormsApplication.Pages
{
    partial class RequestsPage
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
            splitContainer1 = new SplitContainer();
            label2 = new Label();
            label1 = new Label();
            requestsContainer = new FlowLayoutPanel();
            notFoundLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            requestsContainer.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.FixedPanel = FixedPanel.Panel1;
            splitContainer1.IsSplitterFixed = true;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.RoyalBlue;
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(label1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(requestsContainer);
            splitContainer1.Size = new Size(788, 529);
            splitContainer1.SplitterDistance = 35;
            splitContainer1.TabIndex = 0;
            // 
            // label2
            // 
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(84, 11);
            label2.Name = "label2";
            label2.Size = new Size(288, 23);
            label2.TabIndex = 1;
            label2.Text = "Здесь вы можете найти информацию о запросах";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(7, 6);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 0;
            label1.Text = "Запросы";
            // 
            // requestsContainer
            // 
            requestsContainer.AutoScroll = true;
            requestsContainer.Controls.Add(notFoundLabel);
            requestsContainer.Dock = DockStyle.Fill;
            requestsContainer.Location = new Point(0, 0);
            requestsContainer.Name = "requestsContainer";
            requestsContainer.Size = new Size(788, 490);
            requestsContainer.TabIndex = 0;
            // 
            // notFoundLabel
            // 
            notFoundLabel.AutoSize = true;
            notFoundLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            notFoundLabel.ForeColor = SystemColors.WindowFrame;
            notFoundLabel.Location = new Point(3, 0);
            notFoundLabel.Name = "notFoundLabel";
            notFoundLabel.Size = new Size(326, 21);
            notFoundLabel.TabIndex = 1;
            notFoundLabel.Text = "Ни одного запроса еще не было создано!";
            notFoundLabel.Visible = false;
            // 
            // RequestsPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            Name = "RequestsPage";
            Size = new Size(788, 529);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            requestsContainer.ResumeLayout(false);
            requestsContainer.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Label label1;
        private Label label2;
        private FlowLayoutPanel requestsContainer;
        private Label notFoundLabel;
    }
}
