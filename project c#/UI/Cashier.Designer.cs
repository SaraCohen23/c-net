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
            dataGridView1.BackgroundColor = Color.Peru;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = Color.Peru;
            dataGridView1.Location = new Point(50, 79);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(370, 196);
            dataGridView1.TabIndex = 0;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(50, 327);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(468, 23);
            comboBox1.TabIndex = 1;

            // 
            // add
            // 
            add.BackColor = Color.Peru;
            add.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            add.Location = new Point(264, 356);
            add.Name = "add";
            add.Size = new Size(75, 28);
            add.TabIndex = 2;
            add.Text = "add product";
            add.UseVisualStyleBackColor = false;
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
            customerId.BackColor = Color.Peru;
            customerId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            customerId.Location = new Point(608, 40);
            customerId.Name = "customerId";
            customerId.Size = new Size(88, 21);
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
            label2.BackColor = Color.Peru;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(720, 309);
            label2.Name = "label2";
            label2.Size = new Size(44, 21);
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
            doorder.BackColor = Color.Peru;
            doorder.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            doorder.Location = new Point(264, 390);
            doorder.Name = "doorder";
            doorder.Size = new Size(89, 32);
            doorder.TabIndex = 9;
            doorder.Text = "do order";
            doorder.UseVisualStyleBackColor = false;
            doorder.Click += doorder_Click;
            // 
            // sales
            // 
            sales.BackgroundColor = Color.Peru;
            sales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            sales.Location = new Point(435, 79);
            sales.Name = "sales";
            sales.RowTemplate.Height = 25;
            sales.Size = new Size(298, 196);
            sales.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Peru;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(50, 303);
            label1.Name = "label1";
            label1.Size = new Size(127, 21);
            label1.TabIndex = 11;
            label1.Text = "Choose products";

            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Peru;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(435, 45);
            label3.Name = "label3";
            label3.Size = new Size(44, 21);
            label3.TabIndex = 12;
            label3.Text = "sales";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Peru;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(50, 45);
            label4.Name = "label4";
            label4.Size = new Size(130, 21);
            label4.TabIndex = 13;
            label4.Text = "products in order";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Peru;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(538, 309);
            label5.Name = "label5";
            label5.Size = new Size(67, 21);
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
        
            // 
            // Cashier
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
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
            DoubleBuffered = true;
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