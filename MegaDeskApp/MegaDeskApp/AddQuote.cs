using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDeskApp
{
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1View = new Form1();
            form1View.Show();
            Close();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void customerNameBox_TextChanged(object sender, EventArgs e)
        {
            if (customerNameBox.Text.Length == 0)
            {
                Console.WriteLine("Test Message");
            }
        }
    }
}
