<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lblIme" runat="server" Text=""></asp:Label><asp:TextBox ID="txtIme"
            runat="server"></asp:TextBox><asp:Button ID="btnSpremi" runat="server" 
            Text="Spremi" onclick="btnSpremi_Click" />
        <asp:Button ID="btnOdjava" runat="server" onclick="btnOdjava_Click" 
            Text="Odjava" />
    </div>
    </form>
</body>
</html>
