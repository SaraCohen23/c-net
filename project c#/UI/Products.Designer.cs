namespace UI
{
    partial class Products
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Products));
            updates = new Button();
            back = new Button();
            delete = new Button();
            add = new Button();
            addPanel = new Panel();
            ProductId = new Label();
            ProductCategory = new ComboBox();
            Quantity = new NumericUpDown();
            Price = new NumericUpDown();
            label5 = new Label();
            ProductName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label3 = new Label();
            addPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Quantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Price).BeginInit();
            SuspendLayout();
            // 
            // updates
            // 
            updates.Location = new Point(236, 322);
            updates.Name = "updates";
            updates.Size = new Size(75, 23);
            updates.TabIndex = 20;
            updates.Text = "update";
            updates.UseVisualStyleBackColor = true;
            updates.Click += updates_Click_1;
            // 
            // back
            // 
            back.Location = new Point(410, 322);
            back.Name = "back";
            back.Size = new Size(75, 23);
            back.TabIndex = 18;
            back.Text = "back";
            back.UseVisualStyleBackColor = true;
            back.Click += back_Click_1;
            // 
            // delete
            // 
            delete.Location = new Point(317, 322);
            delete.Name = "delete";
            delete.Size = new Size(75, 23);
            delete.TabIndex = 16;
            delete.Text = "delete";
            delete.UseVisualStyleBackColor = true;
            delete.Click += delete_Click_1;
            // 
            // add
            // 
            add.Location = new Point(491, 322);
            add.Name = "add";
            add.Size = new Size(75, 23);
            add.TabIndex = 17;
            add.Text = "add";
            add.UseVisualStyleBackColor = true;
            add.Click += add_Click;
            // 
            // addPanel
            // 
            addPanel.BackColor = Color.Peru;
            addPanel.Controls.Add(ProductId);
            addPanel.Controls.Add(ProductCategory);
            addPanel.Controls.Add(Quantity);
            addPanel.Controls.Add(Price);
            addPanel.Controls.Add(label5);
            addPanel.Controls.Add(ProductName);
            addPanel.Controls.Add(label1);
            addPanel.Controls.Add(label2);
            addPanel.Controls.Add(label4);
            addPanel.Controls.Add(label3);
            addPanel.Location = new Point(234, 77);
            addPanel.Name = "addPanel";
            addPanel.Size = new Size(332, 239);
            addPanel.TabIndex = 19;
            // 
            // ProductId
            // 
            ProductId.AutoSize = true;
            ProductId.Location = new Point(120, 54);
            ProductId.Name = "ProductId";
            ProductId.Size = new Size(59, 15);
            ProductId.TabIndex = 14;
            ProductId.Text = "ProductId";
            // 
            // ProductCategory
            // 
            ProductCategory.FormattingEnabled = true;
            ProductCategory.Location = new Point(117, 132);
            ProductCategory.Name = "ProductCategory";
            ProductCategory.Size = new Size(121, 23);
            ProductCategory.TabIndex = 13;
            // 
            // Quantity
            // 
            Quantity.Location = new Point(118, 174);
            Quantity.Name = "Quantity";
            Quantity.Size = new Size(120, 23);
            Quantity.TabIndex = 12;
            // 
            // Price
            // 
            Price.Location = new Point(118, 207);
            Price.Name = "Price";
            Price.Size = new Size(120, 23);
            Price.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 207);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 10;
            label5.Text = "Price";
            // 
            // ProductName
            // 
            ProductName.Location = new Point(118, 94);
            ProductName.Name = "ProductName";
            ProductName.Size = new Size(100, 23);
            ProductName.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(-4, 54);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 5;
            label1.Text = "ProductId";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(2, 176);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 6;
            label2.Text = "Quantity";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(-4, 94);
            label4.Name = "label4";
            label4.Size = new Size(81, 15);
            label4.TabIndex = 8;
            label4.Text = "ProductName";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(2, 140);
            label3.Name = "label3";
            label3.Size = new Size(97, 15);
            label3.TabIndex = 7;
            label3.Text = "ProductCategory";
            label3.Click += label3_Click;
            // 
            // Products
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(updates);
            Controls.Add(back);
            Controls.Add(delete);
            Controls.Add(add);
            Controls.Add(addPanel);
            DoubleBuffered = true;
            Name = "Products";
            Text = "Products";
            addPanel.ResumeLayout(false);
            addPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Quantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)Price).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button updates;
        private Button back;
        private Button delete;
        private Button add;
        private Panel addPanel;
        private TextBox ProductName;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label3;
        private NumericUpDown Price;
        private Label label5;
        private NumericUpDown Quantity;
        private ComboBox ProductCategory;
        private Label ProductId;
    }
}