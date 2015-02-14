using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.Security;

public partial class RegitFormView : System.Web.UI.Page
{
    SqlCommand cmd;
    SqlConnection con;
    SqlDataAdapter da;
    DataSet ds;
       
    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Text = "Welcome ";
    }
  
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("BookAnAppointment.aspx?n="+TextBox1.Text+"");
        
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        FormsAuthentication.SignOut();
        FormsAuthentication.RedirectToLoginPage();
    }
}