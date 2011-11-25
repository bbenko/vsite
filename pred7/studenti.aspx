<%@ Page Language="C#" AutoEventWireup="true" CodeFile="studenti.aspx.cs" Inherits="studenti" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:SqlDataSource ID="sdsStudent" runat="server" 
            ConnectionString="<%$ ConnectionStrings:FaksConnectionString %>" 
            DeleteCommand="DELETE FROM [student] WHERE [id] = @id" 
            InsertCommand="INSERT INTO [student] ([ime], [prezime], [pbr]) VALUES (@ime, @prezime, @pbr)" 
            ProviderName="<%$ ConnectionStrings:FaksConnectionString.ProviderName %>" 
            SelectCommand="SELECT * FROM [student]" 
            UpdateCommand="UPDATE [student] SET [ime] = @ime, [prezime] = @prezime, [pbr] = @pbr WHERE [id] = @id">
            <DeleteParameters>
                <asp:Parameter Name="id" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="ime" Type="String" />
                <asp:Parameter Name="prezime" Type="String" />
                <asp:Parameter Name="pbr" Type="Int32" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="ime" Type="String" />
                <asp:Parameter Name="prezime" Type="String" />
                <asp:Parameter Name="pbr" Type="Int32" />
                <asp:Parameter Name="id" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
    
    </div>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
        DataKeyNames="id" DataSourceID="sdsStudent">
        <Columns>
            <asp:HyperLinkField DataNavigateUrlFields="id" 
                DataNavigateUrlFormatString="detalji.aspx?id={0}" DataTextField="ime" 
                DataTextFormatString="Detalji o {0}" HeaderText="Detalji" />
            <asp:BoundField DataField="ime" HeaderText="Ime" SortExpression="ime" />
            <asp:BoundField DataField="prezime" HeaderText="prezime" 
                SortExpression="prezime" />
            <asp:BoundField DataField="pbr" HeaderText="Poštanski broj" 
                SortExpression="pbr" />
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
        </Columns>
    </asp:GridView>
    <br />
    Dodaj studenta:<br />
    <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" 
        DataKeyNames="id" DataSourceID="sdsStudent" Height="50px" Width="125px" 
        DefaultMode="Insert">
        <Fields>
            <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" 
                ReadOnly="True" SortExpression="id" />
            <asp:BoundField DataField="ime" HeaderText="ime" SortExpression="ime" />
            <asp:BoundField DataField="prezime" HeaderText="prezime" 
                SortExpression="prezime" />
            <asp:BoundField DataField="pbr" HeaderText="pbr" SortExpression="pbr" />
            <asp:CommandField ShowInsertButton="True" />
        </Fields>
    </asp:DetailsView>
    </form>
</body>
</html>
