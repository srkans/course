<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title></title>
        <style type="text/css">
        .auto-style1 {
            width: 100%;
            border: 1px solid #008000;
        }
        .auto-style2 {
            height: 23px;
        }
    </style>
      </head>
<body>
   <form id="form1" runat="server">
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/index.html">Ana Sayfa</asp:HyperLink>
        <br/>
        <br/>
        <asp:Image ID="Image1" runat="server" ImageUrl="~/baslik.jpg"/>
        <p>&nbsp;</p>
        <asp:Button ID="Button1" runat="server" Text="Button" />
   </form>
        <p>&nbsp;</p>
    <table class="auto-style1">
        <tr>
            <td colspan="5">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2"></td>
            <td class="auto-style2"></td>
            <td class="auto-style2"></td>
            <td class="auto-style2"></td>
            <td class="auto-style2"></td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td colspan="3">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</body>
</html>
