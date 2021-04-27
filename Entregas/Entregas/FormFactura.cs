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
        FacturaBL _facturaBL;
        ClienteBL _clientesBL;
        EntregasBL _entregasBL;

        public FormFactura()
        {
            InitializeComponent();
            _facturaBL = new FacturaBL();
            listaFacturasBindingSource.DataSource = _facturaBL.ObtenerFacturas();
            _clientesBL = new ClienteBL();
            listadeClientesBindingSource.DataSource = _clientesBL.ObtenerClientes();
            _entregasBL = new EntregasBL();
            listaEntregasBindingSource.DataSource = _entregasBL.ObtenerEntregas();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _facturaBL.AgregarFactura();
            listaFacturasBindingSource.MoveLast();
            //facturaDetalleDataGridView.ClearSelection();

            DeshabilitarHabilitarBotones(false);
        }

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

        private void listaFacturasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            listaFacturasBindingSource.EndEdit();
            var factura = (Factura)listaFacturasBindingSource.Current;

            var resultado = _facturaBL.GuardarFactura(factura);

            if (resultado.Exitoso == true)
            {
                listaFacturasBindingSource.ResetBindings(false);
                DeshabilitarHabilitarBotones(true);
                MessageBox.Show("Factura generada");
            }
            else
            {
                MessageBox.Show(resultado.Mensaje);
            }
        }

        public void MarcarFacturado(int id)
        {
            

        }
        

        private void toolStripButtonCancelar_Click(object sender, EventArgs e)
        {
            _facturaBL.CancelarCambios();
            DeshabilitarHabilitarBotones(true);
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
            var resultado = _facturaBL.AnularFactura(id);

            if (resultado == true)
            {
                listaFacturasBindingSource.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("Ocurrio un error al anular la factura");
            }
        }



        private void listaFacturasBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var factura = (Factura)listaFacturasBindingSource.Current;
            _facturaBL.AgregarFacturaDetalle(factura);
            DeshabilitarHabilitarBotones(false);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var factura = (Factura)listaFacturasBindingSource.Current;
            var facturaDetalle = (FacturaDetalle)facturaDetalleBindingSource.Current;
            _facturaBL.RemoverFacturaDetalle(factura, facturaDetalle);
            
                DeshabilitarHabilitarBotones(false);
        }

        private void facturaDetalleDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }

        private void facturaDetalleDataGridView_DataError_1(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }

        private void facturaDetalleDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var factura = (Factura)listaFacturasBindingSource.Current;
            _facturaBL.CalcularFactura(factura);
            listaFacturasBindingSource.ResetBindings(false);
        }

        private void listaFacturasBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            var factura = (Factura)listaFacturasBindingSource.Current;
            if (factura != null && factura.Id !=0 && factura.Activo == false)
            {
                label1.Visible = true;
            }
            else
            {
                label1.Visible = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form formEnvio = new FormEnvio();
            formEnvio.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void bindingNavigatorPositionItem_Click(object sender, EventArgs e)
        {

        }
    }
    
}
