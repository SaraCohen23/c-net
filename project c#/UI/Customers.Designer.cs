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
            ((System.ComponentModel.ISupportInitialize)customerId).BeginInit();
            SuspendLayout();
            // 
            // phone
            // 
            phone.Location = new Point(374, 219);
            phone.Name = "phone";
            phone.Size = new Size(100, 23);
            phone.TabIndex = 1;
            // 
            // address
            // 
            address.Location = new Point(374, 178);
            address.Name = "address";
            address.Size = new Size(100, 23);
            address.TabIndex = 3;
            // 
            // customerName
            // 
            customerName.Location = new Point(374, 140);
            customerName.Name = "customerName";
            customerName.Size = new Size(100, 23);
            customerName.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(252, 100);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 5;
            label1.Text = "customerId";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(258, 222);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 6;
            label2.Text = "phone";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(258, 186);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 7;
            label3.Text = "address";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(252, 140);
            label4.Name = "label4";
            label4.Size = new Size(89, 15);
            label4.TabIndex = 8;
            label4.Text = "customerName";
            // 
            // customerId
            // 
            customerId.Location = new Point(374, 100);
            customerId.Name = "customerId";
            customerId.Size = new Size(120, 23);
            customerId.TabIndex = 9;
            // 
            // add
            // 
            add.Location = new Point(330, 288);
            add.Name = "add";
            add.Size = new Size(75, 23);
            add.TabIndex = 10;
            add.Text = "add";
            add.UseVisualStyleBackColor = true;
            add.Click += button1_Click;
            // 
            // back
            // 
            back.Location = new Point(457, 291);
            back.Name = "back";
            back.Size = new Size(75, 23);
            back.TabIndex = 11;
            back.Text = "back";
            back.UseVisualStyleBackColor = true;
            back.Click += back_Click;
            // 
            // Customers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(back);
            Controls.Add(add);
            Controls.Add(customerId);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(customerName);
            Controls.Add(address);
            Controls.Add(phone);
            Name = "Customers";
            Text = "Customers";
            ((System.ComponentModel.ISupportInitialize)customerId).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
    }
}