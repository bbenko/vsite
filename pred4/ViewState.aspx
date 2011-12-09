<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ViewState.aspx.cs" Inherits="ViewState"  EnableViewState="true" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="txtSaViewState" runat="server" EnableViewState="True"></asp:TextBox>
        <asp:TextBox ID="txtBezViewState" runat="server" EnableViewState="False"></asp:TextBox>
        <input type="text" id="txtClient" name="txtClient"/>
        <asp:Button ID="btnPostback" runat="server" Text="Postback" />   
        <asp:Button ID="btnPromjeniBoju" runat="server" Text="Promjeni boju" 
            onclick="btnPromjeniBoju_Click" />   
         
    </div>
    </form>
</body>
</html>
