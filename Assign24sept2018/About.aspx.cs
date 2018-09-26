using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using Assign24sept2018.model;
using Assign24sept2018.Repository;


namespace Assign24sept2018
{
    public partial class About : Page
    {
       
        
        protected void Page_Load(object sender, EventArgs e)
        {
           
            ProductModel productModel = new ProductModel();
            if (!Page.IsPostBack)
            {
                if (!(Context.User.IsInRole("Products")))
                {
                    Response.Redirect("~/Default.aspx");
                }

                Table tb = new Table();
                tb.ID = "1";
                PlaceHolder1.Controls.Add(tb);
               
                int Idcount = 0;
                TableRow tbr;
                TableCell tbc;
                HyperLink hyperLink;
                Label label;


                
                productModel.getProduct();

                int cnt = 0;
                for (int count = 0; count < productModel.PrdRepList.Count; count++)
                {
                    tbr = new TableRow();
                    tb.Rows.Add(tbr);
                    tbc = new TableCell();

                    Image im = new Image();
                    im.ID = productModel.PrdRepList[count].prdID.ToString();
                    im.ImageUrl = productModel.PrdRepList[count].ImageUrl;
                    PlaceHolder1.Controls.Add(im);
                    hyperLink = new HyperLink();
                    hyperLink.ID = Idcount++.ToString();
                    hyperLink.NavigateUrl = "SingleProductDetails?id=" + productModel.PrdRepList[count].prdID.ToString();
                    hyperLink.Text = productModel.PrdRepList[count].PrdName;
                    PlaceHolder1.Controls.Add(hyperLink);
                    label = new Label();
                    label.Text = " price :-" + productModel.PrdRepList[count].ProductPrice;
                    PlaceHolder1.Controls.Add(label);
                    tbr.Cells.Add(tbc);
                    cnt++;
                    
                }
            }
            else
            {
                
                string s = TextBox1.Text;
                string q = "select * from Product where ProductName LIKE '%" + s + "%'";
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source = ACUPC_117; Initial Catalog = Auth; Integrated Security = True";
                SqlCommand cmd = new SqlCommand(q, con);
                con.Open();
                SqlDataReader sqlDataReader = cmd.ExecuteReader();
                Table table = new Table();
                table.ID = "2";
                PlaceHolder2.Controls.Add(table);
                int count = 0;
                int Idcount = 0;
                TableRow tbr;
                TableCell tbc;
                HyperLink hyperLink;
                Label label;

                while (sqlDataReader.Read())
                {
                    

                    
                        tbr = new TableRow();
                        table.Rows.Add(tbr);
                        tbc = new TableCell();

                        Image im = new Image();
                        im.ID =Idcount.ToString();
                        im.ImageUrl = sqlDataReader["Product"].ToString();
                        PlaceHolder2.Controls.Add(im);
                        hyperLink = new HyperLink();
                        hyperLink.ID = Idcount++.ToString();
                        hyperLink.NavigateUrl = "SingleProductDetails?id=" + sqlDataReader["ProductID"].ToString();
                        hyperLink.Text = sqlDataReader["ProductName"].ToString();
                        PlaceHolder2.Controls.Add(hyperLink);
                        label = new Label();
                        label.Text = " price :-" + sqlDataReader["Price"].ToString();
                        PlaceHolder2.Controls.Add(label);
                        tbr.Cells.Add(tbc);
                        count++;
 
                }
              
            }
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
