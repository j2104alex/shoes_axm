using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using LibConexionBD;
using LibLlenarGrid;
//usar libreria llenar combos
using LibLlenarCombos;
using System.Windows.Forms;

namespace Lib_Empleado
{
    public class Empleado
    {
        #region "Atributos"
        private string id_empleado;
        private string nombre_empleado;
        private string apellido_empleado;
        private string telefono_empleado;
        private string direccion_empleado;
        private string email_empleado;
        private double salario_empleado;
        private string error;
        private SqlDataReader reader;
    
        #endregion

        #region "Propiedades"
        public string Id_empleado { get => id_empleado; set => id_empleado = value; }
        public string Nombre_empleado { get => nombre_empleado; set => nombre_empleado = value; }
        public string Apellido_empleado { get => apellido_empleado; set => apellido_empleado = value; }
        public string Telefono_empleado { get => telefono_empleado; set => telefono_empleado = value; }
        public string Direccion_empleado { get => direccion_empleado; set => direccion_empleado = value; }
        public string Email_empleado { get => email_empleado; set => email_empleado = value; }
        public double Salario_empleado { get => salario_empleado; set => salario_empleado = value; }
        public string Error { get => error; set => error = value; }
        public SqlDataReader Reader { get => reader; set => reader = value; }

        #endregion
        #region "Metodos Publicos"

        /**
        * Metodo para guardar Empleado
        **/
        public bool guardarEmpleado()
        {
            ClsConexion Objco = new ClsConexion();
            string sentencia = "execute USP_insertar_empleado '" + Id_empleado + "','" + Nombre_empleado + "','" + Apellido_empleado + "','" + Telefono_empleado + "','" + Direccion_empleado + "','" + Email_empleado + "','" + Salario_empleado + "'";
            if (!Objco.EjecutarSentencia(sentencia, false))
            {
                Error = Objco.Error;
                Objco = null;
                return false;
            }
            Error = "El empleado se ha guardo exitosamente";
            Objco = null;
            return true;
        }

        /**
        * Metodo para actualizar Empleado
        **/
        public bool actualizarEmpleado()
        {
            ClsConexion Objco = new ClsConexion();
            string sentencia = "execute USP_actualizar_empleado '" + Id_empleado + "','" + Nombre_empleado + "','" + Apellido_empleado + "','" + Telefono_empleado + "','" + Direccion_empleado + "','" + Email_empleado + "','" + Salario_empleado + "'";
            if (!Objco.EjecutarSentencia(sentencia, false))
            {
                Error = Objco.Error;
                Objco = null;
                return false;

            }
            Error = "El empleado se ha actualizado exitosamente";
            Objco = null;
            return true;
        }

        /**
        * Metodo para eliminar Empleado
        **/
        public bool eliminarEmpleado()
        {
            ClsConexion Objco = new ClsConexion();
            string sentencia = "execute USP_borrar_empleado '" + Id_empleado + "'";
            if (!Objco.EjecutarSentencia(sentencia, false))
            {
                Error = Objco.Error;
                Objco = null;
                return false;

            }
            Error = "El empleado se ha eliminado exitosamente";
            Objco = null;
            return true;
        }

        /**
       * Metodo para eliminar Empleado
       **/
        public bool ListarEmpleados(DataGridView objGDV)
        {
            ClsLlenarGrid objLenarGrid = new ClsLlenarGrid();
            objLenarGrid.NombreTabla = "Datos Empleados";
            objLenarGrid.SQL = "execute USP_listar_empleados";

            if (!objLenarGrid.LlenarGrid(objGDV))
            {
                Error = objLenarGrid.Error;
                objLenarGrid = null;
                return false;
            }


            objLenarGrid = null;
            return true;
        }

        

        public bool llenarComboEmpleado(ComboBox objCb)
        {
            /*objCb y obC es diferente, el primero es un objeto de comboBox y el otro de la clase
            llenar combos*/
            ClsLlenarCombos objC = new ClsLlenarCombos();
            objC.NombreTabla = "Datos Empleado";
            objC.SQL = "execute USP_combobox_empleado";
            objC.ColumnaTexto = "nombre_empleado";
            objC.ColumnaValor = "id_empleado";
            try
            {
                if (!objC.LlenarCombo(objCb))
                {
                    error = objC.Error;
                    objC = null;
                    return false;
                }
                objC = null;
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                objC = null;
                return false;
            }
        }

        public bool consultarEmpleadoById()
        {
            ClsConexion Objco = new ClsConexion();
            string sentencia = "execute USP_listar_empleado_por_id '" + Id_empleado + "'";
            if (!Objco.Consultar(sentencia, false))
            {
                Error = Objco.Error;
                Objco = null;
                return false;

            }

            Reader = Objco.Reader;
            Objco = null;
            return true;
        }



        #endregion
        #region "Metodos privados"
        #endregion
    }
}
