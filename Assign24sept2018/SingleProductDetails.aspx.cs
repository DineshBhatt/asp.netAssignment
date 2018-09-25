using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Assign24sept2018.model;
using System.Data.SqlClient;

namespace Assign24sept2018
{
    public partial class SingleProductDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //int str = Convert.ToInt32(Request.QueryString["ID"]);
            //ProductModel productModel = new ProductModel();
            //productModel.getProduct();
            //Image1.ImageUrl = ProductModel.PrdRepList[str].ImageUrl;
            //Label1.Text = ProductModel.PrdRepList[str].PrdName;
            //Label2.Text = ProductModel.PrdRepList[str].ProductPrice.ToString();
            string IDParam = Request.QueryString["Id"];
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = "Data Source=ACUPC_117;Initial Catalog=Auth;Integrated Security=True";
                connection.Open();
                string sql = "select * from Product where ProductId =" + Convert.ToInt32(IDParam);
                SqlCommand mycommand = new SqlCommand(sql, connection);

                using (SqlDataReader myDataReader = mycommand.ExecuteReader())
                {
                    while (myDataReader.Read())
                    {
                        Label1.Text = myDataReader["ProductName"].ToString();
                        Label2.Text = myDataReader["Price"].ToString();
                        //Description.Text = myDataReader["Description"].ToString();
                        Image1.ImageUrl = myDataReader["Product"].ToString();
                    }
                }
            }

        }
    }
}