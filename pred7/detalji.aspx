<%@ Page Language="C#" AutoEventWireup="true" CodeFile="detalji.aspx.cs" Inherits="detalji" %>

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
            ProviderName="<%$ ConnectionStrings:FaksConnectionString.ProviderName %>" 
            SelectCommand="SELECT * FROM [student] WHERE ([id] = @id)">
            <SelectParameters>
                <asp:QueryStringParameter DefaultValue="0" Name="id" QueryStringField="id" 
                    Type="Int32" />
            </SelectParameters>
        </asp:SqlDataSource>
        <asp:DetailsView ID="dvStudent" runat="server" Height="50px" Width="125px" 
            AutoGenerateRows="False" DataKeyNames="id" DataSourceID="sdsStudent">
            <EmptyDataTemplate>
                Nema podataka o tom studentu.
            </EmptyDataTemplate>
            <Fields>
                <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" 
                    ReadOnly="True" SortExpression="id" />
                <asp:BoundField DataField="ime" HeaderText="ime" SortExpression="ime" />
                <asp:BoundField DataField="prezime" HeaderText="prezime" 
                    SortExpression="prezime" />
                <asp:BoundField DataField="pbr" HeaderText="pbr" SortExpression="pbr" />
            </Fields>
        </asp:DetailsView>
    </div>
    </form>
</body>
</html>
