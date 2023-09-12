<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="Menudinamico1.Registro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            REGISTRO

            <br />
            NOMBRE:
            <asp:TextBox ID="Tnombre" runat="server"></asp:TextBox>
            &nbsp;CLAVE:
              <asp:TextBox ID="tclave" runat="server"></asp:TextBox>

            &nbsp;&nbsp;

            <asp:Button ID="BREGRESAR" runat="server" Text="REGRESAR" OnClick="BREGRESAR_Click" />
        </div>
    </form>
</body>
</html>
