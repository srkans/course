<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0">
            <br />
            <asp:View ID="View1" runat="server">
                <asp:Image ID="Image1" runat="server" ImageUrl="~/Desert.jpg" />
            </asp:View>
            <br />
            <br />
            <asp:View ID="View2" runat="server">
                <asp:Image ID="Image2" runat="server" ImageUrl="~/Koala.jpg" />
            </asp:View>
            <asp:View ID="View3" runat="server">
                <asp:Image ID="Image3" runat="server" ImageUrl="~/Lighthouse.jpg" />
            </asp:View>
            <br />
            <br />
            <br />
            <br />
            <br />
            <asp:View ID="View4" runat="server">
            </asp:View>
            <br />
            <br />
            <br />
        </asp:MultiView>
    
    </div>
                <asp:Timer ID="Timer1" runat="server" Interval="2000" OnTick="Timer1_Tick">
                </asp:Timer>
                <asp:ScriptManager ID="ScriptManager1" runat="server" EnableCdn="True">
                </asp:ScriptManager>
    </form>
</body>
</html>
