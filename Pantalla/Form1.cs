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
            Perfil Perfil = new Perfil();
            Perfil.TopLevel = false;
            Perfil.Dock = DockStyle.Fill;
            Perfil.FormBorderStyle = FormBorderStyle.None;

            // Agregar el formulario al panel
            panelChildForm.Controls.Add(Perfil);

            // Mostrar el formulario dentro del panel
            Perfil.Show();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Historial Historial = new Historial();
            Historial.TopLevel = false;
            Historial.Dock = DockStyle.Fill;
            Historial.FormBorderStyle = FormBorderStyle.None;

            // Agregar el formulario al panel
            panelChildForm.Controls.Add(Historial);

            // Mostrar el formulario dentro del panel
            Historial.Show();
          
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void btnSolicitudes_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSolicitudes);
        }

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Productos Productos = new Productos();
            Productos.TopLevel = false;
            Productos.Dock = DockStyle.Fill;
            Productos.FormBorderStyle = FormBorderStyle.None;

            // Agregar el formulario al panel
            panelChildForm.Controls.Add(Productos);

            // Mostrar el formulario dentro del panel
            Productos.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Pedidos Pedidos = new Pedidos();
            Pedidos.TopLevel = false;
            Pedidos.Dock = DockStyle.Fill;
            Pedidos.FormBorderStyle = FormBorderStyle.None;

            // Agregar el formulario al panel
            panelChildForm.Controls.Add(Pedidos);

            // Mostrar el formulario dentro del panel
            Pedidos.Show();
        }
    }
}