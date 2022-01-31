using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebCalcW1.Backend
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          

        }

        protected void lblLogin_Click(object sender, EventArgs e)
        {
            if (txtUname.Text == "Scott" && txtPW.Text == "NEIT")
            {
                Session["UName"] = txtUname.Text;
                Session["LoggedIn"] = "TRUE";
                lblFeedback.Text = "Success!... Now what?!";
                Response.Redirect("~/Backend/ControlPanel.aspx");

            }
            else
            {
                Session["UName"] = "";
                Session["LoggedIn"] = "FALSE";
                lblFeedback.Text = "Sorry!... login failed, please try again........ or else!";
            }

        }
    }
}