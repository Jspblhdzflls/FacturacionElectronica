using Conexion;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class clsFacturaDetalle
    {


        private int u00cod;

        public int U00cod
        {
            get { return u00cod; }
            set { u00cod = value; }
        }

        private string cod_sucursal;

        public string Cod_sucursal
        {
            get { return cod_sucursal; }
            set { cod_sucursal = value; }
        }

        private string clave;

        public string Clave
        {
            get { return clave; }
            set { clave = value; }
        }

        private string num_consecutivo;

        public string Num_consecutivo
        {
            get { return num_consecutivo; }
            set { num_consecutivo = value; }
        }

        private string caja;

        public string Caja
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

        private DateTime fech_emision;

        public DateTime Fech_emision
        {
            get { return fech_emision; }
            set { fech_emision = value; }
        }

        private int numero_linea;

        public int Numero_linea
        {
            get { return numero_linea; }
            set { numero_linea = value; }
        }

        private string cod_proser;

        public string Cod_proser
        {
            get { return cod_proser; }
            set { cod_proser = value; }
        }

        private string cod_serv;

        public string Cod_serv
        {
            get { return cod_serv; }
            set { cod_serv = value; }
        }

        private int cantidad;

        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        private string unidad_medida;

        public string Unidad_medida
        {
            get { return unidad_medida; }
            set { unidad_medida = value; }
        }

        private string unidad_medida_comercial;

        public string Unidad_medida_comercial
        {
            get { return unidad_medida_comercial; }
            set { unidad_medida_comercial = value; }
        }

        private string detalle;

        public string Detalle
        {
            get { return detalle; }
            set { detalle = value; }
        }

        private decimal precio_unitario;

        public decimal Precio_unitario
        {
            get { return precio_unitario; }
            set { precio_unitario = value; }
        }

        private decimal monto_total;

        public decimal Monto_total
        {
            get { return monto_total; }
            set { monto_total = value; }
        }

        private decimal monto_descuento;

        public decimal Monto_descuento
        {
            get { return monto_descuento; }
            set { monto_descuento = value; }
        }

        private string naturaleza_descuento;

        public string Naturaleza_descuento
        {
            get { return naturaleza_descuento; }
            set { naturaleza_descuento = value; }
        }

        private decimal subtotal;

        public decimal Subtotal
        {
            get { return subtotal; }
            set { subtotal = value; }
        }

        private string cod_docuauto;

        public string Cod_docuauto
        {
            get { return cod_docuauto; }
            set { cod_docuauto = value; }
        }

        private string numero_documento_exonerado;

        public string Numero_documento_exonerado
        {
            get { return numero_documento_exonerado; }
            set { numero_documento_exonerado = value; }
        }

        private string nombre_institucion_exonerado;

        public string Nombre_institucion_exonerado
        {
            get { return nombre_institucion_exonerado; }
            set { nombre_institucion_exonerado = value; }
        }

        private DateTime fecha_emision_exonerado;

        public DateTime Fecha_emision_exonerado
        {
            get { return fecha_emision_exonerado; }
            set { fecha_emision_exonerado = value; }
        }

        private decimal monto_impuesto_exonerado;

        public decimal Monto_impuesto_exonerado
        {
            get { return monto_impuesto_exonerado; }
            set { monto_impuesto_exonerado = value; }
        }

        private int porcentaje_compra_exonerada;

        public int Porcentaje_compra_exonerada
        {
            get { return porcentaje_compra_exonerada; }
            set { porcentaje_compra_exonerada = value; }
        }

        private string cod_impuesto;

        public string Cod_impuesto
        {
            get { return cod_impuesto; }
            set { cod_impuesto = value; }
        }

        private decimal tarifa_impuesto;

        public decimal Tarifa_impuesto
        {
            get { return tarifa_impuesto; }
            set { tarifa_impuesto = value; }
        }

        private decimal monto_impuesto;

        public decimal Monto_impuesto
        {
            get { return monto_impuesto; }
            set { monto_impuesto = value; }
        }

        private decimal monto_total_linea;

        public decimal Monto_total_linea
        {
            get { return monto_total_linea; }
            set { monto_total_linea = value; }
        }




        public int InsertarDetalle()
        {

            clsConexion objConexion = new clsConexion();
            List<SqlParameter> misParametros = new List<SqlParameter>();

            misParametros.Clear();

            SqlParameter miParametro;
            miParametro = new SqlParameter("@U00COD", this.u00cod);
            misParametros.Add(miParametro);
            miParametro = new SqlParameter("@COD_PROSER", this.u00cod);
            misParametros.Add(miParametro);
            miParametro = new SqlParameter("@COD_SERV", this.u00cod);
            misParametros.Add(miParametro);
            miParametro = new SqlParameter("@CANTIDAD", this.u00cod);
            misParametros.Add(miParametro);
            miParametro = new SqlParameter("@UNIDAD_MEDIDA", this.u00cod);
            misParametros.Add(miParametro);
            miParametro = new SqlParameter("@UNIDAD_MEDIDA_COMERCIAL", this.u00cod);
            misParametros.Add(miParametro);
            miParametro = new SqlParameter("@DETALLE", this.u00cod);
            misParametros.Add(miParametro);
            miParametro = new SqlParameter("@PRECIO_UNITARIO", this.u00cod);
            misParametros.Add(miParametro);
            miParametro = new SqlParameter("@MONTO_TOTAL", this.u00cod);
            misParametros.Add(miParametro);
            miParametro = new SqlParameter("@MONTO_DESCUENTO", this.u00cod);
            misParametros.Add(miParametro);
            miParametro = new SqlParameter("@NATURALEZA_DESCUENTO", this.u00cod);
            misParametros.Add(miParametro);
            miParametro = new SqlParameter("@SUBTOTAL", this.u00cod);
            misParametros.Add(miParametro);
            miParametro = new SqlParameter("@COD_DOCUAUTO", this.u00cod);
            misParametros.Add(miParametro);
            miParametro = new SqlParameter("@NUMERO_DOCUMENTO_EXONERADO", this.u00cod);
            misParametros.Add(miParametro);
            miParametro = new SqlParameter("@NOMBRE_INSTITUCION_EXONERADO", this.u00cod);
            misParametros.Add(miParametro);
            miParametro = new SqlParameter("@MONTO_IMPUESTO_EXONERADO", this.u00cod);
            misParametros.Add(miParametro);
            miParametro = new SqlParameter("@PORCENTAJE_COMPRA_EXONERADA", this.u00cod);
            misParametros.Add(miParametro);
            miParametro = new SqlParameter("@COD_IMPUESTO", this.u00cod);
            misParametros.Add(miParametro);
            miParametro = new SqlParameter("@TARIFA_IMPUESTO", this.u00cod);
            misParametros.Add(miParametro);
            miParametro = new SqlParameter("@MONTO_IMPUESTO", this.u00cod);
            misParametros.Add(miParametro);
            miParametro = new SqlParameter("@MONTO_TOTAL_LINEA", this.u00cod);
            misParametros.Add(miParametro);

            String micomando = "sp_TGuadarDetalle";

            return objConexion.ejecutarSentenciaSPScalar(micomando, misParametros);


        }


        public int InsertarDetalle(clsFacturaDetalle miProduto)
        {

            clsConexion objConexion = new clsConexion();
            List<SqlParameter> misParametros = new List<SqlParameter>();

            misParametros.Clear();

            SqlParameter miParametro;
            miParametro = new SqlParameter("@U00COD", this.u00cod);
            misParametros.Add(miParametro);
            miParametro = new SqlParameter("@CLAVE", this.clave);
            misParametros.Add(miParametro);

            miParametro = new SqlParameter("@COD_PROSER", miProduto.cod_proser);
            misParametros.Add(miParametro);
            miParametro = new SqlParameter("@COD_SERV", miProduto.cod_serv);
            misParametros.Add(miParametro);
            miParametro = new SqlParameter("@CANTIDAD", miProduto.cantidad);
            misParametros.Add(miParametro);
            miParametro = new SqlParameter("@UNIDAD_MEDIDA", miProduto.unidad_medida);
            misParametros.Add(miParametro);
            miParametro = new SqlParameter("@UNIDAD_MEDIDA_COMERCIAL", miProduto.unidad_medida_comercial);
            misParametros.Add(miParametro);
            miParametro = new SqlParameter("@DETALLE", miProduto.detalle);
            misParametros.Add(miParametro);
            miParametro = new SqlParameter("@PRECIO_UNITARIO", miProduto.precio_unitario);
            misParametros.Add(miParametro);
            miParametro = new SqlParameter("@MONTO_TOTAL", miProduto.monto_total);
            misParametros.Add(miParametro);
            miParametro = new SqlParameter("@MONTO_DESCUENTO", miProduto.monto_descuento);
            misParametros.Add(miParametro);
            miParametro = new SqlParameter("@NATURALEZA_DESCUENTO", miProduto.naturaleza_descuento);
            misParametros.Add(miParametro);
            miParametro = new SqlParameter("@SUBTOTAL", miProduto.subtotal);
            misParametros.Add(miParametro);
            miParametro = new SqlParameter("@COD_DOCUAUTO", miProduto.cod_docuauto);
            misParametros.Add(miParametro);
            miParametro = new SqlParameter("@NUMERO_DOCUMENTO_EXONERADO", miProduto.numero_documento_exonerado);
            misParametros.Add(miParametro);
            miParametro = new SqlParameter("@NOMBRE_INSTITUCION_EXONERADO", miProduto.nombre_institucion_exonerado);
            misParametros.Add(miParametro);
            miParametro = new SqlParameter("@MONTO_IMPUESTO_EXONERADO", miProduto.monto_impuesto_exonerado);
            misParametros.Add(miParametro);
            miParametro = new SqlParameter("@PORCENTAJE_COMPRA_EXONERADA", miProduto.porcentaje_compra_exonerada);
            misParametros.Add(miParametro);
            miParametro = new SqlParameter("@COD_IMPUESTO", miProduto.cod_impuesto);
            misParametros.Add(miParametro);
            miParametro = new SqlParameter("@TARIFA_IMPUESTO", miProduto.tarifa_impuesto);
            misParametros.Add(miParametro);
            miParametro = new SqlParameter("@MONTO_IMPUESTO", miProduto.monto_impuesto);
            misParametros.Add(miParametro);
            miParametro = new SqlParameter("@MONTO_TOTAL_LINEA", miProduto.monto_total_linea);
            misParametros.Add(miParametro);

            String micomando = "sp_TGuadarDetalle";

            return objConexion.ejecutarSentenciaSPScalar(micomando, misParametros);


        }



        public int agregarDetalleFactura(List<clsFacturaDetalle> listDetalle)
        {
            bool existe = false;
            int posicion = 0;


            for (int i = 0; i < listDetalle.Count; i++)
            {
                if (listDetalle[i].cod_serv == this.cod_serv)
                {
                    posicion = i;
                    existe = true;
                    return 0;

                }
            }

            if (existe)
            {
                listDetalle[posicion] = this;
                return 1;
            }
            else if (!existe)
            {
                listDetalle.Add(this);
                return 1;
            }
            else
                return 3;



        }

        public bool guardarLista(List<clsFacturaDetalle> miProducto)
        {



            for (int i = 0; i < miProducto.Count; i++)
            {
                InsertarDetalle(miProducto[i]);

            }
            ActulizaFactura();

            return true;

        }

        public bool borrarElemento(List<clsFacturaDetalle> miProducto, int Posicion)
        {
            if (miProducto.Count < Posicion)
            {
                Posicion = Posicion - 1;
                miProducto.RemoveAt(Posicion);
                return true;
            }

            if (Posicion < 0)
                return false;
            else
            {

                miProducto.RemoveAt(Posicion);
                return true;

            }
        }



        public void  ActulizaFactura()
        {

            clsConexion objConexion = new clsConexion();
            List<SqlParameter> misParametros = new List<SqlParameter>();

            misParametros.Clear();

            SqlParameter miParametro;
            miParametro = new SqlParameter("@U00COD", this.u00cod);
            misParametros.Add(miParametro);
            miParametro = new SqlParameter("@CLAVE", this.clave);
            misParametros.Add(miParametro);

            String micomando = "sp_TActualizaEncabezado";

            objConexion.ejecutarSentenciaSP(micomando, misParametros);


        }


    }
}
