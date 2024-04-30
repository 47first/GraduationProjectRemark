using Database;
using WinFormsApplication.Forms;

namespace WinFormsApplication.Components
{
    public partial class ServiceView : UserControl
    {
        private int _id;

        public event Action ServiceUpdated = delegate { };

        public ServiceView(
            int id,
            string title,
            string description,
            string category,
            Image image,
            bool requestButtonVisible,
            bool deleteButtonVisible,
            bool updateButtonVisible)
        {
            _id = id;

            InitializeComponent();

            pictureBox1.Image = image;

            titleLabel.Text = title;
            descriptionLabel.Text = description;
            categoryLabel.Text = string.Format(categoryLabel.Text, category);

            requestButton.Visible = requestButtonVisible;
            deleteButton.Visible = deleteButtonVisible;
            updateButton.Visible = updateButtonVisible;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            var currentService = DatabaseContext.Instance.Services.First(x => x.Id == _id);

            DatabaseContext.Instance.Services.Remove(currentService);

            DatabaseContext.Instance.SaveChanges();

            ServiceUpdated();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            var service = DatabaseContext.Instance.Services.FirstOrDefault(x => x.Id == _id);

            var setForm = new ServiceSetForm("Обновить услугу", "Обновить", service);

            setForm.ValidClick += (service) =>
            {
                DatabaseContext.Instance.Services.Update(service);

                DatabaseContext.Instance.SaveChanges();

                setForm.Close();

                ServiceUpdated();
            };

            setForm.Show();
        }
    }
}
