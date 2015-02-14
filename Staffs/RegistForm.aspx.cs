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

public partial class RegistForm : System.Web.UI.Page
{
    SqlCommand cmd;
    SqlConnection con;
    DataSet db;
    SqlDataAdapter da;
    SqlDataReader dr;
    protected void Page_Load(object sender, EventArgs e)
    {
        Label3.Text = "Welcome ";
        Label1.Text = "PID" + Convert.ToString(DateTime.Now.Second) + Convert.ToString(DateTime.Now.Minute) + Convert.ToString(DateTime.Now.Hour) + Convert.ToString(DateTime.Now.Day) + Convert.ToString(DateTime.Now.DayOfYear) + Convert.ToString(DateTime.Now.Year);
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        TextBox1.Text = "";
        TextBox2.Text = "";
        TextBox3.Text = "";
        TextBox4.Text = "";
        TextBox5.Text = "";
        TextBox6.Text = "";
        TextBox7.Text = "";
        TextBox8.Text = "";
        TextBox9.Text = "";
        TextBox10.Text = "";
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        con = new SqlConnection(ConfigurationManager.ConnectionStrings["L_id"].ToString());
        con.Open();
        string qry = "insert into registration values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + Label1.Text + "','" + TextBox3.Text + "','" + TextBox12.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + TextBox11.Text + "','" + TextBox6.Text + "','" + TextBox7.Text + "','" + DropDownList1.SelectedItem.Text + "','" + DropDownList2.SelectedItem.Text + "','" + TextBox8.Text + "','" + TextBox9.Text + "','" + TextBox10.Text + "','"+DateTime.Today.Date+"',+'"+TextBox1.Text+" "+TextBox2.Text+"')";
        SqlCommand cmd = new SqlCommand(qry, con);

        cmd.ExecuteNonQuery();
        con.Close();
        Response.Redirect("BookAnAppointment.aspx?n="+Label1.Text+"");
    }
    
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        FormsAuthentication.SignOut();
        FormsAuthentication.RedirectToLoginPage();
    }
}