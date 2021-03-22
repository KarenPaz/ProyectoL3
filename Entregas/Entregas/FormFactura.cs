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
    public partial class FormFactura : Form
    {
        EntregaBL _entregaBL;
        ClienteBL _clienteBL;

        public FormFactura()
        {
            InitializeComponent();
            _entregaBL = new EntregaBL();
            listaEntregasBindingSource.DataSource = _entregaBL.ObtenerEntregas();

            _clienteBL = new ClienteBL();
            listadeClientesBindingSource.DataSource = _clienteBL.ObtenerClientes();


        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _entregaBL.AgregarEntrega();
            listaEntregasBindingSource.MoveLast();

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

        private void listaEntregasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            listaEntregasBindingSource.EndEdit();

            var entrega = (Entrega)listaEntregasBindingSource.Current;
            var resultado = _entregaBL.GuardarEntrega(entrega);

            if (resultado.Exitoso == true)
            {
                listaEntregasBindingSource.ResetBindings(false);
                DeshabilitarHabilitarBotones(true);
                MessageBox.Show("Factura Guardada");
            }
            else
            {
                MessageBox.Show(resultado.Mensaje);
            }
        }

        private void toolStripButtonCancelar_Click(object sender, EventArgs e)
        {
            DeshabilitarHabilitarBotones(true);
            _entregaBL.CancelarCambios();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var entrega = (Entrega)listaEntregasBindingSource.Current;
            _entregaBL.AgregarEntregaDetalle(entrega);

            DeshabilitarHabilitarBotones(false);

            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
