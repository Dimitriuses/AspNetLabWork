using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab4
{
    public partial class Information : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            User user = Session["User"] as User;
            Label1.Text =
                ((user.Name != string.Empty) ? $"Name: {user.Name} \n" : "") +
                ((user.FirstName != string.Empty) ? $"FirstName: {user.FirstName} \n" : "") +
                ((user.LastName != string.Empty) ? $"LastName: {user.LastName} \n" : "") +
                ((user.Email != string.Empty) ? $"Email: {user.Email} \n" : "") +
                ((user.Location != string.Empty) ? $"Location: {user.Location} \n" : "") +
                ((user.NikName != string.Empty) ? $"nik: {user.NikName}" : "");
        }
    }
}