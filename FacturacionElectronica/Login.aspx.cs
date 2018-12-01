using LogicaNegocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FacturacionElectronica
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {

            if (ValidarDatos())
            {
                validarUsuario();
            }

        }

        public Boolean ValidarDatos()
        {

            if (txtUsuario.Text == "")
            {

                Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "clave", "alert('Por favor digitar el usuario');", true);
                return false;
            }
            else
            {

                if (txtContrasena.Text == "")
                {

                    Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "clave", "alert('Por favor digitar la contraseña');", true);
                    return false;
                }
                else
                {


                    return true;
                }

            }


        }


        public void validarUsuario()
        {

            clsUsuario objUsuario = new clsUsuario();
            objUsuario.IdentificacionUsuario = txtUsuario.Text;
            objUsuario.Contrasena = txtContrasena.Text;

            DataTable miDt = new DataTable();

            miDt = objUsuario.ValidarInicioSession();

            if (miDt.Rows.Count > 0)
            {


              //  int idRol = int.Parse(miDt.Rows[0]["IdRol"].ToString());
                //  Session["IdRol"] = idRol.ToString();
                //  Session["Estado"] = "1";
                Session["idUsuario"] = miDt.Rows[0]["idUsuario"].ToString();
                Session["IdentifiacionUsuario"] = miDt.Rows[0]["IdentifiacionUsuario"].ToString();


                
                Response.Redirect("Default.aspx");
                //if (idRol == 1 || idRol == 2)
                //{
                //    Response.Redirect("Default.aspx");

                //}
                //else if (idRol == 3 || idRol == 4)
                //{
                //    Response.Redirect("DefaultCobrador.aspx");


                //}


            }
            else
            {
                Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "clave", "alert('Usuario o Contraseña inválidos');", true);
                Session["Estado"] = "0";

            }


        }

    }
}