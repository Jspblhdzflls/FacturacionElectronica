using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conexion
{
    public class clsConexion
    {
        private SqlConnection miconexion;
        private SqlCommand comandoSql;


        private bool abreConexion()
        {
            miconexion = new SqlConnection();

            // miconexion.ConnectionString = "Data Source=AIU654BDA02-PR;Initial Catalog=InternetBanking;User ID=USERIB2;Password=1234";

            miconexion.ConnectionString = @"Data Source=PABLOLAP\MSSQLSERVER2017;Initial Catalog=FacturaElectronica;User ID=userFactElec;Password=1234";


            miconexion.Open();

            return true;

        }

        public bool ejecutarSentencia(String sqlText)
        {


            this.comandoSql = new SqlCommand();
            abreConexion();
            this.comandoSql.Connection = this.miconexion;
            this.comandoSql.CommandText = (sqlText);
            this.comandoSql.ExecuteNonQuery();
            this.miconexion.Close();

            return true;

        }


        public int ejecutarSentencia2(String sqlText)
        {

            int resultado = 0;

            this.comandoSql = new SqlCommand();
            abreConexion();
            this.comandoSql.Connection = this.miconexion;
            this.comandoSql.CommandText = (sqlText);
            resultado = this.comandoSql.ExecuteNonQuery();
            this.miconexion.Close();

            return resultado;

        }


        public bool ejecutarSentencia(String comandoSql, SqlParameter[] parametroSql)
        {

            bool resultado;

            try
            {
                this.comandoSql = new SqlCommand();

                abreConexion();
                this.comandoSql.Connection = this.miconexion;
                this.comandoSql.CommandText = comandoSql;

                this.comandoSql.Parameters.AddRange(parametroSql);
                this.comandoSql.ExecuteNonQuery();
                this.miconexion.Close();
                resultado = true;

            }
            catch (Exception ex)
            {

                resultado = false;
            }
            return resultado;
        }

        public bool ejecutarSentenciaSP2(String comandoSql, SqlParameter[] parametroSql)
        {

            bool resultado;

            try
            {
                this.comandoSql = new SqlCommand();

                abreConexion();
                this.comandoSql.Connection = this.miconexion;
                this.comandoSql.CommandText = comandoSql;
                this.comandoSql.CommandType = CommandType.StoredProcedure;


                this.comandoSql.Parameters.AddRange(parametroSql);
                this.comandoSql.ExecuteNonQuery();
                this.miconexion.Close();
                resultado = true;

            }
            catch (Exception ex)
            {
                resultado = false;
            }
            return resultado;
        }

        //Consultar infomacion sin Parametros con SP
        public DataTable ConsultarInformacion(String comando)
        {
            DataTable dtResultado = new DataTable();
            //SqlDataReader drResultado = new SqlDataReader();
            abreConexion();
            this.comandoSql = new SqlCommand();
            this.comandoSql.Connection = this.miconexion;
            this.comandoSql.CommandText = comando;
            this.comandoSql.CommandType = CommandType.StoredProcedure;


            this.comandoSql.ExecuteReader();


            return dtResultado;


        }

        public SqlDataAdapter ConsultarInformacion2(String comando)
        {

            abreConexion();

            this.comandoSql = new SqlCommand(comando);
            SqlDataAdapter da = new SqlDataAdapter(comandoSql);
            DataTable dtResultado = new DataTable();

            // this.comandoSql.ExecuteReader();
            // dtResultado.Load(drResultado);

            return da;


        }

        //Inserta Datos con SP
        public Boolean ejecutarSentenciaSP(String comando, List<SqlParameter> misParametros)
        {

            //Se utiliza
            try
            {
                this.comandoSql = new SqlCommand();
                abreConexion();
                this.comandoSql.Connection = this.miconexion;
                this.comandoSql.CommandText = comando;
                this.comandoSql.CommandType = CommandType.StoredProcedure;


                this.comandoSql.Parameters.AddRange(misParametros.ToArray());
                this.comandoSql.ExecuteNonQuery();
                this.miconexion.Close();
                //objResultado.codigoError = 0;

            }
            catch (SqlException exSql)
            {
                //   objResultado.codigoError = exSql.Number;
                //    objResultado.mensajeError = exSql.Message;
                //  objResultado.mensajeError = exSql.StackTrace;

                return false;
            }
            catch (Exception ex)
            {


                // objResultado.codigoError = 1;
                //   objResultado.mensajeError = ex.Message;
                //
                return false;
            }
            return true;
        }

        public int ejecutarSentenciaSPScalar(String comando, List<SqlParameter> misParametros)
        {
            int resultado = 0;
            //Se utiliza
            try
            {
                this.comandoSql = new SqlCommand();
                abreConexion();
                this.comandoSql.Connection = this.miconexion;
                this.comandoSql.CommandText = comando;
                this.comandoSql.CommandType = CommandType.StoredProcedure;


                this.comandoSql.Parameters.AddRange(misParametros.ToArray());
                resultado = int.Parse(this.comandoSql.ExecuteScalar().ToString());
                this.miconexion.Close();
                //objResultado.codigoError = 0;

            }
            catch (SqlException exSql)
            {
                //   objResultado.codigoError = exSql.Number;
                //    objResultado.mensajeError = exSql.Message;
                //  objResultado.mensajeError = exSql.StackTrace;

                return 0;
            }
            catch (Exception ex)
            {

                // objResultado.codigoError = 1;
                //   objResultado.mensajeError = ex.Message;
                //


                return 0;
            }
            return resultado;
        }


        public String guardarEnceabezado(String comando, List<SqlParameter> misParametros)
        {
            String resultado = "";
            //Se utiliza
            try
            {
                this.comandoSql = new SqlCommand();
                abreConexion();
                this.comandoSql.Connection = this.miconexion;
                this.comandoSql.CommandText = comando;
                this.comandoSql.CommandType = CommandType.StoredProcedure;


                this.comandoSql.Parameters.AddRange(misParametros.ToArray());
                resultado = this.comandoSql.ExecuteScalar().ToString();
                this.miconexion.Close();
                //objResultado.codigoError = 0;

            }
            catch (SqlException exSql)
            {
                //   objResultado.codigoError = exSql.Number;
                //    objResultado.mensajeError = exSql.Message;
                //  objResultado.mensajeError = exSql.StackTrace;

                return "";
            }
            catch (Exception ex)
            {

                // objResultado.codigoError = 1;
                //   objResultado.mensajeError = ex.Message;
                //


                return "";
            }
            return resultado;
        }

        //Consuta informacion con parametros
        public DataTable consultarInformacion(String comando, List<SqlParameter> misParametros)
        {

            SqlDataReader dr;
            DataTable miDT = new DataTable();

            this.comandoSql = new SqlCommand();
            abreConexion();
            this.comandoSql.CommandText = comando;
            this.comandoSql.CommandType = CommandType.StoredProcedure;

            this.comandoSql.Connection = this.miconexion;
            this.comandoSql.Parameters.AddRange(misParametros.ToArray());


            dr = this.comandoSql.ExecuteReader();


            if (dr.HasRows)
            {
                miDT.Load(dr);
                miconexion.Close();
                return miDT;
            }
            else
            {
                miconexion.Close();
                return miDT;
            }


        }

        //Consuta informacion con parametros
        public SqlDataReader consultarAdjutno(String comando, List<SqlParameter> misParametros)
        {

            SqlDataReader dr;
            DataTable miDT = new DataTable();

            this.comandoSql = new SqlCommand();
            abreConexion();
            this.comandoSql.CommandText = comando;
            this.comandoSql.CommandType = CommandType.StoredProcedure;

            this.comandoSql.Connection = this.miconexion;
            this.comandoSql.Parameters.AddRange(misParametros.ToArray());


            dr = this.comandoSql.ExecuteReader();
            return dr;


        }

        //Consultar Informacion Sin parametros
        public DataTable consultarInformacion(String comandoSql)
        {
            SqlDataReader dr;
            DataTable miDT = new DataTable();
            abreConexion();
            this.comandoSql = new SqlCommand();
            this.comandoSql.CommandText = comandoSql;
            this.comandoSql.Connection = this.miconexion;
            this.comandoSql.CommandType = CommandType.StoredProcedure;

            //  if (parametroSql != null)
            //     this.sqlCommand.Parameters.AddRange(parametroSql);
            dr = this.comandoSql.ExecuteReader();
            //cerrarConexion();

            if (dr.HasRows)
            {
                miDT.Load(dr);
                miconexion.Close();
                return miDT;
            }
            else
            {
                miconexion.Close();
                return miDT;
            }

        }
        //Consultar Informacion Sin parametros
        public DataTable consultarInformacionSQL(String comandoSql)
        {
            SqlDataReader dr;
            DataTable miDT = new DataTable();
            abreConexion();
            this.comandoSql = new SqlCommand();
            this.comandoSql.CommandText = comandoSql;
            this.comandoSql.Connection = this.miconexion;
            this.comandoSql.CommandType = CommandType.Text;

            //  if (parametroSql != null)
            //     this.sqlCommand.Parameters.AddRange(parametroSql);
            dr = this.comandoSql.ExecuteReader();



            if (dr.HasRows)
            {
                miDT.Load(dr);
                miconexion.Close();
                return miDT;
            }
            else
            {
                miconexion.Close();
                return miDT;
            }

        }


        //Consultar Informacion Sin parametros
        public SqlDataReader consultarInformacionArchivoAdjunto(String comandoSql)
        {
            SqlDataReader dr;
            abreConexion();
            this.comandoSql = new SqlCommand();
            this.comandoSql.CommandText = comandoSql;
            this.comandoSql.Connection = this.miconexion;
            this.comandoSql.CommandType = CommandType.Text;

            //  if (parametroSql != null)
            //     this.sqlCommand.Parameters.AddRange(parametroSql);
            dr = this.comandoSql.ExecuteReader();


            //cerrarConexion();
            return dr;
        }

        public DataTable consultarDataTable(String comandoSql)
        {
            SqlDataReader dr;
            DataTable dt = new DataTable();
            abreConexion();
            this.comandoSql = new SqlCommand();
            this.comandoSql.CommandText = comandoSql;
            this.comandoSql.Connection = this.miconexion;
            this.comandoSql.CommandType = CommandType.Text;

            //  if (parametroSql != null)
            //     this.sqlCommand.Parameters.AddRange(parametroSql);
            dr = this.comandoSql.ExecuteReader();


            dt.Load(dr);

            dr.Close();
            miconexion.Close();

            return dt;
        }

        public String consultarInformacionScalar(String comandoSql)
        {
            String Resultado = "";

            abreConexion();
            this.comandoSql = new SqlCommand();
            this.comandoSql.CommandText = comandoSql;
            this.comandoSql.Connection = this.miconexion;
            this.comandoSql.CommandType = CommandType.Text;
            Resultado = this.comandoSql.ExecuteScalar().ToString();

            return Resultado;
        }


        public int EliminarDatos(String comandoSql)
        {
            String Resultado = "";

            abreConexion();
            this.comandoSql = new SqlCommand();
            this.comandoSql.CommandText = comandoSql;
            this.comandoSql.Connection = this.miconexion;
            this.comandoSql.CommandType = CommandType.Text;
            Resultado = this.comandoSql.ExecuteNonQuery().ToString();


            return int.Parse(Resultado);
        }


        public int EliminarEstado(String comandoSql)
        {
            String Resultado = "";
            try
            {
                abreConexion();
                this.comandoSql = new SqlCommand();
                this.comandoSql.CommandText = comandoSql;
                this.comandoSql.Connection = this.miconexion;
                this.comandoSql.CommandType = CommandType.Text;
                Resultado = this.comandoSql.ExecuteNonQuery().ToString();

                return int.Parse(Resultado);
                //objResultado.codigoError = 0;

            }
            catch (SqlException exSql)
            {

                return -1;
            }




        }


    }
}
