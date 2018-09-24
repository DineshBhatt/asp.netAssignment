using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


namespace Assign24sept2018
{
    public partial class About : Page
    {
        //DataTable dataTable = new DataTable();
        
        protected void Page_Load(object sender, EventArgs e)
        {
           //dataTable.Columns.AddRange(new DataColumn[4] { new DataColumn("ProductID", typeof(string)), new DataColumn("ProductName", typeof(string)), new DataColumn("Product", typeof(string)), new DataColumn("Price", typeof(string))});
            //PlaceHolder1.Controls.Add(dataTable);              
            using (SqlConnection sqlConnection = new SqlConnection())
            {
                sqlConnection.ConnectionString = "Data Source = ACUPC_117; Initial Catalog = Auth; Integrated Security = True";
                sqlConnection.Open();
                string query = "select * from Product";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                {
                    //while (sqlDataReader.Read())
                    //{
                    //    //dataTable.Rows.Add(sqlDataReader["ProductID"].ToString(), sqlDataReader["ProductName"].ToString(), sqlDataReader["Product"].ToString(), sqlDataReader["Price"].ToString());
                    //    //Console.WriteLine($"-> ProductID: {sqlDataReader["ProductID"]}, ProductName: {sqlDataReader["ProductName"]}, Product: {sqlDataReader["Product"]}, Price: {sqlDataReader["Product"]}.");
                    //}
                    Table tb = new Table();
                    tb.ID = "1";
                    PlaceHolder1.Controls.Add(tb);
                    //for (int rowCount = 0; rowCount < 6; rowCount++)
                    //{
                    //    TableRow tbr = new TableRow();
                    //    tb.Rows.Add(tbr);
                    //    for (int ColCount = 0; ColCount < 2; ColCount++)
                    //    {
                    //        TableCell tbc = new TableCell();
                    //        tbr.Cells.Add(tbc);
                    //        Image im = new Image();
                    //        im.ID = (ColCount+rowCount).ToString();
                    //        PlaceHolder2.Controls.Add(im);
                    //        Label lb = new Label();
                    //        lb.ID= (ColCount * rowCount).ToString();
                    //        PlaceHolder2.Controls.Add(lb);

                    //    }

                    //}
                    int Idcount = 0;
                    TableRow tbr;
                    TableCell tbc;
                    HyperLink hyperLink;
                    Label label;

                  

                        
                        int cnt = 0;
                        while (sqlDataReader.Read())
                        {
                        tbr = new TableRow();
                        tb.Rows.Add(tbr);
                        
                           

                            tbc = new TableCell();

                            Image im = new Image();
                            im.ID = sqlDataReader["ProductID"].ToString();
                            im.ImageUrl = sqlDataReader["Product"].ToString();
                            PlaceHolder1.Controls.Add(im);
                            hyperLink = new HyperLink();
                            hyperLink.ID = Idcount++.ToString();
                            hyperLink.NavigateUrl = "SingleProductDetails";
                            hyperLink.Text = sqlDataReader["ProductName"].ToString() ;
                            PlaceHolder1.Controls.Add(hyperLink);
                            label = new Label();
                      
                            label.Text = " price :-" + sqlDataReader["Price"].ToString();
                        
                            PlaceHolder1.Controls.Add(label);
                            tbr.Cells.Add(tbc);


                            cnt++;
                            //dataTable.Rows.Add(sqlDataReader["ProductID"].ToString(), sqlDataReader["ProductName"].ToString(), sqlDataReader["Product"].ToString(), sqlDataReader["Price"].ToString());
                            //Console.WriteLine($"-> ProductID: {sqlDataReader["ProductID"]}, ProductName: {sqlDataReader["ProductName"]}, Product: {sqlDataReader["Product"]}, Price: {sqlDataReader["Product"]}.");
                        }

                    

                }
            }


        }
    }
}
