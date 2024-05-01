namespace WinFormsApplication.Forms
{
    partial class RequestForm
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
            titleLabel = new Label();
            serviceNameLabel = new Label();
            serviceImageBox = new PictureBox();
            priceLabel = new Label();
            startTimePicker = new DateTimePicker();
            startTimeLabel = new Label();
            endTimeLabel = new Label();
            sendButton = new Button();
            splitContainer1 = new SplitContainer();
            endTimePicker = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)serviceImageBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.BackColor = Color.RoyalBlue;
            titleLabel.Dock = DockStyle.Top;
            titleLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            titleLabel.ForeColor = SystemColors.Control;
            titleLabel.Location = new Point(0, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(603, 43);
            titleLabel.TabIndex = 1;
            titleLabel.Text = "Форма запроса";
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // serviceNameLabel
            // 
            serviceNameLabel.AutoSize = true;
            serviceNameLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            serviceNameLabel.Location = new Point(11, 10);
            serviceNameLabel.Name = "serviceNameLabel";
            serviceNameLabel.Size = new Size(109, 25);
            serviceNameLabel.TabIndex = 2;
            serviceNameLabel.Text = "Услуга \"{0}\"";
            // 
            // serviceImageBox
            // 
            serviceImageBox.BackColor = Color.Lavender;
            serviceImageBox.Dock = DockStyle.Fill;
            serviceImageBox.Image = Properties.Images.people;
            serviceImageBox.Location = new Point(5, 5);
            serviceImageBox.Name = "serviceImageBox";
            serviceImageBox.Size = new Size(208, 208);
            serviceImageBox.SizeMode = PictureBoxSizeMode.Zoom;
            serviceImageBox.TabIndex = 3;
            serviceImageBox.TabStop = false;
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new Point(12, 35);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(52, 15);
            priceLabel.TabIndex = 4;
            priceLabel.Text = "Цена {0}";
            // 
            // startTimePicker
            // 
            startTimePicker.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            startTimePicker.CustomFormat = "dd.MM.yyyy HH:mm";
            startTimePicker.Format = DateTimePickerFormat.Custom;
            startTimePicker.Location = new Point(12, 78);
            startTimePicker.Name = "startTimePicker";
            startTimePicker.Size = new Size(357, 23);
            startTimePicker.TabIndex = 5;
            startTimePicker.Value = new DateTime(2024, 5, 9, 0, 0, 0, 0);
            // 
            // startTimeLabel
            // 
            startTimeLabel.AutoSize = true;
            startTimeLabel.Location = new Point(12, 60);
            startTimeLabel.Name = "startTimeLabel";
            startTimeLabel.Size = new Size(95, 15);
            startTimeLabel.TabIndex = 6;
            startTimeLabel.Text = "Начало услуги: ";
            // 
            // endTimeLabel
            // 
            endTimeLabel.AutoSize = true;
            endTimeLabel.Location = new Point(12, 111);
            endTimeLabel.Name = "endTimeLabel";
            endTimeLabel.Size = new Size(115, 15);
            endTimeLabel.TabIndex = 8;
            endTimeLabel.Text = "Окончание услуги: ";
            // 
            // sendButton
            // 
            sendButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            sendButton.Location = new Point(274, 183);
            sendButton.Name = "sendButton";
            sendButton.Size = new Size(95, 23);
            sendButton.TabIndex = 9;
            sendButton.Text = "Отправить";
            sendButton.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.FixedPanel = FixedPanel.Panel1;
            splitContainer1.IsSplitterFixed = true;
            splitContainer1.Location = new Point(0, 43);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(serviceImageBox);
            splitContainer1.Panel1.Padding = new Padding(5);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(endTimePicker);
            splitContainer1.Panel2.Controls.Add(serviceNameLabel);
            splitContainer1.Panel2.Controls.Add(sendButton);
            splitContainer1.Panel2.Controls.Add(priceLabel);
            splitContainer1.Panel2.Controls.Add(endTimeLabel);
            splitContainer1.Panel2.Controls.Add(startTimeLabel);
            splitContainer1.Panel2.Controls.Add(startTimePicker);
            splitContainer1.Size = new Size(603, 218);
            splitContainer1.SplitterDistance = 218;
            splitContainer1.TabIndex = 10;
            // 
            // endTimePicker
            // 
            endTimePicker.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            endTimePicker.CustomFormat = "dd.MM.yyyy HH:mm";
            endTimePicker.Format = DateTimePickerFormat.Custom;
            endTimePicker.Location = new Point(12, 129);
            endTimePicker.Name = "endTimePicker";
            endTimePicker.Size = new Size(357, 23);
            endTimePicker.TabIndex = 10;
            endTimePicker.Value = new DateTime(2024, 5, 9, 0, 0, 0, 0);
            // 
            // RequestForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(603, 261);
            Controls.Add(splitContainer1);
            Controls.Add(titleLabel);
            MaximizeBox = false;
            MaximumSize = new Size(619, 300);
            MinimumSize = new Size(619, 300);
            Name = "RequestForm";
            Text = "Форма запроса";
            ((System.ComponentModel.ISupportInitialize)serviceImageBox).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label titleLabel;
        private Label serviceNameLabel;
        private PictureBox serviceImageBox;
        private Label priceLabel;
        private DateTimePicker startTimePicker;
        private Label startTimeLabel;
        private Label endTimeLabel;
        private Button sendButton;
        private SplitContainer splitContainer1;
        private DateTimePicker endTimePicker;
    }
}