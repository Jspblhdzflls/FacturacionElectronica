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
    public class clsArticulo
    {
        private int u00cod;
        private int id_articulo;
        private String cod_prod_serv;
        private String cod_serv;
        private String detalle;
        private String unidad_medida;
        private String unidad_medida_comercial;
        private double precio_unitario;
        private Boolean paga_impuesto;
        private String cod_impuesto;
        private int estado_articulo;

        private int idTipoBusqueda;

        public int Estado_articulo
        {
            get
            {
                return estado_articulo;
            }

            set
            {
                estado_articulo = value;
            }
        }

        public string Cod_impuesto
        {
            get
            {
                return cod_impuesto;
            }

            set
            {
                cod_impuesto = value;
            }
        }

        public bool Paga_impuesto
        {
            get
            {
                return paga_impuesto;
            }

            set
            {
                paga_impuesto = value;
            }
        }

        public double Precio_unitario
        {
            get
            {
                return precio_unitario;
            }

            set
            {
                precio_unitario = value;
            }
        }

        public string Unidad_medida_comercial
        {
            get
            {
                return unidad_medida_comercial;
            }

            set
            {
                unidad_medida_comercial = value;
            }
        }

        public string Unidad_medida
        {
            get
            {
                return unidad_medida;
            }

            set
            {
                unidad_medida = value;
            }
        }

        public string Detalle
        {
            get
            {
                return detalle;
            }

            set
            {
                detalle = value;
            }
        }

        public string Cod_serv
        {
            get
            {
                return cod_serv;
            }

            set
            {
                cod_serv = value;
            }
        }

        public string Cod_prod_serv
        {
            get
            {
                return cod_prod_serv;
            }

            set
            {
                cod_prod_serv = value;
            }
        }

        public int Id_articulo
        {
            get
            {
                return id_articulo;
            }

            set
            {
                id_articulo = value;
            }
        }

        public int U00cod
        {
            get
            {
                return u00cod;
            }

            set
            {
                u00cod = value;
            }
        }

        public int IdTipoBusqueda
        {
            get
            {
                return idTipoBusqueda;
            }

            set
            {
                idTipoBusqueda = value;
            }
        }

        public int GuardarArticulo()
        {

            clsConexion objConexion = new clsConexion();
            List<SqlParameter> misParametros = new List<SqlParameter>();

            misParametros.Clear();

            SqlParameter miParametro;
            miParametro = new SqlParameter("@U00COD", this.U00cod);
            misParametros.Add(miParametro);

            miParametro = new SqlParameter("@ID_ARTICULO", this.Id_articulo);
            misParametros.Add(miParametro);
            miParametro = new SqlParameter("@COD_PROD_SERV", this.Cod_prod_serv);
            misParametros.Add(miParametro);
            miParametro = new SqlParameter("@COD_SERV", this.cod_serv);
            misParametros.Add(miParametro);
            miParametro = new SqlParameter("@DETALLE", this.detalle);
            misParametros.Add(miParametro);
            miParametro = new SqlParameter("@UNIDAD_MEDIDA", this.unidad_medida);
            misParametros.Add(miParametro);
            miParametro = new SqlParameter("@UNIDAD_MEDIDA_COMERCIAL", this.unidad_medida_comercial);
            misParametros.Add(miParametro);
            miParametro = new SqlParameter("@PRECIO_UNITARIO", this.precio_unitario);
            misParametros.Add(miParametro);
            miParametro = new SqlParameter("@PAGA_IMPUESTO", this.paga_impuesto);
            misParametros.Add(miParametro);
            miParametro = new SqlParameter("@COD_IMPUESTO", this.cod_impuesto);
            misParametros.Add(miParametro);
            miParametro = new SqlParameter("@ESTADO_ARTICULO", this.estado_articulo);
            misParametros.Add(miParametro);



            String micomando = "sp_TGuadarArticulo";


            return objConexion.ejecutarSentenciaSPScalar(micomando, misParametros);



        }



        public int EliminarArticulo()
        {

            int resultado = 0;


            clsConexion objConexion = new clsConexion();


            String miComando = "DELETE ARTICULO WHERE U00COD =" + this.u00cod + " AND ID_ARTICULO = " + this.id_articulo;


            resultado = objConexion.EliminarDatos(miComando);

            return resultado;
        }







        public int ExiteArticulo()
        {
            clsConexion objConexion = new clsConexion();


            String miComando = "SELECT * FROM ARTICULO WHERE DETALLE = '" + this.detalle + "' AND  U00COD = " + this.u00cod;

            int resultado = int.Parse(objConexion.consultarInformacionScalar(miComando));

            return resultado;
        }



        public DataTable consultarArticulo()
        {

            clsConexion objConexion = new clsConexion();
            List<SqlParameter> misParametros = new List<SqlParameter>();

            misParametros.Clear();


            SqlParameter miParametro;
            miParametro = new SqlParameter("@TipoBusqueda", this.IdTipoBusqueda);
            misParametros.Add(miParametro);

            miParametro = new SqlParameter("@ID_ARTICULO", this.id_articulo);
            misParametros.Add(miParametro);

            miParametro = new SqlParameter("@NOMBRE_ARTICULO", this.detalle);
            misParametros.Add(miParametro);
            miParametro = new SqlParameter("@U00COD", this.u00cod);
            misParametros.Add(miParametro);

            String micomando = "sp_TConsultaArticulo";


            return objConexion.consultarInformacion(micomando, misParametros);



        }




    }
}
