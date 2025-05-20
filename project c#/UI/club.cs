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
    public partial class club : Form
    {
        public club()
        {
            InitializeComponent();
            cusId.Visible = false;
            id.Visible = false;

        }

        private void next_Click(object sender, EventArgs e)
        {
            int idc = (int)cusId.Value;
            Cashier c = new Cashier(idc);
            c.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            cusId.Visible = true;
            id.Visible = true;
        }
    }
}
