<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MantenimientoProductos.aspx.cs" Inherits="FacturacionElectronica.Paginas.Mantenimientos.MantenimientoProductos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="panel panel-default" style="margin-top: 40px">
        <div class="panel-heading">
            <h3 class="panel-title">Buscar  Productos</h3>
        </div>
        <div class="panel-body">

            <div class="form-group col-md-12">

                <asp:Label ID="Label7" runat="server" Text="Seleccione Emisor " CssClass="label"></asp:Label>
                <asp:DropDownList ID="ddlEmisor" CssClass="form-control" runat="server" AppendDataBoundItems="true">
                    <asp:ListItem Value="0">Seleccione Emisor</asp:ListItem>
                </asp:DropDownList>
            </div>

            <div class="form-group col-md-4">
                <asp:Label ID="Label6" runat="server" Text="Selecciones el Filtro" CssClass="label"></asp:Label>

                <asp:RadioButtonList ID="rdSeleccionFiltro" runat="server">


                    <asp:ListItem Value="1">Por ID Producto</asp:ListItem>
                    <asp:ListItem Value="2">Por Nombre Producto</asp:ListItem>


                </asp:RadioButtonList>
            </div>

            <div class="form-group col-md-4">
                <asp:Label ID="lblParametro" runat="server" Text="Digite el parametro de búsqueda" CssClass="label"></asp:Label>

                <asp:TextBox ID="txtParametroUno" CssClass="form-control" runat="server" ></asp:TextBox>
            </div>

        </div>
        <div class="panel-footer">

            <asp:Button ID="btnBuscar" CssClass="btn btn-primary btn-bloque" runat="server" Text="Buscar Articulo" OnClick="btnBuscar_Click" />
            <asp:Button ID="btnBuscarTodos" CssClass="btn btn-primary btn-bloque" runat="server" Text="Buscar Todos" OnClick="btnBuscarTodos_Click" />



        </div>
    </div>

    <asp:Panel ID="panelProductosPrevio" runat="server">
        <div class="panel panel-default" style="margin-top: 40px">
            <div class="panel-heading">
                <h3 class="panel-title">Lista de Artículos</h3>
            </div>
            <div class="panel-body">

                <div class="table-responsive">
                    <asp:GridView ID="gvProductosPrevio" CssClass="table" runat="server" AutoGenerateColumns="False">
                        <Columns>

                            <asp:BoundField DataField="ID_ARTICULO" HeaderText="Cod Articulo" />
                            <asp:BoundField DataField="DESCRIPCION_PROSER" HeaderText="Tipo" />
                            <asp:BoundField DataField="DETALLE" HeaderText="Detalle" />
                            <asp:BoundField DataField="PRECIO_UNITARIO" HeaderText="Precio" />

                        </Columns>
                    </asp:GridView>
                </div>

            </div>
        </div>

    </asp:Panel>

    <div class="panel panel-default" style="margin-top: 40px">
        <div class="panel-heading">
            <h3 class="panel-title">Mantenimiento Productos</h3>
        </div>
        <div class="panel-body">

            <div class="form-group col-md-4">
                <asp:Label ID="Label3" runat="server" Text="Codigo Artículo" CssClass="label"></asp:Label>
                <asp:TextBox ID="txtIdArticulo" CssClass="form-control" runat="server"></asp:TextBox>
            </div>


            <div class="form-group col-md-4">
                <asp:Label ID="Label1" runat="server" Text="Nombre Articulo" CssClass="label"></asp:Label>
                <asp:TextBox ID="txtNombreArticulo" CssClass="form-control" runat="server"></asp:TextBox>
            </div>

            <div class="form-group col-md-4">

                <asp:Label ID="Label8" runat="server" Text="Tipo Articulo" CssClass="label"></asp:Label>
                <asp:DropDownList ID="ddlTipoArticulo" CssClass="form-control" runat="server" AppendDataBoundItems="true">
                    <asp:ListItem Value="0">Seleccione Tipo Articulo</asp:ListItem>
                    <asp:ListItem Value="1">Producto</asp:ListItem>
                    <asp:ListItem Value="2">Servicio</asp:ListItem>

                </asp:DropDownList>
            </div>


            <div class="form-group col-md-4">

                <asp:Label ID="Label10" runat="server" Text="Unidad Medida" CssClass="label"></asp:Label>
                <asp:DropDownList ID="ddlUnidadMedida" CssClass="form-control" runat="server" AppendDataBoundItems="true">
                    <asp:ListItem Value="0">Seleccione Unidad Medida</asp:ListItem>
                </asp:DropDownList>
            </div>
            <div class="form-group col-md-4">

                <asp:Label ID="Label11" runat="server" Text="Unidad Medida Comercial" CssClass="label"></asp:Label>
                <asp:DropDownList ID="ddlUnidadMedidaComercial" CssClass="form-control" runat="server" AppendDataBoundItems="true">
                    <asp:ListItem Value="0">Seleccione Unidad Medida Comercial</asp:ListItem>
                    <asp:ListItem Value="1">Litro</asp:ListItem>

                </asp:DropDownList>
            </div>

            <div class="form-group col-md-4">
                <asp:Label ID="Label2" runat="server" Text="Precio" CssClass="label"></asp:Label>
                <asp:TextBox ID="txtPrecio" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
            <div class="form-group col-md-4">

                <asp:Label ID="Label4" runat="server" Text="Estado" CssClass="label"></asp:Label>
                <asp:DropDownList ID="ddlEstadoArticulo" CssClass="form-control" runat="server" AppendDataBoundItems="true">
                    <asp:ListItem Value="0">Seleccione Estado</asp:ListItem>
                </asp:DropDownList>
            </div>

            <div class="form-group col-md-4">
                <asp:Label ID="Label5" runat="server" Text="¿Paga Impuesto?" CssClass="label"></asp:Label>

                <asp:CheckBox ID="ckPagaImpuesto" runat="server" CssClass="label" />

            </div>



            <!-- -->


        </div>

        <div class="panel-footer">

            <asp:Button ID="btnNuevo" CssClass="btn btn-primary btn-bloque" runat="server" Text="Agregar Artículo" OnClick="btnNuevo_Click" />

            <asp:Button ID="btnActualizar" CssClass="btn btn-success btn-bloque" runat="server" Text="Editar Artículo" OnClick="btnActualizar_Click" />

            <asp:Button ID="btnLimpiar" CssClass="btn btn-success btn-bloque" runat="server" Text="Limpiar Artículo" OnClick="btnLimpiar_Click" />

            <asp:Button ID="btnConsultarTodos" CssClass="btn btn-success btn-bloque" runat="server" Text="Consultar Todos" OnClick="btnConsultarTodos_Click" />

            <asp:Button ID="btnEliminar" CssClass="btn btn-danger btn-bloque" runat="server" Text="Eliminar Artículo" OnClick="btnEliminar_Click" />

        </div>
    </div>


    <div class="panel panel-default" style="margin-top: 40px">
        <div class="panel-heading">
            <h3 class="panel-title">Lista de Artículos</h3>
        </div>
        <div class="panel-body">

            <div class="table-responsive">
                <asp:GridView ID="gvProductos" CssClass="table" runat="server" AutoGenerateColumns="true">
                    <Columns>
                    </Columns>
                </asp:GridView>
            </div>

        </div>
        <div class="panel-footer">
            <asp:Button ID="btnExportar" CssClass="btn btn-success btn-bloque" runat="server" Text="Exportar" Visible="false" OnClick="btnExportar_Click" />

        </div>

    </div>
</asp:Content>
