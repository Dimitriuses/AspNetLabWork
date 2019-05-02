using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab4
{
    public partial class реєстрація : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["User"] = new User
            {
                Name = TextBox1.Text,
                FirstName = TextBox2.Text,
                LastName = TextBox3.Text,
                Email = TextBox4.Text,
                Location = TextBox5.Text,
                NikName = TextBox6.Text
            };
            Response.Redirect("~/Information.aspx");
        }
    }
}