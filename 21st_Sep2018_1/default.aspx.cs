using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _21st_Sep2018_1
{
    public partial class _default : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
              
        }

        public  static List<PersonData> PSList = new List<PersonData>();
        protected void Button1_Click(object sender, EventArgs e)
        {
            PersonData Ps = new PersonData();
            Ps.FName = TextBox1.Text;
            Ps.LName = TextBox2.Text;
            Ps.Age = Convert.ToInt32(TextBox3.Text);
            Ps.Num = Convert.ToInt32(TextBox4.Text);
            Ps.Gender = RadioButtonList1.Text;
            Ps.Country = DropDownList1.Text;
            //Ps.details = Ps.FName + Ps.LName + Ps.Age + Ps.Num + Ps.Gender + Ps.Country;
            PSList.Add(Ps);
            Response.Redirect("HomePage.aspx");

        }
    }
}