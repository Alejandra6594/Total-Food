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
            
            // Cierra el Formulario1 si está abierto
            foreach (Form form in panelChildForm.Controls)
            {
                if (form is Productos)
                {
                    form.Close();
                    form.Dispose();
                    break;
                }
                if (form is Pedidos)
                {
                    form.Close();
                    form.Dispose();
                    break;
                }
                if (form is Historial)
                {
                    form.Close();
                    form.Dispose();
                    break;
                }
                if (form is Perfil)
                {
                    form.Close();
                    form.Dispose();
                    break;
                }
            }


            // Crea una instancia del formulario2
            Perfil Perfil = new Perfil();
            

            // Establece las propiedades necesarias para mostrar el formulario en el panel contenedor
            Perfil.TopLevel = false;
            Perfil.Dock = DockStyle.Fill;

            // Agrega el formulario al panel contenedor y lo muestra
            panelChildForm.Controls.Add(Perfil);
            Perfil.Show();


        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            // Cierra el Formulario1 si está abierto
            foreach (Form form in panelChildForm.Controls)
            {
                if (form is Productos)
                {
                    form.Close();
                    form.Dispose();
                    break;
                }
                if (form is Pedidos)
                {
                    form.Close();
                    form.Dispose();
                    break;
                }
                if (form is Perfil)
                {
                    form.Close();
                    form.Dispose();
                    break;
                }
                if (form is Historial)
                {
                    form.Close();
                    form.Dispose();
                    break;
                }
            }
            Historial Historial = new Historial();
            Historial.TopLevel = false;
            Historial.Dock = DockStyle.Fill;

            // Agrega el formulario al panel contenedor y lo muestra
            panelChildForm.Controls.Add(Historial);
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
            foreach (Form form in panelChildForm.Controls)
            {
                if (form is Historial)
                {
                    form.Close();
                    form.Dispose();
                    break;
                }
                if (form is Pedidos)
                {
                    form.Close();
                    form.Dispose();
                    break;
                }
                if (form is Perfil)
                {
                    form.Close();
                    form.Dispose();
                    break;
                }
                if (form is Productos)
                {
                    form.Close();
                    form.Dispose();
                    break;
                }
            }
            Productos Productos = new Productos();
            Productos.TopLevel = false;
            Productos.Dock = DockStyle.Fill;

            // Agrega el formulario al panel contenedor y lo muestra
            panelChildForm.Controls.Add(Productos);
            Productos.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (Form form in panelChildForm.Controls)
            {
                if (form is Historial)
                {
                    form.Close();
                    form.Dispose();
                    break;
                }
                if (form is Productos)
                {
                    form.Close();
                    form.Dispose();
                    break;
                }
                if (form is Perfil)
                {
                    form.Close();
                    form.Dispose();
                    break;
                }
                if (form is Pedidos)
                {
                    form.Close();
                    form.Dispose();
                    break;
                }
            }
            Pedidos Pedidos = new Pedidos();
            Pedidos.TopLevel = false;
            Pedidos.Dock = DockStyle.Fill;

            // Agrega el formulario al panel contenedor y lo muestra
            panelChildForm.Controls.Add(Pedidos);
            Pedidos.Show();
        }
    }
}