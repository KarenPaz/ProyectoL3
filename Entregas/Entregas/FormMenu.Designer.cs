namespace Entregas
{
    partial class FormMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.rentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoEnvíoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaFacturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaRutaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.especificoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porPesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generalToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.específicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeRutasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seguridadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.específicoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.recibosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historialDeEnvíosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.todosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.especificoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rentasToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.seguridadToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(379, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // rentasToolStripMenuItem
            // 
            this.rentasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoEnvíoToolStripMenuItem,
            this.nuevaFacturaToolStripMenuItem,
            this.nuevoClienteToolStripMenuItem,
            this.nuevaRutaToolStripMenuItem});
            this.rentasToolStripMenuItem.Name = "rentasToolStripMenuItem";
            this.rentasToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.rentasToolStripMenuItem.Text = "Transacciones";
            this.rentasToolStripMenuItem.Click += new System.EventHandler(this.rentasToolStripMenuItem_Click);
            // 
            // nuevoEnvíoToolStripMenuItem
            // 
            this.nuevoEnvíoToolStripMenuItem.Name = "nuevoEnvíoToolStripMenuItem";
            this.nuevoEnvíoToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.nuevoEnvíoToolStripMenuItem.Text = "Nuevo Entrega";
            this.nuevoEnvíoToolStripMenuItem.Click += new System.EventHandler(this.nuevoEnvíoToolStripMenuItem_Click);
            // 
            // nuevaFacturaToolStripMenuItem
            // 
            this.nuevaFacturaToolStripMenuItem.Name = "nuevaFacturaToolStripMenuItem";
            this.nuevaFacturaToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.nuevaFacturaToolStripMenuItem.Text = "Nueva Factura";
            this.nuevaFacturaToolStripMenuItem.Click += new System.EventHandler(this.nuevaFacturaToolStripMenuItem_Click);
            // 
            // nuevoClienteToolStripMenuItem
            // 
            this.nuevoClienteToolStripMenuItem.Name = "nuevoClienteToolStripMenuItem";
            this.nuevoClienteToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.nuevoClienteToolStripMenuItem.Text = "Nuevo Cliente";
            this.nuevoClienteToolStripMenuItem.Click += new System.EventHandler(this.nuevoClienteToolStripMenuItem_Click);
            // 
            // nuevaRutaToolStripMenuItem
            // 
            this.nuevaRutaToolStripMenuItem.Name = "nuevaRutaToolStripMenuItem";
            this.nuevaRutaToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.nuevaRutaToolStripMenuItem.Text = "Nueva Ruta";
            this.nuevaRutaToolStripMenuItem.Click += new System.EventHandler(this.nuevaRutaToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.porPesosToolStripMenuItem,
            this.facturasToolStripMenuItem,
            this.reporteDeRutasToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generalToolStripMenuItem,
            this.especificoToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(215, 26);
            this.clientesToolStripMenuItem.Text = "Reporte de Clientes";
            // 
            // generalToolStripMenuItem
            // 
            this.generalToolStripMenuItem.Name = "generalToolStripMenuItem";
            this.generalToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.generalToolStripMenuItem.Text = "General";
            // 
            // especificoToolStripMenuItem
            // 
            this.especificoToolStripMenuItem.Name = "especificoToolStripMenuItem";
            this.especificoToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.especificoToolStripMenuItem.Text = "Específico";
            // 
            // porPesosToolStripMenuItem
            // 
            this.porPesosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generalToolStripMenuItem1,
            this.específicoToolStripMenuItem,
            this.específicoToolStripMenuItem1,
            this.recibosToolStripMenuItem,
            this.historialDeEnvíosToolStripMenuItem});
            this.porPesosToolStripMenuItem.Name = "porPesosToolStripMenuItem";
            this.porPesosToolStripMenuItem.Size = new System.Drawing.Size(215, 26);
            this.porPesosToolStripMenuItem.Text = "Reporte de Envíos ";
            // 
            // generalToolStripMenuItem1
            // 
            this.generalToolStripMenuItem1.Name = "generalToolStripMenuItem1";
            this.generalToolStripMenuItem1.Size = new System.Drawing.Size(207, 26);
            this.generalToolStripMenuItem1.Text = "Por Entregar";
            this.generalToolStripMenuItem1.Click += new System.EventHandler(this.generalToolStripMenuItem1_Click);
            // 
            // específicoToolStripMenuItem
            // 
            this.específicoToolStripMenuItem.Name = "específicoToolStripMenuItem";
            this.específicoToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.específicoToolStripMenuItem.Text = "En Tránsito";
            // 
            // facturasToolStripMenuItem
            // 
            this.facturasToolStripMenuItem.Name = "facturasToolStripMenuItem";
            this.facturasToolStripMenuItem.Size = new System.Drawing.Size(215, 26);
            this.facturasToolStripMenuItem.Text = "Reporte de Facturas";
            // 
            // reporteDeRutasToolStripMenuItem
            // 
            this.reporteDeRutasToolStripMenuItem.Name = "reporteDeRutasToolStripMenuItem";
            this.reporteDeRutasToolStripMenuItem.Size = new System.Drawing.Size(215, 26);
            this.reporteDeRutasToolStripMenuItem.Text = "Reporte de Rutas";
            // 
            // seguridadToolStripMenuItem
            // 
            this.seguridadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem});
            this.seguridadToolStripMenuItem.Name = "seguridadToolStripMenuItem";
            this.seguridadToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.seguridadToolStripMenuItem.Text = "Seguridad";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // específicoToolStripMenuItem1
            // 
            this.específicoToolStripMenuItem1.Name = "específicoToolStripMenuItem1";
            this.específicoToolStripMenuItem1.Size = new System.Drawing.Size(207, 26);
            this.específicoToolStripMenuItem1.Text = "Entregadas";
            // 
            // recibosToolStripMenuItem
            // 
            this.recibosToolStripMenuItem.Name = "recibosToolStripMenuItem";
            this.recibosToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.recibosToolStripMenuItem.Text = "Recibos";
            // 
            // historialDeEnvíosToolStripMenuItem
            // 
            this.historialDeEnvíosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.todosToolStripMenuItem,
            this.especificoToolStripMenuItem1});
            this.historialDeEnvíosToolStripMenuItem.Name = "historialDeEnvíosToolStripMenuItem";
            this.historialDeEnvíosToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.historialDeEnvíosToolStripMenuItem.Text = "Historial de Envíos";
            // 
            // todosToolStripMenuItem
            // 
            this.todosToolStripMenuItem.Name = "todosToolStripMenuItem";
            this.todosToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.todosToolStripMenuItem.Text = "Todos";
            // 
            // especificoToolStripMenuItem1
            // 
            this.especificoToolStripMenuItem1.Name = "especificoToolStripMenuItem1";
            this.especificoToolStripMenuItem1.Size = new System.Drawing.Size(181, 26);
            this.especificoToolStripMenuItem1.Text = "Especifico";
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 321);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMenu";
            this.Text = "Menú Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem rentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porPesosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seguridadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoEnvíoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaFacturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaRutaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeRutasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem especificoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generalToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem específicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem específicoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem recibosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historialDeEnvíosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem todosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem especificoToolStripMenuItem1;
    }
}