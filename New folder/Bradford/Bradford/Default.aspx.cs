using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bradford
{
    public partial class Default : System.Web.UI.Page
    {

        protected void ButtonCalculate_Click(object sender, EventArgs e)
        {
            int num1;
            int num2;
            bool Conversion1 = Int32.TryParse(TextBox1.Text, out num1);
            bool Conversion2 = Int32.TryParse(TextBox2.Text, out num2);
            if (Conversion1 && Conversion2)
            {
                int sum = num1 * num2 * num1;
                CheckBoxLabel.Text = sum.ToString();
            }
            else
            {
                CheckBoxLabel.Text = "Please enter numbers in both boxes above";
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {






            footerLabel.Text = "Current date and time is: " + DateTime.Now.ToString();
        }
    }
}