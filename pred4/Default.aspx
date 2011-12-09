<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript">
        function jedanplusjedan() {
            document.getElementById("txtClient").value = 1 + 1;
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <p>
        
            <asp:TextBox ID="txtServer" runat="server"></asp:TextBox> 
            <asp:Button ID="btnServer" runat="server" Text="Zbroji na serveru" 
                onclick="btnServer_Click" />
        </p>
        <p>
            <input type="text" id="txtClient" name="txtClient" />
            <input type="button" value="Zbroji na klijentu" onclick="jedanplusjedan()" />         
        </p>
    </div>
    </form>
</body>
</html>
