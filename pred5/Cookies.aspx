<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Cookies.aspx.cs" Inherits="Cookies" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lblCookie" runat="server" Text=""></asp:Label>
        <asp:Button ID="btnNapraviCookie" runat="server" Text="Napravi Cookie" 
            onclick="btnNapraviCookie_Click" />
        <asp:Button ID="btnPostBack" runat="server" Text="Button" />
    </div>
    </form>
</body>
</html>
