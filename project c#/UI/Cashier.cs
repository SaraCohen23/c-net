using BO;
using System.ComponentModel;


namespace UI
{
    public partial class Cashier : Form
    {
        private BlApi.IBl s_bl = BlApi.Factory.Get();
        private BindingList<ProductInOrder> order = new BindingList<ProductInOrder>();
        private bool favorite;
        private Order o;
        private BindingList<SaleInProduct> l = new BindingList<SaleInProduct>();


        public Cashier(int id)
        {
            InitializeComponent();
            o = new Order(this.favorite, 0, order.ToList());
            this.favorite = id != 0;
            customerId.Visible = id != 0;
            cusId.Visible = id != 0;
            cusId.Text = id.ToString();

            var products = s_bl.product.ReadAll();
            comboBox1.Items.Clear();
            foreach (var product in products)
            {
                comboBox1.Items.Add(product);
            }
            dataGridView1.DataSource = order;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Product selectedItem = (Product)comboBox1.SelectedItem;

            try
            {
                var addedSaless = s_bl.order.AddProductToOrder(o, selectedItem.ProductId, (int)quantity.Value);

                foreach (var item in addedSaless)
                {
                    l.Add(item);
                }
               // l.AddRange(s_bl.order.AddProductToOrder(o, selectedItem.ProductId, (int)quantity.Value, selectedItem.Price ?? 0));
            }
            catch (BlNotInStockException b)
            {
                MessageBox.Show(b.Message);
            }


            //dataGridView1.DataSource = null;
            //dataGridView1.DataSource = o.ProductInOrders;
            order.Clear();
            foreach (var item in o.ProductInOrders)
            {
                order.Add(item);
            }
      
            sales.DataSource=null;
            l.Clear();
            foreach (var item in o.ProductInOrders)
            {
                foreach (var item2 in item.SaleInProducts)
                l.Add(item2);
            }
            sales.DataSource = l;



            price.Text = (o.FinalPrice).ToString();

        }

        private void doorder_Click(object sender, EventArgs e)
        {
            s_bl.order.DoOrder(o);
            MessageBox.Show("order was done");
            this.Close();
        }


    }
}
