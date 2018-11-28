using Conexion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class clsReceptor
    {



        private int u00cod;

        public int U00cod
        {
            get { return u00cod; }
            set { u00cod = value; }
        }

        private String cod_receptor;

        public String Cod_receptor
        {
            get { return cod_receptor; }
            set { cod_receptor = value; }
        }


        private String ced_Receptor;

        public String Ced_Receptor
        {
            get { return ced_Receptor; }
            set { ced_Receptor = value; }
        }

        private String nombre_receptor;

        public String Nombre_receptor
        {
            get { return nombre_receptor; }
            set { nombre_receptor = value; }
        }

        private String cod_identificacion;

        public String Cod_identificacion
        {
            get { return cod_identificacion; }
            set { cod_identificacion = value; }
        }

        private String ced_receptor;

        public String Ced_receptor
        {
            get { return ced_receptor; }
            set { ced_receptor = value; }
        }

        private Boolean estado;

        public Boolean Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        private String email_receptor;

        public String Email_receptor
        {
            get { return email_receptor; }
            set { email_receptor = value; }
        }

        private String telefono_receptor;

        public String Telefono_receptor
        {
            get { return telefono_receptor; }
            set { telefono_receptor = value; }
        }

        private int tipoBusqueda;

        public int TipoBusqueda
        {
            get { return tipoBusqueda; }
            set { tipoBusqueda = value; }
        }



        public DataTable consultarReceptor()
        {

            clsConexion objConexion = new clsConexion();
            List<SqlParameter> misParametros = new List<SqlParameter>();

            misParametros.Clear();


            SqlParameter miParametro;
            miParametro = new SqlParameter("@U00COD", this.u00cod);
            misParametros.Add(miParametro);
            miParametro = new SqlParameter("@tipoBusqueda", this.tipoBusqueda);
            misParametros.Add(miParametro);

            miParametro = new SqlParameter("@NOMBRE_RECEPTOR", this.nombre_receptor);
            misParametros.Add(miParametro);
            miParametro = new SqlParameter("@CED_RECEPTOR", this.ced_Receptor);
            misParametros.Add(miParametro);


            String micomando = "sp_TConsultaReceptor";


            return objConexion.consultarInformacion(micomando, misParametros);



        }

        public int GuardarReceptor()
        {

            clsConexion objConexion = new clsConexion();
            List<SqlParameter> misParametros = new List<SqlParameter>();

            misParametros.Clear();

            SqlParameter miParametro;
            miParametro = new SqlParameter("@U00COD", this.u00cod);
            misParametros.Add(miParametro);
            miParametro = new SqlParameter("@NOM_RECEPTOR", this.nombre_receptor);
            misParametros.Add(miParametro);
            miParametro = new SqlParameter("@COD_IDENTIFICACION", this.cod_identificacion);
            misParametros.Add(miParametro);
            miParametro = new SqlParameter("@EMAIL_RECEPTOR", this.email_receptor);
            misParametros.Add(miParametro);
            miParametro = new SqlParameter("@CED_RECEPTOR", this.ced_receptor);
            misParametros.Add(miParametro);
            miParametro = new SqlParameter("@TELEFONO_RECEPTOR", this.telefono_receptor);
            misParametros.Add(miParametro);
            miParametro = new SqlParameter("@COD_RECEPTOR", this.cod_receptor);
            misParametros.Add(miParametro);

            String micomando = "sp_TGuadarReceptor";


            return objConexion.ejecutarSentenciaSPScalar(micomando, misParametros);



        }



        public int ConsultaEliminarReceptor()
        {
            clsConexion objConexion = new clsConexion();


            String miComando = "select COUNT(*) from ENCABEZADO WHERE U00COD =" + this.u00cod + " and COD_EMISOR = '" + this.cod_receptor + "'";

            int resultado = int.Parse(objConexion.consultarInformacionScalar(miComando));

            return resultado;
        }

        public int ELiminarReceptor()
        {

            int resultado = 0;


            clsConexion objConexion = new clsConexion();


            String miComando = "delete RECEPTOR WHERE U00COD = " + this.u00cod + " AND COD_RECEPTOR = '" + this.cod_receptor + "'";



            resultado = objConexion.EliminarDatos(miComando);

            return resultado;
        }

        public int ExiteReceptor()
        {
            clsConexion objConexion = new clsConexion();


            String miComando = "select COUNT(*) from RECEPTOR WHERE U00COD = " + this.u00cod + " 1 AND CED_RECEPTOR = '" + this.ced_receptor + "'";
;

            int resultado = int.Parse(objConexion.consultarInformacionScalar(miComando));

            return resultado;
        }



    }
}
