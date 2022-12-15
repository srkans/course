<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Giris.aspx.cs" Inherits="userLogin.Giris" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <span>Kullanıcı Adı : </span><span><asp:TextBox runat="server" ID="txtUserName"></asp:TextBox></span>
        <br /> <br />
        <span>Şifre : </span><span><asp:TextBox runat="server" ID="txtPassword" TextMode="Password"></asp:TextBox></span>
        <br /> <br />
        <asp:Button runat="server" ID="btnLogin" Text="Login" OnClick="btnLogin_Click" />

        <input type="button" value="jsLogin" onclick ="loginCheck()" />
    </div>
        <script>
            <!--JavaScript ile yazılan kodlar inspect kısmında görünürken c# kodları görünmüyor(daha güvenli) js-clientside c#-serverside-->
            
            function loginCheck()
            {
                var user = document.getElementById("txtUserName").value;
                var password = document.getElementById("txtPassword").value;

                if (user == "Serkan" && password == "1234")
                {
                    location.href = "loginOK.aspx";
                }
                else
                {
                    location.href = "loginNotOK.aspx";
                }

            }
        </script>
    </form>
</body>
</html>
