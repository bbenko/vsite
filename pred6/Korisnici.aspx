<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Korisnici.aspx.cs" Inherits="Korisnici" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
    <asp:ListBox ID="lblKorisnici" runat="server" SelectionMode="Multiple"></asp:ListBox>
    <br />
    Korisničko ime: 
    <asp:TextBox ID="txtKorisnickoIme" runat="server"></asp:TextBox> <br />
    Lozinka: <asp:TextBox ID="txtLozinka" runat="server" 
        TextMode="Password"></asp:TextBox><br />
    <asp:Button ID="btnProvjeri" runat="server" Text="Provjeri" 
        onclick="btnProvjeri_Click" /><br />
    <asp:Label ID="lblLozinka" runat="server" 
        Text="Unesite korisničko ime i lozinku"></asp:Label>
    </form>
</body>
</html>
