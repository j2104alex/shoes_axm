using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lib_Empleado;

namespace MDI
{
    public partial class FacturaVentana : Form
    {
        public FacturaVentana()
        {
            InitializeComponent();
            llenarComboBoxEmpleado();
        }

        private void FacturaVentana_Load(object sender, EventArgs e)
        {

        }

        private void llenarComboBoxEmpleado()
        {
            Empleado obEm = new Empleado();
            if (!obEm.llenarComboEmpleado(BoxEmpleado))
            {
                MessageBox.Show(obEm.Error);
                obEm = null;
                return;
            }
        }

        private void BoxEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {

            ComboBox boxEmpleado = (ComboBox) sender;
            DataRowView drv = (DataRowView)boxEmpleado.SelectedItem;
           
            //string selectedEmpleado = BoxEmpleado.SelectedItem.ToString();
            textBox1.Text = drv["id_empleado"].ToString();
        }
    }
}
