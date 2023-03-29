using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDI{
    /*Un contenedor MDI es un contenedor que es capaz de contener
     * un formulario dentro de ella
    */
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ingresarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClienteVentana NuevaVentanaCliente = new ClienteVentana();

            NuevaVentanaCliente.MdiParent = this;
            NuevaVentanaCliente.Show();
        }

        private void ingresarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmpleadoVentana NuevaVentanaEmpleado = new EmpleadoVentana();
            //ok
            NuevaVentanaEmpleado.MdiParent = this;
            NuevaVentanaEmpleado.Show();
        }

        private void ingresarProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            proveedorIngresar NuevaVentanaProveedorIngresar = new proveedorIngresar();
            //ok
            NuevaVentanaProveedorIngresar.MdiParent = this;
            NuevaVentanaProveedorIngresar.Show();
        }


        private void eliminarProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            proveedorConsultaEliminar NuevaVentanaProveedorEliminar = new proveedorConsultaEliminar();
            //ok
            NuevaVentanaProveedorEliminar.MdiParent = this;
            NuevaVentanaProveedorEliminar.Show();
        }

        private void eliminarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ok
           
        }

        private void consultarEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmpleadoConsultaEliminar NuevaVentanaEmpleadoEliminar = new EmpleadoConsultaEliminar();
            //ok
            NuevaVentanaEmpleadoEliminar.MdiParent = this;
            NuevaVentanaEmpleadoEliminar.Show();
        }

        private void registroFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FacturaVentana NuevaVentanaFacturaVenta = new FacturaVentana();
            //ok
            NuevaVentanaFacturaVenta.MdiParent = this;
            NuevaVentanaFacturaVenta.Show();
        }
    }
}
