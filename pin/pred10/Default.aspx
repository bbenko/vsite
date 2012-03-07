<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="txtStudenti" runat="server" TextMode="MultiLine"></asp:TextBox>
    </div>
    <br />
    <asp:TextBox ID="txtIme" runat="server"></asp:TextBox>
    <asp:TextBox ID="txtPrezime" runat="server"></asp:TextBox>
    <asp:TextBox ID="txtPbr" runat="server"></asp:TextBox>
    <asp:Button ID="Button1" runat="server" Text="Button" onclick="Button1_Click" />

    </form>
</body>
</html>
