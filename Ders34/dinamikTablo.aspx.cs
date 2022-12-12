using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class dinamikTablo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Write("<table border = 1>");

        for (int i = 0; i < int.Parse(TextBox1.Text); i++)
        {
            if(i%2 == 1)
            {
                Response.Write("<tr bgcolor = #aaaaaa>");
            }
            else
            {
                Response.Write("<tr bgcolor = orange>");
            }

            for(int j = 0; j< int.Parse(TextBox2.Text); j++)
            {
                Response.Write("<td>Betül</td>");
            }
            Response.Write("</tr>");
        }
        Response.Write("</table>");

    }
}