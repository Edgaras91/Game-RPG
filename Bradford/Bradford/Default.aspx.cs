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
            //Coverting text values in text boxes to int and storing in "num1" and "num2"
            int num1;
            int num2;
            bool Conversion1 = Int32.TryParse(TextBox1.Text, out num1);
            bool Conversion2 = Int32.TryParse(TextBox2.Text, out num2);
            //Checks if conversions are successful(True). If not, throw a message to put numbers only in both boxes.
            if (Conversion1 && Conversion2)
            {
                //Bradford Factor calculation:
                int sum = num1 * num2 * num1;
                ResultLabel.Text = "Your score is: "+sum.ToString();
            }
            else
            {
                ResultLabel.Text = "Please enter numbers in both boxes above";
            }
        }
    }
}