using Lib_Empleado;
using Lib_Proveedor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDI
{
    public partial class proveedorConsultaEliminar : Form
    {
        public proveedorConsultaEliminar()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            //Instanciar la logica de negocio.
            Proveedor objProveedor = new Proveedor();

            try
            {

                //capturar los datos.
                string identificacionProveedor = txtIdentificacion.Text;
                objProveedor.Id_proveedor = identificacionProveedor;
                if (!objProveedor.consultarProveedorById())
                {
                    MessageBox.Show(objProveedor.Error);
                    objProveedor = null;

                    return;
                }

                SqlDataReader reader;
                reader = objProveedor.Reader;
                if (reader.HasRows)
                {
                    reader.Read();

                    string idProveedor, nombreProveedor, apellidoProveedor, telefonoProveedor, direccionProveedor, correoProveedor;
                    idProveedor = "Identificacion proveedor: "+ reader.GetString(0);
                nombreProveedor = "Nombre proveedor: " + reader.GetString(1);
                apellidoProveedor= " "+reader.GetString(2);
                telefonoProveedor= "Teléfono proveedor: "+reader.GetString(3);
                direccionProveedor = "Dirección proveedor: "+reader.GetString(4);
                correoProveedor = "Correo proveedor: "+reader.GetString(5);
                    MessageBox.Show(idProveedor+ "\n" + nombreProveedor+apellidoProveedor + "\n" + telefonoProveedor + "\n" + direccionProveedor + "\n" + correoProveedor);

                    reader.Close();
                    objProveedor = null;
                    return;

                }
                else
                {
                    MessageBox.Show("El proveedor no existe");
                }

                objProveedor = null;
                return;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                objProveedor = null;

            }
        }
    private void listarProveedor()
        {
            //Instanciar la logica de negocio.
            Proveedor objNuevoProveedor = new Proveedor();

            if (!objNuevoProveedor.ListarProveedor(dgvProveedor))
            {

                MessageBox.Show(objNuevoProveedor.Error);
                objNuevoProveedor = null;
                return;
            }

            objNuevoProveedor = null;
            return;
        }

        private void proveedorConsultaEliminar_Load(object sender, EventArgs e)
        {
            listarProveedor();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Proveedor objNuevoProveedor = new Proveedor();

                string id_proveedor;

                //capturar los datos.
                id_proveedor = txtIdentificacion.Text;


                //Enviar datos a la logica de negocio.

                objNuevoProveedor.Id_proveedor = id_proveedor;

                if (!objNuevoProveedor.eliminarProveedor())
                {
                    MessageBox.Show(objNuevoProveedor.Error);
                    objNuevoProveedor = null;
                    return;
                }
                else
                {
                    MessageBox.Show(objNuevoProveedor.Error);
                    objNuevoProveedor = null;
                    listarProveedor();
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
