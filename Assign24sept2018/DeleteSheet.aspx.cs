using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using Assign24sept2018.model;

namespace Assign24sept2018
{
    public partial class DeleteSheet : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                if (TextBox1.Text != null)
                {
                    using (SqlConnection myConnection = new SqlConnection())
                    {
                        myConnection.ConnectionString = "Data Source=ACUPC_117;Initial Catalog=Auth;Integrated Security=True";
                        myConnection.Open();
                        //SqlProcess.OpenConnection("Data Source=ACUPC_117;Initial Catalog=Auth;Integrated Security=True");
                        string query = "delete from Product where ProductName = '" + TextBox1.Text + "'";
                        SqlCommand myCommand = new SqlCommand("cartproc", SqlProcess._sqlConnection);
                        
                    }
                }
                if (TextBox2.Text != null)
                {

                }
            }
            else
            {
                Label1.Text = "The data is deleted";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}