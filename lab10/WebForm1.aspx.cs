using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab10
{
    public partial class WebForm1 : Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            DropDownList1.Items.Clear();
            DropDownList1.Items.Add("7");
            DropDownList1.Items.Add("9");
            DropDownList1.Items.Add("18");
            DropDownList1.Items.Add("26");
            if (Session["drop"] != null)
            {
                DropDownList1.SelectedIndex = (int)Session["drop"];
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text != string.Empty && Calendar1.SelectedDate != null && Calendar2.SelectedDate != null)
            {
                int sum = Convert.ToInt32(TextBox1.Text);
                int proz = Convert.ToInt32(DropDownList1.SelectedValue);
                DateTime date1 = Calendar1.SelectedDate;
                DateTime date2 = Calendar2.SelectedDate;
                double rezultat_sum;
                int rezultat_mons;
                if (date1 < date2)
                {
                    int days = (date2 - date1).Days;
                    rezultat_sum = sum * (proz / 100.0) * (days / 360.0);
                    rezultat_mons = Math.Abs((date1.Month - date2.Month) + 12 * (date1.Year - date2.Year));
                    Label1.Text = $"Сума банківського відсотку кредиту {rezultat_sum}";
                    Label2.Text = $"Кількість Місяців для оплати {rezultat_mons}";
                }
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Session["drop"] = DropDownList1.SelectedIndex;
        }
    }
}