using BL.Entregas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entregas
{
    public partial class FormMenu : Form
    {
        Contexto _contexto;
        SeguridadBL _seguridad;

        public FormMenu()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void rentasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            Acceso();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Acceso();
        }

        private void Acceso()
        {
            var formLogin = new FormLogin();
            formLogin.ShowDialog();

            if (Program.UsuarioLogueado != null)
            {
                toolStripStatusLabel1.Text = "Usuario: " + Program.UsuarioLogueado.Nombre;

                if (Program.UsuarioLogueado.TipoUsuario == "Administradores")
                {
                    nuevoEnvíoToolStripMenuItem.Visible = true;
                    nuevaFacturaToolStripMenuItem.Visible = true;
                    nuevoClienteToolStripMenuItem.Visible = true;
                    reportesToolStripMenuItem.Visible = true;
                    clientesToolStripMenuItem.Visible = true;
                    porPesosToolStripMenuItem.Visible = true;
                    facturasToolStripMenuItem.Visible = true;
                    loginToolStripMenuItem.Visible = true;
                    administracionDeUsuariosToolStripMenuItem.Visible = true;
                    rentasToolStripMenuItem.Visible = true;
                    historialDeEnvíosToolStripMenuItem.Visible = true;
                    facturasToolStripMenuItem.Visible = true;
                    clientesToolStripMenuItem.Visible = true;
                }


                if (Program.UsuarioLogueado.TipoUsuario == "Usuario Entregas")
                {
                    nuevoEnvíoToolStripMenuItem.Visible = true;
                    nuevaFacturaToolStripMenuItem.Visible = false;
                    nuevoClienteToolStripMenuItem.Visible = false;
                    reportesToolStripMenuItem.Visible = false;
                    clientesToolStripMenuItem.Visible = false;
                    porPesosToolStripMenuItem.Visible = true;
                    facturasToolStripMenuItem.Visible = true;
                    loginToolStripMenuItem.Visible = true;
                    administracionDeUsuariosToolStripMenuItem.Visible = false;
                }


                if (Program.UsuarioLogueado.TipoUsuario == "Usuario Facturacion")
                {
                    nuevoEnvíoToolStripMenuItem.Visible = true;
                    nuevaFacturaToolStripMenuItem.Visible = true;
                    nuevoClienteToolStripMenuItem.Visible = true;
                    reportesToolStripMenuItem.Visible = false;
                    clientesToolStripMenuItem.Visible = true;
                    porPesosToolStripMenuItem.Visible = true;
                    facturasToolStripMenuItem.Visible = true;
                    loginToolStripMenuItem.Visible = true;
                    administracionDeUsuariosToolStripMenuItem.Visible = false;
                }
            }else
            {
                Application.Exit();
            }
            
            
        }


        

        
        private void nuevoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formCliente = new FormClientes();
            formCliente.MdiParent = this;
            formCliente.Show();

        }

        private void nuevoEnvíoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formEnvio = new FormEnvio();
            formEnvio.MdiParent = this;
            formEnvio.Show();
        }

        private void nuevaFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formFactura = new FormFactura();
            formFactura.MdiParent = this;
            formFactura.Show();
        }

        private void nuevaRutaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formRuta = new FormRuta();
            formRuta.MdiParent = this;
            formRuta.Show();
        }

        private void generalToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void historialDeEnvíosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formReporteEntregas = new FormReporteEntregas();
            formReporteEntregas.MdiParent = this;
            formReporteEntregas.Show();
        }

        private void facturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formReporteFacturas = new FormReporteFacturas();
            formReporteFacturas.MdiParent = this;
            formReporteFacturas.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formReporteClientes = new FormReportedeClientes();
            formReporteClientes.MdiParent = this;
            formReporteClientes.Show();
        }

        private void administracionDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formUsurios = new FormUsuarios();
            formUsurios.MdiParent = this;
            formUsurios.Show();
      
        }
    }
}
