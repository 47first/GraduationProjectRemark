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
            servicesPage = new TabPage();
            servicesSplitContatiner = new SplitContainer();
            label2 = new Label();
            label1 = new Label();
            servicesContainer = new FlowLayoutPanel();
            requestsPage = new TabPage();
            coworkingZones = new TabPage();
            usersPage = new TabPage();
            header = new ToolStrip();
            quitButton = new ToolStripButton();
            welcomeLabel = new ToolStripLabel();
            panel1 = new Panel();
            pagesControl.SuspendLayout();
            servicesPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)servicesSplitContatiner).BeginInit();
            servicesSplitContatiner.Panel1.SuspendLayout();
            servicesSplitContatiner.Panel2.SuspendLayout();
            servicesSplitContatiner.SuspendLayout();
            servicesContainer.SuspendLayout();
            header.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pagesControl
            // 
            pagesControl.Controls.Add(servicesPage);
            pagesControl.Controls.Add(requestsPage);
            pagesControl.Controls.Add(coworkingZones);
            pagesControl.Controls.Add(usersPage);
            pagesControl.Dock = DockStyle.Fill;
            pagesControl.Font = new Font("Segoe UI", 8.5F);
            pagesControl.Location = new Point(0, 0);
            pagesControl.Name = "pagesControl";
            pagesControl.SelectedIndex = 0;
            pagesControl.Size = new Size(800, 415);
            pagesControl.TabIndex = 0;
            // 
            // servicesPage
            // 
            servicesPage.BackColor = SystemColors.GradientActiveCaption;
            servicesPage.Controls.Add(servicesSplitContatiner);
            servicesPage.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            servicesPage.Location = new Point(4, 22);
            servicesPage.Name = "servicesPage";
            servicesPage.Padding = new Padding(3);
            servicesPage.Size = new Size(792, 389);
            servicesPage.TabIndex = 0;
            servicesPage.Text = "Услуги";
            servicesPage.Enter += servicesPage_Enter;
            // 
            // servicesSplitContatiner
            // 
            servicesSplitContatiner.Dock = DockStyle.Fill;
            servicesSplitContatiner.FixedPanel = FixedPanel.Panel1;
            servicesSplitContatiner.IsSplitterFixed = true;
            servicesSplitContatiner.Location = new Point(3, 3);
            servicesSplitContatiner.Name = "servicesSplitContatiner";
            servicesSplitContatiner.Orientation = Orientation.Horizontal;
            // 
            // servicesSplitContatiner.Panel1
            // 
            servicesSplitContatiner.Panel1.BackColor = Color.RoyalBlue;
            servicesSplitContatiner.Panel1.Controls.Add(label2);
            servicesSplitContatiner.Panel1.Controls.Add(label1);
            // 
            // servicesSplitContatiner.Panel2
            // 
            servicesSplitContatiner.Panel2.Controls.Add(servicesContainer);
            servicesSplitContatiner.Size = new Size(786, 383);
            servicesSplitContatiner.SplitterDistance = 55;
            servicesSplitContatiner.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(100, 23);
            label2.Name = "label2";
            label2.Size = new Size(226, 15);
            label2.TabIndex = 1;
            label2.Text = "Здесь вы можете забронировать место";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(13, 11);
            label1.Name = "label1";
            label1.Size = new Size(81, 30);
            label1.TabIndex = 0;
            label1.Text = "Услуги";
            // 
            // servicesContainer
            // 
            servicesContainer.AutoScroll = true;
            servicesContainer.Dock = DockStyle.Fill;
            servicesContainer.Location = new Point(0, 0);
            servicesContainer.Margin = new Padding(0);
            servicesContainer.Name = "servicesContainer";
            servicesContainer.Padding = new Padding(10, 0, 10, 10);
            servicesContainer.Size = new Size(786, 324);
            servicesContainer.TabIndex = 0;
            servicesContainer.SizeChanged += servicesContainer_SizeChanged;

            // 
            // requestsPage
            // 
            requestsPage.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            requestsPage.Location = new Point(4, 22);
            requestsPage.Name = "requestsPage";
            requestsPage.Padding = new Padding(3);
            requestsPage.Size = new Size(792, 389);
            requestsPage.TabIndex = 1;
            requestsPage.Text = "Запросы";
            requestsPage.UseVisualStyleBackColor = true;
            // 
            // coworkingZones
            // 
            coworkingZones.Location = new Point(4, 22);
            coworkingZones.Name = "coworkingZones";
            coworkingZones.Size = new Size(792, 389);
            coworkingZones.TabIndex = 2;
            coworkingZones.Text = "Коворкинг зоны";
            coworkingZones.UseVisualStyleBackColor = true;
            // 
            // usersPage
            // 
            usersPage.Location = new Point(4, 22);
            usersPage.Name = "usersPage";
            usersPage.Size = new Size(792, 389);
            usersPage.TabIndex = 3;
            usersPage.Text = "Пользователи";
            usersPage.UseVisualStyleBackColor = true;
            // 
            // header
            // 
            header.AutoSize = false;
            header.BackColor = Color.RoyalBlue;
            header.Items.AddRange(new ToolStripItem[] { quitButton, welcomeLabel });
            header.Location = new Point(0, 0);
            header.Name = "header";
            header.RightToLeft = RightToLeft.Yes;
            header.Size = new Size(800, 35);
            header.TabIndex = 1;
            header.Text = "toolStrip1";
            header.ItemClicked += toolStrip1_ItemClicked;
            // 
            // quitButton
            // 
            quitButton.BackColor = Color.CornflowerBlue;
            quitButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            quitButton.ForeColor = SystemColors.Info;
            quitButton.Image = Properties.Images.quit;
            quitButton.ImageTransparentColor = Color.Magenta;
            quitButton.Name = "quitButton";
            quitButton.Padding = new Padding(5, 0, 5, 0);
            quitButton.Size = new Size(76, 32);
            quitButton.Text = "Выйти";
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
            welcomeLabel.Size = new Size(174, 32);
            welcomeLabel.Text = "Здравствуйте, Алексей!";
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
            MinimumSize = new Size(300, 200);
            Name = "Home";
            Text = "Коворкинг зона";
            pagesControl.ResumeLayout(false);
            servicesPage.ResumeLayout(false);
            servicesSplitContatiner.Panel1.ResumeLayout(false);
            servicesSplitContatiner.Panel1.PerformLayout();
            servicesSplitContatiner.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)servicesSplitContatiner).EndInit();
            servicesSplitContatiner.ResumeLayout(false);
            servicesContainer.ResumeLayout(false);
            servicesContainer.PerformLayout();
            header.ResumeLayout(false);
            header.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl pagesControl;
        private TabPage servicesPage;
        private TabPage requestsPage;
        private ToolStrip header;
        private ToolStripButton quitButton;
        private Panel panel1;
        private ToolStripLabel welcomeLabel;
        private TabPage coworkingZones;
        private TabPage usersPage;
        private Label label1;
        private Label label2;
        private SplitContainer servicesSplitContatiner;
        private FlowLayoutPanel servicesContainer;
    }
}