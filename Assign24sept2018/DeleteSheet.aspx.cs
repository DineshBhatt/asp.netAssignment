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
        ProductModel productModel = new ProductModel();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                productModel.getProduct();
                int positionOfData = Convert.ToInt32(Request.QueryString["id"]);
                TextBox1.Text = productModel.PrdRepList[positionOfData].PrdName;
                
                TextBox2.Text = Convert.ToString(productModel.PrdRepList[positionOfData].ProductPrice);
                
            }
        }
        
        protected void Button1_Click(object sender, EventArgs e)
        {
            
           
            productModel.UpdateData(TextBox1.Text, FileUpload1.FileName ,Convert.ToSingle(TextBox2.Text));


        }
    }
}