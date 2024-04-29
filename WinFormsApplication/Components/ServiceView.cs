namespace WinFormsApplication.Components
{
    public partial class ServiceView : UserControl
    {
        public ServiceView(
            Image image,
            string title,
            string description,
            string category,
            bool isAdmin)
        {
            InitializeComponent();

            pictureBox1.Image = image;

            titleLabel.Text = title;
            descriptionLabel.Text = description;
            categoryLabel.Text = string.Format(categoryLabel.Text, category);

            deleteButton.Visible = isAdmin;
            updateButton.Visible = isAdmin;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

        }
    }
}
