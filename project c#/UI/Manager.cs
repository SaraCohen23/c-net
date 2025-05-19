using DalApi;
using System;
using System.Collections;
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
    public enum Type{ Customers,Products ,Sales};
    public partial class Manager : Form
    {
        private BlApi.IBl s_bl = BlApi.Factory.Get();
        public Type type;
        public Manager(Type type)
        {
            this.type = type;

            InitializeComponent();
            label1.Text = type.ToString();
            FillPanelWithData();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (type)
            {
                case Type.Customers:
                    {
                        Customers customers = new Customers();
                        customers.Show();
                    }

                    break;
                case Type.Products:
                    {
                        Products products = new Products();
                        products.Show();
                    }

                    break;
                case Type.Sales:
                    {
                        Sales sales = new Sales();
                        sales.Show();
                    }
                    break;

                    dataGridView1.Refresh();

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void FillPanelWithData()
        {
            switch (type)
            {
                case Type.Customers:
                    {
                        dataGridView1.DataSource = s_bl.customer.ReadAll();
                    }
                    break;
                case Type.Products:
                    {
                        dataGridView1.DataSource = s_bl.product.ReadAll();

                    }
                    break;
                case Type.Sales:
                    {
                        dataGridView1.DataSource = s_bl.sale.ReadAll();

                    }
                    break;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //

        private void label1_Click(object sender, EventArgs e)
        {
            //
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (type)
            {
                case Type.Customers:
                    {
                        Customers customers = new Customers( (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                        customers.Show();
                    }

                    break;
                case Type.Products:
                    {
                        Products products = new Products( (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                        products.Show();
                    }

                    break;
                case Type.Sales:
                    {
                        Sales sales = new Sales((int)dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                        sales.Show();
                    }
                    break;

            }
        }
    }
}
