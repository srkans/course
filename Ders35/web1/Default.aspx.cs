using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // sayfa postback yapılmadıysa ekle

        if(!Page.IsPostBack)
        {
            DropDownList1.Items.Add(new ListItem() { Text = "Tablet", Value = "5" });
        }
    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        Response.Write(DropDownList1.SelectedValue);
    }
}