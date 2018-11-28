<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CrearFactura.aspx.cs" Inherits="FacturacionElectronica.Paginas.CrearFactura" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <div class="panel panel-default" style="margin-top: 40px">
        <div class="panel-heading">
            <h3 class="panel-title">Emisor
            </h3>
        </div>
        <div class="panel-body">


            <div class="form-group col-md-4">
                <asp:Label ID="lblCodigoEmisor" runat="server" Text="Codigo Emisor" CssClass="label"></asp:Label>
                <asp:TextBox ID="txtCodigoEmisor" CssClass="form-control" runat="server"></asp:TextBox>

            </div>
            <div class="form-group col-md-4">
                <asp:Label ID="Label4" runat="server" Text="Nombre Emisor" CssClass="label"></asp:Label>
                <asp:TextBox ID="txtNombreEmisor" CssClass="form-control" runat="server"></asp:TextBox>

            </div>
            <div class="form-group col-md-4">

                <asp:Label ID="Label12" runat="server" Text="Cedula Emisor" CssClass="label"></asp:Label>
                <asp:TextBox ID="txtCedulaEmisor" CssClass="form-control" runat="server"></asp:TextBox>

            </div>

            <div class="form-group col-md-4">
                <asp:Label ID="Label38" runat="server" Text="Sucursal" CssClass="label"></asp:Label>
                <asp:DropDownList ID="ddlSucursal" CssClass="form-control" runat="server">
                    <asp:ListItem Value="0">Seleccione Sucursal</asp:ListItem>
                </asp:DropDownList>
            </div>
            <div class="form-group col-md-4">
                <asp:Label ID="Label39" runat="server" Text="Caja" CssClass="label"></asp:Label>
                <asp:DropDownList ID="ddlCaja" CssClass="form-control" runat="server">
                    <asp:ListItem Value="0">Seleccione Caja</asp:ListItem>
                </asp:DropDownList>
            </div>

            <div class="form-group col-md-4">
                <asp:Label ID="Label57" runat="server" Text="Tipo Documento" CssClass="label"></asp:Label>
                <asp:DropDownList ID="ddlTipoDocumento" CssClass="form-control" runat="server">
                    <asp:ListItem Value="0">Seleccione Tipo Documento</asp:ListItem>
                </asp:DropDownList>
            </div>

            <div class="form-group col-md-4">
                <asp:Label ID="Label59" runat="server" Text="Seleccione Moneda" CssClass="label"></asp:Label>
                <asp:DropDownList ID="ddlMoneda" CssClass="form-control" runat="server">
                    <asp:ListItem Value="0">Seleccione Tipo Documento</asp:ListItem>
                </asp:DropDownList>
            </div>

            <div class="form-group col-md-4">
                <asp:Label ID="Label60" runat="server" Text="Tipo Documento" CssClass="label"></asp:Label>
                <asp:DropDownList ID="ddlFormaPago" CssClass="form-control" runat="server">
                    <asp:ListItem Value="0">Seleccione Forma Pago</asp:ListItem>
                </asp:DropDownList>
            </div>

            <div class="form-group col-md-4">
                <asp:Label ID="Label58" runat="server" Text="Condicion Venta" CssClass="label"></asp:Label>
                <asp:DropDownList ID="ddlCondicionVenta" CssClass="form-control" runat="server">
                    <asp:ListItem Value="0">Seleccione Condicion Venta</asp:ListItem>
                </asp:DropDownList>
            </div>

        </div>


    </div>

    <div class="panel panel-default" style="margin-top: 40px">
        <div class="panel-heading">
            <h3 class="panel-title">Receptor

            </h3>
        </div>
        <div class="panel-body">

            <div class="form-group col-md-4">

                <asp:Label ID="Label36" runat="server" Text="Seleccione Tipo ID" CssClass="label"></asp:Label>
                <asp:DropDownList ID="ddlTipoID" CssClass="form-control" runat="server" AppendDataBoundItems="true">
                    <asp:ListItem Value="0">Seleccione Tipo ID</asp:ListItem>
                </asp:DropDownList>
            </div>



            <div class="form-group col-md-4">
                <asp:Label ID="Label35" runat="server" Text="Cedula Receptor" CssClass="label"></asp:Label>
                <asp:TextBox ID="TextBox3" CssClass="form-control" runat="server"></asp:TextBox>

            </div>

            <div class="form-group col-md-4">
                <asp:Label ID="Label34" runat="server" Text="Nombre Emisor" CssClass="label"></asp:Label>
                <asp:TextBox ID="TextBox2" CssClass="form-control" runat="server"></asp:TextBox>

            </div>

            <div class="form-group col-md-4">
                <asp:Label ID="Label13" runat="server" Text="Correo Receptor" CssClass="label"></asp:Label>
                <asp:TextBox ID="txtCorreoReceptor" CssClass="form-control" runat="server"></asp:TextBox>

            </div>
            <div class="form-group col-md-4">
                <asp:Label ID="Label37" runat="server" Text="Telefono Receptor" CssClass="label"></asp:Label>
                <asp:TextBox ID="txtTelefono" CssClass="form-control" runat="server"></asp:TextBox>

            </div>


        </div>
    </div>





    <asp:Panel ID="PanelCrearCliente" runat="server">
        <div class="panel panel-default" style="margin-top: 40px">
            <div class="panel-heading">
                <h3 class="panel-title">Detalle Productos</h3>
            </div>
            <div class="panel-body">



                <div class="panel-body">


                    <div class="form-group col-md-4">

                        <asp:Label ID="Label40" runat="server" Text="Seleccione Tipo Articulo" CssClass="label"></asp:Label>
                        <asp:DropDownList ID="ddlProdServ" CssClass="form-control" runat="server" AppendDataBoundItems="true">
                            <asp:ListItem Value="0">Seleccione Producto o Servicio</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <asp:Label ID="lblIDCliente" runat="server" Text="0" CssClass="label" Visible="false"></asp:Label>

                    <div class="form-group col-md-4">
                        <asp:Label ID="Label2" runat="server" Text="Digite Codigo del Articulo" CssClass="label"></asp:Label>
                        <asp:TextBox ID="txtCodArticulo" CssClass="form-control" runat="server"></asp:TextBox>

                    </div>

                    <div class="form-group col-md-4">
                        <asp:Label ID="Label41" runat="server" Text="Detalle Articulo" CssClass="label"></asp:Label>
                        <asp:TextBox ID="txtDetalle" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group col-md-4">
                        <asp:Label ID="Label22" runat="server" Text="Unidad de medida" CssClass="label"></asp:Label>
                        <asp:DropDownList ID="ddlUidadMEdida" CssClass="form-control" runat="server" AppendDataBoundItems="true">
                            <asp:ListItem Value="0">Seleccione Unidad de medida</asp:ListItem>
                        </asp:DropDownList>
                    </div>

                    <div class="form-group col-md-4">
                        <asp:Label ID="Label43" runat="server" Text="Medida Comercial" CssClass="label"></asp:Label>
                        <asp:TextBox ID="txtmedidacomercial" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group col-md-4">
                        <asp:Label ID="Label21" runat="server" Text="Cantidad" CssClass="label"></asp:Label>
                        <asp:TextBox ID="txtCantidad" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>

                    <div class="form-group col-md-4">
                        <asp:Label ID="Label42" runat="server" Text="Detalle" CssClass="label"></asp:Label>
                        <asp:TextBox ID="txtPrecioUnitario" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>

                    <div class="form-group col-md-4">
                        <asp:Label ID="Label44" runat="server" Text="Monto Descuento" CssClass="label"></asp:Label>
                        <asp:TextBox ID="txtMontoDescuento" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group col-md-4">
                        <asp:Label ID="Label45" runat="server" Text="Naturaleza Descuento" CssClass="label"></asp:Label>
                        <asp:TextBox ID="txtNaturalezaDescuento" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group col-md-4">
                        <asp:Label ID="Label46" runat="server" Text="Monto Total" CssClass="label"></asp:Label>
                        <asp:TextBox ID="txtMontoTotal" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>

                    <div class="form-group col-md-4">
                        <asp:Label ID="Label47" runat="server" Text="SubTotal" CssClass="label"></asp:Label>
                        <asp:TextBox ID="txtSubtotal" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group col-md-4">
                        <asp:Label ID="Label48" runat="server" Text="Total Linea" CssClass="label"></asp:Label>
                        <asp:TextBox ID="txtTotalLinea" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>

                    <!-- -->






                </div>

            </div>
            <div class="panel-footer">

                <asp:Button ID="btnGuardarLinea" CssClass="btn btn-primary btn-bloque" runat="server" Text="Guardar Linea" OnClick="btnGuardarLinea_Click" />

            </div>

        </div>
    </asp:Panel>



    <div class="panel panel-default" style="margin-top: 40px">
        <div class="panel-heading">
            <h3 class="panel-title">Clientes Pendientes de Pago</h3>
        </div>
        <div class="panel-body">

            <div class="table-responsive">
                <asp:GridView ID="gvArticulos" CssClass="table" runat="server" AutoGenerateColumns="true"
                    EmptyDataText="No hay pagos pendientes para el dia de hoy">
                    <Columns>
                    </Columns>
                </asp:GridView>
            </div>


        </div>
        <div class="panel-footer">
        </div>
    </div>







</asp:Content>

