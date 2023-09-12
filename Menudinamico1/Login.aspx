<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Menudinamico1.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            NOMBRE:<br />
            <asp:TextBox ID="TNOMBRE" runat="server"></asp:TextBox>
            <br />
            CLAVE:<br />
            <asp:TextBox ID="TCLAVE" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:HyperLink ID="HyperLink1" runat="server">Registrarse</asp:HyperLink>
            <br />
            <br />
            <asp:Button ID="Bingresar" runat="server" OnClick="Bingresar_Click" Text="INGRESAR" />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server"></asp:Label>
            <br />
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:UPICONEXION %>" SelectCommand="SELECT * FROM [Menu]"></asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
