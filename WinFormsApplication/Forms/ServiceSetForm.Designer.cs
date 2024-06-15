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
            imageLabel = new Label();
            imageBox = new PictureBox();
            categoryLabel = new Label();
            categoryComboBox = new ComboBox();
            panel1 = new Panel();
            priceInput = new NumericUpDown();
            priceLabel = new Label();
            paymentTypeComboBox = new ComboBox();
            paymentTypeLabel = new Label();
            errorLabel = new Label();
            submitButton = new Button();
            openFileDialog = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)imageBox).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)priceInput).BeginInit();
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
            // imageLabel
            // 
            imageLabel.AutoSize = true;
            imageLabel.Location = new Point(12, 170);
            imageLabel.Name = "imageLabel";
            imageLabel.Size = new Size(83, 15);
            imageLabel.TabIndex = 10;
            imageLabel.Text = "Изображение";
            // 
            // imageBox
            // 
            imageBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            imageBox.BackColor = Color.Lavender;
            imageBox.BackgroundImageLayout = ImageLayout.Zoom;
            imageBox.Cursor = Cursors.Hand;
            imageBox.Image = Properties.Images.people;
            imageBox.Location = new Point(10, 188);
            imageBox.Name = "imageBox";
            imageBox.Size = new Size(774, 100);
            imageBox.SizeMode = PictureBoxSizeMode.Zoom;
            imageBox.TabIndex = 11;
            imageBox.TabStop = false;
            imageBox.DoubleClick += imageBox_DoubleClick;
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Location = new Point(12, 302);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new Size(63, 15);
            categoryLabel.TabIndex = 13;
            categoryLabel.Text = "Категория";
            // 
            // categoryComboBox
            // 
            categoryComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            categoryComboBox.FormattingEnabled = true;
            categoryComboBox.Location = new Point(10, 320);
            categoryComboBox.Name = "categoryComboBox";
            categoryComboBox.Size = new Size(777, 23);
            categoryComboBox.TabIndex = 14;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(priceInput);
            panel1.Controls.Add(priceLabel);
            panel1.Controls.Add(paymentTypeComboBox);
            panel1.Controls.Add(paymentTypeLabel);
            panel1.Controls.Add(errorLabel);
            panel1.Controls.Add(submitButton);
            panel1.Controls.Add(nameLabel);
            panel1.Controls.Add(nameTextBox);
            panel1.Controls.Add(categoryComboBox);
            panel1.Controls.Add(descriptionLabel);
            panel1.Controls.Add(categoryLabel);
            panel1.Controls.Add(descriptionTextBox);
            panel1.Controls.Add(imageBox);
            panel1.Controls.Add(imageLabel);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 43);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 567);
            panel1.TabIndex = 15;
            // 
            // priceInput
            // 
            priceInput.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            priceInput.Location = new Point(10, 433);
            priceInput.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            priceInput.Name = "priceInput";
            priceInput.Size = new Size(777, 23);
            priceInput.TabIndex = 22;
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new Point(10, 415);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(35, 15);
            priceLabel.TabIndex = 19;
            priceLabel.Text = "Цена";
            // 
            // paymentTypeComboBox
            // 
            paymentTypeComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            paymentTypeComboBox.FormattingEnabled = true;
            paymentTypeComboBox.Location = new Point(10, 376);
            paymentTypeComboBox.Name = "paymentTypeComboBox";
            paymentTypeComboBox.Size = new Size(777, 23);
            paymentTypeComboBox.TabIndex = 18;
            // 
            // paymentTypeLabel
            // 
            paymentTypeLabel.AutoSize = true;
            paymentTypeLabel.Location = new Point(12, 358);
            paymentTypeLabel.Name = "paymentTypeLabel";
            paymentTypeLabel.Size = new Size(71, 15);
            paymentTypeLabel.TabIndex = 17;
            paymentTypeLabel.Text = "Тип оплаты";
            // 
            // errorLabel
            // 
            errorLabel.ForeColor = Color.OrangeRed;
            errorLabel.Location = new Point(12, 470);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(774, 57);
            errorLabel.TabIndex = 16;
            errorLabel.Text = "Some error";
            errorLabel.Visible = false;
            // 
            // submitButton
            // 
            submitButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            submitButton.Location = new Point(690, 530);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(94, 23);
            submitButton.TabIndex = 15;
            submitButton.Text = "Создать";
            submitButton.UseVisualStyleBackColor = true;
            submitButton.Click += submitButton_Click;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "image";
            // 
            // ServiceSetForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 610);
            Controls.Add(panel1);
            Controls.Add(titleLabel);
            MinimumSize = new Size(500, 300);
            Name = "ServiceSetForm";
            Text = "Создание услуги";
            ((System.ComponentModel.ISupportInitialize)imageBox).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)priceInput).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label titleLabel;
        private Label nameLabel;
        private TextBox nameTextBox;
        private TextBox descriptionTextBox;
        private Label descriptionLabel;
        private Label imageLabel;
        private PictureBox imageBox;
        private Label categoryLabel;
        private ComboBox categoryComboBox;
        private Panel panel1;
        private Label errorLabel;
        private Button submitButton;
        private ComboBox paymentTypeComboBox;
        private Label paymentTypeLabel;
        private Label priceLabel;
        private NumericUpDown priceInput;
        private OpenFileDialog openFileDialog;
    }
}