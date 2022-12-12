using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class uploadFile : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Guid g = Guid.NewGuid();

        FileUpload1.SaveAs(Server.MapPath("resimler/" + g.ToString() + "_" + FileUpload1.FileName));
    }
}