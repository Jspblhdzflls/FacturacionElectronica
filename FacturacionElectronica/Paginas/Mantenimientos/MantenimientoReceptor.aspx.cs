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
    public partial class MantenimientoReceptor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!this.IsPostBack)
            {

                CargarTipoID();

                lblIDEmisor.Text = "1";

            }
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

        public int GuardarReceptor(int pU00Cod, String codReceptor)
        {

            clsReceptor objReceptor = new clsReceptor();

            objReceptor.U00cod = pU00Cod;
            objReceptor.Nombre_receptor = txtNombreReceptor.Text;
            objReceptor.Cod_identificacion = ddlTipoID.SelectedValue;
            objReceptor.Email_receptor = txtCorreoElectronico.Text;
            objReceptor.Ced_receptor = txtCedReceptor.Text;
            objReceptor.Telefono_receptor = txtTelefono.Text;
            objReceptor.Cod_receptor = codReceptor;


            int resultado = objReceptor.GuardarReceptor();

            return resultado;

        }

        public DataTable consultaReceptor(int codEmisor, String cedReceptor, int tipoBusqueda, String nombre_receptor)
        {

            clsReceptor objReceptor = new clsReceptor();

            objReceptor.U00cod = codEmisor;
            objReceptor.Ced_Receptor = cedReceptor;
            objReceptor.TipoBusqueda = tipoBusqueda;
            objReceptor.Nombre_receptor = "";

            DataTable dtDatos = new DataTable();

            dtDatos = objReceptor.consultarReceptor();

            return dtDatos;

        }

        public void CargarReceptor(DataTable dtDatos)
        {
            if (dtDatos.Rows.Count > 0)
            {
                lblCodReceptor.Text = dtDatos.Rows[0]["COD_RECEPTOR"].ToString();

                txtNombreReceptor.Text = dtDatos.Rows[0]["NOMBRE_RECEPTOR"].ToString();
                txtCedReceptor.Text = dtDatos.Rows[0]["CED_RECEPTOR"].ToString();
                txtCorreoElectronico.Text = dtDatos.Rows[0]["EMAIL_RECEPTOR"].ToString();
                txtTelefono.Text = dtDatos.Rows[0]["TELEFONO_RECEPTOR"].ToString();


            }

        }

        public void ValidaBusquedaReceptor()
        {

            if (rdSeleccionFiltro.SelectedValue == "")
            {
                Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "clave", "alert('Debe Seleccionar un filtro');", true);

            }
            else
            {
                int Filtro = int.Parse(rdSeleccionFiltro.SelectedValue);

                if (Filtro == 0)
                {
                    Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "clave", "alert('Debe Seleccionar un filtro');", true);

                }

                else if (Filtro == 1)
                {
                    if (txtParametroUno.Text == "")
                    {
                        Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "clave", "alert('Por favor el numero de cedula del usuario');", true);

                    }
                    else
                    {
                        //   ConsultaReceptor(1, int.Parse(txtParametroUno.Text), "", "", "", "");
                        CargarReceptor(consultaReceptor(1, txtParametroUno.Text, 1, ""));

                    }


                }
                else if (Filtro == 2)
                {


                    CargarReceptor(consultaReceptor(1, "", 2, txtParametroUno.Text));


                }

            }
        }


        public void limpiar()
        {

            lblCodReceptor.Text = "0";
            txtParametroUno.Text = "";

            txtNombreReceptor.Text = "";
            //   ddlTipoID.SelectedValue = "00";
            txtCedReceptor.Text = "";
            txtTelefono.Text = "";
            txtCorreoElectronico.Text = "";



        }


        public int ConsultaEliminarEmisor(String codReceptor)
        {


            clsReceptor objReceptor = new clsReceptor();
            objReceptor.Cod_receptor = codReceptor;
            objReceptor.U00cod = 1;

            int resultado = objReceptor.ConsultaEliminarReceptor();

            return resultado;

        }

        public void eliminarReceptor()
        {

            clsReceptor objReceptor = new clsReceptor();
            objReceptor.Cod_receptor = lblCodReceptor.Text;
            objReceptor.U00cod = int.Parse(lblIDEmisor.Text);

            int resultado;

            resultado = objReceptor.ELiminarReceptor();

            if (resultado > 0)
            {
                Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "clave", "alert('Eliminado Correctamente');", true);
            }
            else
            {
                Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "clave", "alert('Problemas al Eliminar');", true);

            }


        }


        public void ConsultarTodos()
        {

            DataTable miDT = consultaReceptor(1, "0", 1, "");

            if (miDT.Rows.Count > 0)
            {

                gvReceptor.DataSource = miDT;
                gvReceptor.DataBind();
                gvReceptor.Visible = true;

            }
            else
            {
                gvReceptor.Visible = false;
            }
        }

        public int ExisteCedula(String CedReceptor)
        {


            clsReceptor objReceptor = new clsReceptor();
            objReceptor.Ced_receptor = CedReceptor;

            int resultado = objReceptor.ExiteReceptor();

            return resultado;

        }
        protected void btnNuevo_Click(object sender, EventArgs e)
        {

            GuardarReceptor(1, "0");
            ConsultarTodos();
            limpiar();
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            ValidaBusquedaReceptor();

        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            GuardarReceptor(1, lblCodReceptor.Text);
            ConsultarTodos();
        }

        protected void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
            ConsultarTodos();
        }

        protected void btnConsultarTodos_Click(object sender, EventArgs e)
        {
            ConsultarTodos();
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            if (int.Parse(lblCodReceptor.Text) == 0)
            {

                Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "clave", "alert('Por favor consultar un receptor');", true);

            }
            else
            {
                if (ConsultaEliminarEmisor(lblCodReceptor.Text) > 0)
                {
                    Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "clave", "alert('No se puede eliminar, debido que tiene facturas asociadas');", true);

                }
                else
                {
                    eliminarReceptor();
                    limpiar();
                    consultaReceptor(1, "0", 1, "");
                }
            }
        }

        protected void rdSeleccionFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {

            int valor = int.Parse(rdSeleccionFiltro.SelectedValue);

            if (valor == 1)
            {

                lblParametro.Text = "Digite la identificación del usuario";
                txtParametroUno.Visible = true;
                txtParametroUno.Attributes.Remove("MaxLength");
                txtParametroUno.Attributes.Add("MaxLength", "9");


            }
            if (valor == 2)
            {

                lblParametro.Text = "Digite parte del nombrte/apellidos ";
                txtParametroUno.Visible = true;

            }

        }

        protected void btnExportar_Click(object sender, EventArgs e)
        {
            ExportToExcel("Resumen_Receptores.xls", gvReceptor);

        }

        protected void txtCedReceptor_TextChanged(object sender, EventArgs e)
        {


            if (txtCedReceptor.Text == String.Empty)
            {
                txtCedReceptor.Focus();
            }
            else
            {

                int existe = ExisteCedula(txtCedReceptor.Text);

                if (existe > 0)
                {

                    Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "clave", "alert('La Cedula indicada ya exite, por favor verificar');", true);
                    txtCedReceptor.Focus();
                }
                else
                {
                    txtNombreReceptor.Focus();
                }

            }
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