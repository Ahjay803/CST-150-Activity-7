using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Approximate_PI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calButton_Click(object sender, EventArgs e)
        {
            int counter;
            double pi = 1;
            int terms = int.Parse(textBox1.Text);
            double sum = 0;

            for(counter = 1; counter <= terms; counter++)
            {
                if((counter % 2) == 1)
                {
                    sum = sum + 1.0 / ((2.0 * (double)counter) - 1.0);
                }
                pi = 4 * sum;
            }
            inputLabel.Text = "Approximate value of pi after " + terms + " terms" + 
                "\n" + "= " + pi.ToString();

        }
    }
}
