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

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void servicesContainer_SizeChanged(object sender, EventArgs e)
        {
            if (sender is not FlowLayoutPanel flowLayoutPanel)
            {
                return;
            }

            foreach (ServiceView control in flowLayoutPanel.Controls)
            {
                control.Size = new()
                {
                    Width = flowLayoutPanel.Size.Width,
                    Height = control.Size.Height
                };
            }
        }
    }
}
