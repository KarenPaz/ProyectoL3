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
    public partial class FormEnvio : Form
    {
        EntregasBL _entregas;
        ClienteBL _clienteBL;
        TiposBL _tipoPaquete;
        TiposBL _formadePagos;
        TiposBL _estadoDePago;
        TiposBL _status;

        public FormEnvio()
        {
            InitializeComponent();

            _entregas = new EntregasBL();
            listaEntregasBindingSource.DataSource = _entregas.ObtenerEntregas();
                       

           _clienteBL = new ClienteBL();
            listadeClientesBindingSource.DataSource = _clienteBL.ObtenerClientes();
            

            _tipoPaquete = new TiposBL();
            listaPaquetesBindingSource.DataSource = _tipoPaquete.ObtenerPaquete();

            _formadePagos = new TiposBL();
            listaPagosBindingSource.DataSource = _formadePagos.ObtenerFormasPago();

            _estadoDePago = new TiposBL();
            listaDeEstadoDePagoBindingSource.DataSource = _estadoDePago.ObtenerEstadoDePago();

            _status = new TiposBL();
            listaStatusBindingSource.DataSource = _status.ObtenerStatus();       

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form formEntrega = new FormClientes();
            //formEntrega.MdiParent = this;
            formEntrega.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form formFactura = new FormFactura();
            //formFactura.MdiParent = this;
            formFactura.Show();
        }

        private void FormEnvio_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            _entregas.CancelarCambios();
            DeshabilitarHabilitarBotones(true);
            
        }

        private void listaEntregasBindingNavigatorSaveItem_Click(object sender, EventArgs e)//GUARDAR NUEVA ENTREGA
        {
            listaEntregasBindingSource.EndEdit();
            var entrega = (Entrega)listaEntregasBindingSource.Current;

            var resultado = _entregas.GuardarEntrega(entrega);

            if (resultado.Exitoso == true)
            {
                listaEntregasBindingSource.ResetBindings(false);
                DeshabilitarHabilitarBotones(true);
                MessageBox.Show("Entrega generada");
            }
            else
            {
                MessageBox.Show(resultado.Mensaje);
            }



        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)///AGREGAR NUEVA ENTREGA
        {            
            _entregas.AgregarEntrega();
            listaEntregasBindingSource.MoveLast();
            DeshabilitarHabilitarBotones(false);

            costoTextBox.Clear();
            costoAdicionalTextBox.Clear();
            subtotalTextBox.Clear();
            impuestoTextBox.Clear();
            totalTextBox.Clear();
            
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

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            
            if (IDtextBox1.Text != "")
            {
                var resultado = MessageBox.Show("Desea eliminar este registro?", "Eliminar", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    var id = Convert.ToInt32(IDtextBox1.Text);
                    Eliminar(id);
                }                
            }            
        }

        private void Eliminar(int id)
        {
            
            var resultado = _entregas.EliminarEntrega(id);
            if (resultado == true)
            {
                listaEntregasBindingSource.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("Ocurrió un error al eliminar el registro");
            }
        }

        

        private void pesoTextBox_TextChanged_1(object sender, EventArgs e)
        {
            string peso = "";
            double tarifaBase = 45.00;
            double tarifaAdicional1 = 2.00;
            double tarifaAdicional2 = 1.90;
            double tarifaAdicional3 = 1.00;
            double tarifaAdicional4 = 0.50;
            double costoAdicional = 0;
            
            
            peso = pesoTextBox.Text;
            

            if (pesoTextBox.Text == "")
            {
                costoTextBox.Clear();
                costoAdicionalTextBox.Clear();
                subtotalTextBox.Clear();
                impuestoTextBox.Clear();
                totalTextBox.Clear();
                
            }
            else
            {
                double lbs = double.Parse(peso);
                if (lbs >= 1 && lbs <= 25)
                {
                    tarifaBase = 45.00;
                }

                if (lbs > 25 && lbs <= 50)
                {
                    costoAdicional = (lbs - 25) * tarifaAdicional1;
                }

                if (lbs > 50 && lbs <= 100)
                {
                    costoAdicional = (lbs - 25) * tarifaAdicional2;
                }

                if (lbs > 100 && lbs <= 200)
                {
                    costoAdicional = (lbs - 25) * tarifaAdicional3;
                }
                if (lbs > 200)
                {
                    costoAdicional = (lbs - 25) * tarifaAdicional4;
                }

                var entrega = (Entrega)listaEntregasBindingSource.Current;
                entrega.Costo = double.Parse(tarifaBase.ToString());
                entrega.CostoAdicional = double.Parse(costoAdicional.ToString());

                costoTextBox.Text = Math.Round(tarifaBase, 2).ToString();
                costoAdicionalTextBox.Text = Math.Round(costoAdicional, 2).ToString();

                entrega.Subtotal = costoAdicional + tarifaBase;
                entrega.Impuesto = entrega.Subtotal * 0.15;
                entrega.Total = entrega.Subtotal + entrega.Impuesto;

                subtotalTextBox.Text = Math.Round(entrega.Subtotal, 2).ToString();
                impuestoTextBox.Text = Math.Round(entrega.Impuesto, 2).ToString();
                totalTextBox.Text = Math.Round(entrega.Total, 2).ToString();
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form formTabla = new FormTabladePesos();
            formTabla.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
