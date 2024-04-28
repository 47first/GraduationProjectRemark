namespace WinFormsApplication.Components
{
    public partial class ServiceView : UserControl
    {
        public ServiceView(string title, string description)
        {
            InitializeComponent();

            titleLabel.Text = title;
            descriptionLabel.Text = description;
        }
    }
}
