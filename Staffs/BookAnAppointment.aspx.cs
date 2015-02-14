using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.Security;
public partial class RegistFormView2 : System.Web.UI.Page
{
    SqlCommand cmd;
    SqlConnection con;
    SqlDataAdapter da;
    SqlDataReader dr;
    protected void Page_Load(object sender, EventArgs e)
    {
        con = new SqlConnection(ConfigurationManager.ConnectionStrings["L_id"].ToString());
        con.Open();
        Label7.Text = "Welcome ";
        try
        {
            TextBox1.Text = Request.QueryString["n"].ToString();
        }
        catch (Exception)
        { }
        
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        int str = DropDownList1.SelectedIndex;
        DropDownList2.Items.Clear();
        DropDownList2.Items.Add("Select");
        

        switch(str)
        {
            case 0: DropDownList2.Items.Add("Select");
                break;
            case 1: DropDownList2.Items.Add("Dr. Kumod Kumar Sinha");
                DropDownList2.Items.Add("Dr. Amrendra Bhushan");
                   
                    break;
            case 2: DropDownList2.Items.Add("Dr. Tabishi Sinha");
                    DropDownList2.Items.Add("Dr. Apurva Shrestha");
                break;
            case 3: DropDownList2.Items.Add("Dr. Tanya Sinha");
                DropDownList2.Items.Add("Dr. Prajna Bhushan");
                break;
            case 4: DropDownList2.Items.Add("Adarsh Shrestha");
                DropDownList2.Items.Add("Dr. Akhil Kumar");
                break;
            case 5: DropDownList2.Items.Add("Dr. Priti Kumar Sinha");
                DropDownList2.Items.Add("Dr. Rajni Sinha");
                break;
              
                
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
       
        string qry = "select * from registration where PID='" + TextBox1.Text + "'";
        cmd = new SqlCommand(qry, con);
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
        
        
        
    }
    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {
        int x=DropDownList1.SelectedIndex;
        switch (x)
        {
            case 1: Label6.Text = "Rs.300";
                break;
            case 2: Label6.Text = "Rs.400";
                break;
            case 3: Label6.Text = "Rs.500";
                break;
            case 4: Label6.Text = "Rs.450";
                break;
            case 5: Label6.Text = "Rs.350";
                break;
        }
            
    }

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        FormsAuthentication.SignOut();
        FormsAuthentication.RedirectToLoginPage();
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        string qry = "insert into receipt values('" + Label2.Text + "','" + DropDownList1.SelectedItem.Text + "','" + DropDownList2.SelectedItem.Text + "','" + Label6.Text + "')";
        SqlCommand cmd = new SqlCommand(qry, con);
        cmd.ExecuteNonQuery();
        con.Close();

        if (Label6.Text !="")
            Response.Redirect("invoice.aspx?n="+Label2.Text+"");
    }
}