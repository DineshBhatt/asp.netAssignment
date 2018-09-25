using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using Assign24sept2018.model;
using System.Data;

namespace Assign24sept2018
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!(Context.User.IsInRole("Order")))
            {
                Response.Redirect("default.aspx");
            }
            //Table table = new Table();
            //table.ID = "3";
            //PlaceHolder1.Controls.Add(table);
            //SqlConnection sqlConnection = new SqlConnection();
            //sqlConnection.ConnectionString = "Data Source=ACUPC_117;Initial Catalog=Auth;Integrated Security=True";
            //sqlConnection.Open();
            //string query = "select * from Product";
            //SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            //int rowcount = 0;
            //int colcount = 0;
            //using (SqlDataReader myDataReader = sqlCommand.ExecuteReader())
            //{
            //    //int count = 0;
            //    TableRow tableRow = new TableRow();
            //    tableRow.ID = rowcount.ToString();
            //    table.Rows.Add(tableRow);
            //    while (myDataReader.Read())
            //    {

            //        TableCell tableCell1 = new TableCell();
            //        tableCell1.ID = colcount.ToString();

            //        Label label = new Label();
            //        HyperLink hyperLink1 = new HyperLink();
            //        HyperLink hyperLink2 = new HyperLink();
            //        HyperLink hyperLink3 = new HyperLink();
            //        hyperLink1.ID = "4";
            //        hyperLink2.ID = "5";
            //        hyperLink3.ID = "6";
            //        label.ID = "7";
            //        label.Text = myDataReader["ProductName"].ToString();
            //        tableRow.Cells.Add(tableCell1);
            //        TableCell tableCell2 = new TableCell();
            //        tableCell2.ID = colcount.ToString();
            //        hyperLink1.Text = "Preview";
            //        tableRow.Cells.Add(tableCell2);
            //        TableCell tableCell3 = new TableCell();
            //        tableCell3.ID = colcount.ToString();
            //        hyperLink2.Text = "Insert";
            //        tableRow.Cells.Add(tableCell3);
            //        TableCell tableCell4 = new TableCell();
            //        tableCell4.ID = colcount.ToString();

            //        hyperLink3.Text = "Delete" + "<br />";
            //        tableRow.Cells.Add(tableCell4);
            //        PlaceHolder1.Controls.Add(label);
            //        PlaceHolder1.Controls.Add(hyperLink1);
            //        PlaceHolder1.Controls.Add(hyperLink2);
            //        PlaceHolder1.Controls.Add(hyperLink3);

            //    }
            //}
            if (Page.IsPostBack)
            {
                //ProductModel pr1 = new ProductModel();
                //pr1.getProduct();

                //Table tb = new Table();
                //tb.CssClass = "tcell";

                //tb.Attributes.Add("class", "tcell");
                //PlaceHolder1.Controls.Add(tb);
                //TableRow tRow = new TableRow();
                //tRow.CssClass = "tcell";
                //tRow.Attributes.Add("class", "tcell");
                //tb.Rows.Add(tRow);
                //HyperLink hl;
                //Label lb1;
                //for (int Pl = 0; Pl < ProductModel.PrdRepList.Count; Pl++)
                //{
                //    TableCell tCell = new TableCell();
                //    tCell.CssClass = "tcell";
                //    tCell.Attributes.Add("class", "tcell");
                //    hl = new HyperLink();
                //    PlaceHolder1.Controls.Add(hl);

                //    hl.NavigateUrl = "SingleProductDetails?id=" + Pl;
                //    hl.Text = ProductModel.PrdRepList[Pl].PrdName;
                //    hl.Width = 100;
                //    lb1 = new Label();
                //    PlaceHolder1.Controls.Add(lb1);
                //    lb1.Text = Convert.ToString(ProductModel.PrdRepList[Pl].ProductPrice);
                //    lb1.Width = 250;
                //    tRow.Cells.Add(tCell);
                //    HyperLink h2 = new HyperLink();
                //    PlaceHolder1.Controls.Add(h2);
                //    h2.NavigateUrl = "SingleProductDetails?id=" + Pl;
                //    h2.Text = "PREVIEW";
                //    h2.Width = 250;
                //    HyperLink h3 = new HyperLink();
                //    PlaceHolder1.Controls.Add(h3);
                //    h3.NavigateUrl = "SingleProductDetails?id=" + Pl;
                //    h3.Text = "UPDATE";
                //    h3.Width = 250;
                //    HyperLink h4 = new HyperLink();
                //    PlaceHolder1.Controls.Add(h4);
                //    h4.NavigateUrl = "SingleProductDetails?id=" + Pl;
                //    h4.Text = "DELETE";
                //    h4.Width = 300;
                //    //Console.WriteLine(Environment.NewLine);
                //}
                string ProcessQuery = DropDownList2.Text;
                if (ProcessQuery == "Preview")
                {
                    for (int i = 1001; i < ProductModel.PrdRepList.Count + 1000; i++)
                    {


                        Response.Redirect("SingleProductDetail?id=" + i);
                    }
                }
                if(ProcessQuery == "Insert")
                {
                    insertintoTable(TextBox1.Text.ToString(), TextBox2.Text.ToString(), Convert.ToSingle(TextBox3.Text));
                }
                if (ProcessQuery == "Update")
                {
                    Response.Redirect("~/UpdateSheet.aspx");               
                }
                if(ProcessQuery == "delete")
                {
                    Response.Redirect("~/DeleteSheet.aspx");
                }
            }
            else
            {
                //Button1.Text = "Query";
                
                Label label = new Label();
                label.ID = "5";
                PlaceHolder1.Controls.Add(label);
                label.Text = "" +
                    "1.   for kitchen product use keyword 'KITCHENPRODUCT'" +"<br />"+
                    "2.   for room product use keyword 'ROOMPRODUCT'"+"<br />";
                //TextBox textBox = new TextBox();
                //textBox.ID = "6";
                //PlaceHolder1.Controls.Add(textBox);
                //Button button = new Button();
                //button.ID = "8";
                //PlaceHolder1.Controls.Add(button);
                //button.Text = DropDownList1.Text;
                
                
            }
        }
        int Idcount = 1013;
        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        SqlConnection _sqlConnection = new SqlConnection();
        
        public void insertintoTable(string ProductName, string Product, float Price)
        {
            _sqlConnection.ConnectionString = "Data Source=ACUPC_117;Initial Catalog=Auth;Integrated Security=True";
            _sqlConnection.Open();
            //Note the "placeholders" in the SQL query.
                string sql = "Insert Into Product" +
                                "(ProductName, Product, Price) Values" +
                                "(@ProductName, @Product, @Price)";

            // This command will have internal parameters.
            using (SqlCommand command = new SqlCommand(sql, _sqlConnection))
            {
                
                // Fill params collection.
                SqlParameter parameter = new SqlParameter
                {
                    ParameterName = "@ProductId",
                    Value = Idcount++,
                    SqlDbType = SqlDbType.Char,
                    Size = 10,
                   
                };

                Idcount++;

                parameter = new SqlParameter
                {
                    ParameterName = "@ProductName",
                    Value = ProductName,
                    SqlDbType = SqlDbType.Char,
                    Size = 10
                };
                command.Parameters.Add(parameter);

                parameter = new SqlParameter
                {
                    ParameterName = "@Product",
                    Value = Product,
                    SqlDbType = SqlDbType.Char,
                    Size = 10
                };
                command.Parameters.Add(parameter);

                parameter = new SqlParameter
                {
                    ParameterName = "@Price",
                    Value = Price,
                    SqlDbType = SqlDbType.Char,
                    Size = 10
                };
                command.Parameters.Add(parameter);

                command.ExecuteNonQuery();
            }
        }

    }
}