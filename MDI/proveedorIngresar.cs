using Lib_Empleado;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lib_Proveedor;

namespace MDI
{
    public partial class proveedorIngresar : Form
    {
        public proveedorIngresar()
        {
            InitializeComponent();
        }

        private void proveedorIngresar_Load(object sender, EventArgs e)
        {
            listarProveedor();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Proveedor objNuevoProveedor = new Proveedor();

                string id_proveedor, nombre_proveedor, apellido_proveedor, telefono_proveedor, direccion_proveedor, email_proveedor, error;

                //capturar los datos.
                id_proveedor = txtIdentificacion.Text;
                nombre_proveedor = txtNombre.Text;
                apellido_proveedor = txtApellido.Text;
                telefono_proveedor = txtTelefono.Text;
                direccion_proveedor = txtDireccion.Text;
                email_proveedor = txtEmail.Text;

                //Enviar datos a la logica de negocio.

                objNuevoProveedor.Id_proveedor = id_proveedor;
                objNuevoProveedor.Nombre_proovedor = nombre_proveedor;
                objNuevoProveedor.Apellido_proveedor = apellido_proveedor;
                objNuevoProveedor.Telefono_proveedor = telefono_proveedor;
                objNuevoProveedor.Direccion_proveedor = direccion_proveedor;
                objNuevoProveedor.Email_proveedor = email_proveedor;

                if (!objNuevoProveedor.actualizarProveedor())
                {
                    MessageBox.Show(objNuevoProveedor.Error);
                    objNuevoProveedor = null;
                    return;
                }
                else
                {
                    listarProveedor();
                    MessageBox.Show(objNuevoProveedor.Error);
                    objNuevoProveedor = null;
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

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

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            try
            {
                Proveedor objNuevoProveedor = new Proveedor();

                string id_proveedor, nombre_proveedor, apellido_proveedor, telefono_proveedor, direccion_proveedor, email_proveedor, error;

                //capturar los datos.
                id_proveedor = txtIdentificacion.Text;
                nombre_proveedor = txtNombre.Text;
                apellido_proveedor = txtApellido.Text;
                telefono_proveedor = txtTelefono.Text;
                direccion_proveedor = txtDireccion.Text;
                email_proveedor = txtEmail.Text;

                //Enviar datos a la logica de negocio.

                objNuevoProveedor.Id_proveedor = id_proveedor;
                objNuevoProveedor.Nombre_proovedor = nombre_proveedor;
                objNuevoProveedor.Apellido_proveedor = apellido_proveedor;
                objNuevoProveedor.Telefono_proveedor = telefono_proveedor;
                objNuevoProveedor.Direccion_proveedor = direccion_proveedor;
                objNuevoProveedor.Email_proveedor = email_proveedor;

                if (!objNuevoProveedor.guardarProveedor())
                {
                    MessageBox.Show(objNuevoProveedor.Error);
                    objNuevoProveedor = null;
                    return;
                }
                else
                {
                    listarProveedor();
                    MessageBox.Show(objNuevoProveedor.Error);
                    objNuevoProveedor = null;
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

