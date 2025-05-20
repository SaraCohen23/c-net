namespace UI
{
    partial class Cashier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cashier));
            dataGridView1 = new DataGridView();
            comboBox1 = new ComboBox();
            add = new Button();
            price = new Label();
            customerId = new Label();
            cusId = new Label();
            label2 = new Label();
            quantity = new NumericUpDown();
            doorder = new Button();
            sales = new DataGridView();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            id = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)quantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sales).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(34, 72);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(484, 223);
            dataGridView1.TabIndex = 0;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(34, 327);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(484, 23);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // add
            // 
            add.Location = new Point(264, 367);
            add.Name = "add";
            add.Size = new Size(75, 23);
            add.TabIndex = 2;
            add.Text = "add product";
            add.UseVisualStyleBackColor = true;
            add.Click += button1_Click;
            // 
            // price
            // 
            price.AutoSize = true;
            price.Location = new Point(720, 336);
            price.Name = "price";
            price.Size = new Size(13, 15);
            price.TabIndex = 3;
            price.Text = "0";
            // 
            // customerId
            // 
            customerId.AutoSize = true;
            customerId.Location = new Point(630, 23);
            customerId.Name = "customerId";
            customerId.Size = new Size(67, 15);
            customerId.TabIndex = 4;
            customerId.Text = "customerId";
            // 
            // cusId
            // 
            cusId.AutoSize = true;
            cusId.Location = new Point(618, 107);
            cusId.Name = "cusId";
            cusId.Size = new Size(0, 15);
            cusId.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(720, 309);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 7;
            label2.Text = "price";
            // 
            // quantity
            // 
            quantity.Location = new Point(538, 328);
            quantity.Name = "quantity";
            quantity.Size = new Size(120, 23);
            quantity.TabIndex = 8;
            quantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // doorder
            // 
            doorder.Location = new Point(264, 415);
            doorder.Name = "doorder";
            doorder.Size = new Size(75, 23);
            doorder.TabIndex = 9;
            doorder.Text = "do order";
            doorder.UseVisualStyleBackColor = true;
            doorder.Click += doorder_Click;
            // 
            // sales
            // 
            sales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            sales.Location = new Point(548, 125);
            sales.Name = "sales";
            sales.RowTemplate.Height = 25;
            sales.Size = new Size(240, 150);
            sales.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 309);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 11;
            label1.Text = "products";
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(548, 82);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 12;
            label3.Text = "sales";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(50, 45);
            label4.Name = "label4";
            label4.Size = new Size(98, 15);
            label4.TabIndex = 13;
            label4.Text = "products in order";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(538, 309);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 11;
            label5.Text = "quantity";
            // 
            // id
            // 
            id.AutoSize = true;
            id.Location = new Point(630, 55);
            id.Name = "id";
            id.Size = new Size(0, 15);
            id.TabIndex = 14;
            id.Click += label6_Click;
            // 
            // Cashier
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(id);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(sales);
            Controls.Add(doorder);
            Controls.Add(quantity);
            Controls.Add(label2);
            Controls.Add(cusId);
            Controls.Add(customerId);
            Controls.Add(price);
            Controls.Add(add);
            Controls.Add(comboBox1);
            Controls.Add(dataGridView1);
            Name = "Cashier";
            Text = "Cashier";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)quantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)sales).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private ComboBox comboBox1;
        private Button add;
        private Label price;
        private Label customerId;
        private Label cusId;
        private Label label2;
        private NumericUpDown quantity;
        private Button doorder;
        private DataGridView sales;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label id;
    }
}