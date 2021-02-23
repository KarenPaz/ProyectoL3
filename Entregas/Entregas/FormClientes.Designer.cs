namespace Entregas
{
    partial class FormClientes
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label activoLabel;
            System.Windows.Forms.Label codigoClienteLabel;
            System.Windows.Forms.Label contactoLabel;
            System.Windows.Forms.Label direccionLabel;
            System.Windows.Forms.Label nombredeEmpresaLabel;
            System.Windows.Forms.Label rTNLabel;
            System.Windows.Forms.Label telefonoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClientes));
            this.listadeClientesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.listadeClientesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.activoCheckBox = new System.Windows.Forms.CheckBox();
            this.codigoClienteTextBox = new System.Windows.Forms.TextBox();
            this.contactoTextBox = new System.Windows.Forms.TextBox();
            this.direccionTextBox = new System.Windows.Forms.TextBox();
            this.nombredeEmpresaTextBox = new System.Windows.Forms.TextBox();
            this.rTNTextBox = new System.Windows.Forms.TextBox();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.toolStripButtonCancelar = new System.Windows.Forms.ToolStripButton();
            this.listadeClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            activoLabel = new System.Windows.Forms.Label();
            codigoClienteLabel = new System.Windows.Forms.Label();
            contactoLabel = new System.Windows.Forms.Label();
            direccionLabel = new System.Windows.Forms.Label();
            nombredeEmpresaLabel = new System.Windows.Forms.Label();
            rTNLabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listadeClientesBindingNavigator)).BeginInit();
            this.listadeClientesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listadeClientesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // activoLabel
            // 
            activoLabel.AutoSize = true;
            activoLabel.Location = new System.Drawing.Point(54, 256);
            activoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            activoLabel.Name = "activoLabel";
            activoLabel.Size = new System.Drawing.Size(40, 13);
            activoLabel.TabIndex = 1;
            activoLabel.Text = "Activo:";
            // 
            // codigoClienteLabel
            // 
            codigoClienteLabel.AutoSize = true;
            codigoClienteLabel.Location = new System.Drawing.Point(48, 39);
            codigoClienteLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            codigoClienteLabel.Name = "codigoClienteLabel";
            codigoClienteLabel.Size = new System.Drawing.Size(78, 13);
            codigoClienteLabel.TabIndex = 3;
            codigoClienteLabel.Text = "Codigo Cliente:";
            // 
            // contactoLabel
            // 
            contactoLabel.AutoSize = true;
            contactoLabel.Location = new System.Drawing.Point(54, 136);
            contactoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            contactoLabel.Name = "contactoLabel";
            contactoLabel.Size = new System.Drawing.Size(53, 13);
            contactoLabel.TabIndex = 5;
            contactoLabel.Text = "Contacto:";
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.Location = new System.Drawing.Point(53, 164);
            direccionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(55, 13);
            direccionLabel.TabIndex = 7;
            direccionLabel.Text = "Direccion:";
            // 
            // nombredeEmpresaLabel
            // 
            nombredeEmpresaLabel.AutoSize = true;
            nombredeEmpresaLabel.Location = new System.Drawing.Point(50, 76);
            nombredeEmpresaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            nombredeEmpresaLabel.Name = "nombredeEmpresaLabel";
            nombredeEmpresaLabel.Size = new System.Drawing.Size(106, 13);
            nombredeEmpresaLabel.TabIndex = 9;
            nombredeEmpresaLabel.Text = "Nombre de Empresa:";
            nombredeEmpresaLabel.Click += new System.EventHandler(this.nombredeEmpresaLabel_Click);
            // 
            // rTNLabel
            // 
            rTNLabel.AutoSize = true;
            rTNLabel.Location = new System.Drawing.Point(52, 106);
            rTNLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            rTNLabel.Name = "rTNLabel";
            rTNLabel.Size = new System.Drawing.Size(33, 13);
            rTNLabel.TabIndex = 11;
            rTNLabel.Text = "RTN:";
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Location = new System.Drawing.Point(53, 218);
            telefonoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(52, 13);
            telefonoLabel.TabIndex = 13;
            telefonoLabel.Text = "Telefono:";
            // 
            // listadeClientesBindingNavigator
            // 
            this.listadeClientesBindingNavigator.AddNewItem = null;
            this.listadeClientesBindingNavigator.BindingSource = this.listadeClientesBindingSource;
            this.listadeClientesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.listadeClientesBindingNavigator.DeleteItem = null;
            this.listadeClientesBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.listadeClientesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.listadeClientesBindingNavigatorSaveItem,
            this.toolStripButtonCancelar});
            this.listadeClientesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.listadeClientesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.listadeClientesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.listadeClientesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.listadeClientesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.listadeClientesBindingNavigator.Name = "listadeClientesBindingNavigator";
            this.listadeClientesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.listadeClientesBindingNavigator.Size = new System.Drawing.Size(485, 27);
            this.listadeClientesBindingNavigator.TabIndex = 0;
            this.listadeClientesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 24);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(38, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // listadeClientesBindingNavigatorSaveItem
            // 
            this.listadeClientesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.listadeClientesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("listadeClientesBindingNavigatorSaveItem.Image")));
            this.listadeClientesBindingNavigatorSaveItem.Name = "listadeClientesBindingNavigatorSaveItem";
            this.listadeClientesBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.listadeClientesBindingNavigatorSaveItem.Text = "Guardar datos";
            this.listadeClientesBindingNavigatorSaveItem.Click += new System.EventHandler(this.listadeClientesBindingNavigatorSaveItem_Click);
            // 
            // activoCheckBox
            // 
            this.activoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.listadeClientesBindingSource, "Activo", true));
            this.activoCheckBox.Location = new System.Drawing.Point(161, 254);
            this.activoCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.activoCheckBox.Name = "activoCheckBox";
            this.activoCheckBox.Size = new System.Drawing.Size(78, 20);
            this.activoCheckBox.TabIndex = 2;
            this.activoCheckBox.UseVisualStyleBackColor = true;
            // 
            // codigoClienteTextBox
            // 
            this.codigoClienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listadeClientesBindingSource, "CodigoCliente", true));
            this.codigoClienteTextBox.Location = new System.Drawing.Point(161, 37);
            this.codigoClienteTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.codigoClienteTextBox.Multiline = true;
            this.codigoClienteTextBox.Name = "codigoClienteTextBox";
            this.codigoClienteTextBox.Size = new System.Drawing.Size(79, 28);
            this.codigoClienteTextBox.TabIndex = 4;
            // 
            // contactoTextBox
            // 
            this.contactoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listadeClientesBindingSource, "Contacto", true));
            this.contactoTextBox.Location = new System.Drawing.Point(161, 133);
            this.contactoTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.contactoTextBox.Name = "contactoTextBox";
            this.contactoTextBox.Size = new System.Drawing.Size(256, 20);
            this.contactoTextBox.TabIndex = 6;
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listadeClientesBindingSource, "Direccion", true));
            this.direccionTextBox.Location = new System.Drawing.Point(161, 162);
            this.direccionTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.direccionTextBox.Multiline = true;
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.Size = new System.Drawing.Size(240, 37);
            this.direccionTextBox.TabIndex = 8;
            // 
            // nombredeEmpresaTextBox
            // 
            this.nombredeEmpresaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listadeClientesBindingSource, "NombredeEmpresa", true));
            this.nombredeEmpresaTextBox.Location = new System.Drawing.Point(161, 74);
            this.nombredeEmpresaTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nombredeEmpresaTextBox.Name = "nombredeEmpresaTextBox";
            this.nombredeEmpresaTextBox.Size = new System.Drawing.Size(256, 20);
            this.nombredeEmpresaTextBox.TabIndex = 10;
            // 
            // rTNTextBox
            // 
            this.rTNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listadeClientesBindingSource, "RTN", true));
            this.rTNTextBox.Location = new System.Drawing.Point(161, 104);
            this.rTNTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rTNTextBox.Name = "rTNTextBox";
            this.rTNTextBox.Size = new System.Drawing.Size(256, 20);
            this.rTNTextBox.TabIndex = 12;
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listadeClientesBindingSource, "Telefono", true));
            this.telefonoTextBox.Location = new System.Drawing.Point(161, 211);
            this.telefonoTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.telefonoTextBox.Multiline = true;
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(122, 24);
            this.telefonoTextBox.TabIndex = 14;
            // 
            // toolStripButtonCancelar
            // 
            this.toolStripButtonCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonCancelar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCancelar.Image")));
            this.toolStripButtonCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCancelar.Name = "toolStripButtonCancelar";
            this.toolStripButtonCancelar.Size = new System.Drawing.Size(57, 24);
            this.toolStripButtonCancelar.Text = "Cancelar";
            this.toolStripButtonCancelar.Visible = false;
            this.toolStripButtonCancelar.Click += new System.EventHandler(this.toolStripButtonCancelar_Click);
            // 
            // listadeClientesBindingSource
            // 
            this.listadeClientesBindingSource.DataSource = typeof(BL.Entregas.Clientes);
            // 
            // FormClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 332);
            this.Controls.Add(activoLabel);
            this.Controls.Add(this.activoCheckBox);
            this.Controls.Add(codigoClienteLabel);
            this.Controls.Add(this.codigoClienteTextBox);
            this.Controls.Add(contactoLabel);
            this.Controls.Add(this.contactoTextBox);
            this.Controls.Add(direccionLabel);
            this.Controls.Add(this.direccionTextBox);
            this.Controls.Add(nombredeEmpresaLabel);
            this.Controls.Add(this.nombredeEmpresaTextBox);
            this.Controls.Add(rTNLabel);
            this.Controls.Add(this.rTNTextBox);
            this.Controls.Add(telefonoLabel);
            this.Controls.Add(this.telefonoTextBox);
            this.Controls.Add(this.listadeClientesBindingNavigator);
            this.Name = "FormClientes";
            this.Text = "Nuevo Cliente";
            this.Load += new System.EventHandler(this.FormClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listadeClientesBindingNavigator)).EndInit();
            this.listadeClientesBindingNavigator.ResumeLayout(false);
            this.listadeClientesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listadeClientesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource listadeClientesBindingSource;
        private System.Windows.Forms.BindingNavigator listadeClientesBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton listadeClientesBindingNavigatorSaveItem;
        private System.Windows.Forms.CheckBox activoCheckBox;
        private System.Windows.Forms.TextBox codigoClienteTextBox;
        private System.Windows.Forms.TextBox contactoTextBox;
        private System.Windows.Forms.TextBox direccionTextBox;
        private System.Windows.Forms.TextBox nombredeEmpresaTextBox;
        private System.Windows.Forms.TextBox rTNTextBox;
        private System.Windows.Forms.TextBox telefonoTextBox;
        private System.Windows.Forms.ToolStripButton toolStripButtonCancelar;
    }
}