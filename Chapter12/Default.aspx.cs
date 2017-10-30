//1. using is a keyword, it's blue
//2. System is a name space that stores already created code
//3. using System brings in existing code
using System;
//4. class is a required container for creating our own code samples
public partial class _Default : System.Web.UI.Page
{
    //5. Code below is where we place our own code
    //6. Page_Load is code that runs when a page loads from a server

    protected void Button1_Click(object sender, EventArgs e)
    {
        double xOut, yOut;//7. Purpose of these variable is to try to set them using try parse
        //8. Line below combines the ternary operator with TryParse
        //9. If conversion works, xOut has the intended value and it's then saved to x
        //10. If conversion fails, xOut has the value 0, but I've chosen to just save 0 to x
        double x = double.TryParse(TextBox1.Text, out xOut) ? xOut :0;

        //11. Line below combines the ternary operator with TryParse
        //12. If conversion works, yOut has the intended value and it's then saved to y
        //13. If conversion fails, yOut has the value 0, but I've chosen to just save 0 to y explicitly
        double y = double.TryParse(TextBox2.Text, out yOut) ? yOut : 0;

        //14. x+y are added, and the result is saved into the string for printing
        Label1.Text = $"Your sum is {x + y}";
    }
}

