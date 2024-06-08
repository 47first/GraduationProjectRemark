namespace WinFormsApplication.Pages
{
    partial class StatisticsPage
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
            createButton = new Button();
            label1 = new Label();
            totalCompletedRequests = new Label();
            totalRequestRevenueLabel = new Label();
            topUsefullCategories = new Label();
            mostActiveEmployeeLabel = new Label();
            mostActiveUserLabel = new Label();
            mostPopularServiceLabel = new Label();
            createdRequestAmountLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
            splitContainer.Panel1.SuspendLayout();
            splitContainer.Panel2.SuspendLayout();
            splitContainer.SuspendLayout();
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
            splitContainer.Panel1.Controls.Add(createButton);
            splitContainer.Panel1.Controls.Add(label1);
            // 
            // splitContainer.Panel2
            // 
            splitContainer.Panel2.Controls.Add(createdRequestAmountLabel);
            splitContainer.Panel2.Controls.Add(totalCompletedRequests);
            splitContainer.Panel2.Controls.Add(totalRequestRevenueLabel);
            splitContainer.Panel2.Controls.Add(topUsefullCategories);
            splitContainer.Panel2.Controls.Add(mostActiveEmployeeLabel);
            splitContainer.Panel2.Controls.Add(mostActiveUserLabel);
            splitContainer.Panel2.Controls.Add(mostPopularServiceLabel);
            splitContainer.Size = new Size(788, 529);
            splitContainer.SplitterDistance = 35;
            splitContainer.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(109, 11);
            label2.Name = "label2";
            label2.Size = new Size(228, 15);
            label2.TabIndex = 3;
            label2.Text = "Здесь находится подробная статистика";
            // 
            // createButton
            // 
            createButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            createButton.BackColor = SystemColors.ButtonHighlight;
            createButton.FlatStyle = FlatStyle.Flat;
            createButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            createButton.ForeColor = Color.RoyalBlue;
            createButton.Location = new Point(1348, 7);
            createButton.Name = "createButton";
            createButton.Size = new Size(75, 23);
            createButton.TabIndex = 1;
            createButton.Text = "Создать";
            createButton.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(7, 6);
            label1.Name = "label1";
            label1.Size = new Size(96, 21);
            label1.TabIndex = 2;
            label1.Text = "Статистика";
            // 
            // totalCompletedRequests
            // 
            totalCompletedRequests.AutoSize = true;
            totalCompletedRequests.Font = new Font("Segoe UI", 11F);
            totalCompletedRequests.Location = new Point(7, 177);
            totalCompletedRequests.Name = "totalCompletedRequests";
            totalCompletedRequests.Size = new Size(316, 20);
            totalCompletedRequests.TabIndex = 5;
            totalCompletedRequests.Text = "Общее количество завершенных заявок: {0}";
            // 
            // totalRequestRevenueLabel
            // 
            totalRequestRevenueLabel.AutoSize = true;
            totalRequestRevenueLabel.Font = new Font("Segoe UI", 11F);
            totalRequestRevenueLabel.Location = new Point(7, 110);
            totalRequestRevenueLabel.Name = "totalRequestRevenueLabel";
            totalRequestRevenueLabel.Size = new Size(224, 20);
            totalRequestRevenueLabel.TabIndex = 4;
            totalRequestRevenueLabel.Text = "Общая сумма за все время: {0}";
            // 
            // topUsefullCategories
            // 
            topUsefullCategories.AutoSize = true;
            topUsefullCategories.Font = new Font("Segoe UI", 11F);
            topUsefullCategories.Location = new Point(7, 210);
            topUsefullCategories.Name = "topUsefullCategories";
            topUsefullCategories.Size = new Size(267, 20);
            topUsefullCategories.TabIndex = 3;
            topUsefullCategories.Text = "Часто приобретаемые категории: {0}";
            // 
            // mostActiveEmployeeLabel
            // 
            mostActiveEmployeeLabel.AutoSize = true;
            mostActiveEmployeeLabel.Font = new Font("Segoe UI", 11F);
            mostActiveEmployeeLabel.Location = new Point(7, 77);
            mostActiveEmployeeLabel.Name = "mostActiveEmployeeLabel";
            mostActiveEmployeeLabel.Size = new Size(228, 20);
            mostActiveEmployeeLabel.TabIndex = 2;
            mostActiveEmployeeLabel.Text = "Самый активный сотрудник: {0}";
            // 
            // mostActiveUserLabel
            // 
            mostActiveUserLabel.AutoSize = true;
            mostActiveUserLabel.Font = new Font("Segoe UI", 11F);
            mostActiveUserLabel.Location = new Point(7, 43);
            mostActiveUserLabel.Name = "mostActiveUserLabel";
            mostActiveUserLabel.Size = new Size(218, 20);
            mostActiveUserLabel.TabIndex = 1;
            mostActiveUserLabel.Text = "Самый активный заказчик: {0}";
            // 
            // mostPopularServiceLabel
            // 
            mostPopularServiceLabel.AutoSize = true;
            mostPopularServiceLabel.Font = new Font("Segoe UI", 11F);
            mostPopularServiceLabel.Location = new Point(7, 10);
            mostPopularServiceLabel.Name = "mostPopularServiceLabel";
            mostPopularServiceLabel.Size = new Size(270, 20);
            mostPopularServiceLabel.TabIndex = 0;
            mostPopularServiceLabel.Text = "Самая часто используемая услуга: {0}";
            // 
            // createdRequestAmountLabel
            // 
            createdRequestAmountLabel.AutoSize = true;
            createdRequestAmountLabel.Font = new Font("Segoe UI", 11F);
            createdRequestAmountLabel.Location = new Point(7, 144);
            createdRequestAmountLabel.Name = "createdRequestAmountLabel";
            createdRequestAmountLabel.Size = new Size(245, 20);
            createdRequestAmountLabel.TabIndex = 6;
            createdRequestAmountLabel.Text = "Количество созданных заявок: {0}";
            // 
            // StatisticsPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer);
            Name = "StatisticsPage";
            Size = new Size(788, 529);
            splitContainer.Panel1.ResumeLayout(false);
            splitContainer.Panel1.PerformLayout();
            splitContainer.Panel2.ResumeLayout(false);
            splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
            splitContainer.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer;
        private Label label2;
        private Button createButton;
        private Label label1;
        private Label mostPopularServiceLabel;
        private Label mostActiveUserLabel;
        private Label mostActiveEmployeeLabel;
        private Label topUsefullCategories;
        private Label totalRequestRevenueLabel;
        private Label totalCompletedRequests;
        private Label createdRequestAmountLabel;
    }
}
