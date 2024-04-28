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
            tabControl1 = new TabControl();
            servicesPage = new TabPage();
            label2 = new Label();
            label1 = new Label();
            requestsPage = new TabPage();
            coworkingZones = new TabPage();
            usersPage = new TabPage();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripLabel1 = new ToolStripLabel();
            panel1 = new Panel();
            tabControl1.SuspendLayout();
            servicesPage.SuspendLayout();
            toolStrip1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(servicesPage);
            tabControl1.Controls.Add(requestsPage);
            tabControl1.Controls.Add(coworkingZones);
            tabControl1.Controls.Add(usersPage);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 425);
            tabControl1.TabIndex = 0;
            // 
            // servicesPage
            // 
            servicesPage.AutoScroll = true;
            servicesPage.Controls.Add(label2);
            servicesPage.Controls.Add(label1);
            servicesPage.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            servicesPage.Location = new Point(4, 24);
            servicesPage.Name = "servicesPage";
            servicesPage.Padding = new Padding(3);
            servicesPage.Size = new Size(792, 397);
            servicesPage.TabIndex = 0;
            servicesPage.Text = "Услуги";
            servicesPage.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 41);
            label2.Name = "label2";
            label2.Size = new Size(220, 14);
            label2.TabIndex = 1;
            label2.Text = "Здесь вы можете забронировать место";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(10, 10);
            label1.Name = "label1";
            label1.Size = new Size(63, 21);
            label1.TabIndex = 0;
            label1.Text = "Услуги";
            // 
            // requestsPage
            // 
            requestsPage.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            requestsPage.Location = new Point(4, 24);
            requestsPage.Name = "requestsPage";
            requestsPage.Padding = new Padding(3);
            requestsPage.Size = new Size(792, 397);
            requestsPage.TabIndex = 1;
            requestsPage.Text = "Запросы";
            requestsPage.UseVisualStyleBackColor = true;
            // 
            // coworkingZones
            // 
            coworkingZones.Location = new Point(4, 24);
            coworkingZones.Name = "coworkingZones";
            coworkingZones.Size = new Size(792, 397);
            coworkingZones.TabIndex = 2;
            coworkingZones.Text = "Коворкинг зоны";
            coworkingZones.UseVisualStyleBackColor = true;
            // 
            // usersPage
            // 
            usersPage.Location = new Point(4, 24);
            usersPage.Name = "usersPage";
            usersPage.Size = new Size(792, 397);
            usersPage.TabIndex = 3;
            usersPage.Text = "Пользователи";
            usersPage.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripLabel1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.RightToLeft = RightToLeft.Yes;
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.BackColor = Color.Transparent;
            toolStripButton1.Image = Properties.Images.quit;
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(62, 22);
            toolStripButton1.Text = "Выйти";
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Alignment = ToolStripItemAlignment.Right;
            toolStripLabel1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.RightToLeft = RightToLeft.No;
            toolStripLabel1.Size = new Size(145, 22);
            toolStripLabel1.Text = "Здравствуйте, Алексей!";
            // 
            // panel1
            // 
            panel1.Controls.Add(tabControl1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 25);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 425);
            panel1.TabIndex = 3;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(toolStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(300, 200);
            Name = "Home";
            Text = "Коворкинг зона";
            tabControl1.ResumeLayout(false);
            servicesPage.ResumeLayout(false);
            servicesPage.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage servicesPage;
        private TabPage requestsPage;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private Panel panel1;
        private ToolStripLabel toolStripLabel1;
        private TabPage coworkingZones;
        private TabPage usersPage;
        private Label label1;
        private Label label2;
    }
}