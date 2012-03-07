<%@ Page Language="C#" AutoEventWireup="true" CodeFile="kosarica.aspx.cs" Inherits="kosarica" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="gvKosarica" runat="server" AutoGenerateColumns="False" CellPadding="4"
            ForeColor="#333333" GridLines="None" OnRowDeleting="gvKosarica_RowDeleting" OnRowCancelingEdit="gvKosarica_RowCancelingEdit" OnRowEditing="gvKosarica_RowEditing" OnRowUpdating="gvKosarica_RowUpdating">
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="ID" ReadOnly="True" />
                <asp:BoundField DataField="Naziv" HeaderText="Naziv" ReadOnly="True" />
                <asp:BoundField DataField="Cijena" HeaderText="Cijena" ReadOnly="True" />
                <asp:BoundField DataField="Kolicina" HeaderText="Količina" />
                <asp:BoundField DataField="Ukupno" HeaderText="Ukupno" ReadOnly="True" />
                <asp:CommandField ButtonType="Button" DeleteText="Briši" ShowDeleteButton="True"  />
                <asp:CommandField ButtonType="Button" CancelText="Otkaži" EditText="Količina" ShowEditButton="True"
                    UpdateText="Spremi" />
            </Columns>
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <EditRowStyle BackColor="#999999" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        </asp:GridView>
        <br />
        <br />
        <asp:Button ID="btnSok" runat="server" OnClick="btnSok_Click" Text="Dodaj sok" />
        <asp:Button ID="btnPivo" runat="server" OnClick="btnPivo_Click" Text="Dodaj pivo" /><br />
    
    </div>
    </form>
</body>
</html>
