<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Registracija.aspx.cs" Inherits="Registracija" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ValidationSummary ID="validationSummary" runat="server" />
        <asp:textbox ID="txtEmail" runat="server"></asp:textbox><asp:RequiredFieldValidator
            ID="rfvEmail" runat="server" ErrorMessage="Molimo unesite email adresu." 
            ControlToValidate="txtEmail"></asp:RequiredFieldValidator>
        <br />
        <asp:textbox ID="txtLozinka" runat="server"></asp:textbox><asp:RequiredFieldValidator
            ID="rfvLozinka" runat="server" ErrorMessage="Molimo unesite lozinku." 
            ControlToValidate="txtLozinka"></asp:RequiredFieldValidator>
        <br />
        <asp:textbox ID="txtLozinka2" runat="server"></asp:textbox>
        <asp:CompareValidator ID="CompareValidator1" runat="server" 
            ErrorMessage="Lozinke nisu iste." ControlToCompare="txtLozinka" 
            ControlToValidate="txtLozinka2"></asp:CompareValidator>
        <br />
        <asp:button ID="btnPosalji" runat="server" text="Pošalji" />
    </div>
    </form>
</body>
</html>
