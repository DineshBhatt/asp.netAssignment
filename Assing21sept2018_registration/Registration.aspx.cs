using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assing21sept2018_registration
{
    public partial class Registration : System.Web.UI.Page
    {
        int id = 0; string Firstname; string Lastname; int age = 0; DateTime dob; string gender; string country;
        public static string details;
        public static List<string> list = new List<string>();

        protected void Page_Load(object sender, EventArgs e)
        {
            id = Convert.ToInt32(RegistrationID.Text);
            Firstname = Convert.ToString(FirstName.Text);
            Lastname = Convert.ToString(LastName.Text);
            age = Convert.ToInt32(Age.Text);
            dob = Convert.ToDateTime(DateOfBirth.Text);
            gender = Gender.Text;
            country = DropDownList1.Text;
            details = id + " " + Firstname + " " + Lastname + " " + age + " " + dob + " " + gender + " " + country;
            list.Add(details);
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            Response.Redirect("~/HomePage.aspx");
        }

    }
}