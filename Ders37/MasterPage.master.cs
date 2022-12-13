using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(Session["uye"] !=null)
        {
            MultiView1.ActiveViewIndex = 1;
        }
        else
        {
            MultiView1.ActiveViewIndex = 0;
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Uyelik uye = new Uyelik();

        string uyeAdi;
        int uyeID = uye.uyeKontrol(TextBox1.Text, TextBox2.Text, out uyeAdi);

        if(uyeID>0)
        {
            Session["uye"] = uyeID;

            Label2.Text = "Hosgeldin " + uyeAdi;

            MultiView1.ActiveViewIndex = 1;

            Response.Redirect("detay2.aspx");
        }
        else
        {
            Label1.Text = "Hatalı kullanıcı adı ya da şifre...";
        }
    }

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        Response.Redirect("default.aspx");
    }
}
