using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class session : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Session["msj"] = TextBox1.Text;
        Personel p = new Personel() { PerID = 132, PerAD = "Betül" };

        Session["prs"] = p;

        Session.Timeout = 1;
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Personel p = (Personel)Session["prs"];
        Response.Write(p.PerAD);

        if(Session["msj"] != null)
        {
            Response.Write("Oturum açık...");
        }
        else
        {
            Response.Redirect("Default.aspx");
        }
    }

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Session.Abandon();
    }
}