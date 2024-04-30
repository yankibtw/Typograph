using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace typograph
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void TypeBtn_Click(object sender, EventArgs e)
        {
            string inputText = mainTextBox.Text;
            TypographyText(inputText);
        }
        private void TypographyText(string inputText)
        {
            if (!string.IsNullOrEmpty(inputText)) {

                ///1st rule
                string result = Regex.Replace(inputText, @"(\p{L})\s+(\p{P})", "$1$2");
                result = Regex.Replace(result, @"([^\w\s]+)", "$0 ");
                result = Regex.Replace(result, @"(\w)(-)(\w)", "$1 $2 $3");
                result = Regex.Replace(result, @"(\w)([({<«])", "$1 $2");
                result = Regex.Replace(result, @"([)}\]>»])(\w)", "$1 $2");
                result = Regex.Replace(result, @"(\w)([""‘“])(\w)", "$1 $2 $3");
                result = Regex.Replace(result, @"(\w)([""’”])(\w)", "$1 $2 $3");

                ///2nd rule
                result = Regex.Replace(result, @"\s{2,}", " ");

                mainTextBox.Text = result;
            }
        }
    }
}
