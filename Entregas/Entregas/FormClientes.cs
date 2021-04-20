using BL.Entregas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entregas
{
    public partial class FormClientes : Form
    {
        ClienteBL _clientes;
        //private Stream fileStream;//
        TiposBL _tiposBL;                                                                                                

        public FormClientes()
        {
            InitializeComponent();

            _clientes = new ClienteBL();
            listadeClientesBindingSource.DataSource = _clientes.ObtenerClientes();

            _tiposBL = new TiposBL();//
            listaTiposBindingSource.DataSource = _tiposBL.ObtenerTipo();
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

            bindingNavigatorSaveItem.Enabled = valor;
            bindingNavigatorDeleteItem.Enabled = valor;
            toolStripButtonCancelar.Visible = !valor;
        }

        private void listadeClientesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            listadeClientesBindingSource.EndEdit();
            var cliente = (Clientes)listadeClientesBindingSource.Current;

            if (fotoPictureBox.Image != null)//
            {
                cliente.Foto = Program.imageToByteArray(fotoPictureBox.Image);//
            }
            else
            {
                cliente.Foto = null;//
            }

            var resultado = _clientes.GuardarCliente(cliente);

            if (resultado.Exitoso == true)
            {
                listadeClientesBindingSource.ResetBindings(false);
                DeshabilitarHabilitarBotones(true);
                MessageBox.Show("Cliente ha sido creado");
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
            _clientes.CancelarCambios();//
            DeshabilitarHabilitarBotones(true);
          
        }

        private void IdTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//
        {
            var cliente = (Clientes)listadeClientesBindingSource.Current;//
            if(cliente != null)//
            { 
            openFileDialog1.ShowDialog();//
            var archivo = openFileDialog1.FileName;//

                if (archivo != "")//
                {
                    var fileInfo = new FileInfo(archivo);//
                    var fileStream = fileInfo.OpenRead();//

                    fotoPictureBox.Image = Image.FromStream(fileStream);//
                } 
            }
            else//
            {
                MessageBox.Show("Cree un cliente antes de asignarle una imagen");//
            }
        }

        private void button2_Click(object sender, EventArgs e)//
        {
            fotoPictureBox.Image = null;//

        }

        private void fotoPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void tipoIdComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
