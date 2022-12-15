using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace userLogin
{
    public partial class Giris : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string password = txtPassword.Text;

            if(userName == "Serkan" && password=="1234")
            {
                Response.Redirect("loginOK.aspx");
            }
            else
            {
                Response.Redirect("loginNotOK.aspx");
            }
        }
    }
}