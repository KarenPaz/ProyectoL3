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
    }
}
