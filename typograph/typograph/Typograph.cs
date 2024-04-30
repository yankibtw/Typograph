using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace typograph
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void typeBtn_Click(object sender, EventArgs e)
        {
            string inputText = mainTextBox.Text;
            TypographyText(inputText);
        }
        private void TypographyText(string inputText)
        {
            if (!string.IsNullOrEmpty(inputText)) {

                string result = Regex.Replace(inputText, @"([^\w\s-])(\s*)(\w)", "$1 $3");
                result = Regex.Replace(result, @"(\w)(-)(\w)", "$1 $2 $3");
                result = Regex.Replace(result, @"(\w)([({<«])", "$1 $2");
                result = Regex.Replace(result, @"([)}\]>»])(\w)", "$1 $2");
                result = Regex.Replace(result, @"(\w)([""‘“])(\w)", "$1 $2 $3");
                result = Regex.Replace(result, @"(\w)([""’”])(\w)", "$1 $2 $3");

                mainTextBox.Text = result;
            }
        }
    }
}
