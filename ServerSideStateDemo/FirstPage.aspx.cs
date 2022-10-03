using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ServerSideStateDemo
{
    public partial class SessionDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = Session.SessionID.ToString();
            Label2.Text = Application["hits"].ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            string username=TextBox1.Text;
            Session["uname"] = username;
            Response.Redirect("~/SecondPage.aspx");
        }
    }
}