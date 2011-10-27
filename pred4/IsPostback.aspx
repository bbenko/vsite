<%@ Page Language="C#" AutoEventWireup="true" CodeFile="IsPostback.aspx.cs" Inherits="IsPostback" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lblPostback" runat="server"></asp:Label>
        <asp:Button ID="btnProvocirajPostback"
            runat="server" Text="Provociraj" />
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True">
            <asp:ListItem>Jedan</asp:ListItem>
            <asp:ListItem>Dva</asp:ListItem>
        </asp:DropDownList>
    </div>
    </form>
</body>
</html>
