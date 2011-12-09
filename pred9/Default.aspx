<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <input type="checkbox" id="chkPrvi" name="chkPrvi" />chkPrvi <br />
        <asp:CheckBox ID="chkDrugi" runat="server" />chkDrugi <br />
        <asp:RadioButton ID="rbPrvi" runat="server" GroupName="grupa" />rbPrvi <br />
        <asp:RadioButton ID="rbDrugi" runat="server" GroupName="grupa" />rbDrugi <br />
        <input type="radio" id="rbTreci" name="grupa" />rbTreci <br />
        <asp:TextBox ID="txtPrvi" runat="server" ViewStateMode="Enabled"></asp:TextBox>txtPrvi <br />
        <asp:TextBox ID="txtDrugi" runat="server" ViewStateMode="Disabled"></asp:TextBox>txtDrugi <br />
        <input type="text" id="txtTreci" name="txtTreci" ViewStateMode="Enabled"/>txtTreci <br />
        <asp:Button ID="btnPosalji" runat="server" Text="Posalji" />
    
    </div>
    </form>
</body>
</html>
