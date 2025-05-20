namespace UI
{
    partial class Customers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customers));
            phone = new TextBox();
            address = new TextBox();
            customerName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            customerId = new NumericUpDown();
            add = new Button();
            back = new Button();
            addPanel = new Panel();
            delete = new Button();
            updates = new Button();
            ((System.ComponentModel.ISupportInitialize)customerId).BeginInit();
            addPanel.SuspendLayout();
            SuspendLayout();
            // 
            // phone
            // 
            phone.Location = new Point(118, 173);
            phone.Name = "phone";
            phone.Size = new Size(100, 23);
            phone.TabIndex = 1;
            // 
            // address
            // 
            address.Location = new Point(118, 132);
            address.Name = "address";
            address.Size = new Size(100, 23);
            address.TabIndex = 3;
            // 
            // customerName
            // 
            customerName.Location = new Point(118, 94);
            customerName.Name = "customerName";
            customerName.Size = new Size(100, 23);
            customerName.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(-4, 54);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 5;
            label1.Text = "customerId";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(2, 176);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 6;
            label2.Text = "phone";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(2, 140);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 7;
            label3.Text = "address";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(-4, 94);
            label4.Name = "label4";
            label4.Size = new Size(89, 15);
            label4.TabIndex = 8;
            label4.Text = "customerName";
            // 
            // customerId
            // 
            customerId.Location = new Point(118, 54);
            customerId.Name = "customerId";
            customerId.Size = new Size(120, 23);
            customerId.TabIndex = 9;
            // 
            // add
            // 
            add.Location = new Point(477, 341);
            add.Name = "add";
            add.Size = new Size(75, 23);
            add.TabIndex = 10;
            add.Text = "add";
            add.UseVisualStyleBackColor = true;
            add.Click += button1_Click;
            // 
            // back
            // 
            back.Location = new Point(396, 341);
            back.Name = "back";
            back.Size = new Size(75, 23);
            back.TabIndex = 11;
            back.Text = "back";
            back.UseVisualStyleBackColor = true;
            back.Click += back_Click;
            // 
            // addPanel
            // 
            addPanel.BackColor = Color.Peru;
            addPanel.Controls.Add(address);
            addPanel.Controls.Add(phone);
            addPanel.Controls.Add(customerName);
            addPanel.Controls.Add(label1);
            addPanel.Controls.Add(customerId);
            addPanel.Controls.Add(label2);
            addPanel.Controls.Add(label4);
            addPanel.Controls.Add(label3);
            addPanel.Location = new Point(220, 124);
            addPanel.Name = "addPanel";
            addPanel.Size = new Size(332, 211);
            addPanel.TabIndex = 12;
            // 
            // delete
            // 
            delete.Location = new Point(303, 341);
            delete.Name = "delete";
            delete.Size = new Size(75, 23);
            delete.TabIndex = 10;
            delete.Text = "delete";
            delete.UseVisualStyleBackColor = true;
            delete.Click += delete_Click;
            // 
            // updates
            // 
            updates.Location = new Point(222, 341);
            updates.Name = "updates";
            updates.Size = new Size(75, 23);
            updates.TabIndex = 15;
            updates.Text = "update";
            updates.UseVisualStyleBackColor = true;
            updates.Click += updates_Click;
            // 
            // Customers
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
            Name = "Customers";
            Text = "Customers";
            ((System.ComponentModel.ISupportInitialize)customerId).EndInit();
            addPanel.ResumeLayout(false);
            addPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox phone;
        private TextBox address;
        private TextBox customerName;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private NumericUpDown customerId;
        private Button add;
        private Button back;
        private Panel addPanel;
        private Button delete;
        private Button updates;
    }
}