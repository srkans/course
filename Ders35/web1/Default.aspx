<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            <asp:ListItem Value="1">Telefon</asp:ListItem>
            <asp:ListItem Value="2">Notebook</asp:ListItem>
            <asp:ListItem Value="3">DesktopPC</asp:ListItem>
            <asp:ListItem Value="4">DEC</asp:ListItem>
        </asp:DropDownList>
    
    </div>
    </form>
</body>
</html>
