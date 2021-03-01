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
    public partial class FormClientes : Form
    {
        ClienteBL _clientes;

        public FormClientes()
        {
            InitializeComponent();

            _clientes = new ClienteBL();
            listadeClientesBindingSource.DataSource = _clientes.ObtenerClientes();
        }

        private void FormClientes_Load(object sender, EventArgs e)
        {
            
        }

        private void nombredeEmpresaLabel_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _clientes.AgregarCliente();
            listadeClientesBindingSource.MoveLast();

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
            bindingNavigatorDeleteItem.Enabled = valor;
            toolStripButtonCancelar.Visible = !valor;
        }

        private void listadeClientesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            listadeClientesBindingSource.EndEdit();
            var cliente = (Clientes)listadeClientesBindingSource.Current;

            var resultado = _clientes.GuardarCliente(cliente);

            if (resultado.Exitoso == true)
            {
                listadeClientesBindingSource.ResetBindings(false);
                DeshabilitarHabilitarBotones(true);
                MessageBox.Show("Producto Guardado");
            }
            else
            {
                MessageBox.Show(resultado.Mensaje);
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (IdTextBox.Text != "" )
            {
                var resultado = MessageBox.Show("Desea eliminar este Cliente?", "Eliminar", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    var Id = Convert.ToInt32(IdTextBox.Text);
                    Eliminar(Id);
                }
            }
            
        }

        private void Eliminar(int id)
        {            
            var resultado = _clientes.EliminarCliente(id);

            if (resultado == true)
            {
                listadeClientesBindingSource.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("Ocurrio un Error al Eliminar Cliente");
            }
        }

        //Boton de Cancelar

        private void toolStripButtonCancelar_Click(object sender, EventArgs e)
        {
            DeshabilitarHabilitarBotones(true);
            Eliminar(0);
        }

        private void IdTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
