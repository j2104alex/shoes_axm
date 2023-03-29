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
using Lib_Empleado;

namespace MDI
{
    public partial class EmpleadoVentana : Form
    {
        public EmpleadoVentana()
        {
            InitializeComponent();
        }

        private void EmpleadoVentana_Load(object sender, EventArgs e)
        {
            listarEmpleado();
        }



        private void BtnGuardar_Click(object sender, EventArgs e)
        {

            try
            {
                Empleado objNuevoEmpleado = new Empleado();

                string id_empleado, nombre_empleado, apellido_empleado, telefono_empleado, direccion_empleado, email_empleado, error;
                double salario_empleado;

                //capturar los datos.
                id_empleado = TxtIdentificacion.Text;
                nombre_empleado = TxtNombreEmpleado.Text;
                apellido_empleado = TxtApellidoEmpleado.Text;
                telefono_empleado = txtTelefonoEmpleado.Text;
                direccion_empleado = txtDireccionEmpleado.Text;
                email_empleado = TxtEmailEmpleado.Text;
                salario_empleado = Convert.ToDouble(TxtSalarioEmpleado.Text);

                //Enviar datos a la logica de negocio.

                objNuevoEmpleado.Id_empleado = id_empleado;
                objNuevoEmpleado.Nombre_empleado = nombre_empleado;
                objNuevoEmpleado.Apellido_empleado = apellido_empleado;
                objNuevoEmpleado.Telefono_empleado = telefono_empleado;
                objNuevoEmpleado.Direccion_empleado = direccion_empleado;
                objNuevoEmpleado.Email_empleado = email_empleado;
                objNuevoEmpleado.Salario_empleado = salario_empleado;

                if (!objNuevoEmpleado.guardarEmpleado())
                {
                    MessageBox.Show(objNuevoEmpleado.Error);
                    objNuevoEmpleado = null;
                    return;
                }
                else
                {
                    listarEmpleado();
                    MessageBox.Show(objNuevoEmpleado.Error);
                    objNuevoEmpleado = null;
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            listarEmpleado();
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            try{
                Empleado objNuevoEmpleado = new Empleado();

                string id_empleado;

                //capturar los datos.
                id_empleado = TxtIdentificacion.Text;


                //Enviar datos a la logica de negocio.

                objNuevoEmpleado.Id_empleado = id_empleado;

                if (!objNuevoEmpleado.eliminarEmpleado())
                {
                    MessageBox.Show(objNuevoEmpleado.Error);
                    objNuevoEmpleado = null;
                    return;
                }
                else
                {
                    listarEmpleado();
                    MessageBox.Show(objNuevoEmpleado.Error);
                    objNuevoEmpleado = null;
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
         }

        private void listarEmpleado()
        {
            //Instanciar la logica de negocio.
            Empleado objNuevoEmpleado = new Empleado();

            if (!objNuevoEmpleado.ListarEmpleados(DGListarEmpleado))
            {

                MessageBox.Show(objNuevoEmpleado.Error);
                objNuevoEmpleado = null;
                return;
            }

            objNuevoEmpleado = null;
            return;
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            //Instanciar la logica de negocio.
            Empleado objEmp = new Empleado();

            try
            {

                //capturar los datos.
                string identificacionEmp = TxtIdentificacion.Text;
                objEmp.Id_empleado = identificacionEmp;
                if (!objEmp.consultarEmpleadoById())
                {
                    MessageBox.Show(objEmp.Error);
                    objEmp = null;
                    return;
                }


                SqlDataReader reader;
                reader = objEmp.Reader;
                if (reader.HasRows)
                {
                    reader.Read();

                    Console.Write(reader.GetString(0));


                    //TxtIdentificacion.Text = reader.GetString(0);
                    TxtNombreEmpleado.Text = reader.GetString(1);
                    TxtApellidoEmpleado.Text = reader.GetString(2);
                    txtTelefonoEmpleado.Text = reader.GetString(3);
                    txtDireccionEmpleado.Text = reader.GetString(4);
                    TxtEmailEmpleado.Text = reader.GetString(5);
                    TxtSalarioEmpleado.Text = Convert.ToString(reader.GetDouble(6));

                    reader.Close();
                    objEmp = null;
                    return;

                }
                else
                {
                    MessageBox.Show("El empleado no existe");
                }

                objEmp = null;
                return;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                objEmp = null;

            }
        }
    }
}
