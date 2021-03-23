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
            var entrega = (Entrega)listaEntregasBindingSource.Current;
            var entregaDetalle = (EntregaDetalle)entregaDetalleBindingSource.Current;

            _entregaBL.RemoverEntregaDetalle(entrega, entregaDetalle);
            DeshabilitarHabilitarBotones(false);

        }

        private void entregaDetalleDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }

        private void entregaDetalleDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var entrega = (Entrega)listaEntregasBindingSource.Current;
            _entregaBL.CalcularEntrega(entrega);

            listaEntregasBindingSource.ResetBindings(false);
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (idTextBox.Text != "")
            {
                var resultado = MessageBox.Show("Desea anular esta factura?", "Anular", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    var id = Convert.ToInt32(idTextBox.Text);
                    Anular(id);
                }
            }
        }

        private void Anular(int id)
        {
            var resultado = _entregaBL.AnularEntrega(id);
            if (resultado == true)
            {
                listaEntregasBindingSource.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("Ocurrio un error al anular la factutra");
            }
        }

        private void listaEntregasBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            var entrega = (Entrega)listaEntregasBindingSource.Current;

            if (entrega != null && entrega.Id != 0 && entrega.Activo == false)
            {
                label1.Visible = true;
            }
            else
            {
                label1.Visible = false;
            }
        }
    }
}
