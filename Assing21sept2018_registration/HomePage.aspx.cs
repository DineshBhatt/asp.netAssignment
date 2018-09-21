using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assing21sept2018_registration
{
    public partial class HomePage : System.Web.UI.Page
    {
        TextBox tb;
        int y = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            tb = new TextBox();
            tb.ID = y.ToString();
            PlaceHolder1.Controls.Add(tb);
            tb.Text = Registration.details;
        }

        protected void SignOut_Click(object sender, EventArgs e)
        {
            Response.Redirect("Registration.aspx");
        }
    }
}