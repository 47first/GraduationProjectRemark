namespace WinFormsApplication.Components
{
    partial class RequestView
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
            completedCheckBox = new CheckBox();
            titleLabel = new Label();
            priceLabel = new Label();
            userNameLabel = new Label();
            employeeLabelName = new Label();
            serviceImageBox = new PictureBox();
            createTimeLabel = new Label();
            servicePeriodLabel = new Label();
            endTimeLabel = new Label();
            appointButton = new Button();
            ((System.ComponentModel.ISupportInitialize)serviceImageBox).BeginInit();
            SuspendLayout();
            // 
            // completedCheckBox
            // 
            completedCheckBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            completedCheckBox.AutoSize = true;
            completedCheckBox.Location = new Point(438, 252);
            completedCheckBox.Name = "completedCheckBox";
            completedCheckBox.Size = new Size(82, 19);
            completedCheckBox.TabIndex = 100;
            completedCheckBox.Text = "Пройдено";
            completedCheckBox.UseVisualStyleBackColor = true;
            completedCheckBox.CheckedChanged += completedCheckBox_CheckedChanged;
            // 
            // titleLabel
            // 
            titleLabel.BackColor = Color.RoyalBlue;
            titleLabel.Dock = DockStyle.Top;
            titleLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            titleLabel.ForeColor = SystemColors.ButtonHighlight;
            titleLabel.Location = new Point(0, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(533, 35);
            titleLabel.TabIndex = 1;
            titleLabel.Text = "Название";
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            priceLabel.Location = new Point(14, 44);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(86, 21);
            priceLabel.TabIndex = 101;
            priceLabel.Text = "Цена: {0} р";
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            userNameLabel.Location = new Point(14, 74);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new Size(83, 17);
            userNameLabel.TabIndex = 102;
            userNameLabel.Text = "Заказчик: {0}";
            // 
            // employeeLabelName
            // 
            employeeLabelName.AutoSize = true;
            employeeLabelName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            employeeLabelName.Location = new Point(15, 101);
            employeeLabelName.Name = "employeeLabelName";
            employeeLabelName.Size = new Size(108, 17);
            employeeLabelName.TabIndex = 103;
            employeeLabelName.Text = "Исполнитель: {0}";
            // 
            // serviceImageBox
            // 
            serviceImageBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            serviceImageBox.Location = new Point(308, 38);
            serviceImageBox.Name = "serviceImageBox";
            serviceImageBox.Size = new Size(222, 201);
            serviceImageBox.SizeMode = PictureBoxSizeMode.Zoom;
            serviceImageBox.TabIndex = 104;
            serviceImageBox.TabStop = false;
            // 
            // createTimeLabel
            // 
            createTimeLabel.AutoSize = true;
            createTimeLabel.Location = new Point(15, 159);
            createTimeLabel.Name = "createTimeLabel";
            createTimeLabel.Size = new Size(115, 15);
            createTimeLabel.TabIndex = 105;
            createTimeLabel.Text = "Время создания: {0}";
            // 
            // servicePeriodLabel
            // 
            servicePeriodLabel.AutoSize = true;
            servicePeriodLabel.Location = new Point(14, 209);
            servicePeriodLabel.Name = "servicePeriodLabel";
            servicePeriodLabel.Size = new Size(95, 30);
            servicePeriodLabel.TabIndex = 106;
            servicePeriodLabel.Text = "Период услуги: \r{0} - {1}";
            // 
            // endTimeLabel
            // 
            endTimeLabel.AutoSize = true;
            endTimeLabel.Location = new Point(15, 185);
            endTimeLabel.Name = "endTimeLabel";
            endTimeLabel.Size = new Size(125, 15);
            endTimeLabel.TabIndex = 107;
            endTimeLabel.Text = "Время окончания: {0}";
            // 
            // appointButton
            // 
            appointButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            appointButton.Location = new Point(9, 248);
            appointButton.Name = "appointButton";
            appointButton.Size = new Size(121, 23);
            appointButton.TabIndex = 108;
            appointButton.Text = "Назначить на себя";
            appointButton.UseVisualStyleBackColor = true;
            // 
            // RequestView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(appointButton);
            Controls.Add(endTimeLabel);
            Controls.Add(servicePeriodLabel);
            Controls.Add(createTimeLabel);
            Controls.Add(serviceImageBox);
            Controls.Add(employeeLabelName);
            Controls.Add(userNameLabel);
            Controls.Add(priceLabel);
            Controls.Add(titleLabel);
            Controls.Add(completedCheckBox);
            MinimumSize = new Size(533, 248);
            Name = "RequestView";
            Size = new Size(533, 283);
            ((System.ComponentModel.ISupportInitialize)serviceImageBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox completedCheckBox;
        private Label titleLabel;
        private Label priceLabel;
        private Label userNameLabel;
        private Label employeeLabelName;
        private PictureBox serviceImageBox;
        private Label createTimeLabel;
        private Label servicePeriodLabel;
        private Label endTimeLabel;
        private Button appointButton;
    }
}
