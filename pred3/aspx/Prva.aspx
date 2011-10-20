<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Prva.aspx.cs" Inherits="Prva" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <p>
        <asp:TextBox ID="txtPoruka" runat="server"></asp:TextBox>
        &nbsp;
        <asp:DropDownList ID="ddlKartice" runat="server" AutoPostBack="True" 
                onselectedindexchanged="ddlKartice_SelectedIndexChanged">
                <asp:ListItem Value="1">Amex</asp:ListItem>
                <asp:ListItem Value="2">Diners</asp:ListItem>
                <asp:ListItem Value="3">Visa</asp:ListItem>
                <asp:ListItem Value="4">Master</asp:ListItem>
            </asp:DropDownList>
        </p>
        <p>
        <asp:Button ID="btnPosalji" runat="server" Text="Button" 
                onclick="btnPosalji_Click" />
        </p>
    </div>
    </form>
</body>
</html>
