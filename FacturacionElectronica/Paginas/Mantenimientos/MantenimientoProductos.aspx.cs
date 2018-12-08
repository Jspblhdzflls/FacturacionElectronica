using LogicaNegocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace FacturacionElectronica.Paginas.Mantenimientos
{
    public partial class MantenimientoProductos : System.Web.UI.Page
    {
        clsUtilitario objUtilitario = new clsUtilitario();

        protected void Page_Load(object sender, EventArgs e)
        {


            if (!this.IsPostBack)
            {

                String identificacionUsuario = Session["IdentifiacionUsuario"] as String;


                ConsultarEmisoresXusuario(identificacionUsuario);
                CargarUnidadMedida();
                CargarEstadoArticulo();

            }
        }

        public void CargarUnidadMedida()
        {
            DataTable miDt = new DataTable();

            miDt = objUtilitario.ConsultaUnidadMedida();


            ddlUnidadMedida.DataSource = miDt;
            ddlUnidadMedida.DataValueField = "unidad_medida";
            ddlUnidadMedida.DataTextField = "descripcion_unidad_medida";
            ddlUnidadMedida.DataBind();
        }

        public void CargarEstadoArticulo()
        {


            DataTable miDt = new DataTable();

            miDt = objUtilitario.ConsultaEstadoArticulo();


            ddlEstadoArticulo.DataSource = miDt;
            ddlEstadoArticulo.DataValueField = "COD_ESTADO_ARTICULO";
            ddlEstadoArticulo.DataTextField = "DESCRIPCION_CODIGO_ARTICULO";
            ddlEstadoArticulo.DataBind();
        }


        public void ConsultarEmisoresXusuario(String pIdentificacionUsuario)
        {
            clsEmisor objEmisor = new clsEmisor();

            DataTable miDt = new DataTable();

            miDt = objEmisor.consultarEmisoresXUsuario(pIdentificacionUsuario);

            if (miDt.Rows.Count == 0)
            {
                ddlEmisor.Visible = false;

            }
            else if (miDt.Rows.Count > 1)
            {
                ddlEmisor.Visible = true;

                ddlEmisor.DataSource = miDt;
                ddlEmisor.DataValueField = "U00COD";
                ddlEmisor.DataTextField = "NOM_EMISOR";
                ddlEmisor.DataBind();
            }

        }


        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            int filtro = int.Parse(rdSeleccionFiltro.SelectedValue);

            if (filtro == 1)
            {
                CargarPanel(consultarArticulo(int.Parse(ddlEmisor.SelectedValue), int.Parse(txtParametroUno.Text), "", 1));
            }
            else if (filtro == 2)
            {

                CargarPanel(consultarArticulo(int.Parse(ddlEmisor.SelectedValue), 0, txtParametroUno.Text, 2));

            }

        }

        protected void btnBuscarTodos_Click(object sender, EventArgs e)
        {
            CargarPanelTodos(consultarArticulo(int.Parse(ddlEmisor.SelectedValue), 0, "", 1));

        }


        public void CargarPanelTodos(DataTable miDT)
        {

            if (miDT.Rows.Count > 0)
            {

                gvProductos.DataSource = miDT;
                gvProductos.DataBind();

            }



        }


        public DataTable consultarArticulo(int pU00Cod, int pIdArticulo, String pNombreArticulo, int pIdTipoBusqueda)
        {

            DataTable dtdatos = new DataTable();
            clsArticulo objArticulo = new clsArticulo();
            objArticulo.U00cod = pU00Cod;
            objArticulo.Id_articulo = pIdArticulo;
            objArticulo.IdTipoBusqueda = pIdTipoBusqueda;
            objArticulo.Detalle = pNombreArticulo;
            dtdatos = objArticulo.consultarArticulo();

            return dtdatos;
        }

        public void CargarPanel(DataTable dtDatos)
        {
            if (dtDatos.Rows.Count == 0)
            {
                panelProductosPrevio.Visible = false;
            }
            else if (dtDatos.Rows.Count == 1)
            {

                txtIdArticulo.Text = dtDatos.Rows[0]["ID_ARTICULO"].ToString();
                txtNombreArticulo.Text = dtDatos.Rows[0]["DETALLE"].ToString();
                ddlTipoArticulo.SelectedValue = dtDatos.Rows[0]["COD_PROD_SERV"].ToString();
                ddlUnidadMedida.SelectedValue = dtDatos.Rows[0]["UNIDAD_MEDIDA"].ToString();
                ddlUnidadMedidaComercial.SelectedValue = dtDatos.Rows[0]["UNIDAD_MEDIDA_COMERCIAL"].ToString();
                txtPrecio.Text = dtDatos.Rows[0]["PRECIO_UNITARIO"].ToString();
                ddlEstadoArticulo.SelectedValue = dtDatos.Rows[0]["COD_ESTADO_ARTICULO"].ToString();

                Boolean impuesto = Boolean.Parse(dtDatos.Rows[0]["PAGA_IMPUESTO"].ToString());

                if (impuesto)
                {
                    ckPagaImpuesto.Checked = true;
                }
                else if (!impuesto)
                {
                    ckPagaImpuesto.Checked = false;
                }

                panelProductosPrevio.Visible = false;

            }
            else if (dtDatos.Rows.Count > 1)
            {

                gvProductosPrevio.DataSource = dtDatos;
                gvProductosPrevio.DataBind();
                panelProductosPrevio.Visible = true;


            }



        }

        public void GuardarArticulo(int U00Cod, int idArticulo)
        {

            clsArticulo objArticulo = new clsArticulo();
            objArticulo.U00cod = U00Cod;
            objArticulo.Id_articulo = idArticulo;
            objArticulo.Cod_prod_serv = ddlTipoArticulo.SelectedValue;
            objArticulo.Cod_serv = "04";
            objArticulo.Detalle = txtNombreArticulo.Text;
            objArticulo.Unidad_medida = ddlUnidadMedida.SelectedValue;
            objArticulo.Unidad_medida_comercial = ddlUnidadMedidaComercial.SelectedValue;
            objArticulo.Precio_unitario = double.Parse(txtPrecio.Text);

            if (ckPagaImpuesto.Checked)
            {
                objArticulo.Paga_impuesto = true;
            }
            else
            {
                objArticulo.Paga_impuesto = false;
            }

            objArticulo.Cod_impuesto = "01";
            objArticulo.Estado_articulo = int.Parse(ddlEstadoArticulo.SelectedValue);
            objArticulo.GuardarArticulo();

        }

        protected void btnNuevo_Click(object sender, EventArgs e)
        {

            GuardarArticulo(int.Parse(ddlEmisor.SelectedValue), int.Parse(txtIdArticulo.Text));

        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {

            GuardarArticulo(int.Parse(ddlEmisor.SelectedValue), int.Parse(txtIdArticulo.Text));

        }

        protected void btnLimpiar_Click(object sender, EventArgs e)
        {

            txtIdArticulo.Text = "";
            txtNombreArticulo.Text = "";
            ddlTipoArticulo.SelectedIndex = 0;
            ddlUnidadMedida.SelectedIndex = 0;
            txtPrecio.Text = "";
            ddlEstadoArticulo.SelectedIndex = 0;
            ckPagaImpuesto.Checked = false;
        }

        protected void btnConsultarTodos_Click(object sender, EventArgs e)
        {
            CargarPanelTodos(consultarArticulo(int.Parse(ddlEmisor.SelectedValue), 0, "", 1));

        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {


        }

        protected void btnExportar_Click(object sender, EventArgs e)
        {

            ExportToExcel("Articulos.xls", gvProductos);


        }

        private void ExportToExcel(string nameReport, GridView wControl)
        {
            HttpResponse responsePage = Response;
            StringWriter sw = new StringWriter();
            HtmlTextWriter htw = new HtmlTextWriter(sw);
            Page pageToRender = new Page();
            HtmlForm form = new HtmlForm();
            form.Controls.Add(wControl);
            pageToRender.Controls.Add(form);
            responsePage.Clear();
            responsePage.Buffer = true;
            responsePage.ContentType = "application/vnd.ms-excel";
            responsePage.AddHeader("Content-Disposition", "attachment;filename=" + nameReport);
            responsePage.Charset = "UTF-8";
            responsePage.ContentEncoding = Encoding.Default;
            pageToRender.RenderControl(htw);
            responsePage.Write(sw.ToString());
            responsePage.End();
        }

    }
}
