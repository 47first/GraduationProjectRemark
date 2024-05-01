﻿namespace WinFormsApplication.Forms
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
            servicesPage1 = new Pages.ServicesPage();
            requestsPage = new TabPage();
            requestsPage1 = new Pages.RequestsPage();
            header = new ToolStrip();
            quitButton = new ToolStripButton();
            welcomeLabel = new ToolStripLabel();
            panel1 = new Panel();
            pagesControl.SuspendLayout();
            servicesPage.SuspendLayout();
            requestsPage.SuspendLayout();
            header.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pagesControl
            // 
            pagesControl.Controls.Add(servicesPage);
            pagesControl.Controls.Add(requestsPage);
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
            // servicesPage
            // 
            servicesPage.BackColor = SystemColors.Window;
            servicesPage.Controls.Add(servicesPage1);
            servicesPage.Font = new Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point, 204);
            servicesPage.Location = new Point(4, 29);
            servicesPage.Name = "servicesPage";
            servicesPage.Padding = new Padding(3);
            servicesPage.Size = new Size(792, 382);
            servicesPage.TabIndex = 0;
            servicesPage.Text = "Услуги";
            servicesPage.UseVisualStyleBackColor = true;
            servicesPage.Enter += servicesPage_Enter;
            // 
            // servicesPage1
            // 
            servicesPage1.Dock = DockStyle.Fill;
            servicesPage1.Location = new Point(3, 3);
            servicesPage1.Name = "servicesPage1";
            servicesPage1.Size = new Size(786, 376);
            servicesPage1.TabIndex = 0;
            // 
            // requestsPage
            // 
            requestsPage.Controls.Add(requestsPage1);
            requestsPage.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            requestsPage.Location = new Point(4, 29);
            requestsPage.Name = "requestsPage";
            requestsPage.Padding = new Padding(3);
            requestsPage.Size = new Size(792, 382);
            requestsPage.TabIndex = 1;
            requestsPage.Text = "Запросы";
            requestsPage.UseVisualStyleBackColor = true;
            requestsPage.Enter += requestsPage_Enter;
            // 
            // requestsPage1
            // 
            requestsPage1.Dock = DockStyle.Fill;
            requestsPage1.Location = new Point(3, 3);
            requestsPage1.Name = "requestsPage1";
            requestsPage1.Size = new Size(786, 376);
            requestsPage1.TabIndex = 0;
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
            // welcomeLabel
            // 
            welcomeLabel.Alignment = ToolStripItemAlignment.Right;
            welcomeLabel.BackColor = Color.Transparent;
            welcomeLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            welcomeLabel.ForeColor = SystemColors.ControlLightLight;
            welcomeLabel.Margin = new Padding(10, 1, 0, 2);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.RightToLeft = RightToLeft.No;
            welcomeLabel.Size = new Size(122, 32);
            welcomeLabel.Text = "Коворкинг зона";
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
            Text = "Коворкинг зона";
            pagesControl.ResumeLayout(false);
            servicesPage.ResumeLayout(false);
            requestsPage.ResumeLayout(false);
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
        private Pages.ServicesPage servicesPage1;
        private Pages.RequestsPage requestsPage1;
    }
}