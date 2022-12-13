using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Cookies : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }



    protected void Button1_Click(object sender, EventArgs e)
    {
        HttpCookie cerez = new HttpCookie("cookie");

        cerez["ad"] = TextBox1.Text;
        cerez["soyad"] = TextBox2.Text;

        cerez.Expires = DateTime.Now.AddDays(30);

        Response.Cookies.Add(cerez);

    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        HttpCookie crz = Request.Cookies["cookie"];

        Response.Write(crz["ad"] + " " + crz["soyad"]);
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Write(Request.Browser.Browser);
        Response.Write(Request.Browser.Version);
    }
}