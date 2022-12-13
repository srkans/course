using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Uyelik uye = new Uyelik();

        string uyeAdi;
        int uyeID = uye.uyeKontrol(TextBox1.Text, TextBox2.Text, out uyeAdi);

        if (uyeID > 0)
        {
            Session["Uye"] = uyeID;

            Label2.Text = "Hosgeldin " + uyeAdi;
            MultiView1.ActiveViewIndex = 1; //MasterPage'de kullanılacak.

            Response.Redirect("detay.aspx"); //şifre kullanıcı adı tutuyorsa detay sayfasına gönder
        }

        else
        {
            Label1.Text = "Hatalı kullanıcı adı yada şifre...";
        }
    }
}