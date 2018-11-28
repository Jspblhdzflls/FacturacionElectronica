using LogicaNegocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FacturacionElectronica.Paginas.Mantenimientos
{
    public partial class MantenimientoEmisor : System.Web.UI.Page
    {

        clsUtilitario objUtilitario = new clsUtilitario();

        protected void Page_Load(object sender, EventArgs e)
       {
            if (!this.IsPostBack)
            {

                lblUsuarioLogueado.Text = "115520845";
                ConsultarEmisoresXusuario(lblUsuarioLogueado.Text);
                CargarProvincia();
            }

        }
        //

        public void CargarProvincia() {

            DataTable miDt = new DataTable();
            miDt = objUtilitario.ConsultarProvincia();
            if (miDt.Rows.Count > 0) {

                ddlProvincia.DataSource = miDt;
                ddlProvincia.DataValueField = "COD_PROVINCIA";
                ddlProvincia.DataTextField = "PROVINCIA";
                ddlProvincia.DataBind();
            }
            
        }
        public void CargarCanton( int idProvincia)
        {

            DataTable miDt = new DataTable();
            miDt = objUtilitario.ConsultarCanton(idProvincia);
            if (miDt.Rows.Count > 0)
            {

                ddlCanton.DataSource = miDt;
                ddlCanton.DataValueField = "COD_CANTON";
                ddlCanton.DataTextField = "CANTON";
                ddlCanton.DataBind();
            }

        }

        public void CargarDistrito(int idProvincia, string cod_canton)
        {

            DataTable miDt = new DataTable();
            miDt = objUtilitario.ConsultarDistrito(idProvincia,cod_canton);
            if (miDt.Rows.Count > 0)
            {

                ddldistriro.DataSource = miDt;
                ddldistriro.DataValueField = "COD_DISTRITO";
                ddldistriro.DataTextField = "DISTRITO";
                ddldistriro.DataBind();
            }

        }
        public void CargarBarrio(int idProvincia, string cod_canton, string cod_Distrito)
        {

            DataTable miDt = new DataTable();
            miDt = objUtilitario.ConsultarBarrio(idProvincia, cod_canton,cod_Distrito);
            if (miDt.Rows.Count > 0)
            {

                ddlBArrio.DataSource = miDt;
                ddlBArrio.DataValueField = "COD_BARRIO";
                ddlBArrio.DataTextField = "BARRIO";
                ddlBArrio.DataBind();
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
                PanelEmisor.Visible = false;

            }
            else if (miDt.Rows.Count > 1)
            {
                PanelEmisor.Visible = true;
                ddlEmisor.DataSource = miDt;
                ddlEmisor.DataValueField = "U00COD";
                ddlEmisor.DataTextField = "NOM_EMISOR";
                ddlEmisor.DataBind();
            }

        }

        public void CargarPanel(DataTable dtDatos)
        {

            if (dtDatos.Rows.Count > 0)
            {

                int provincia = int.Parse(dtDatos.Rows[0]["COD_PROVINCIA"].ToString());
                String canton = dtDatos.Rows[0]["COD_CANTON"].ToString(); ;
                String Distrito = dtDatos.Rows[0]["COD_DISTRITO"].ToString();
                String Barrio = dtDatos.Rows[0]["COD_BARRIO"].ToString();


                ddlProvincia.SelectedValue = provincia.ToString();
                CargarCanton(provincia);
                ddlCanton.SelectedValue = canton;
                CargarDistrito(provincia, canton);
                ddldistriro.SelectedValue = Distrito;
                CargarBarrio(provincia, canton, Distrito);
                ddlBArrio.SelectedValue = Barrio;

                txtNombreEmisor.Text = dtDatos.Rows[0]["NOM_EMISOR"].ToString();
                txtCedEmisor.Text = dtDatos.Rows[0]["CED_EMISOR"].ToString();
                txtNombreComercial.Text = dtDatos.Rows[0]["NOM_COMERCIAL"].ToString();
               
                txtOtrasSeñas.Text = dtDatos.Rows[0]["OTRAS_SENNAS"].ToString();
                txtCodPais.Text = dtDatos.Rows[0]["COD_PAIS_TEL"].ToString();
                txtTelefono.Text = dtDatos.Rows[0]["NUM_TEL"].ToString();
                txtCodPaisFax.Text = dtDatos.Rows[0]["COD_PAIS_FAX"].ToString();
                txtFax.Text = dtDatos.Rows[0]["NUM_FAX"].ToString();
                txtCorreoElectronico.Text = dtDatos.Rows[0]["EMAIL"].ToString();
                txtUserHacienda.Text = dtDatos.Rows[0]["USR_HACIENDA"].ToString();
                txtContraseñaHacienda.Text = dtDatos.Rows[0]["PASSWORD"].ToString();
                txtRutaXML.Text = dtDatos.Rows[0]["RUTA_XML"].ToString();
                txtRutaPDF.Text = dtDatos.Rows[0]["RUTA_PDF"].ToString();
                txtCertificado.Text = dtDatos.Rows[0]["CERTIFICADO"].ToString();
                txtCorreoFacturacion.Text = dtDatos.Rows[0]["EMAILFAC"].ToString();
                txtContrasenaFacturacion.Text = dtDatos.Rows[0]["PSSW_EMAILFAC"].ToString();
                txtLogo.Text = dtDatos.Rows[0]["RUTALOGO"].ToString();

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
    }
}