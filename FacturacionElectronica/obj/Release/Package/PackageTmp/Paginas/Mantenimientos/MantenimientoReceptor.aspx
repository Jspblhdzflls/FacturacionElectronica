<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MantenimientoReceptor.aspx.cs" Inherits="FacturacionElectronica.Paginas.Mantenimientos.MantenimientoReceptor" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">





    <div class="panel panel-default" style="margin-top: 40px">
        <div class="panel-heading">
            <h3 class="panel-title">Buscar  Receptor</h3>
        </div>
        <div class="panel-body">

            <div class="form-group col-md-4">
                <asp:Label ID="Label6" runat="server" Text="Selecciones el Filtro" CssClass="label"></asp:Label>

                <asp:RadioButtonList ID="rdSeleccionFiltro" runat="server" AutoPostBack="true" OnSelectedIndexChanged="rdSeleccionFiltro_SelectedIndexChanged">

                    <asp:ListItem Value="1">Por Identificacion Receptor</asp:ListItem>
                    <asp:ListItem Value="2">Por Nombre y Apellidos</asp:ListItem>

                </asp:RadioButtonList>
            </div>

            <div class="form-group col-md-4">
                <asp:Label ID="lblParametro" runat="server" Text="" CssClass="label"></asp:Label>

                <asp:TextBox ID="txtParametroUno" CssClass="form-control" runat="server" Visible="false"></asp:TextBox>
            </div>




        </div>
        <div class="panel-footer">

            <asp:Button ID="btnBuscar" CssClass="btn btn-primary btn-bloque" runat="server" Text="Buscar Usuario" OnClick="btnBuscar_Click" />


        </div>
    </div>



    <div class="panel panel-default" style="margin-top: 40px">
        <div class="panel-heading">
            <h3 class="panel-title">Ingresar Receptor</h3>
        </div>
        <div class="panel-body">

            <asp:Label ID="lblCodReceptor" runat="server" Text="0" CssClass="label" Visible="false"></asp:Label>

            <div class="form-group col-md-4">
                <asp:Label ID="Label1" runat="server" Text="Digite el nombre del receptor" CssClass="label"></asp:Label>
                <asp:TextBox ID="txtNombreReceptor" CssClass="form-control" runat="server"></asp:TextBox>
            </div>

            <!-- -->


            <div class="form-group col-md-4">

                <asp:Label ID="Label5" runat="server" Text="Seleccione Tipo ID" CssClass="label"></asp:Label>
                <asp:DropDownList ID="ddlTipoID" CssClass="form-control" runat="server" AppendDataBoundItems="true">
                    <asp:ListItem Value="0">Seleccione Tipo ID</asp:ListItem>
                </asp:DropDownList>
            </div>
            <div class="form-group col-md-4">
                <asp:Label ID="Label9" runat="server" Text="Identificación" CssClass="label"></asp:Label>
                <asp:TextBox ID="txtCedReceptor" CssClass="form-control" runat="server" AutoPostBack="True" ></asp:TextBox>
            </div>


            <!-- -->



            <div class="form-group col-md-4">
                <asp:Label ID="Label20" runat="server" Text="Teléfono" CssClass="label"></asp:Label>
                <asp:TextBox ID="txtTelefono" CssClass="form-control" runat="server"></asp:TextBox>
            </div>


            <!-- -->

            <div class="form-group col-md-4">
                <asp:Label ID="Label19" runat="server" Text="Correo Electronico" CssClass="label" ></asp:Label>
                <asp:TextBox ID="txtCorreoElectronico" CssClass="form-control" runat="server" ></asp:TextBox>
            </div>

            <div class="form-group col-md-4">

                <asp:Label ID="Label4" runat="server" Text="Estado" CssClass="label"></asp:Label>
                <asp:DropDownList ID="ddlEstadoUsuario" CssClass="form-control" runat="server" AppendDataBoundItems="true">
                    <asp:ListItem Value="0">Seleccione Estado</asp:ListItem>
                </asp:DropDownList>
            </div>




        </div>
        <div class="panel-footer">

            <asp:Button ID="btnNuevo" CssClass="btn btn-primary btn-bloque" runat="server" Text="Agregar Usuario" OnClick="btnNuevo_Click" />

            <asp:Button ID="btnActualizar" CssClass="btn btn-success btn-bloque" runat="server" Text="Editar Usuario" OnClick="btnActualizar_Click" />

            <asp:Button ID="btnLimpiar" CssClass="btn btn-success btn-bloque" runat="server" Text="Limpiar Campos" OnClick="btnLimpiar_Click" />

            <asp:Button ID="btnConsultarTodos" CssClass="btn btn-success btn-bloque" runat="server" Text="Consultar Todos" OnClick="btnConsultarTodos_Click" />

            <asp:Button ID="btnEliminar" CssClass="btn btn-danger btn-bloque" runat="server" Text="Eliminar Usuario" OnClick="btnEliminar_Click" />

        </div>
    </div>


    <div class="panel panel-default" style="margin-top: 40px">
        <div class="panel-heading">
            <h3 class="panel-title">Lista de Receptores</h3>
        </div>
        <div class="panel-body">

            <div class="table-responsive">
                <asp:GridView ID="gvReceptor" CssClass="table" runat="server" AutoGenerateColumns="false">
                    <Columns>
                        <asp:BoundField DataField="COD_RECEPTOR" HeaderText="Codigo Receptor" />

                        <asp:BoundField DataField="NOMBRE_RECEPTOR" HeaderText="Nombre " />

                        <asp:BoundField DataField="DESCRIPCION" HeaderText="Tipo ID" />
                        <asp:BoundField DataField="EMAIL_RECEPTOR" HeaderText="Correo" />
                        <asp:BoundField DataField="TELEFONO_RECEPTOR" HeaderText="Telefono" />
                        <asp:BoundField DataField="ESTADO" HeaderText="Estado" />
                        <asp:BoundField DataField="FECHA_CREACION" HeaderText="Fecha Creacón " />


                    </Columns>
                </asp:GridView>
            </div>

        </div>
        <div class="panel-footer">
            <asp:Button ID="btnExportar" CssClass="btn btn-success btn-bloque" runat="server" Text="Exportar"  OnClick="btnExportar_Click" />

        </div>

    </div>

    <asp:Label ID="lblIDEmisor" runat="server" Text="0"></asp:Label>
</asp:Content>
