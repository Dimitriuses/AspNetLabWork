using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab9
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        const int JKP2015 = 1330;
        const int JKP2016 = 1544;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //int income = Convert.ToInt32(TextBox1.Text);
            //int count = Convert.ToInt32(TextBox2.Text);
            TextBox3.Text = $"{Convert.ToInt32(TextBox1.Text) / Convert.ToInt32(TextBox2.Text)/1.0}";
            TextBox4.Text = $"{Convert.ToDouble(TextBox3.Text) / JKP2015 / 2 * 15.0}";
            TextBox5.Text = $"{Convert.ToDouble(TextBox3.Text) / JKP2016 / 2 * 15.0}";
            TextBox6.Text = $"{Convert.ToInt32(TextBox1.Text) / 100 * Convert.ToDouble(TextBox4.Text)}";
            TextBox7.Text = $"{Convert.ToInt32(TextBox1.Text) / 100 * Convert.ToDouble(TextBox5.Text)}";
        }
    }
}