using System;
using System.Collections.Generic;

using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Assign24sept2018.model;

namespace Assign24sept2018
{
    public partial class UpdateSheet : System.Web.UI.Page
    {
        ProductModel productModel = new ProductModel();
        
        protected void Page_Load(object sender, EventArgs e)
        {
          
            if (!Page.IsPostBack)
            {
                Label label = new Label();
                label.ID = "Lebel1";
                PlaceHolder1.Controls.Add(label);
                label.Text = "are you sure you want to delete the data";
                Button1.Text = "click here";

            }
            else
            {
                Label label = new Label();
                label.ID = "Label2";
                PlaceHolder1.Controls.Add(label);
                label.Text = "the total data is deleted";
                Button1.Text = "go back to Product Page";
               
            }
        }

        private void Button1_Click1(object sender, EventArgs e)
        {
            Response.Redirect("~/Contact.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            productModel.getProduct(); 
            productModel.DeleteInDatabase(Convert.ToInt32(Request.QueryString["id"]));
        }
    }
}