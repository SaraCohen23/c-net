using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cashier cashier = new Cashier();
            cashier.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Choose choose = new Choose();
            choose.Show();
        }

     
    }
}
