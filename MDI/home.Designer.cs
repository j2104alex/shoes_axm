namespace MDI
{
    partial class home
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarEmpleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pegarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroFacturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturaCompraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrosCompraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarCategoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarCategoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarCategoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarCategoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.probandoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.otrosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.abrirToolStripMenuItem,
            this.cerrarToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.archivoToolStripMenuItem.Text = "Persona";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarClientesToolStripMenuItem,
            this.eliminarClienteToolStripMenuItem});
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nuevoToolStripMenuItem.Text = "Cliente";
            // 
            // ingresarClientesToolStripMenuItem
            // 
            this.ingresarClientesToolStripMenuItem.Name = "ingresarClientesToolStripMenuItem";
            this.ingresarClientesToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.ingresarClientesToolStripMenuItem.Text = "Ingresar/actualizar";
            this.ingresarClientesToolStripMenuItem.Click += new System.EventHandler(this.ingresarClientesToolStripMenuItem_Click);
            // 
            // eliminarClienteToolStripMenuItem
            // 
            this.eliminarClienteToolStripMenuItem.Name = "eliminarClienteToolStripMenuItem";
            this.eliminarClienteToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.eliminarClienteToolStripMenuItem.Text = "Consultar/eliminar";
            this.eliminarClienteToolStripMenuItem.Click += new System.EventHandler(this.eliminarClienteToolStripMenuItem_Click);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarEmpleadoToolStripMenuItem,
            this.consultarEmpleadosToolStripMenuItem});
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.abrirToolStripMenuItem.Text = "Empleado";
            // 
            // ingresarEmpleadoToolStripMenuItem
            // 
            this.ingresarEmpleadoToolStripMenuItem.Name = "ingresarEmpleadoToolStripMenuItem";
            this.ingresarEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.ingresarEmpleadoToolStripMenuItem.Text = "Ingresar/Actualizar";
            this.ingresarEmpleadoToolStripMenuItem.Click += new System.EventHandler(this.ingresarEmpleadoToolStripMenuItem_Click);
            // 
            // consultarEmpleadosToolStripMenuItem
            // 
            this.consultarEmpleadosToolStripMenuItem.Name = "consultarEmpleadosToolStripMenuItem";
            this.consultarEmpleadosToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.consultarEmpleadosToolStripMenuItem.Text = "Consultar/Eliminar";
            this.consultarEmpleadosToolStripMenuItem.Click += new System.EventHandler(this.consultarEmpleadosToolStripMenuItem_Click);
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarProveedorToolStripMenuItem,
            this.eliminarProveedorToolStripMenuItem});
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cerrarToolStripMenuItem.Text = "Proveedor";
            // 
            // ingresarProveedorToolStripMenuItem
            // 
            this.ingresarProveedorToolStripMenuItem.Name = "ingresarProveedorToolStripMenuItem";
            this.ingresarProveedorToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.ingresarProveedorToolStripMenuItem.Text = "Ingresar/Actualizar";
            this.ingresarProveedorToolStripMenuItem.Click += new System.EventHandler(this.ingresarProveedorToolStripMenuItem_Click);
            // 
            // eliminarProveedorToolStripMenuItem
            // 
            this.eliminarProveedorToolStripMenuItem.Name = "eliminarProveedorToolStripMenuItem";
            this.eliminarProveedorToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.eliminarProveedorToolStripMenuItem.Text = "Consultar/Eliminar";
            this.eliminarProveedorToolStripMenuItem.Click += new System.EventHandler(this.eliminarProveedorToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pegarToolStripMenuItem,
            this.copiarToolStripMenuItem});
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.editarToolStripMenuItem.Text = "Servicios";
            // 
            // pegarToolStripMenuItem
            // 
            this.pegarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroFacturaToolStripMenuItem,
            this.registroToolStripMenuItem});
            this.pegarToolStripMenuItem.Name = "pegarToolStripMenuItem";
            this.pegarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pegarToolStripMenuItem.Text = "Venta";
            // 
            // registroFacturaToolStripMenuItem
            // 
            this.registroFacturaToolStripMenuItem.Name = "registroFacturaToolStripMenuItem";
            this.registroFacturaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.registroFacturaToolStripMenuItem.Text = "Generar factura";
            this.registroFacturaToolStripMenuItem.Click += new System.EventHandler(this.registroFacturaToolStripMenuItem_Click);
            // 
            // registroToolStripMenuItem
            // 
            this.registroToolStripMenuItem.Name = "registroToolStripMenuItem";
            this.registroToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.registroToolStripMenuItem.Text = "Consultar facturas";
            // 
            // copiarToolStripMenuItem
            // 
            this.copiarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.facturaCompraToolStripMenuItem,
            this.registrosCompraToolStripMenuItem});
            this.copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            this.copiarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.copiarToolStripMenuItem.Text = "Compra";
            // 
            // facturaCompraToolStripMenuItem
            // 
            this.facturaCompraToolStripMenuItem.Name = "facturaCompraToolStripMenuItem";
            this.facturaCompraToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.facturaCompraToolStripMenuItem.Text = "Registrar factura";
            // 
            // registrosCompraToolStripMenuItem
            // 
            this.registrosCompraToolStripMenuItem.Name = "registrosCompraToolStripMenuItem";
            this.registrosCompraToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.registrosCompraToolStripMenuItem.Text = "Registros compra";
            // 
            // otrosToolStripMenuItem
            // 
            this.otrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productosToolStripMenuItem,
            this.categoriasToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.probandoToolStripMenuItem});
            this.otrosToolStripMenuItem.Name = "otrosToolStripMenuItem";
            this.otrosToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.otrosToolStripMenuItem.Text = "Otros";
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarProductoToolStripMenuItem,
            this.actualizarProductoToolStripMenuItem,
            this.eliminarProductoToolStripMenuItem,
            this.consultarProductosToolStripMenuItem});
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.productosToolStripMenuItem.Text = "Productos";
            // 
            // ingresarProductoToolStripMenuItem
            // 
            this.ingresarProductoToolStripMenuItem.Name = "ingresarProductoToolStripMenuItem";
            this.ingresarProductoToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.ingresarProductoToolStripMenuItem.Text = "Ingresar producto";
            // 
            // actualizarProductoToolStripMenuItem
            // 
            this.actualizarProductoToolStripMenuItem.Name = "actualizarProductoToolStripMenuItem";
            this.actualizarProductoToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.actualizarProductoToolStripMenuItem.Text = "Actualizar producto";
            // 
            // eliminarProductoToolStripMenuItem
            // 
            this.eliminarProductoToolStripMenuItem.Name = "eliminarProductoToolStripMenuItem";
            this.eliminarProductoToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.eliminarProductoToolStripMenuItem.Text = "Eliminar producto";
            // 
            // consultarProductosToolStripMenuItem
            // 
            this.consultarProductosToolStripMenuItem.Name = "consultarProductosToolStripMenuItem";
            this.consultarProductosToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.consultarProductosToolStripMenuItem.Text = "Consultar productos";
            // 
            // categoriasToolStripMenuItem
            // 
            this.categoriasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarCategoriaToolStripMenuItem,
            this.actualizarCategoriaToolStripMenuItem,
            this.eliminarCategoriaToolStripMenuItem,
            this.consultarCategoriasToolStripMenuItem});
            this.categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            this.categoriasToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.categoriasToolStripMenuItem.Text = "Categorias";
            // 
            // ingresarCategoriaToolStripMenuItem
            // 
            this.ingresarCategoriaToolStripMenuItem.Name = "ingresarCategoriaToolStripMenuItem";
            this.ingresarCategoriaToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.ingresarCategoriaToolStripMenuItem.Text = "Ingresar categoria";
            // 
            // actualizarCategoriaToolStripMenuItem
            // 
            this.actualizarCategoriaToolStripMenuItem.Name = "actualizarCategoriaToolStripMenuItem";
            this.actualizarCategoriaToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.actualizarCategoriaToolStripMenuItem.Text = "Actualizar categoria";
            // 
            // eliminarCategoriaToolStripMenuItem
            // 
            this.eliminarCategoriaToolStripMenuItem.Name = "eliminarCategoriaToolStripMenuItem";
            this.eliminarCategoriaToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.eliminarCategoriaToolStripMenuItem.Text = "Eliminar categoria";
            // 
            // consultarCategoriasToolStripMenuItem
            // 
            this.consultarCategoriasToolStripMenuItem.Name = "consultarCategoriasToolStripMenuItem";
            this.consultarCategoriasToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.consultarCategoriasToolStripMenuItem.Text = "Consultar categorias";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarUsuariosToolStripMenuItem});
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // consultarUsuariosToolStripMenuItem
            // 
            this.consultarUsuariosToolStripMenuItem.Name = "consultarUsuariosToolStripMenuItem";
            this.consultarUsuariosToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.consultarUsuariosToolStripMenuItem.Text = "Consultar usuarios";
            // 
            // probandoToolStripMenuItem
            // 
            this.probandoToolStripMenuItem.Name = "probandoToolStripMenuItem";
            this.probandoToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 601);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "System_sales";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pegarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copiarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroFacturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturaCompraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrosCompraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarEmpleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarEmpleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarProveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarProveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarCategoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarCategoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarCategoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarCategoriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem probandoToolStripMenuItem;
    }
}

