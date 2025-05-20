namespace UI
{
    partial class Choose
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Choose));
            products = new Button();
            customers = new Button();
            orders = new Button();
            SuspendLayout();
            // 
            // products
            // 
            products.Location = new Point(523, 173);
            products.Name = "products";
            products.Size = new Size(75, 23);
            products.TabIndex = 0;
            products.Text = "מוצרים";
            products.UseVisualStyleBackColor = true;
            products.Click += products_Click;
            // 
            // customers
            // 
            customers.Location = new Point(280, 173);
            customers.Name = "customers";
            customers.Size = new Size(75, 23);
            customers.TabIndex = 1;
            customers.Text = "לקוחות";
            customers.UseVisualStyleBackColor = true;
            customers.Click += customers_Click;
            // 
            // orders
            // 
            orders.Location = new Point(402, 173);
            orders.Name = "orders";
            orders.Size = new Size(75, 23);
            orders.TabIndex = 2;
            orders.Text = "מבצעים";
            orders.UseVisualStyleBackColor = true;
            orders.Click += orders_Click;
            // 
            // Choose
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(orders);
            Controls.Add(customers);
            Controls.Add(products);
            DoubleBuffered = true;
            Name = "Choose";
            Text = "Choose";
            ResumeLayout(false);
        }

        #endregion

        private Button products;
        private Button customers;
        private Button orders;
    }
}