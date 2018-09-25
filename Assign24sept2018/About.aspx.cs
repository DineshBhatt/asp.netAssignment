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
        //DataTable dataTable = new DataTable();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            //dataTable.Columns.AddRange(new DataColumn[4] { new DataColumn("ProductID", typeof(string)), new DataColumn("ProductName", typeof(string)), new DataColumn("Product", typeof(string)), new DataColumn("Price", typeof(string))});
            //PlaceHolder1.Controls.Add(dataTable);              
            //using (SqlConnection sqlConnection = new SqlConnection())
            //{
            //    sqlConnection.ConnectionString = "Data Source = ACUPC_117; Initial Catalog = Auth; Integrated Security = True";
            //    sqlConnection.Open();
            //    string query = "select * from Product";
            //    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            //    using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
            //    {
            //while (sqlDataReader.Read())
            //{
            //    //dataTable.Rows.Add(sqlDataReader["ProductID"].ToString(), sqlDataReader["ProductName"].ToString(), sqlDataReader["Product"].ToString(), sqlDataReader["Price"].ToString());
            //    //Console.WriteLine($"-> ProductID: {sqlDataReader["ProductID"]}, ProductName: {sqlDataReader["ProductName"]}, Product: {sqlDataReader["Product"]}, Price: {sqlDataReader["Product"]}.");
            //}
            if (!Page.IsPostBack)
            {
                if (!(Context.User.IsInRole("Products")))
                {
                    Response.Redirect("~/Default.aspx");
                }

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


                ProductModel productModel = new ProductModel();
                productModel.getProduct();

                int cnt = 0;
                for (int count = 0; count < ProductModel.PrdRepList.Count; count++)
                {
                    tbr = new TableRow();
                    tb.Rows.Add(tbr);
                    tbc = new TableCell();

                    Image im = new Image();
                    im.ID = ProductModel.PrdRepList[count].prdID.ToString();
                    im.ImageUrl = ProductModel.PrdRepList[count].ImageUrl;
                    PlaceHolder1.Controls.Add(im);
                    hyperLink = new HyperLink();
                    hyperLink.ID = Idcount++.ToString();
                    hyperLink.NavigateUrl = "SingleProductDetails?id=" + ProductModel.PrdRepList[count].prdID.ToString();
                    hyperLink.Text = ProductModel.PrdRepList[count].PrdName;
                    PlaceHolder1.Controls.Add(hyperLink);
                    label = new Label();
                    label.Text = " price :-" + ProductModel.PrdRepList[count].ProductPrice;
                    PlaceHolder1.Controls.Add(label);
                    tbr.Cells.Add(tbc);


                    cnt++;
                    //dataTable.Rows.Add(sqlDataReader["ProductID"].ToString(), sqlDataReader["ProductName"].ToString(), sqlDataReader["Product"].ToString(), sqlDataReader["Price"].ToString());
                    //Console.WriteLine($"-> ProductID: {sqlDataReader["ProductID"]}, ProductName: {sqlDataReader["ProductName"]}, Product: {sqlDataReader["Product"]}, Price: {sqlDataReader["Product"]}.");


                }
            }
            else
            {
                //ProductRepository productrepo = new ProductRepository();
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
                        im.ID = ProductModel.PrdRepList[count].prdID.ToString();
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
                //SqlDataAdapter sda = new SqlDataAdapter(cmd);
                //DataSet ds = new DataSet();
                //sda.Fill(ds, "Product");
                //GridView1.DataSource = ds;
                //GridView1.DataBind();
            }




        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //string str = TextBox1.Text;
            //string query = "select * from Product" +
            //    "where ProductName like '%" + str + "%'";
            //ProductModel productModel = new ProductModel();
            //productModel.getProduct(query);
            //Table tb = new Table();
            //tb.ID = "1";
            //PlaceHolder1.Controls.Add(tb);
            //int Idcount = 0;
            //TableRow tbr;
            //TableCell tbc;
            //HyperLink hyperLink;
            //Label label;

            //int cnt = 0;
            //for (int count = 0; count < ProductModel.PrdRepList.Count; count++)
            //{
            //    tbr = new TableRow();
            //    tb.Rows.Add(tbr);
            //    tbc = new TableCell();

            //    Image im = new Image();
            //    im.ID = ProductModel.PrdRepList[count].PrdID.ToString();
            //    im.ImageUrl = ProductModel.PrdRepList[count].ImageUrl;
            //    PlaceHolder1.Controls.Add(im);
            //    hyperLink = new HyperLink();
            //    hyperLink.ID = Idcount++.ToString();
            //    hyperLink.NavigateUrl = "SingleProductDetails?id=" + count;
            //    hyperLink.Text = ProductModel.PrdRepList[count].PrdName;
            //    PlaceHolder1.Controls.Add(hyperLink);
            //    label = new Label();
            //    label.Text = " price :-" + ProductModel.PrdRepList[count].ProductPrice;
            //    PlaceHolder1.Controls.Add(label);
            //    tbr.Cells.Add(tbc);


            //    cnt++;
            //    //dataTable.Rows.Add(sqlDataReader["ProductID"].ToString(), sqlDataReader["ProductName"].ToString(), sqlDataReader["Product"].ToString(), sqlDataReader["Price"].ToString());
            //    //Console.WriteLine($"-> ProductID: {sqlDataReader["ProductID"]}, ProductName: {sqlDataReader["ProductName"]}, Product: {sqlDataReader["Product"]}, Price: {sqlDataReader["Product"]}.");


            //}
            ////Response.Redirect("SingleProductDetails");
             
           


        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
