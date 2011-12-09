<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Postavke.aspx.cs" Inherits="Postavke" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphZaglavlje" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphSadrzaj" Runat="Server">
<h1>Postavke</h1>
    <asp:DropDownList ID="ddlBoje" runat="server">
    </asp:DropDownList>
    <asp:Button ID="btnSpremi" runat="server" Text="Spremi" 
        onclick="btnSpremi_Click" />
</asp:Content>

