using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Assign24sept2018.model;

using System.Threading;

namespace Assign24sept2018
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!(Context.User.IsInRole("Management")))
            {
                Response.Redirect("default.aspx");
            }
          
            if (Page.IsPostBack)
            {
                
                string ProcessQuery = DropDownList2.Text;
              
                if(ProcessQuery == "Insert")
                {
                    Thread.Sleep(2000);
                    Response.Redirect("~/InsertData.aspx");
                }
                if (ProcessQuery == "Update" )
                {

                    ProductModel productModel = new ProductModel();
                    productModel.getProduct();

                    Table tb = new Table();
                    tb.CssClass = "tcell";
                    tb.Attributes.Add("class", "tcell");
                    PlaceHolder1.Controls.Add(tb);
                    TableRow tRow = new TableRow();
                    tRow.CssClass = "tcell";
                    tRow.Attributes.Add("class", "tcell");
                    tb.Rows.Add(tRow);
                    HyperLink hl;
                    Label lb1;
                    for (int Pl = 0; Pl < productModel.PrdRepList.Count; Pl++)
                    {
                        TableCell tCell = new TableCell();
                        tCell.CssClass = "tcell";
                        tCell.Attributes.Add("class", "tcell");
                        lb1 = new Label();
                        PlaceHolder1.Controls.Add(lb1);
                        
                        lb1.Text = productModel.PrdRepList[Pl].PrdName;
                        lb1.Width = 100;
                        Label lb2 = new Label();
                        PlaceHolder1.Controls.Add(lb2);
                        lb2.Text = Convert.ToString(productModel.PrdRepList[Pl].ProductPrice);
                        lb2.Width = 250;
                        tRow.Cells.Add(tCell);
                        HyperLink h2 = new HyperLink();
                        PlaceHolder1.Controls.Add(h2);
                        h2.NavigateUrl = "SingleProductDetails?id=" + productModel.PrdRepList[Pl].prdID;
                        h2.Text = "Preview";
                        h2.Width = 250;
                        HyperLink h3 = new HyperLink();
                        PlaceHolder1.Controls.Add(h3);
                        h3.NavigateUrl = "~/DeleteSheet?id=" + Pl;
                        h3.Text = "Update";
                        h3.Width = 250;
                        HyperLink h4 = new HyperLink();
                        PlaceHolder1.Controls.Add(h4);
                        h4.NavigateUrl = "~/UpdateSheet?id=" + Pl;
                        h4.Text = "Delete" + "<br />";
                        h4.Width = 300;
                        
                    }
                }
                
            }
            else
            {
               
                
                Label label = new Label();
                label.ID = "Label1";
                PlaceHolder1.Controls.Add(label);
                label.Text = "1.  this page provides you access to the database and change the data " +"<br />";
                Label label1 = new Label();
                label1.ID = "Label2";
                PlaceHolder1.Controls.Add(label1);
                    label1.Text ="                                                                      " +
                    "2.   you can do insert, update, delete from the following button that we provided "+"<br />";

                Button2.Text = "search the query";
                
            }
        }
        
        protected void Button2_Click(object sender, EventArgs e)
        {
            string ProcessQuery = DropDownList2.Text;

            if (ProcessQuery == "Preview")
            {

                Table tb = new Table();
                tb.ID = "1";
                PlaceHolder1.Controls.Add(tb);
                int Idcount = 0;
                TableRow tbr;
                TableCell tbc;
                HyperLink hyperLink;
                Label label;


                ProductModel productModel = new ProductModel();
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
           
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
       

        
    }
}