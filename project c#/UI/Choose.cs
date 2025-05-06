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
    public partial class Choose : Form
    {
        public Choose()
        {
            InitializeComponent();
        }

        private void products_Click(object sender, EventArgs e)
        {
            Manager manager = new Manager();
            manager.Show();
        }

        private void orders_Click(object sender, EventArgs e)
        {
            Manager manager = new Manager();
            manager.Show();
        }

        private void customers_Click(object sender, EventArgs e)
        {
            Manager manager = new Manager();
            manager.Show();
        }
    }
}
