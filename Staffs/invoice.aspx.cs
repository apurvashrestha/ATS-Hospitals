using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class invoice : System.Web.UI.Page
{
    SqlCommand cmd;
    SqlConnection con;
    DataSet db;
    SqlDataAdapter da;
    SqlDataReader dr;
    public string y;
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            y = Request.QueryString["n"];
        }
        catch(Exception)
        {
            Response.Write("Book An Appointment First");
        }
    }
    protected void LinkButton6_Click(object sender, EventArgs e)
    {
        FormsAuthentication.SignOut();
        FormsAuthentication.RedirectToLoginPage();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Receipt.aspx?z="+y+"");

    }
}