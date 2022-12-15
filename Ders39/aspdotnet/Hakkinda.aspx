<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Hakkinda.aspx.cs" Inherits="aspdotnet.Hakkinda" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>ASP.NET MVC Tutorial</h1>

        <% int yas = 32; %> <!--c# kodları sunucuda çalışıyor-->

        <p>Yaşım : <%=yas %></p> <!--inspect sayfasında c# kodlarını göstermiyor-->
    </div>
    </form>
</body>
</html>
