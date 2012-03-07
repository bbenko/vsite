<%@ Page Language="C#" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<script runat="server">

    protected void btnPisi_Click(object sender, EventArgs e)
    {
        lblPoruka.Text = "Pozdrav svijete!";
    }
</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="lblPoruka" runat="server"></asp:Label>
        <asp:Button ID="btnPisi" runat="server" onclick="btnPisi_Click" Text="Piši" />
    
    </div>
    </form>
</body>
</html>
