using BO;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Products : Form
    {
        private BlApi.IBl s_bl = BlApi.Factory.Get();
        private int id;
        public event EventHandler ButtonClicked;
        public event EventHandler updateClicked;
        public event EventHandler deleteClicked;
        Category? category = null;

        public Products(int id = -1)
        {
            this.id = id;
            InitializeComponent();
            ProductCategory.DataSource = Enum.GetValues(typeof(Category));
            ProductId.Text = id.ToString();
            if (id == -1)
            {
                delete.Visible = false;
                updates.Visible = false;
                //addProduct();
            }
            else updateProduct();


        }

        public void updateProduct()
        {
            delete.Visible = true;
            updates.Visible = true;
            add.Visible = false;
            Product c = s_bl.product.Read(id);
            ProductId.Text = c.ProductId.ToString();
            ProductName.Text = c.ProductName;
            Quantity.Text = c.Quantity.ToString();
            Price.Text = c.Price.ToString();
        }









        private void updates_Click_1(object sender, EventArgs e)
        {
            string categoryText = ProductCategory.Text.ToString();

            if (Enum.TryParse<BO.Category>(categoryText, out BO.Category tempCategory))
            {
                category = tempCategory; // המרה הצליחה
            }



            Product c = new Product(int.Parse(ProductId.Text), ProductName.Text,
            category, (int)Quantity.Value, (double)Price.Value);
            s_bl.product.Update(c);
            MessageBox.Show(c.ToString());
            updateClicked?.Invoke(this, EventArgs.Empty);

            this.Close();

        }

        private void delete_Click_1(object sender, EventArgs e)
        {
            s_bl.product.Delete(id);

            deleteClicked?.Invoke(this, EventArgs.Empty);
            this.Close();

        }

        private void back_Click_1(object sender, EventArgs e)
        {
            this.Close();


        }

        private void add_Click(object sender, EventArgs e)
        {
            string categoryText = ProductCategory.SelectedItem.ToString();

            if (Enum.TryParse<BO.Category>(categoryText, out BO.Category tempCategory))
            {
                category = tempCategory; // המרה הצליחה
            }

            s_bl.product.Create(new Product(1, ProductName.Text,
                category, (int)Quantity.Value, (double)Price.Value));
          
            ButtonClicked?.Invoke(this, EventArgs.Empty);
            this.Close();

        }

        private void ProductCategory_TextChanged(object sender, EventArgs e)//טעות יש למחוק
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

