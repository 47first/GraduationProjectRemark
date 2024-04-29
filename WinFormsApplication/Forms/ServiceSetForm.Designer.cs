namespace WinFormsApplication.Forms
{
    partial class ServiceSetForm
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
            nameLabel = new Label();
            nameTextBox = new TextBox();
            descriptionTextBox = new TextBox();
            descriptionLabel = new Label();
            amountTextBox = new TextBox();
            amountLabel = new Label();
            imageLabel = new Label();
            imageBox = new PictureBox();
            imagesComboBox = new ComboBox();
            categoryLabel = new Label();
            categoryComboBox = new ComboBox();
            panel1 = new Panel();
            errorLabel = new Label();
            submitButton = new Button();
            ((System.ComponentModel.ISupportInitialize)imageBox).BeginInit();
            panel1.SuspendLayout();
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
            titleLabel.Size = new Size(800, 43);
            titleLabel.TabIndex = 2;
            titleLabel.Text = "Создание услуги";
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(12, 14);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(59, 15);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Название";
            // 
            // nameTextBox
            // 
            nameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nameTextBox.Location = new Point(12, 32);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(777, 23);
            nameTextBox.TabIndex = 4;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            descriptionTextBox.Location = new Point(12, 85);
            descriptionTextBox.Multiline = true;
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(777, 70);
            descriptionTextBox.TabIndex = 6;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new Point(12, 67);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(62, 15);
            descriptionLabel.TabIndex = 5;
            descriptionLabel.Text = "Описание";
            // 
            // amountTextBox
            // 
            amountTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            amountTextBox.Location = new Point(14, 185);
            amountTextBox.Name = "amountTextBox";
            amountTextBox.Size = new Size(775, 23);
            amountTextBox.TabIndex = 8;
            // 
            // amountLabel
            // 
            amountLabel.AutoSize = true;
            amountLabel.Location = new Point(14, 167);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new Size(72, 15);
            amountLabel.TabIndex = 7;
            amountLabel.Text = "Количество";
            // 
            // imageLabel
            // 
            imageLabel.AutoSize = true;
            imageLabel.Location = new Point(14, 222);
            imageLabel.Name = "imageLabel";
            imageLabel.Size = new Size(83, 15);
            imageLabel.TabIndex = 10;
            imageLabel.Text = "Изображение";
            // 
            // imageBox
            // 
            imageBox.BackColor = Color.Lavender;
            imageBox.BackgroundImageLayout = ImageLayout.Zoom;
            imageBox.Image = Properties.Images.people;
            imageBox.Location = new Point(12, 240);
            imageBox.Name = "imageBox";
            imageBox.Size = new Size(149, 100);
            imageBox.SizeMode = PictureBoxSizeMode.Zoom;
            imageBox.TabIndex = 11;
            imageBox.TabStop = false;
            // 
            // imagesComboBox
            // 
            imagesComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            imagesComboBox.FormattingEnabled = true;
            imagesComboBox.Location = new Point(167, 240);
            imagesComboBox.Name = "imagesComboBox";
            imagesComboBox.Size = new Size(622, 23);
            imagesComboBox.TabIndex = 12;
            imagesComboBox.SelectedIndexChanged += imagesComboBox_SelectedValueChanged;
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Location = new Point(14, 354);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new Size(63, 15);
            categoryLabel.TabIndex = 13;
            categoryLabel.Text = "Категория";
            // 
            // categoryComboBox
            // 
            categoryComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            categoryComboBox.FormattingEnabled = true;
            categoryComboBox.Location = new Point(12, 372);
            categoryComboBox.Name = "categoryComboBox";
            categoryComboBox.Size = new Size(777, 23);
            categoryComboBox.TabIndex = 14;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(errorLabel);
            panel1.Controls.Add(submitButton);
            panel1.Controls.Add(nameLabel);
            panel1.Controls.Add(nameTextBox);
            panel1.Controls.Add(categoryComboBox);
            panel1.Controls.Add(descriptionLabel);
            panel1.Controls.Add(categoryLabel);
            panel1.Controls.Add(descriptionTextBox);
            panel1.Controls.Add(imagesComboBox);
            panel1.Controls.Add(amountLabel);
            panel1.Controls.Add(imageBox);
            panel1.Controls.Add(amountTextBox);
            panel1.Controls.Add(imageLabel);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 43);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 493);
            panel1.TabIndex = 15;
            // 
            // errorLabel
            // 
            errorLabel.ForeColor = Color.OrangeRed;
            errorLabel.Location = new Point(14, 398);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(774, 57);
            errorLabel.TabIndex = 16;
            errorLabel.Text = "Some error";
            errorLabel.Visible = false;
            // 
            // submitButton
            // 
            submitButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            submitButton.Location = new Point(694, 458);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(94, 23);
            submitButton.TabIndex = 15;
            submitButton.Text = "Создать";
            submitButton.UseVisualStyleBackColor = true;
            submitButton.Click += submitButton_Click;
            // 
            // ServiceSetForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 536);
            Controls.Add(panel1);
            Controls.Add(titleLabel);
            MinimumSize = new Size(500, 300);
            Name = "ServiceSetForm";
            Text = "Создание услуги";
            ((System.ComponentModel.ISupportInitialize)imageBox).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label titleLabel;
        private Label nameLabel;
        private TextBox nameTextBox;
        private TextBox descriptionTextBox;
        private Label descriptionLabel;
        private TextBox amountTextBox;
        private Label amountLabel;
        private Label imageLabel;
        private PictureBox imageBox;
        private ComboBox imagesComboBox;
        private Label categoryLabel;
        private ComboBox categoryComboBox;
        private Panel panel1;
        private Label errorLabel;
        private Button submitButton;
    }
}