<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Menudinamico1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
      <link href="css/jquery.mcdropdown.css" rel="stylesheet" type="text/css" />
    <script src="Scripts/jquery-1.4.1-vsdoc.js" type="text/javascript"></script>
    <script src="Scripts/jquery-1.4.1.js" type="text/javascript"></script>
    <style type="text/css">
        .menu
        {
            width: 913px;
            font-family: verdana, Segoe UI;
            margin: 0 auto;
            border: 1px solid #B34C00;
            border-radius: 4px;
           
        }
        .menu ul
        {
            padding: 10px;
            background-color: #FF6600 ;
            float: left;
            margin: 0px;
            list-style: none;
        }
        .menu ul li        {
            display: inline;
            float: left;
            position: relative;
            cursor: pointer;
        }
        .menu ul li a        {
            cursor: pointer;

            display: block;
            padding: 10px;
            float: left;
            color: #fff;
            text-decoration: none;
        }
        .menu ul li ul
        {
            display: none;
            margin-top: 10px;
        }
        .menu ul li:hover ul
        {
            display: block;
            width: 200px;
            position: absolute;
            left: 0px;
            top: 25px;
            background: #FF6600;
            border: 1px solid #B34C00;
            border-top: none;
            color: #fff;
        }
        .menu ul li:hover ul li
        {
            padding: 5px;
            float: none;
            display: block;
        }
        .menu ul li:hover ul li a
        {
            padding: 5px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="menu">
        <asp:Panel ID="Panel1" runat="server" Width="913px" Style="margin: 0px">
           
        </asp:Panel>
            
    </div>
        <div>
            <br />
            <br />
            <br />
            <br />
            Seleccione un Usuario&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" Height="22px" Width="138px"></asp:DropDownList>
        &nbsp;&nbsp;&nbsp;
        </div>
    </form>
</body>
</html>
