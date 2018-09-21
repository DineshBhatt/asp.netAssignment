using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace _21st_Sep2018_1
{
    public partial class HomePage : System.Web.UI.Page
    {
        TextBox tb;
        int  j = 0;
        
        protected void Page_Load(object sender, EventArgs e)
        {

            DataTable Dt = new DataTable();
            Dt.Columns.AddRange(new DataColumn[6] { new DataColumn("FirstName", typeof(string)), new DataColumn("LastName", typeof(string)), new DataColumn("Age", typeof(string)), new DataColumn("Country", typeof(string)), new DataColumn("Gender", typeof(string)), new DataColumn("Mobile", typeof(string)) });
            for (int i = 0; i < _default.PSList.Count; i++)
            {
                Dt.Rows.Add(_default.PSList[i].FName, _default.PSList[i].LName, _default.PSList[i].Age, _default.PSList[i].Country, _default.PSList[i].Gender, _default.PSList[i].Num);
                
             
                //tb = new TextBox();
                //tb.ID = j++.ToString();
                //PlaceHolder1.Controls.Add(tb);
                //tb.Text = Convert.ToString(i + 1);
                //tb = new TextBox();
                //tb.ID = j++.ToString();
                //PlaceHolder1.Controls.Add(tb);
                //tb.Text = _default.PSList[i].FName;
                //tb = new TextBox();
                //tb.ID = j++.ToString();
                //PlaceHolder1.Controls.Add(tb);
                //tb.Text = _default.PSList[i].LName;
                //tb = new TextBox();
                //tb.ID = j++.ToString();
                //PlaceHolder1.Controls.Add(tb);
                //tb.Text = Convert.ToString(_default.PSList[i].Age);
                //tb = new TextBox();
                //tb.ID = j++.ToString();
                //PlaceHolder1.Controls.Add(tb);
                //tb.Text = _default.PSList[i].Country;
                //tb = new TextBox();
                //tb.ID = j++.ToString();
                //PlaceHolder1.Controls.Add(tb);
                //tb.Text = _default.PSList[i].Gender;
                //tb = new TextBox();
                //tb.ID = j++.ToString();
                //PlaceHolder1.Controls.Add(tb);
                //tb.Text = Convert.ToString(_default.PSList[i].Num);

            }
            GridView1.DataSource=Dt;
            GridView1.DataBind();
        }
        protected void RegisterMe_Click(object sender, EventArgs e)
        {
            Response.Redirect("default.aspx");
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}