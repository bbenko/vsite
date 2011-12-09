<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LifeCycle.aspx.cs" Inherits="LifeCycle" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="btnPosalji" runat="server" Text="Pošalji" 
            onclick="btnPosalji_Click" />
        <asp:DropDownList ID="ddlIzbor" runat="server" 
            onselectedindexchanged="ddlIzbor_SelectedIndexChanged">
            <asp:ListItem>Da</asp:ListItem>
            <asp:ListItem>Ne</asp:ListItem>
        </asp:DropDownList>
        <br />
        <asp:TextBox ID="txtDogadaji" runat="server" Height="134px" 
            TextMode="MultiLine"></asp:TextBox>
    </div>
    </form>
</body>
</html>
