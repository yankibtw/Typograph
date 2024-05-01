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
                mainTextBox.Text = ChangePunctuation(inputText);
            }
        }

        //rule 1
        private string ChangePunctuation(string input)
        {
            string result = Regex.Replace(input, @"(\p{L})\s+(\p{P})", "$1$2");
            result = Regex.Replace(result, @"([^\w\s]+)", "$0 ");
            result = Regex.Replace(result, @"(\w)(-)(\w)", "$1 $2 $3");
            result = Regex.Replace(result, @"([({<«])\s*(\w)", "$1$2");
            result = Regex.Replace(result, @"(\w)([)}\]>»])(\w)", "$1$2 $3");
            result = Regex.Replace(result, @"([""“])\s*(\w)", " $1$2");
            result = Regex.Replace(result, @"(\w)([""”])(\w)", "$1$2 $3");

            return WhitespChangingTheSpellingOfSpaceace(result);
        }
        //rule 2
        private string WhitespChangingTheSpellingOfSpaceace(string input)
        {
            return ChangingQuotes(Regex.Replace(input, @"\s{2,}", " "));
        }
        //rule 3
        private string ChangingQuotes(string input)
        {
            string result =  Regex.Replace(input, "\"(.*?)\"", match =>
            {
                string captured = match.Groups[1].Value;
                string firstWord = char.ToUpper(captured[0]) + captured.Substring(1);
                return "«" + firstWord + "»";
            });

            return ReplacingTheSignApproximately(result);
        }
        //rule 9
        private string ReplacingTheSignApproximately(string input)
        {
            return ReplaceEllipsis(Regex.Replace(input, @"\+\-|\-\+", " ± "));
        }
        //rule 13
        private string ReplaceEllipsis(string input)
        {
            return input.Replace("...", "…");
        }
    }
}
