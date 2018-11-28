using Conexion;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
   public class clsFacturaEncabezado
    {
        private int u00cod;

        public int U00cod
        {
            get { return u00cod; }
            set { u00cod = value; }
        }

        private String cod_sucursal;

        public String Cod_sucursal
        {
            get { return cod_sucursal; }
            set { cod_sucursal = value; }
        }

        private String clave;

        public String Clave
        {
            get { return clave; }
            set { clave = value; }
        }

        private String num_consecutivo;

        public String Num_consecutivo
        {
            get { return num_consecutivo; }
            set { num_consecutivo = value; }
        }

        private String caja;

        public String Caja
        {
            get { return caja; }
            set { caja = value; }
        }

        private int transaccion;

        public int Transaccion
        {
            get { return transaccion; }
            set { transaccion = value; }
        }

        private DateTime fecha_emision;

        public DateTime Fecha_emision
        {
            get { return fecha_emision; }
            set { fecha_emision = value; }
        }

        private String usuario;

        public String Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

        private String cod_emisor;

        public String Cod_emisor
        {
            get { return cod_emisor; }
            set { cod_emisor = value; }
        }

        private String cod_cond_ventas;

        public String Cod_cond_ventas
        {
            get { return cod_cond_ventas; }
            set { cod_cond_ventas = value; }
        }

        private String det_otr_cond_venta;

        public String Det_otr_cond_venta
        {
            get { return det_otr_cond_venta; }
            set { det_otr_cond_venta = value; }
        }

        private String plazo_credito;

        public String Plazo_credito
        {
            get { return plazo_credito; }
            set { plazo_credito = value; }
        }

        private String cod_medio_pago;

        public String Cod_medio_pago
        {
            get { return cod_medio_pago; }
            set { cod_medio_pago = value; }
        }

        private String det_otr_medio_pago;

        public String Det_otr_medio_pago
        {
            get { return det_otr_medio_pago; }
            set { det_otr_medio_pago = value; }
        }

        private decimal tipo_cambio;

        public decimal Tipo_cambio
        {
            get { return tipo_cambio; }
            set { tipo_cambio = value; }
        }

        private decimal total_serv_gravado;

        public decimal Total_serv_gravado
        {
            get { return total_serv_gravado; }
            set { total_serv_gravado = value; }
        }

        private decimal total_serv_exento;

        public decimal Total_serv_exento
        {
            get { return total_serv_exento; }
            set { total_serv_exento = value; }
        }

        private decimal total_mercancia_gravada;

        public decimal Total_mercancia_gravada
        {
            get { return total_mercancia_gravada; }
            set { total_mercancia_gravada = value; }
        }

        private decimal total_mercancia_exenta;

        public decimal Total_mercancia_exenta
        {
            get { return total_mercancia_exenta; }
            set { total_mercancia_exenta = value; }
        }

        private decimal total_gravado;

        public decimal Total_gravado
        {
            get { return total_gravado; }
            set { total_gravado = value; }
        }

        private decimal total_exento;

        public decimal Total_exento
        {
            get { return total_exento; }
            set { total_exento = value; }
        }

        private decimal total_venta;

        public decimal Total_venta
        {
            get { return total_venta; }
            set { total_venta = value; }
        }

        private decimal total_descuento;

        public decimal Total_descuento
        {
            get { return total_descuento; }
            set { total_descuento = value; }
        }

        private decimal total_venta_neta;

        public decimal Total_venta_neta
        {
            get { return total_venta_neta; }
            set { total_venta_neta = value; }
        }

        private decimal total_impuestos;

        public decimal Total_impuestos
        {
            get { return total_impuestos; }
            set { total_impuestos = value; }
        }

        private decimal total_comprobante;

        public decimal Total_comprobante
        {
            get { return total_comprobante; }
            set { total_comprobante = value; }
        }

        private DateTime fecha_extraccion;

        public DateTime Fecha_extraccion
        {
            get { return fecha_extraccion; }
            set { fecha_extraccion = value; }
        }

        private DateTime fecha_envio;

        public DateTime Fecha_envio
        {
            get { return fecha_envio; }
            set { fecha_envio = value; }
        }

        private DateTime fecha_respuesta;

        public DateTime Fecha_respuesta
        {
            get { return fecha_respuesta; }
            set { fecha_respuesta = value; }
        }

        private String estado_hacienda;

        public String Estado_hacienda
        {
            get { return estado_hacienda; }
            set { estado_hacienda = value; }
        }

        private String cod_tipodocu;

        public String Cod_tipodocu
        {
            get { return cod_tipodocu; }
            set { cod_tipodocu = value; }
        }

        private int cod_receptor;

        public int Cod_receptor
        {
            get { return cod_receptor; }
            set { cod_receptor = value; }
        }

        private String estado_respuesta;

        public String Estado_respuesta
        {
            get { return estado_respuesta; }
            set { estado_respuesta = value; }
        }



        public int InsertarEncabezado()
        {

            clsConexion objConexion = new clsConexion();
            List<SqlParameter> misParametros = new List<SqlParameter>();

            misParametros.Clear();

            SqlParameter miParametro;
            miParametro = new SqlParameter("@U00COD", this.u00cod);
            misParametros.Add(miParametro);
            miParametro = new SqlParameter("@COD_SUCURSAL", this.cod_sucursal);
            misParametros.Add(miParametro);
            miParametro = new SqlParameter("@CAJA", this.caja);
            misParametros.Add(miParametro);
            miParametro = new SqlParameter("@TRANSACCION", this.transaccion);
            misParametros.Add(miParametro);
            miParametro = new SqlParameter("@COD_EMISOR", this.cod_emisor);
            misParametros.Add(miParametro);
            miParametro = new SqlParameter("@COD_COND_VENTAS", this.cod_cond_ventas);
            misParametros.Add(miParametro);
            miParametro = new SqlParameter("@DET_OTR_COND_VENTA", this.det_otr_cond_venta);
            misParametros.Add(miParametro);
            miParametro = new SqlParameter("@PLAZO_CREDITO", this.plazo_credito);
            misParametros.Add(miParametro);
            miParametro = new SqlParameter("@COD_MEDIO_PAGO", this.cod_medio_pago);
            misParametros.Add(miParametro);
            miParametro = new SqlParameter("@DET_OTR_MEDIO_PAGO", this.det_otr_medio_pago);
            misParametros.Add(miParametro);
            miParametro = new SqlParameter("@TOTAL_SERV_GRAVADO", this.total_serv_gravado);
            misParametros.Add(miParametro);
            miParametro = new SqlParameter("@TOTAL_SERV_EXENTO", this.total_serv_exento);
            misParametros.Add(miParametro);
            miParametro = new SqlParameter("@TOTAL_MERCANCIA_GRAVADA", this.total_mercancia_gravada);
            misParametros.Add(miParametro);
            miParametro = new SqlParameter("@TOTAL_MERCANCIA_EXENTA", this.total_mercancia_exenta);
            misParametros.Add(miParametro);
            miParametro = new SqlParameter("@TOTAL_GRAVADO", this.total_gravado);
            misParametros.Add(miParametro);
            miParametro = new SqlParameter("@TOTAL_EXENTO", this.total_exento);
            misParametros.Add(miParametro);
            miParametro = new SqlParameter("@TOTAL_VENTA", this.total_venta);
            misParametros.Add(miParametro);
            miParametro = new SqlParameter("@TOTAL_DESCUENTO", this.total_descuento);
            misParametros.Add(miParametro);
            miParametro = new SqlParameter("@TOTAL_VENTA_NETA", this.total_venta_neta);
            misParametros.Add(miParametro);
            miParametro = new SqlParameter("@TOTAL_IMPUESTOS", this.total_impuestos);
            misParametros.Add(miParametro);
            miParametro = new SqlParameter("@TOTAL_COMPROBANTE", this.total_comprobante);
            misParametros.Add(miParametro);
            miParametro = new SqlParameter("@COD_TIPODOCU", this.cod_tipodocu);
            misParametros.Add(miParametro);
            miParametro = new SqlParameter("@COD_RECEPTOR", this.cod_receptor);
            misParametros.Add(miParametro);


            String micomando = "sp_TGuadarEncabezado";


            return objConexion.ejecutarSentenciaSPScalar(micomando, misParametros);



        }

        public String InsertarEncabezado2()
        {

            clsConexion objConexion = new clsConexion();
            List<SqlParameter> misParametros = new List<SqlParameter>();

            misParametros.Clear();

            SqlParameter miParametro;
            miParametro = new SqlParameter("@U00COD", this.u00cod);
            misParametros.Add(miParametro);
            miParametro = new SqlParameter("@COD_SUCURSAL", this.cod_sucursal);
            misParametros.Add(miParametro);
            miParametro = new SqlParameter("@CAJA", this.caja);
            misParametros.Add(miParametro);
            miParametro = new SqlParameter("@TRANSACCION", this.transaccion);
            misParametros.Add(miParametro);
            miParametro = new SqlParameter("@COD_EMISOR", this.cod_emisor);
            misParametros.Add(miParametro);
            miParametro = new SqlParameter("@COD_COND_VENTAS", this.cod_cond_ventas);
            misParametros.Add(miParametro);
            miParametro = new SqlParameter("@DET_OTR_COND_VENTA", this.det_otr_cond_venta);
            misParametros.Add(miParametro);
            miParametro = new SqlParameter("@PLAZO_CREDITO", this.plazo_credito);
            misParametros.Add(miParametro);
            miParametro = new SqlParameter("@COD_MEDIO_PAGO", this.cod_medio_pago);
            misParametros.Add(miParametro);
            miParametro = new SqlParameter("@DET_OTR_MEDIO_PAGO", this.det_otr_medio_pago);
            misParametros.Add(miParametro);
            miParametro = new SqlParameter("@COD_RECEPTOR", this.cod_receptor);
            misParametros.Add(miParametro);


            String micomando = "sp_TGuadarEncabezado2";


            return objConexion.guardarEnceabezado(micomando, misParametros);



        }


    }
}
