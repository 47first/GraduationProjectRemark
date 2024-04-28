using Database;
using WinFormsApplication.Components;

namespace WinFormsApplication.Forms
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void servicesPage_Enter(object sender, EventArgs e)
        {
            servicesPage1.EnterPage();
        }

        private void Home_Resize(object sender, EventArgs e)
        {
        }
    }
}
