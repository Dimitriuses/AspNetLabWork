using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace lab3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        protected byte[] getImage()
        {
            FileStream file = File.Open($"C:/Users/shpac/source/repos/lab3/lab3/images/{DropDownList1.SelectedItem.Text}", FileMode.Open);
            byte[] bytes = new byte[file.Length];
            file.Read(bytes, 0, bytes.Length);
            file.Close();
            return bytes;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            byte[] bytes = getImage();
            
            
            Image image = new Image();

            image.ImageUrl = "data:Image/png;base64," + Convert.ToBase64String(bytes);
            PlaceHolder1.Controls.Add(image);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            byte[] bytes = getImage();
            Image1.ImageUrl = "data:Image/png;base64," + Convert.ToBase64String(bytes);
        }
    }
}