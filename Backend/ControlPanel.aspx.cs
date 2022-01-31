using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebCalcW1.Backend
{
    public partial class ControlPanel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["LoggedIn"] != null && Session["LoggedIn"].ToString() == "TRUE")
            {
                //wecan stay here
            }
            else
            {
                //if not logged in, send them to backend page to login 
                Response.Redirect("~/Backend/Default.aspx");
            }
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Abandon();                          //Destroys the variables from that session
            Response.Redirect("~/Backend/Default.aspx");//Send back to login
        }
    }
}