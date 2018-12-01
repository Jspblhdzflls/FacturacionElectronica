<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="FacturacionElectronica.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta name="viewport" content="width=device-width, user-scalable=no" />
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/Site.css" rel="stylesheet" />
    <link href="Content/Login.css" rel="stylesheet" />
    <title></title>

</head>
<body>

    <form runat="server">
        <div class="imgcontainer">
            <img src="images/usuario.png" alt="Avatar" class="avatar" />
        </div>

        <div class="container">

            <asp:Label ID="Label1" runat="server" Text="Usuario"></asp:Label>

            <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>

            <asp:Label ID="Contrase" runat="server" Text="Contraseña"></asp:Label>

            <asp:TextBox ID="txtContrasena" runat="server" TextMode="Password"></asp:TextBox>

            <asp:Button ID="btnIngresar" runat="server" Text="Ingresar" CssClass="button" OnClick="btnIngresar_Click" />
        </div>


    </form>
</body>
</html>
