using BL.Entregas;
//using System;
//using System.Windows.Forms;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
namespace Entregas
{
    public partial class FormUsuario : Form
    {
        SeguridadBL _usuariosBL;

        public FormUsuario()
        {
            InitializeComponent();

            _usuariosBL = new SeguridadBL();
            listaUsuariosBindingSource.DataSource = _usuariosBL.ObtenerUsuario();
        }

        private void listaFacturasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            listaUsuariosBindingSource.EndEdit();
            var usuario = (Usuario)listaUsuariosBindingSource.Current;

            var resultado = _usuariosBL.GuardarUsuario(usuario);

            if (resultado.Exitoso == true)
            {
                listaUsuariosBindingSource.ResetBindings(false);
                DeshabilitarHabilitarBotones(true);
                MessageBox.Show("Usuario guardado");
            }
            else
            {
                MessageBox.Show(resultado.Mensaje);
            }

        }

        private void DeshabilitarHabilitarBotones(bool valor)
        {
            bindingNavigatorMoveFirstItem.Enabled = valor;
            bindingNavigatorMoveLastItem.Enabled = valor;
            bindingNavigatorMovePreviousItem.Enabled = valor;
            bindingNavigatorMoveNextItem.Enabled = valor;
            bindingNavigatorPositionItem.Enabled = valor;

            bindingNavigatorAddNewItem.Enabled = valor;
            bindingNavigatorSaveItem.Enabled = valor;
            bindingNavigatorDeleteItem.Enabled = valor;
            toolStripButtonCancelar.Visible = !valor;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (idTextBox.Text != "")
            {
                var resultado = MessageBox.Show("Desea anular esta factura?", "Anular", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    var id = Convert.ToInt32(idTextBox.Text);
                    Elimiar(id);
                }
            }
        }

        private void Elimiar(int id)
        {
            var resultado = _usuariosBL.ElimiarUsuario(id);

            if (resultado == true)
            {
                listaUsuariosBindingSource.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("Ocurrio un error al anular el Usuario");
            }
        }

        private void toolStripButtonCancelar_Click(object sender, EventArgs e)
        {
            _usuariosBL.CancelarCambios();
            DeshabilitarHabilitarBotones(true);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _usuariosBL.AgregarUsuario();
            listaUsuariosBindingSource.MoveLast();
           

            DeshabilitarHabilitarBotones(false);
        }
    }
}
