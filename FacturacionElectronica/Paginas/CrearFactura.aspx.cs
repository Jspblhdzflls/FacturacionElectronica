using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LogicaNegocio;
using System.Data;

namespace FacturacionElectronica.Paginas
{
    public partial class CrearFactura : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


            if (!Page.IsPostBack)
            {
                CargarUnidadMedida();
                CargarTipoDocumento();
                CargarMoneda();
                CargarFormaPago();
                CargarCondicionVenta();
                CamposReceptor(false);
                CargarTipoID();

                String identificacionUsuario = Session["IdentifiacionUsuario"] as String;



                ConsultarEmisoresXusuario(identificacionUsuario);
            }



        }



        public void ConsultarEmisoresXusuario(String pIdentificacionUsuario)
        {
            clsEmisor objEmisor = new clsEmisor();

            DataTable miDt = new DataTable();

            miDt = objEmisor.consultarEmisoresXUsuario(pIdentificacionUsuario);

            if (miDt.Rows.Count == 0)
            {

            }
            else if (miDt.Rows.Count == 1)
            {
                CargarPanel(miDt);
                ddlEmisor.Visible = false;



            }
            else if (miDt.Rows.Count > 1)
            {

                ddlEmisor.DataSource = miDt;
                ddlEmisor.DataValueField = "U00COD";
                ddlEmisor.DataTextField = "NOM_EMISOR";
                ddlEmisor.DataBind();
                ddlEmisor.Visible = true;

            }

        }

        protected void ddlEmisor_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (ddlEmisor.SelectedIndex == 0)
            {

            }
            else
            {
                consultarEmisor(int.Parse(ddlEmisor.SelectedValue));
            }

        }

        public void consultarEmisor(int pU00cod)
        {

            clsEmisor objEmisor = new clsEmisor();
            objEmisor.U00cod = pU00cod;
            DataTable miDt = new DataTable();
            miDt = objEmisor.consultarEmisor();
            if (miDt.Rows.Count > 0)
            {
                CargarPanel(miDt);

            }


        }

        public void CargarPanel(DataTable dtDatos)
        {

            if (dtDatos.Rows.Count > 0)
            {
                txtCodigoEmisor.Text = dtDatos.Rows[0]["U00COD"].ToString();
                txtNombreEmisor.Text = dtDatos.Rows[0]["NOM_EMISOR"].ToString();
                txtTelefono.Text = dtDatos.Rows[0]["NUM_TEL"].ToString();
                txtCedulaEmisor.Text = dtDatos.Rows[0]["CED_EMISOR"].ToString();
            }


        }

        public void cargarReceptor(int codEmisor, String ced_Receptor)
        {
            clsReceptor objReceptor = new clsReceptor();

            objReceptor.U00cod = codEmisor;
            objReceptor.Ced_Receptor = ced_Receptor;
            objReceptor.TipoBusqueda = 1;
            objReceptor.Nombre_receptor = "";

            DataTable dtDatos = new DataTable();

            dtDatos = objReceptor.consultarReceptor();

            if (dtDatos.Rows.Count > 0)
            {
                lblCodReceptor.Text = dtDatos.Rows[0]["COD_RECEPTOR"].ToString();

                txtNombreReceptor.Text = dtDatos.Rows[0]["NOMBRE_RECEPTOR"].ToString();
                txtIdentifiacionReceptor.Text = dtDatos.Rows[0]["CED_RECEPTOR"].ToString();
                txtCorreoReceptor.Text = dtDatos.Rows[0]["EMAIL_RECEPTOR"].ToString();
                txtTelefono.Text = dtDatos.Rows[0]["TELEFONO_RECEPTOR"].ToString();

                CamposReceptor(false);
            }
            else
            {

                CamposReceptor(true);
            }



        }


        public void cargarEmisor(int idEmisor)
        {
            clsEmisor objEmisor = new clsEmisor();

            objEmisor.U00cod = idEmisor;

            DataTable dtDatos = new DataTable();

            dtDatos = objEmisor.consultarEmisor();

            if (dtDatos.Rows.Count > 0)
            {
                lblCodEmisor.Text = dtDatos.Rows[0]["U00COD"].ToString();

                txtNombreEmisor.Text = dtDatos.Rows[0]["NOM_EMISOR"].ToString();
                txtCedulaEmisor.Text = dtDatos.Rows[0]["CED_EMISOR"].ToString();
                CargarSucursal(idEmisor);
            }
            else
            {


            }



        }

        public void CamposReceptor(Boolean estado)
        {

            ddlTipoID.Enabled = estado;

            txtNombreReceptor.Enabled = estado;
            txtCorreoReceptor.Enabled = estado;
            txtTelefono.Enabled = estado;

        }

        public void CargarSucursal(int cod_emisor)
        {

            clsEmisor objEmisor = new clsEmisor();

            DataTable miDt = new DataTable();
            objEmisor.U00cod = cod_emisor;
            miDt = objEmisor.consultarSucursal();


            ddlSucursal.DataSource = miDt;
            ddlSucursal.DataValueField = "COD_SUCURSAL";
            ddlSucursal.DataTextField = "NOM_SUCURSAL";
            ddlSucursal.DataBind();


        }

        protected void btnGuardarLinea_Click(object sender, EventArgs e)
        {

            AgregarLinea();

        }


        public void AgregarLinea()
        {

            List<clsFacturaDetalle> listProductos = new List<clsFacturaDetalle>();

            if (Session[clsVariablesSession.ProductosLista] != null)

                listProductos = (List<clsFacturaDetalle>)Session[clsVariablesSession.ProductosLista];
            clsFacturaDetalle objFacturaDetalle = new clsFacturaDetalle();

            objFacturaDetalle.Cod_proser = ddlProdServ.SelectedValue;
            objFacturaDetalle.Cod_serv = txtCodArticulo.Text;
            objFacturaDetalle.Cantidad = int.Parse(txtCantidad.Text);
            objFacturaDetalle.Unidad_medida = ddlUidadMEdida.SelectedValue;
            objFacturaDetalle.Unidad_medida_comercial = txtmedidacomercial.Text;
            objFacturaDetalle.Detalle = txtDetalle.Text;
            objFacturaDetalle.Precio_unitario = decimal.Parse(txtPrecioUnitario.Text);
            double descuento = double.Parse(txtMontoDescuento.Text);
            objFacturaDetalle.Monto_descuento = decimal.Parse(descuento.ToString());
            objFacturaDetalle.Naturaleza_descuento = txtNaturalezaDescuento.Text;
            double subtotal = (int.Parse(txtCantidad.Text) * double.Parse(txtPrecioUnitario.Text));
            objFacturaDetalle.Subtotal = decimal.Parse(subtotal.ToString());


            objFacturaDetalle.Cod_docuauto = "";
            objFacturaDetalle.Numero_documento_exonerado = "";
            objFacturaDetalle.Nombre_institucion_exonerado = "";
            objFacturaDetalle.Monto_impuesto_exonerado = 0;
            objFacturaDetalle.Porcentaje_compra_exonerada = 0;
            if (ckImpuesto.Checked)
            {
                objFacturaDetalle.Cod_impuesto = "01";
                double impuesto = (subtotal - descuento) * 0.13;
                double total = subtotal - descuento + impuesto;
                objFacturaDetalle.Monto_total = decimal.Parse(total.ToString());
                objFacturaDetalle.Monto_total_linea = decimal.Parse(total.ToString());
                objFacturaDetalle.Monto_impuesto = decimal.Parse(impuesto.ToString());


            }
            else
            {
                objFacturaDetalle.Cod_impuesto = "00";

                double total = subtotal - descuento;
                objFacturaDetalle.Monto_total = decimal.Parse(total.ToString());
                objFacturaDetalle.Monto_total_linea = decimal.Parse(total.ToString());
                objFacturaDetalle.Monto_impuesto = 0;


            }
            objFacturaDetalle.Tarifa_impuesto = 0;




            //objFacturaDetalle.Monto_total = int.Parse(txtCantidad.Text) * decimal.Parse(txtPrecioUnitario.Text);
            //objFacturaDetalle.Monto_total_linea = int.Parse(txtCantidad.Text) * decimal.Parse(txtPrecioUnitario.Text);


            int i = objFacturaDetalle.agregarDetalleFactura(listProductos);

            if (ValidacionInsert(i) == 1)
            {

                Session[clsVariablesSession.ProductosLista] = listProductos;

            }
            MostrarProductos();


        }

        public int ValidacionInsert(int i)
        {

            switch (i)
            {

                case 0:

                    Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "clave", "alert('El servicio / producto ya Existe');", true);
                    return 0;

                case 1:

                    // Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "clave", "alert('Ingresada exitosamente');", true);
                    return 1;
                case 3:
                    Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "clave", "alert('Problemas al ingresar el articulo');", true);

                    return 2;


            }
            return 0;


        }

        public void MostrarProductos()
        {

            if (Session[clsVariablesSession.ProductosLista] == null)
            {
                gvArticulos.Visible = false;

            }

            else
            {

                gvArticulos.DataSource = (List<clsFacturaDetalle>)Session[clsVariablesSession.ProductosLista];
                gvArticulos.DataBind();



            }




        }



        public void CargarUnidadMedida()
        {

            clsUtilitario objUnidadMedida = new clsUtilitario();

            DataTable miDt = new DataTable();

            miDt = objUnidadMedida.ConsultaUnidadMedida();


            ddlUidadMEdida.DataSource = miDt;
            ddlUidadMEdida.DataValueField = "unidad_medida";
            ddlUidadMEdida.DataTextField = "descripcion_unidad_medida";
            ddlUidadMEdida.DataBind();
        }

        public void CargarTipoDocumento()
        {

            clsUtilitario objTipoDocumento = new clsUtilitario();

            DataTable miDt = new DataTable();

            miDt = objTipoDocumento.ConsultaTiposDocumento();


            ddlTipoDocumento.DataSource = miDt;
            ddlTipoDocumento.DataValueField = "COD_TIPODOCU";
            ddlTipoDocumento.DataTextField = "DESCRIPCION";
            ddlTipoDocumento.DataBind();
        }
        public void CargarMoneda()
        {

            clsUtilitario objMoneda = new clsUtilitario();

            DataTable miDt = new DataTable();

            miDt = objMoneda.ConsultaMoneda();


            ddlMoneda.DataSource = miDt;
            ddlMoneda.DataValueField = "COD_MONEDA";
            ddlMoneda.DataTextField = "DESCRIPCION_MONEDA";
            ddlMoneda.DataBind();
        }
        public void CargarFormaPago()
        {

            clsUtilitario objFormaPago = new clsUtilitario();

            DataTable miDt = new DataTable();

            miDt = objFormaPago.ConsultaFormaPago();


            ddlFormaPago.DataSource = miDt;
            ddlFormaPago.DataValueField = "COD_MEDIO_PAGO";
            ddlFormaPago.DataTextField = "DESCRIPCION";
            ddlFormaPago.DataBind();
        }
        public void CargarCondicionVenta()
        {

            clsUtilitario objCondicionVenta = new clsUtilitario();

            DataTable miDt = new DataTable();

            miDt = objCondicionVenta.ConsultaCondicionVenta();


            ddlCondicionVenta.DataSource = miDt;
            ddlCondicionVenta.DataValueField = "COD_COND_VENTAS";
            ddlCondicionVenta.DataTextField = "DESCRIPCION";
            ddlCondicionVenta.DataBind();
        }
        public void CargarTipoID()
        {

            clsUtilitario objTipoID = new clsUtilitario();

            DataTable miDt = new DataTable();

            miDt = objTipoID.ConsultaTipoID();


            ddlTipoID.DataSource = miDt;
            ddlTipoID.DataValueField = "COD_IDENTIFICACION";
            ddlTipoID.DataTextField = "DESCRIPCION";
            ddlTipoID.DataBind();
        }

        protected void txtCodigoEmisor_TextChanged(object sender, EventArgs e)
        {

            cargarEmisor(int.Parse(txtCodigoEmisor.Text));

        }

        protected void txtIdentifiacionReceptor_TextChanged(object sender, EventArgs e)
        {

            cargarReceptor(int.Parse(txtCodigoEmisor.Text), txtIdentifiacionReceptor.Text);

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {

            String miclave = guardarFactura(1, 1);
            guardarDetalle(1, miclave);



        }

        public void guardarDetalle(int u00cod, String clave)
        {

            clsFacturaDetalle objDetalle = new clsFacturaDetalle();

            objDetalle.U00cod = u00cod;
            objDetalle.Clave = clave;
            objDetalle.guardarLista((List<clsFacturaDetalle>)Session[clsVariablesSession.ProductosLista]);




        }

        public String guardarFactura(int u00cod, int codReceptor)
        {


            clsFacturaEncabezado objFacturaEncabezado = new clsFacturaEncabezado();

            objFacturaEncabezado.U00cod = u00cod;
            objFacturaEncabezado.Cod_sucursal = ddlSucursal.SelectedValue;
            objFacturaEncabezado.Caja = ddlCaja.SelectedValue;

            //?????? transaccion
            objFacturaEncabezado.Transaccion = 1;
            //???????
            objFacturaEncabezado.Cod_emisor = u00cod.ToString();
            objFacturaEncabezado.Cod_cond_ventas = ddlCondicionVenta.SelectedValue;

            //?????
            objFacturaEncabezado.Det_otr_cond_venta = "";
            //???

            objFacturaEncabezado.Plazo_credito = "";

            objFacturaEncabezado.Cod_medio_pago = ddlFormaPago.SelectedValue;

            //??????????
            objFacturaEncabezado.Det_otr_medio_pago = "";
            //???????????
            objFacturaEncabezado.Cod_receptor = codReceptor;

            String Clave = objFacturaEncabezado.InsertarEncabezado2();

            return Clave;
        }
    }

}