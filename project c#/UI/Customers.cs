using BO;
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
    public partial class Customers : Form
    {
        private BlApi.IBl s_bl = BlApi.Factory.Get();
        private int id;
        public Customers(int id = -1)
        {
            this.id = id;
            InitializeComponent();
            if (id == -1)
                addCustomer();


        }

        public void addCustomer()
        {

        }

        public void removeCustomer()
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            s_bl.customer.Create(new Customer((int)customerId.Value, customerName.Text, address.Text, phone.Text));
            customerId.Value = 0;
            customerName.Text = "";
            phone.Text = "";
            address.Text = "";

        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
