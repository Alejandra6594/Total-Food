namespace Pantalla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            hideSubMenu();
        }
        private void hideSubMenu()
        {
            panelSolicitudes.Visible = false;

        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void panelSideMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void btnSolicitudes_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSolicitudes);
        }
    }
}