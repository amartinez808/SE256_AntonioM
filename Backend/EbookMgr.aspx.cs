using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using WebCalcW1.App_Code;

namespace WebCalcW1.Backend
{
    public partial class EbookMgr : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if the user is already logged in, we can keep them here
            if (Session["LoggedIn"] != null && Session["LoggedIn"].ToString() == "TRUE")
            {
                //we can stay here .. they are good
            }
            else
            {
                //if the y are not logged in, send them to the backend's page to login
                Response.Redirect("~/Backend/Default.aspx");
            }

        }
        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Book temp = new Book();

            temp.Title = txtTitle.Text; //fill Temp book with info from the form
            temp.AuthorFirst = txtAuthorFirst.Text;
            temp.AuthorLast = txtAuthorLast.Text;
            temp.Email = txtAuthorEmail.Text;
            temp.DatePublished = DatePublished.SelectedDate;

            Int32 intPages = 0;
            if(Int32.TryParse(txtPages.Text, out intPages))
            {
                temp.Pages = intPages;
            }

            Double dblPrice = 0;
            if(Double.TryParse(txtPrice.Text, out dblPrice))
            {
                temp.Price = dblPrice;
            }

            if (temp.Feedback.Contains("ERROR:"))
            {
                lblFeedback.Text = temp.Feedback;
            }
            else
            {
                lblFeedback.Text = temp.Title + " by " + temp.AuthorFirst + " " + temp.AuthorLast; //Else display some info
            }


        }
    }
}