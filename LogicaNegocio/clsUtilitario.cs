using Conexion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class clsUtilitario
    {

        public DataTable ConsultaUnidadMedida()
        {
            clsConexion objConexion = new clsConexion();


            String miComando = "SELECT UNIDAD_MEDIDA, DESCRIPCION_UNIDAD_MEDIDA FROM UNIDAD_MEDIDA";


            return objConexion.consultarInformacionSQL(miComando); ;
        }

        public DataTable ConsultaTiposCodigos()
        {
            clsConexion objConexion = new clsConexion();


            String miComando = "SELECT COD_PROSER,DESCRIPCION FROM PROD_SER";


            return objConexion.consultarInformacionSQL(miComando); ;
        }

        public DataTable ConsultaTiposDocumento()
        {
            clsConexion objConexion = new clsConexion();


            String miComando = "select COD_TIPODOCU,DESCRIPCION,ESTADO from TIPO_DOCUMENTO";


            return objConexion.consultarInformacionSQL(miComando); ;
        }


        public DataTable ConsultaMoneda()
        {
            clsConexion objConexion = new clsConexion();


            String miComando = "  SELECT COD_MONEDA,DESCRIPCION_MONEDA FROM MONEDA";


            return objConexion.consultarInformacionSQL(miComando); ;
        }

        public DataTable ConsultaFormaPago()
        {
            clsConexion objConexion = new clsConexion();


            String miComando = "SELECT COD_MEDIO_PAGO,DESCRIPCION FROM MEDIOS_PAGO";


            return objConexion.consultarInformacionSQL(miComando); ;
        }

        public DataTable ConsultaCondicionVenta()
        {
            clsConexion objConexion = new clsConexion();


            String miComando = "SELECT COD_COND_VENTAS,DESCRIPCION FROM COND_VENTAS";


            return objConexion.consultarInformacionSQL(miComando); ;
        }

        public DataTable ConsultaTipoID()
        {
            clsConexion objConexion = new clsConexion();


            String miComando = "select COD_IDENTIFICACION,DESCRIPCION from TIPO_IDENTIFICACION";


            return objConexion.consultarInformacionSQL(miComando); ;
        }

        public DataTable ConsultarProvincia()
        {
            clsConexion objConexion = new clsConexion();


            String miComando = "select * from PROVINCIA";


            return objConexion.consultarInformacionSQL(miComando); ;
        }

        public DataTable ConsultarCanton(int Cod_Provincia)
        {
            clsConexion objConexion = new clsConexion();


            String miComando = "select * from CANTON WHERE COD_PROVINCIA = " + Cod_Provincia;


            return objConexion.consultarInformacionSQL(miComando); ;
        }
        public DataTable ConsultarDistrito(int Cod_Provincia, String Cod_Canton)
        {
            clsConexion objConexion = new clsConexion();


            String miComando = "SELECT * FROM DISTRITO  WHERE COD_PROVINCIA = " + Cod_Provincia + " and COD_CANTON = '" + Cod_Canton + "'";


            return objConexion.consultarInformacionSQL(miComando); ;
        }

        public DataTable ConsultarBarrio(int Cod_Provincia, String Cod_Canton, String cod_Distrito)
        {
            clsConexion objConexion = new clsConexion();


            String miComando = "SELECT * FROM BARRIO WHERE COD_PROVINCIA = " + Cod_Provincia + "AND COD_CANTON ='" + Cod_Canton + "' AND COD_DISTRITO = '" + cod_Distrito + "'";


            return objConexion.consultarInformacionSQL(miComando); ;
        }

        public DataTable ConsultaEstadoArticulo()
        {
            clsConexion objConexion = new clsConexion();


            String miComando = "SELECT COD_ESTADO_ARTICULO,DESCRIPCION_CODIGO_ARTICULO FROM ESTADO_ARTICULO";



            return objConexion.consultarInformacionSQL(miComando); ;
        }


    }
}
