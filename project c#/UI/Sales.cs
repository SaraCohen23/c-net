using BO;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Sales : Form
    {
        private BlApi.IBl s_bl = BlApi.Factory.Get();
        private int id;
        public event EventHandler ButtonClicked;
        public event EventHandler updateClicked;
        public event EventHandler deleteClicked;

        public Sales(int id = -1)
        {
            this.id = id;
            InitializeComponent();
            SaleId.Text = id.ToString();
            if (id == -1)
            {
                delete.Visible = false;
                updates.Visible = false;
                //addSale();
            }
            else updateSale();


        }

        public void updateSale()
        {
            delete.Visible = true;
            updates.Visible = true;
            add.Visible = false;
            Sale c = s_bl.sale.Read(id);
            SaleProductId.Value = (Decimal)c.SaleProductId;
            SaleQuantity.Value = (Decimal)c.SaleQuantity;
            SalePrice.Value = (Decimal)c.SalePrice;
            SaleIfClub.Checked = c.SaleIfClub ?? false;
            SaleStartDate.Value = (DateTime)c.SaleStartDate;
            SaleFinishDate.Value = (DateTime)c.SaleFinishDate;




        }









        private void updates_Click(object sender, EventArgs e)
        {

            Sale c = new Sale(this.id, (int)SaleProductId.Value, (int)SaleQuantity.Value, (double)SalePrice.Value, SaleIfClub.Checked, (DateTime)SaleStartDate.Value,
             (DateTime)SaleFinishDate.Value);


            s_bl.sale.Update(c);
            MessageBox.Show(c.ToString());
            updateClicked?.Invoke(this, EventArgs.Empty);

            this.Close();

        }

        private void delete_Click(object sender, EventArgs e)
        {
            s_bl.sale.Delete(id);

            deleteClicked?.Invoke(this, EventArgs.Empty);
            this.Close();

        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();


        }

        private void add_Click(object sender, EventArgs e)
        {


            s_bl.sale.Create(new Sale(int.Parse(SaleId.Text), (int)SaleProductId.Value, (int)SaleQuantity.Value, (double)SalePrice.Value, SaleIfClub.Checked, (DateTime)SaleStartDate.Value,
             (DateTime)SaleFinishDate.Value));

            ButtonClicked?.Invoke(this, EventArgs.Empty);
            this.Close();

        }

        private void SaleCategory_TextChanged(object sender, EventArgs e)//טעות יש למחוק
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void add_Click_1(object sender, EventArgs e)
        {


            s_bl.sale.Create((new Sale(1, (int)SaleProductId.Value, (int)SaleQuantity.Value, (double)SalePrice.Value, SaleIfClub.Checked, (DateTime)SaleStartDate.Value,
             (DateTime)SaleFinishDate.Value)));


            ButtonClicked?.Invoke(this, EventArgs.Empty);
            this.Close();
        }

        private void addPanel_Paint(object sender, PaintEventArgs e)//יש למחוק
        {

        }
    }
}

