using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Data.SqlTypes;
using System.Configuration;
using System.Web.Security;


public partial class Staffs_Receipt : System.Web.UI.Page
{
    SqlCommand cmd;
    SqlConnection con;
    DataSet db;
    SqlDataAdapter da;
    SqlDataReader dr;
    SqlCommand cmd1;
    SqlConnection con1;
    DataSet db1;
    SqlDataAdapter da1;
    SqlDataReader dr1;

    protected void Page_Load(object sender, EventArgs e)
    {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["L_id"].ToString());
        con.Open();
        string qry = "select * from registration where PID='" + Request.QueryString["z"] + "'";
        SqlCommand cmd = new SqlCommand(qry, con);
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.HasRows)
        {
            while (dr.Read())
            {
                Label1.Text = dr[16].ToString();
                Label2.Text = dr[2].ToString();
                Label3.Text = dr[12].ToString();
                Label4.Text = dr[7].ToString() + dr[8].ToString() + ", " + dr[9].ToString() + ", " + dr[10].ToString() + ", " + dr[11].ToString();
                Label5.Text = dr[4].ToString();
            }
        }
        con.Close();
        con1 = new SqlConnection(ConfigurationManager.ConnectionStrings["L_id"].ToString());
        con1.Open();
        string qry1 = "select * from receipt where PID='" + Request.QueryString["z"] + "'";
        SqlCommand cmd1 = new SqlCommand(qry1, con1);
        SqlDataReader dr1 = cmd1.ExecuteReader();
        if (dr1.HasRows)
        {
            while (dr1.Read())
            {
                Label6.Text = dr1[1].ToString();
                Label7.Text = dr1[2].ToString();
                Label8.Text = dr1[3].ToString();
                Label9.Text = dr1[3].ToString();
            }
        }
        con1.Close();
    }
    protected void LinkButton6_Click(object sender, EventArgs e)
    {
        FormsAuthentication.SignOut();
        FormsAuthentication.RedirectToLoginPage();
    }
    
    protected void Button1_Click1(object sender, EventArgs e)
    {
        Response.Write("<script>window.print</script>");
    }
}