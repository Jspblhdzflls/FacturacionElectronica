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
    public class clsUsuario
    {

        private int idUsuario;

        private String identificacionUsuario;

        private String nombreUsuario;

        private String contrasena;

        public string Contrasena
        {
            get
            {
                return contrasena;
            }

            set
            {
                contrasena = value;
            }
        }

        public string NombreUsuario
        {
            get
            {
                return nombreUsuario;
            }

            set
            {
                nombreUsuario = value;
            }
        }

        public string IdentificacionUsuario
        {
            get
            {
                return identificacionUsuario;
            }

            set
            {
                identificacionUsuario = value;
            }
        }

        public int IdUsuario
        {
            get
            {
                return idUsuario;
            }

            set
            {
                idUsuario = value;
            }
        }


        public DataTable ValidarInicioSession()
        {

            clsConexion objConexion = new clsConexion();
            List<SqlParameter> misParametros = new List<SqlParameter>();

            misParametros.Clear();


            SqlParameter miParametro;
            miParametro = new SqlParameter("@identificacionUsuario", this.identificacionUsuario);
            misParametros.Add(miParametro);

            miParametro = new SqlParameter("@contrasenia", this.contrasena);
            misParametros.Add(miParametro);


            String micomando = "spValidarUsuario";


            return objConexion.consultarInformacion(micomando, misParametros);



        }



    }
}
