<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="timeCal.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Selam</title>
    <style>
        .container {
            display:flex;
            flex :1;
            justify-content:center;     
        }
        #lblZaman 
        {           
            font-size : 22px;
            color : red;
        }
        #btnGuncelle {
            background-color:aquamarine;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">

        <div class="container">
          <asp:Label runat="server" ID="lblZaman"></asp:Label>
       </div>
        <div>
         <asp:Button runat="server" ID="btnGuncelle" Text="Update Time" OnClick="btnGuncelle_Click"/>
        </div>
    </form>
</body>
</html>
