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
    public partial class FormReporteEntregas : Form
    {
        public FormReporteEntregas()
        {
            InitializeComponent();

            var _entregaBL = new EntregasBL();
            var _remitente = new ClienteBL();
            var _estadoDePago = new TiposBL();
            var _status = new TiposBL();
           

            var bindingSource = new BindingSource();
            bindingSource.DataSource = _entregaBL.ObtenerEntregas();

            var bindingSource2 = new BindingSource();
            bindingSource2.DataSource = _remitente.ObtenerClientes();

            var bindingSource3 = new BindingSource();
            bindingSource3.DataSource = _estadoDePago.ObtenerEstadoDePago();

            var bindingSource4 = new BindingSource();
            bindingSource4.DataSource = _status.ObtenerStatus();

            var reporte = new ReporteEntregas();
            reporte.Database.Tables["Entrega"].SetDataSource(bindingSource);
            reporte.Database.Tables["Clientes"].SetDataSource(bindingSource2);
            reporte.Database.Tables["Estado"].SetDataSource(bindingSource3);
            reporte.Database.Tables["Estatus"].SetDataSource(bindingSource4);

            crystalReportViewer1.ReportSource = reporte;
            crystalReportViewer1.RefreshReport();

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
