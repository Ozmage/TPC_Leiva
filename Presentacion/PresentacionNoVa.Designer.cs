namespace Presentacion
{
    partial class frmMenuPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPrincipal));
            this.tsBarraHerramientas = new System.Windows.Forms.ToolStrip();
            this.tsbPropiedades = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modeloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.presupuestoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administradorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ediciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copiarctrlCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cortarCTRLXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pegarCTRLVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deshacerCTRLZToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.presupuestoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.porApellidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porFechaDeEmisiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehiculoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porMarcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porModeloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porVersiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porIDToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.porApellidoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soporteTécnicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNunevoPresupuesto = new System.Windows.Forms.Button();
            this.tsBarraHerramientas.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsBarraHerramientas
            // 
            this.tsBarraHerramientas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbPropiedades});
            this.tsBarraHerramientas.Location = new System.Drawing.Point(0, 24);
            this.tsBarraHerramientas.Name = "tsBarraHerramientas";
            this.tsBarraHerramientas.Size = new System.Drawing.Size(800, 25);
            this.tsBarraHerramientas.TabIndex = 51;
            this.tsBarraHerramientas.Text = "toolStrip1";
            // 
            // tsbPropiedades
            // 
            this.tsbPropiedades.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPropiedades.Image = ((System.Drawing.Image)(resources.GetObject("tsbPropiedades.Image")));
            this.tsbPropiedades.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPropiedades.Name = "tsbPropiedades";
            this.tsbPropiedades.Size = new System.Drawing.Size(23, 22);
            this.tsbPropiedades.Text = "toolStripButton1";
            this.tsbPropiedades.Click += new System.EventHandler(this.tsbPropiedades_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.ediciónToolStripMenuItem,
            this.buscarToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 50;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaToolStripMenuItem,
            this.administradorToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // nuevaToolStripMenuItem
            // 
            this.nuevaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.marcaToolStripMenuItem,
            this.modeloToolStripMenuItem,
            this.versionToolStripMenuItem,
            this.presupuestoToolStripMenuItem});
            this.nuevaToolStripMenuItem.Name = "nuevaToolStripMenuItem";
            this.nuevaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nuevaToolStripMenuItem.Text = "Nuevo";
            // 
            // marcaToolStripMenuItem
            // 
            this.marcaToolStripMenuItem.Name = "marcaToolStripMenuItem";
            this.marcaToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.marcaToolStripMenuItem.Text = "Marca";
            // 
            // modeloToolStripMenuItem
            // 
            this.modeloToolStripMenuItem.Name = "modeloToolStripMenuItem";
            this.modeloToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.modeloToolStripMenuItem.Text = "Modelo";
            // 
            // versionToolStripMenuItem
            // 
            this.versionToolStripMenuItem.Name = "versionToolStripMenuItem";
            this.versionToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.versionToolStripMenuItem.Text = "Version";
            // 
            // presupuestoToolStripMenuItem
            // 
            this.presupuestoToolStripMenuItem.Name = "presupuestoToolStripMenuItem";
            this.presupuestoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.presupuestoToolStripMenuItem.Text = "Presupuesto";
            this.presupuestoToolStripMenuItem.Click += new System.EventHandler(this.presupuestoToolStripMenuItem_Click);
            // 
            // administradorToolStripMenuItem
            // 
            this.administradorToolStripMenuItem.Name = "administradorToolStripMenuItem";
            this.administradorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.administradorToolStripMenuItem.Text = "Administrador";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // ediciónToolStripMenuItem
            // 
            this.ediciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copiarctrlCToolStripMenuItem,
            this.cortarCTRLXToolStripMenuItem,
            this.pegarCTRLVToolStripMenuItem,
            this.deshacerCTRLZToolStripMenuItem});
            this.ediciónToolStripMenuItem.Name = "ediciónToolStripMenuItem";
            this.ediciónToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.ediciónToolStripMenuItem.Text = "Edición";
            // 
            // copiarctrlCToolStripMenuItem
            // 
            this.copiarctrlCToolStripMenuItem.Name = "copiarctrlCToolStripMenuItem";
            this.copiarctrlCToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.copiarctrlCToolStripMenuItem.Text = "Copiar           (CTRL+C)";
            // 
            // cortarCTRLXToolStripMenuItem
            // 
            this.cortarCTRLXToolStripMenuItem.Name = "cortarCTRLXToolStripMenuItem";
            this.cortarCTRLXToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.cortarCTRLXToolStripMenuItem.Text = "Cortar            (CTRL+X)";
            // 
            // pegarCTRLVToolStripMenuItem
            // 
            this.pegarCTRLVToolStripMenuItem.Name = "pegarCTRLVToolStripMenuItem";
            this.pegarCTRLVToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.pegarCTRLVToolStripMenuItem.Text = "Pegar             (CTRL+V)";
            // 
            // deshacerCTRLZToolStripMenuItem
            // 
            this.deshacerCTRLZToolStripMenuItem.Name = "deshacerCTRLZToolStripMenuItem";
            this.deshacerCTRLZToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.deshacerCTRLZToolStripMenuItem.Text = "Deshacer       (CTRL+Z)";
            // 
            // buscarToolStripMenuItem
            // 
            this.buscarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.presupuestoToolStripMenuItem1,
            this.vehiculoToolStripMenuItem,
            this.clienteToolStripMenuItem});
            this.buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            this.buscarToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.buscarToolStripMenuItem.Text = "Buscar";
            // 
            // presupuestoToolStripMenuItem1
            // 
            this.presupuestoToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.porApellidoToolStripMenuItem,
            this.porIDToolStripMenuItem,
            this.porFechaDeEmisiónToolStripMenuItem,
            this.porEmailToolStripMenuItem});
            this.presupuestoToolStripMenuItem1.Name = "presupuestoToolStripMenuItem1";
            this.presupuestoToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.presupuestoToolStripMenuItem1.Text = "Presupuesto";
            // 
            // porApellidoToolStripMenuItem
            // 
            this.porApellidoToolStripMenuItem.Name = "porApellidoToolStripMenuItem";
            this.porApellidoToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.porApellidoToolStripMenuItem.Text = "Por apellido...";
            // 
            // porIDToolStripMenuItem
            // 
            this.porIDToolStripMenuItem.Name = "porIDToolStripMenuItem";
            this.porIDToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.porIDToolStripMenuItem.Text = "Por ID...";
            // 
            // porFechaDeEmisiónToolStripMenuItem
            // 
            this.porFechaDeEmisiónToolStripMenuItem.Name = "porFechaDeEmisiónToolStripMenuItem";
            this.porFechaDeEmisiónToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.porFechaDeEmisiónToolStripMenuItem.Text = "Por fecha de emisión...";
            // 
            // porEmailToolStripMenuItem
            // 
            this.porEmailToolStripMenuItem.Name = "porEmailToolStripMenuItem";
            this.porEmailToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.porEmailToolStripMenuItem.Text = "Por email...";
            // 
            // vehiculoToolStripMenuItem
            // 
            this.vehiculoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.porMarcaToolStripMenuItem,
            this.porModeloToolStripMenuItem,
            this.porVersiónToolStripMenuItem});
            this.vehiculoToolStripMenuItem.Name = "vehiculoToolStripMenuItem";
            this.vehiculoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.vehiculoToolStripMenuItem.Text = "Vehiculo";
            // 
            // porMarcaToolStripMenuItem
            // 
            this.porMarcaToolStripMenuItem.Name = "porMarcaToolStripMenuItem";
            this.porMarcaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.porMarcaToolStripMenuItem.Text = "Por marca...";
            this.porMarcaToolStripMenuItem.Click += new System.EventHandler(this.porMarcaToolStripMenuItem_Click);
            // 
            // porModeloToolStripMenuItem
            // 
            this.porModeloToolStripMenuItem.Name = "porModeloToolStripMenuItem";
            this.porModeloToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.porModeloToolStripMenuItem.Text = "Por modelo...";
            this.porModeloToolStripMenuItem.Click += new System.EventHandler(this.porModeloToolStripMenuItem_Click);
            // 
            // porVersiónToolStripMenuItem
            // 
            this.porVersiónToolStripMenuItem.Name = "porVersiónToolStripMenuItem";
            this.porVersiónToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.porVersiónToolStripMenuItem.Text = "Por versión...";
            this.porVersiónToolStripMenuItem.Click += new System.EventHandler(this.porVersiónToolStripMenuItem_Click);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.porIDToolStripMenuItem1,
            this.porApellidoToolStripMenuItem1});
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clienteToolStripMenuItem.Text = "Cliente";
            // 
            // porIDToolStripMenuItem1
            // 
            this.porIDToolStripMenuItem1.Name = "porIDToolStripMenuItem1";
            this.porIDToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.porIDToolStripMenuItem1.Text = "Por ID...";
            // 
            // porApellidoToolStripMenuItem1
            // 
            this.porApellidoToolStripMenuItem1.Name = "porApellidoToolStripMenuItem1";
            this.porApellidoToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.porApellidoToolStripMenuItem1.Text = "Por apellido...";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.soporteTécnicoToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // soporteTécnicoToolStripMenuItem
            // 
            this.soporteTécnicoToolStripMenuItem.Name = "soporteTécnicoToolStripMenuItem";
            this.soporteTécnicoToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.soporteTécnicoToolStripMenuItem.Text = "Soporte técnico";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de...";
            // 
            // btnNunevoPresupuesto
            // 
            this.btnNunevoPresupuesto.BackColor = System.Drawing.Color.OrangeRed;
            this.btnNunevoPresupuesto.Location = new System.Drawing.Point(274, 208);
            this.btnNunevoPresupuesto.Name = "btnNunevoPresupuesto";
            this.btnNunevoPresupuesto.Size = new System.Drawing.Size(253, 34);
            this.btnNunevoPresupuesto.TabIndex = 52;
            this.btnNunevoPresupuesto.Text = "Nuevo Presupuesto";
            this.btnNunevoPresupuesto.UseVisualStyleBackColor = false;
            this.btnNunevoPresupuesto.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNunevoPresupuesto);
            this.Controls.Add(this.tsBarraHerramientas);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.tsBarraHerramientas.ResumeLayout(false);
            this.tsBarraHerramientas.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip tsBarraHerramientas;
        private System.Windows.Forms.ToolStripButton tsbPropiedades;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marcaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modeloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem presupuestoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administradorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ediciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copiarctrlCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cortarCTRLXToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pegarCTRLVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deshacerCTRLZToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem presupuestoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem porApellidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porIDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porFechaDeEmisiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porEmailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vehiculoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porMarcaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porModeloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porVersiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porIDToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem porApellidoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem soporteTécnicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.Button btnNunevoPresupuesto;
    }
}

