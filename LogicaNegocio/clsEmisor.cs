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
    public class clsEmisor
    {


        private int u00cod;

        public int U00cod
        {
            get { return u00cod; }
            set { u00cod = value; }
        }

        private String ced_Emisor;

        public String Ced_Emisor
        {
            get { return ced_Emisor; }
            set { ced_Emisor = value; }
        }

        public string Pssw_emailfac
        {
            get
            {
                return pssw_emailfac;
            }

            set
            {
                pssw_emailfac = value;
            }
        }

        public string Emailfac
        {
            get
            {
                return emailfac;
            }

            set
            {
                emailfac = value;
            }
        }

        public string Certificado
        {
            get
            {
                return certificado;
            }

            set
            {
                certificado = value;
            }
        }

        public string Ruta_pdf
        {
            get
            {
                return ruta_pdf;
            }

            set
            {
                ruta_pdf = value;
            }
        }

        public string Ruta_xml
        {
            get
            {
                return ruta_xml;
            }

            set
            {
                ruta_xml = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public string Usr_hacienda
        {
            get
            {
                return usr_hacienda;
            }

            set
            {
                usr_hacienda = value;
            }
        }

        public string Estado
        {
            get
            {
                return estado;
            }

            set
            {
                estado = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string Num_fax
        {
            get
            {
                return num_fax;
            }

            set
            {
                num_fax = value;
            }
        }

        public int Cod_pais_fax
        {
            get
            {
                return cod_pais_fax;
            }

            set
            {
                cod_pais_fax = value;
            }
        }

        public string Num_tel
        {
            get
            {
                return num_tel;
            }

            set
            {
                num_tel = value;
            }
        }

        public int Cod_pais_tel
        {
            get
            {
                return cod_pais_tel;
            }

            set
            {
                cod_pais_tel = value;
            }
        }

        public string Otras_sennas
        {
            get
            {
                return otras_sennas;
            }

            set
            {
                otras_sennas = value;
            }
        }

        public string Cod_barrio
        {
            get
            {
                return cod_barrio;
            }

            set
            {
                cod_barrio = value;
            }
        }

        public string Cod_distrito
        {
            get
            {
                return cod_distrito;
            }

            set
            {
                cod_distrito = value;
            }
        }

        public string Cod_canton
        {
            get
            {
                return cod_canton;
            }

            set
            {
                cod_canton = value;
            }
        }

        public string Cod_provincia
        {
            get
            {
                return cod_provincia;
            }

            set
            {
                cod_provincia = value;
            }
        }

        public string Nom_comercial
        {
            get
            {
                return nom_comercial;
            }

            set
            {
                nom_comercial = value;
            }
        }

        public string Cod_identificacion
        {
            get
            {
                return cod_identificacion;
            }

            set
            {
                cod_identificacion = value;
            }
        }

        public string Nom_emisor
        {
            get
            {
                return nom_emisor;
            }

            set
            {
                nom_emisor = value;
            }
        }

        public string Cod_emisor
        {
            get
            {
                return cod_emisor;
            }

            set
            {
                cod_emisor = value;
            }
        }

        public string Ruta_Logo
        {
            get
            {
                return ruta_Logo;
            }

            set
            {
                ruta_Logo = value;
            }
        }

        private String cod_emisor;

        private String nom_emisor;

        private String cod_identificacion;

        private String nom_comercial;

        private String cod_provincia;

        private String cod_canton;

        private String cod_distrito;

        private String cod_barrio;

        private String otras_sennas;

        private int cod_pais_tel;

        private String num_tel;

        private int cod_pais_fax;

        private String num_fax;

        private String email;

        private String estado;

        private String usr_hacienda;

        private String password;

        private String ruta_xml;

        private String ruta_pdf;

        private String certificado;

        private String emailfac;

        private String pssw_emailfac;

        private String ruta_Logo;




        public int GuardarEmisor()
        {

            clsConexion objConexion = new clsConexion();
            List<SqlParameter> misParametros = new List<SqlParameter>();

            misParametros.Clear();

            SqlParameter miParametro;
            miParametro = new SqlParameter("@NOM_EMISOR", this.nom_emisor);
            misParametros.Add(miParametro);
            miParametro = new SqlParameter("@COD_IDENTIFICACION", this.cod_identificacion);
            misParametros.Add(miParametro);
            miParametro = new SqlParameter("@CED_EMISOR", this.ced_Emisor);
            misParametros.Add(miParametro);
            miParametro = new SqlParameter("@NOM_COMERCIAL", this.nom_comercial);
            misParametros.Add(miParametro);
            miParametro = new SqlParameter("@COD_PROVINCIA", this.cod_provincia);
            misParametros.Add(miParametro);
            miParametro = new SqlParameter("@COD_CANTON", this.cod_canton);
            misParametros.Add(miParametro);
            miParametro = new SqlParameter("@COD_DISTRITO", this.cod_distrito);
            misParametros.Add(miParametro);
            miParametro = new SqlParameter("@COD_BARRIO", this.Cod_barrio);
            misParametros.Add(miParametro);
            miParametro = new SqlParameter("@OTRAS_SENNAS", this.otras_sennas);
            misParametros.Add(miParametro);
            miParametro = new SqlParameter("@COD_PAIS_TEL", this.cod_pais_tel);
            misParametros.Add(miParametro);
            miParametro = new SqlParameter("@NUM_TEL", this.Num_tel);
            misParametros.Add(miParametro);
            miParametro = new SqlParameter("@COD_PAIS_FAX", this.cod_pais_fax);
            misParametros.Add(miParametro);
            miParametro = new SqlParameter("@NUM_FAX", this.Num_fax);
            misParametros.Add(miParametro);
            miParametro = new SqlParameter("@EMAIL", this.email);
            misParametros.Add(miParametro);
            miParametro = new SqlParameter("@ESTADO", this.estado);
            misParametros.Add(miParametro);
            miParametro = new SqlParameter("@USR_HACIENDA", this.usr_hacienda);
            misParametros.Add(miParametro);
            miParametro = new SqlParameter("@PASSWORD", this.password);
            misParametros.Add(miParametro);
            miParametro = new SqlParameter("@RUTA_XML", this.ruta_xml);
            misParametros.Add(miParametro);
            miParametro = new SqlParameter("@RUTA_PDF", this.ruta_pdf);
            misParametros.Add(miParametro);
            miParametro = new SqlParameter("@CERTIFICADO", this.Certificado);
            misParametros.Add(miParametro);
            miParametro = new SqlParameter("@EMAILFAC", this.emailfac);
            misParametros.Add(miParametro);
            miParametro = new SqlParameter("@PSSW_EMAILFAC", this.pssw_emailfac);
            misParametros.Add(miParametro);
            miParametro = new SqlParameter("@RUTALOGO", this.ruta_Logo);
            misParametros.Add(miParametro);

            String micomando = "sp_TGuadarEmisor";


            return objConexion.ejecutarSentenciaSPScalar(micomando, misParametros);



        }


        public DataTable consultarEmisor()
        {

            clsConexion objConexion = new clsConexion();
            List<SqlParameter> misParametros = new List<SqlParameter>();

            misParametros.Clear();


            SqlParameter miParametro;
            miParametro = new SqlParameter("@U00COD", this.u00cod);
            misParametros.Add(miParametro);

            String micomando = "sp_TConsultaEmisor";


            return objConexion.consultarInformacion(micomando, misParametros);



        }


        public DataTable consultarSucursal()
        {

            clsConexion objConexion = new clsConexion();
            List<SqlParameter> misParametros = new List<SqlParameter>();

            misParametros.Clear();


            SqlParameter miParametro;
            miParametro = new SqlParameter("@U00COD", this.u00cod);
            misParametros.Add(miParametro);

            String micomando = "sp_TConsultaSucursal";


            return objConexion.consultarInformacion(micomando, misParametros);



        }

        public DataTable consultarEmisoresXUsuario( String identificacionUsuario)
        {

            clsConexion objConexion = new clsConexion();
            List<SqlParameter> misParametros = new List<SqlParameter>();

            misParametros.Clear();


            SqlParameter miParametro;
            miParametro = new SqlParameter("@IdentifiacionUsuario", identificacionUsuario);
            misParametros.Add(miParametro);

            String micomando = "sp_TConsultaEmisorXUsuario";


            return objConexion.consultarInformacion(micomando, misParametros);



        }


    }
}
