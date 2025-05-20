using BO;


namespace UI
{
    public partial class Cashier : Form
    {
        private BlApi.IBl s_bl = BlApi.Factory.Get();
        private List<ProductInOrder> order = new List<ProductInOrder>();
        private bool favorite;
        private Order o;
        private List<SaleInProduct> l = new List<SaleInProduct>();


        public Cashier(int id)
        {
            InitializeComponent();
            o = new Order(this.favorite, 0, order);
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
                l.AddRange(s_bl.order.AddProductToOrder(o, selectedItem.ProductId, (int)quantity.Value, selectedItem.Price ?? 0));
            }
            catch (BlNotInStockException b)
            {
                MessageBox.Show(b.Message);
            }

            dataGridView1.DataSource = o.ProductInOrders;
            sales.DataSource = l;
            price.Text = (o.FinalPrice).ToString();

        }

        private void doorder_Click(object sender, EventArgs e)
        {
            s_bl.order.DoOrder(o);
            MessageBox.Show("order was done");
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
