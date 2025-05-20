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
using static System.Windows.Forms.DataFormats;

namespace UI
{
    public enum Type { Customers, Products, Sales };
    public partial class Manager : Form
    {
        private BlApi.IBl s_bl = BlApi.Factory.Get();
        public Type type;

        public Manager(Type type)
        {
            this.type = type;

            InitializeComponent();
            label1.Text = type.ToString();
            filter.Items.Add(BO.Category.drink);
            filter.Items.Add(BO.Category.pizza);
            filter.Items.Add(BO.Category.tost);
            filter.Items.Add(BO.Category.salad);
            filter.Items.Add(BO.Category.waflel);
            filter.Visible = false;
            FillPanelWithData();

        }
        private void OnButtonClicked(object sender, EventArgs e)
        {
            MessageBox.Show("אני מעדכן");
            FillPanelWithData();
            dataGridView1.Refresh();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            switch (type)
            {
                case Type.Customers:
                    {
                        Customers customers = new Customers();

                        customers.ButtonClicked += OnButtonClicked;

                        customers.Show();

                    }

                    break;
                case Type.Products:
                    {
                        Products products = new Products();
                        products.ButtonClicked += OnButtonClicked;

                        products.Show();
                    }

                    break;
                case Type.Sales:
                    {
                        Sales sales = new Sales();
                        sales.ButtonClicked += OnButtonClicked;
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
                        filterr.Text = "club";
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
                        filterr.Text = "current sales";

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
                        Customers customers = new Customers((int)dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                        customers.updateClicked += OnButtonClicked;
                        customers.deleteClicked += OnButtonClicked;
                        customers.Show();
                    }

                    break;
                case Type.Products:
                    {
                        Products products = new Products((int)dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                        products.updateClicked += OnButtonClicked;
                        products.deleteClicked += OnButtonClicked;
                        products.Show();
                    }

                    break;
                case Type.Sales:
                    {
                        Sales sales = new Sales((int)dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                        sales.updateClicked += OnButtonClicked;
                        sales.deleteClicked += OnButtonClicked;
                        sales.Show();
                    }
                    break;

            }
        }

        private void show_all_Click(object sender, EventArgs e)
        {
            FillPanelWithData();
        }

        private void filterr_Click(object sender, EventArgs e)
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
                        filter.Visible = true;
                    }
                    break;

                case Type.Sales:
                    {
                        DateTime now = DateTime.Now;
                        dataGridView1.DataSource = s_bl.sale.ReadAll(sale => sale.SaleFinishDate >= now && sale.SaleStartDate <= now);
                    }
                    break;




            }
        }

        private void category(object sender, EventArgs e)
        {
            string categoryText = filter.Text;

            if (Enum.TryParse<BO.Category>(categoryText, out BO.Category tempCategory))
            {
                dataGridView1.DataSource = s_bl.product.ReadAll(p => p.ProductCategory == (BO.Category)filter.SelectedItem);

            }
        }
    }
}
