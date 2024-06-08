namespace WinFormsApplication.Forms
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            pagesControl = new TabControl();
            servicesPageTab = new TabPage();
            servicesPage = new Pages.ServicesPage();
            requestsPageTab = new TabPage();
            requestsPage = new Pages.RequestsPage();
            statisticsPageTab = new TabPage();
            statisticsPage = new Pages.StatisticsPage();
            header = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            welcomeLabel = new ToolStripLabel();
            quitButton = new ToolStripButton();
            panel1 = new Panel();
            sqlDataAdapter1 = new Microsoft.Data.SqlClient.SqlDataAdapter();
            pagesControl.SuspendLayout();
            servicesPageTab.SuspendLayout();
            requestsPageTab.SuspendLayout();
            statisticsPageTab.SuspendLayout();
            header.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pagesControl
            // 
            pagesControl.Controls.Add(servicesPageTab);
            pagesControl.Controls.Add(requestsPageTab);
            pagesControl.Controls.Add(statisticsPageTab);
            pagesControl.Dock = DockStyle.Fill;
            pagesControl.Enabled = false;
            pagesControl.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            pagesControl.ItemSize = new Size(48, 25);
            pagesControl.Location = new Point(0, 0);
            pagesControl.Name = "pagesControl";
            pagesControl.Padding = new Point(10, 3);
            pagesControl.SelectedIndex = 0;
            pagesControl.Size = new Size(800, 415);
            pagesControl.TabIndex = 0;
            // 
            // servicesPageTab
            // 
            servicesPageTab.BackColor = SystemColors.Window;
            servicesPageTab.Controls.Add(servicesPage);
            servicesPageTab.Font = new Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point, 204);
            servicesPageTab.Location = new Point(4, 29);
            servicesPageTab.Name = "servicesPageTab";
            servicesPageTab.Padding = new Padding(3);
            servicesPageTab.Size = new Size(792, 382);
            servicesPageTab.TabIndex = 0;
            servicesPageTab.Text = "Услуги";
            servicesPageTab.UseVisualStyleBackColor = true;
            servicesPageTab.Enter += servicesPageTab_Enter;
            // 
            // servicesPage1
            // 
            servicesPage.Dock = DockStyle.Fill;
            servicesPage.Location = new Point(3, 3);
            servicesPage.Name = "servicesPage1";
            servicesPage.Size = new Size(786, 376);
            servicesPage.TabIndex = 0;
            // 
            // requestsPageTab
            // 
            requestsPageTab.Controls.Add(requestsPage);
            requestsPageTab.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            requestsPageTab.Location = new Point(4, 29);
            requestsPageTab.Name = "requestsPageTab";
            requestsPageTab.Padding = new Padding(3);
            requestsPageTab.Size = new Size(792, 382);
            requestsPageTab.TabIndex = 1;
            requestsPageTab.Text = "Запросы";
            requestsPageTab.UseVisualStyleBackColor = true;
            requestsPageTab.Enter += requestsPageTab_Enter;
            // 
            // requestsPage1
            // 
            requestsPage.Dock = DockStyle.Fill;
            requestsPage.Location = new Point(3, 3);
            requestsPage.Name = "requestsPage1";
            requestsPage.Size = new Size(786, 376);
            requestsPage.TabIndex = 0;
            // 
            // statisticsPageTab
            // 
            statisticsPageTab.Controls.Add(statisticsPage);
            statisticsPageTab.Location = new Point(4, 29);
            statisticsPageTab.Name = "statisticsPageTab";
            statisticsPageTab.Size = new Size(792, 382);
            statisticsPageTab.TabIndex = 2;
            statisticsPageTab.Text = "Статистика";
            statisticsPageTab.UseVisualStyleBackColor = true;
            statisticsPageTab.Enter += statisticsPageTab_Enter;
            // 
            // statisticsPage1
            // 
            statisticsPage.Dock = DockStyle.Fill;
            statisticsPage.Location = new Point(0, 0);
            statisticsPage.Name = "statisticsPage1";
            statisticsPage.Size = new Size(792, 382);
            statisticsPage.TabIndex = 0;
            // 
            // header
            // 
            header.AutoSize = false;
            header.BackColor = Color.RoyalBlue;
            header.Items.AddRange(new ToolStripItem[] { toolStripButton1, welcomeLabel, quitButton });
            header.Location = new Point(0, 0);
            header.Name = "header";
            header.RightToLeft = RightToLeft.Yes;
            header.Size = new Size(800, 35);
            header.TabIndex = 1;
            header.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.Alignment = ToolStripItemAlignment.Right;
            toolStripButton1.AutoSize = false;
            toolStripButton1.AutoToolTip = false;
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.RightToLeft = RightToLeft.Yes;
            toolStripButton1.Size = new Size(32, 32);
            toolStripButton1.Text = "SpaceJam";
            // 
            // welcomeLabel
            // 
            welcomeLabel.Alignment = ToolStripItemAlignment.Right;
            welcomeLabel.BackColor = Color.Transparent;
            welcomeLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            welcomeLabel.ForeColor = SystemColors.ControlLightLight;
            welcomeLabel.Margin = new Padding(10, 1, 0, 2);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.RightToLeft = RightToLeft.No;
            welcomeLabel.Size = new Size(80, 32);
            welcomeLabel.Text = "Space Jam";
            // 
            // quitButton
            // 
            quitButton.BackColor = Color.Transparent;
            quitButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            quitButton.ForeColor = SystemColors.ControlLightLight;
            quitButton.Image = Properties.Images.quit;
            quitButton.ImageTransparentColor = Color.Magenta;
            quitButton.Margin = new Padding(0);
            quitButton.Name = "quitButton";
            quitButton.Padding = new Padding(5, 0, 5, 0);
            quitButton.Size = new Size(76, 35);
            quitButton.Text = "Выйти";
            quitButton.Click += quitButton_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(pagesControl);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 35);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 415);
            panel1.TabIndex = 3;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(header);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(600, 400);
            Name = "Home";
            Text = "SpaceJam";
            pagesControl.ResumeLayout(false);
            servicesPageTab.ResumeLayout(false);
            requestsPageTab.ResumeLayout(false);
            statisticsPageTab.ResumeLayout(false);
            header.ResumeLayout(false);
            header.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl pagesControl;
        private TabPage servicesPageTab;
        private TabPage requestsPageTab;
        private ToolStrip header;
        private ToolStripButton quitButton;
        private Panel panel1;
        private ToolStripLabel welcomeLabel;
        private Pages.ServicesPage servicesPage;
        private Pages.RequestsPage requestsPage;
        private ToolStripButton toolStripButton1;
        private TabPage statisticsPageTab;
        private Microsoft.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
        private Pages.StatisticsPage statisticsPage;
    }
}