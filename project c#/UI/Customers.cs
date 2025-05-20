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
        public event EventHandler ButtonClicked;
        public event EventHandler updateClicked;
        public event EventHandler deleteClicked;

        public Customers(int id = -1)
        {
            this.id = id;
            InitializeComponent();
            if (id == -1)
            {
                delete.Visible = false;
                updates.Visible = false;
                //addCustomer();
            }
            else updateCustomer();


        }

        public void updateCustomer()
        {
            delete.Visible = true;
            updates.Visible = true;
            add.Visible=false;

            Customer c = s_bl.customer.Read(id);
            customerId.Value = c.CustomerId;
            customerName.Text = c.CustomerName;
            phone.Text = c.Phone;
            address.Text = c.Adress;
        }

        public void removeCustomer()
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            s_bl.customer.Create(new Customer((int)customerId.Value, customerName.Text, address.Text, phone.Text));
            ButtonClicked?.Invoke(this, EventArgs.Empty);
            this.Close();

        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            s_bl.customer.Delete(id);

            deleteClicked?.Invoke(this, EventArgs.Empty);
            this.Close();
        }

        private void updates_Click(object sender, EventArgs e)
        {   Customer c=new Customer((int)customerId.Value,
            customerName.Text,
            phone.Text,
            address.Text);
           
            s_bl.customer.Update(c);
            MessageBox.Show(c.ToString());
            updateClicked?.Invoke(this, EventArgs.Empty);

            customerId.Value = 0;
            customerName.Text = "";
            phone.Text = "";
            address.Text = "";
        }
    }
}
