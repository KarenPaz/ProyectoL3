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
    public partial class FormReportedeClientes : Form
    {
        public FormReportedeClientes()
        {
            InitializeComponent();

            var _clientes = new ClienteBL();
            var _tipoCliente = new TiposBL();

            var bindingSource = new BindingSource();
            bindingSource.DataSource = _clientes.ObtenerClientes();

            var bindingSource2 = new BindingSource();
            bindingSource2.DataSource = _tipoCliente.ObtenerTipo();

            var reporte = new ReporteClientes();
            reporte.Database.Tables["Clientes"].SetDataSource(bindingSource);
            reporte.Database.Tables["Tipo"].SetDataSource(bindingSource2);

            crystalReportViewer1.ReportSource = reporte;
            crystalReportViewer1.RefreshReport();
        }
    }
}
