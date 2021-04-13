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
    public partial class FormTabladePesos : Form
    {
        public FormTabladePesos()
        {
            InitializeComponent();

            //var _tabla = new EntregasBL();

            //var bindingSource = new BindingSource();
            //bindingSource.DataSource = _tabla.ObtenerEntregas();


            var reporte = new TablaDePesos();
            //reporte.SetDataSource(bindingSource);


            crystalReportViewer1.Show();
            crystalReportViewer1.RefreshReport();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
