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
            using var dbContext = new DatabaseContext();

            var currentService = dbContext.Services.First(x => x.Id == _id);

            dbContext.Services.Remove(currentService);

            dbContext.SaveChanges();

            ServiceUpdated();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            using var dbContext = new DatabaseContext();

            var service = dbContext.Services.FirstOrDefault(x => x.Id == _id);

            var setForm = new ServiceSetForm("Обновить услугу", "Обновить", service);

            setForm.ValidClick += (service) =>
            {
                using var innerDb = new DatabaseContext();

                innerDb.Services.Update(service);

                innerDb.SaveChanges();

                setForm.Close();

                ServiceUpdated();
            };

            setForm.Show();
        }

        private void requestButton_Click(object sender, EventArgs e)
        {
            using var dbContext = new DatabaseContext();

            //var requestForm = new RequestForm();

            //requestForm.Show();
        }
    }
}
