using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace extension_method
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void print_Click(object sender, EventArgs e)
        {
            txt_print.printText();
        }
    }

    public static class PrintText
    {
        public static void printText(this TextBox textBox)
        {
            string content = textBox.Text;
            MessageBox.Show(content);
        }

    }
}
