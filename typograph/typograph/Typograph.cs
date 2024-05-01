using System;
using System.Windows.Forms;

namespace typograph
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public void TypeBtn_Click(object sender, EventArgs e)
        {
            string inputText = mainTextBox.Text;
            TextFormatter formatter = new TextFormatter();
            mainTextBox.Text = formatter.TypographyText(inputText);
        }

        public void InfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Типограф\nВерсия 1.0.0\nРазработано и поддерживается by yrnxva");
        }
    }
}
