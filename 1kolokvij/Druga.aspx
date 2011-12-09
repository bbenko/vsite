<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Druga.aspx.cs" Inherits="Druga" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="txtBoja" runat="server" ViewStateMode="Enabled"></asp:TextBox> <br />
        <asp:TextBox ID="txtStatus" runat="server" ViewStateMode="Disabled"></asp:TextBox> <br />
        <asp:TextBox ID="txtX" runat="server"></asp:TextBox> <br />
        <asp:Button ID="btnPosalji" runat="server" Text="Pošalji" />
    </div>
    </form>
</body>
</html>
