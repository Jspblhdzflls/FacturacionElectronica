<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MantenimientoEmisor.aspx.cs" Inherits="FacturacionElectronica.Paginas.Mantenimientos.MantenimientoEmisor" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <asp:Panel ID="PanelEmisor" runat="server" class="panel panel-default">
        <div class="panel panel-default" style="margin-top: 40px">
            <div class="panel-heading">
                <h3 class="panel-title">Emisor</h3>
            </div>
            <div class="panel-body">


                <div class="form-group col-md-4">

                    <asp:Label ID="Label5" runat="server" Text="Seleccione Emisor " CssClass="label"></asp:Label>
                    <asp:DropDownList ID="ddlEmisor" CssClass="form-control" runat="server" AppendDataBoundItems="true" OnSelectedIndexChanged="ddlEmisor_SelectedIndexChanged" AutoPostBack="true">
                        <asp:ListItem Value="0">Seleccione Emisor</asp:ListItem>
                    </asp:DropDownList>
                </div>

            </div>
        </div>

    </asp:Panel>

    <div class="panel panel-default" style="margin-top: 40px">
        <div class="panel-heading">
            <h3 class="panel-title">Emisor</h3>
        </div>
        <div class="panel-body">

            <div class="form-group col-md-4">
                <asp:Label ID="Label1" runat="server" Text="Nombre del Emisor" CssClass="label"></asp:Label>
                <asp:TextBox ID="txtNombreEmisor" CssClass="form-control" runat="server" Enabled="false"></asp:TextBox>
            </div>

            <!-- -->



            <div class="form-group col-md-4">
                <asp:Label ID="Label9" runat="server" Text="Identificación" CssClass="label"></asp:Label>
                <asp:TextBox ID="txtCedEmisor" CssClass="form-control" runat="server" AutoPostBack="True"></asp:TextBox>
            </div>

            <div class="form-group col-md-4">
                <asp:Label ID="Label2" runat="server" Text="Nombre Comercial" CssClass="label"></asp:Label>
                <asp:TextBox ID="txtNombreComercial" CssClass="form-control" runat="server" AutoPostBack="True"></asp:TextBox>
            </div>


            <!-- -->


            <div class="form-group col-md-4">

                <asp:Label ID="Label3" runat="server" Text="Seleccione Provincia " CssClass="label"></asp:Label>
                <asp:DropDownList ID="ddlProvincia" CssClass="form-control" runat="server" AppendDataBoundItems="true">
                    <asp:ListItem Value="0">Seleccione Provincia</asp:ListItem>
                </asp:DropDownList>
            </div>
            <div class="form-group col-md-4">

                <asp:Label ID="Label6" runat="server" Text="Seleccione Cantón " CssClass="label"></asp:Label>
                <asp:DropDownList ID="ddlCanton" CssClass="form-control" runat="server" AppendDataBoundItems="true">
                    <asp:ListItem Value="0">Seleccione Canton</asp:ListItem>
                </asp:DropDownList>
            </div>
            <div class="form-group col-md-4">

                <asp:Label ID="Label7" runat="server" Text="Seleccione Distrito " CssClass="label"></asp:Label>
                <asp:DropDownList ID="ddldistriro" CssClass="form-control" runat="server" AppendDataBoundItems="true">
                    <asp:ListItem Value="0">Seleccione Canton</asp:ListItem>
                </asp:DropDownList>
            </div>

            <div class="form-group col-md-4">

                <asp:Label ID="Label8" runat="server" Text="Seleccione Barrio " CssClass="label"></asp:Label>
                <asp:DropDownList ID="ddlBArrio" CssClass="form-control" runat="server" AppendDataBoundItems="true">
                    <asp:ListItem Value="0">Seleccione Canton</asp:ListItem>
                </asp:DropDownList>
            </div>

            <div class="form-group col-md-4">
                <asp:Label ID="Label10" runat="server" Text="Otras Señas" CssClass="label"></asp:Label>
                <asp:TextBox ID="txtOtrasSeñas" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
            <div class="form-group col-md-4">
                <asp:Label ID="Label11" runat="server" Text="Codigo Pais" CssClass="label"></asp:Label>
                <asp:TextBox ID="txtCodPais" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
            <div class="form-group col-md-4">
                <asp:Label ID="Label20" runat="server" Text="Teléfono" CssClass="label"></asp:Label>
                <asp:TextBox ID="txtTelefono" CssClass="form-control" runat="server"></asp:TextBox>
            </div>

            <div class="form-group col-md-4">
                <asp:Label ID="Label13" runat="server" Text="Codigo Pais Fax" CssClass="label"></asp:Label>
                <asp:TextBox ID="txtCodPaisFax" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
            <div class="form-group col-md-4">
                <asp:Label ID="Label12" runat="server" Text="Fax" CssClass="label"></asp:Label>
                <asp:TextBox ID="txtFax" CssClass="form-control" runat="server"></asp:TextBox>
            </div>



            <!-- -->

            <div class="form-group col-md-4">
                <asp:Label ID="Label19" runat="server" Text="Correo Electronico" CssClass="label"></asp:Label>
                <asp:TextBox ID="txtCorreoElectronico" CssClass="form-control" runat="server"></asp:TextBox>
            </div>

            <div class="form-group col-md-4">
                <asp:Label ID="Label14" runat="server" Text="Usuario Hacienda" CssClass="label"></asp:Label>
                <asp:TextBox ID="txtUserHacienda" CssClass="form-control" runat="server"></asp:TextBox>
            </div>

            <div class="form-group col-md-4">
                <asp:Label ID="Label15" runat="server" Text="Contraseña Hacienda" CssClass="label"></asp:Label>
                <asp:TextBox ID="txtContraseñaHacienda" CssClass="form-control" runat="server"></asp:TextBox>
            </div>

            <div class="form-group col-md-4">
                <asp:Label ID="Label16" runat="server" Text="Ruta XML" CssClass="label"></asp:Label>
                <asp:TextBox ID="txtRutaXML" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
            <div class="form-group col-md-4">
                <asp:Label ID="Label17" runat="server" Text="Ruta PDF" CssClass="label"></asp:Label>
                <asp:TextBox ID="txtRutaPDF" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
            <div class="form-group col-md-4">
                <asp:Label ID="Label18" runat="server" Text="Certificado" CssClass="label"></asp:Label>
                <asp:TextBox ID="txtCertificado" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
            <div class="form-group col-md-4">
                <asp:Label ID="Label21" runat="server" Text="Correo Facturación" CssClass="label"></asp:Label>
                <asp:TextBox ID="txtCorreoFacturacion" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
            <div class="form-group col-md-4">
                <asp:Label ID="Label22" runat="server" Text="Contrasena Correo Facturación" CssClass="label"></asp:Label>
                <asp:TextBox ID="txtContrasenaFacturacion" CssClass="form-control" runat="server"></asp:TextBox>
            </div>


            <div class="form-group col-md-4">
                <asp:Label ID="Label23" runat="server" Text="Ruta Logo" CssClass="label"></asp:Label>
                <asp:TextBox ID="txtLogo" CssClass="form-control" runat="server"></asp:TextBox>
            </div>


            <div class="form-group col-md-4">

                <asp:Label ID="Label4" runat="server" Text="Estado" CssClass="label"></asp:Label>
                <asp:DropDownList ID="ddlEstadoUsuario" CssClass="form-control" runat="server" AppendDataBoundItems="true">
                    <asp:ListItem Value="0">Seleccione Estado</asp:ListItem>
                </asp:DropDownList>
            </div>




        </div>
        <div class="panel-footer">

            <asp:Button ID="btnNuevo" CssClass="btn btn-primary btn-bloque" runat="server" Text="Agregar Usuario" />

            <asp:Button ID="btnActualizar" CssClass="btn btn-success btn-bloque" runat="server" Text="Editar Usuario" />

            <asp:Button ID="btnLimpiar" CssClass="btn btn-success btn-bloque" runat="server" Text="Limpiar Campos" />

            <asp:Button ID="btnConsultarTodos" CssClass="btn btn-success btn-bloque" runat="server" Text="Consultar Todos" />

            <asp:Button ID="btnEliminar" CssClass="btn btn-danger btn-bloque" runat="server" Text="Eliminar Usuario" />

        </div>
    </div>

    <asp:Label ID="lblUsuarioLogueado" runat="server" Text="0" CssClass="label"></asp:Label>


</asp:Content>
