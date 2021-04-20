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
    public partial class FormUsuarios : Form
    {
        SeguridadBL _usuarios;

        public FormUsuarios()
        {
            InitializeComponent();

            _usuarios = new SeguridadBL();
            listaUsuarioBindingSource.DataSource = _usuarios.ObtenerUsuario();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _usuarios.AgregarUsuario();
            listaUsuarioBindingSource.MoveLast();
            
            DeshabilitarHabilitarBotones(false);
        }

        //Habilitar los botones 
        private void DeshabilitarHabilitarBotones(bool valor)
        {
            bindingNavigatorMoveFirstItem.Enabled = valor;
            bindingNavigatorMoveLastItem.Enabled = valor;
            bindingNavigatorMovePreviousItem.Enabled = valor;
            bindingNavigatorMoveNextItem.Enabled = valor;
            bindingNavigatorPositionItem.Enabled = valor;

            bindingNavigatorAddNewItem.Enabled = valor;
            //bindingNavigatorSaveItem.Enabled = valor;
            bindingNavigatorDeleteItem.Enabled = valor;
            toolStripButtonCancelar.Visible = !valor;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (idTextBox.Text != "")
            {
                var resultado = MessageBox.Show("Desea eliminar este Usuario?", "Eliminar", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    var Id = Convert.ToInt32(idTextBox.Text);
                    Eliminar(Id);
                }
            }
        }

        private void Eliminar(int id)
        {
            var resultado = _usuarios.EliminarUusario(id);

            if (resultado == true)
            {
                listaUsuarioBindingSource.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("Ocurrio un Error al Eliminar Usuario");
            }
        }

        
        
        private void usuarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            listaUsuarioBindingSource.EndEdit();
            var usuario = (Usuario)listaUsuarioBindingSource.Current;

            var resultado = _usuarios.GuardarUsuario(usuario);

            if (resultado.Exito == true)
            {
                listaUsuarioBindingSource.ResetBindings(false);
                DeshabilitarHabilitarBotones(true);
                MessageBox.Show("Usuario ha sido creado");
            }
            else
            {
                MessageBox.Show(resultado.Msj);
            }
        }

        //Boton de Cancelar

        private void toolStripButtonCancelar_Click_1(object sender, EventArgs e)
        {
            _usuarios.CancelarCambios();
            DeshabilitarHabilitarBotones(true);
        }
    }
}
