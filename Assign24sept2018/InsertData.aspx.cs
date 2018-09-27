using System;

using Assign24sept2018.model;
using Assign24sept2018.Repository;

namespace Assign24sept2018
{
    public partial class InsertData : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
    
        }
        //SqlConnection _sqlConnection = new SqlConnection();
        ProductRepository productRepository = new ProductRepository();
        ProductModel productModel = new ProductModel();
       
        protected void Button1_Click(object sender, EventArgs e)
        {

            productRepository.PrdName = TextBox1.Text;
            productRepository.ImageUrl = FileUpload1.FileName;
            productRepository.ProductPrice = Convert.ToInt32(TextBox2.Text);
            productModel.insertintoTable(productRepository.PrdName, productRepository.ImageUrl, productRepository.ProductPrice);
        }
    }
}