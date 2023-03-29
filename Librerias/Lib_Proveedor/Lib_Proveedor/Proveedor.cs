using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibConexionBD;
using LibLlenarGrid;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using LibLlenarCombos;


namespace Lib_Proveedor
{
    public class Proveedor
    {
        #region "Atributos"
        private string id_proveedor;
        private string nombre_proovedor;
        private string apellido_proveedor;
        private string telefono_proveedor;
        private string direccion_proveedor;
        private string email_proveedor;
        private string error;
        private SqlDataReader reader;

        #endregion

        #region "Propiedades"
        public string Id_proveedor { get => id_proveedor; set => id_proveedor = value; }
        public string Nombre_proovedor { get => nombre_proovedor; set => nombre_proovedor = value; }
        public string Apellido_proveedor { get => apellido_proveedor; set => apellido_proveedor = value; }
        public string Telefono_proveedor { get => telefono_proveedor; set => telefono_proveedor = value; }
        public string Direccion_proveedor { get => direccion_proveedor; set => direccion_proveedor = value; }
        public string Email_proveedor { get => email_proveedor; set => email_proveedor = value; }
        public string Error { get => error; set => error = value; }
        public SqlDataReader Reader { get => reader; set => reader = value; }

        #endregion

        #region "Metodos Publicos"

        /*** Metodo para guardar Proveedor**/
        public bool guardarProveedor()
        {
            ClsConexion Objco = new ClsConexion();
            string sentencia = "execute USP_insertar_proveedor'" + id_proveedor + "','" + nombre_proovedor + "','" + apellido_proveedor + "','" + telefono_proveedor+ "','" + direccion_proveedor + "','" + email_proveedor+"'";
            if (!Objco.EjecutarSentencia(sentencia, false))
            {
                Error = Objco.Error;
                Objco = null;
                return false;
            }
            Error = "El proveedor se ha guardo exitosamente";
            Objco = null;
            return true;
        }

        /*** Metodo para actualizar Proveedor **/
        public bool actualizarProveedor()
        {
            ClsConexion Objco = new ClsConexion();
            string sentencia = "execute USP_actualizar_proveedor'" + id_proveedor + "','" + nombre_proovedor + "','" + apellido_proveedor + "','" + telefono_proveedor + "','" + direccion_proveedor + "','" + email_proveedor+"'";
            if (!Objco.EjecutarSentencia(sentencia, false))
            {
                Error = Objco.Error;
                Objco = null;
                return false;

            }
            Error = "El proveedor se ha actualizado exitosamente";
            Objco = null;
            return true;
        }

        /*** Metodo para eliminar Proveedor**/
        public bool eliminarProveedor()
        {
            ClsConexion Objco = new ClsConexion();
            string sentencia = "execute USP_borrar_proveedor'" + id_proveedor + "'";
            if (!Objco.EjecutarSentencia(sentencia, false))
            {
                Error = Objco.Error;
                Objco = null;
                return false;

            }
            Error = "El proveedor se ha eliminado exitosamente";
            Objco = null;
            return true;
        }

        /*** Metodo para listar Proveedor**/
        public bool ListarProveedor(DataGridView objGDV)
        {
            ClsLlenarGrid objLenarGrid = new ClsLlenarGrid();
            objLenarGrid.NombreTabla = "Datos Proveedor";
            objLenarGrid.SQL = "execute USP_listar_proveedores";

            if (!objLenarGrid.LlenarGrid(objGDV))
            {
                error = objLenarGrid.Error;
                objLenarGrid = null;
                return false;
            }


            objLenarGrid = null;
            return true;
        }
        public bool consultarProveedorById()
        {
            ClsConexion Objco = new ClsConexion();
            string sentencia = "execute USP_listar_proveedor_por_id '" + id_proveedor + "'";
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
