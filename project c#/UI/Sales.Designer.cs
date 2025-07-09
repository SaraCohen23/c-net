namespace UI
{
    partial class Sales
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
            updates = new Button();
            back = new Button();
            delete = new Button();
            add = new Button();
            addPanel = new Panel();
            SaleProductId = new NumericUpDown();
            SalePrice = new NumericUpDown();
            SaleFinishDate = new DateTimePicker();
            SaleStartDate = new DateTimePicker();
            SaleIfClub = new CheckBox();
            label7 = new Label();
            label6 = new Label();
            SaleId = new Label();
            SaleQuantity = new NumericUpDown();
            label5 = new Label();
            label2 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            addPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SaleProductId).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SalePrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SaleQuantity).BeginInit();
            SuspendLayout();
            // 
            // updates
            // 
            updates.Location = new Point(236, 336);
            updates.Name = "updates";
            updates.Size = new Size(75, 23);
            updates.TabIndex = 25;
            updates.Text = "update";
            updates.UseVisualStyleBackColor = true;
            updates.Click += updates_Click;
            // 
            // back
            // 
            back.Location = new Point(410, 336);
            back.Name = "back";
            back.Size = new Size(75, 23);
            back.TabIndex = 23;
            back.Text = "back";
            back.UseVisualStyleBackColor = true;
            back.Click += back_Click;
            // 
            // delete
            // 
            delete.Location = new Point(317, 336);
            delete.Name = "delete";
            delete.Size = new Size(75, 23);
            delete.TabIndex = 21;
            delete.Text = "delete";
            delete.UseVisualStyleBackColor = true;
            delete.Click += delete_Click;
            // 
            // add
            // 
            add.Location = new Point(491, 336);
            add.Name = "add";
            add.Size = new Size(75, 23);
            add.TabIndex = 22;
            add.Text = "add";
            add.UseVisualStyleBackColor = true;
            add.Click += add_Click_1;
            // 
            // addPanel
            // 
            addPanel.BackColor = Color.Peru;
            addPanel.Controls.Add(SaleProductId);
            addPanel.Controls.Add(SalePrice);
            addPanel.Controls.Add(SaleFinishDate);
            addPanel.Controls.Add(SaleStartDate);
            addPanel.Controls.Add(SaleIfClub);
            addPanel.Controls.Add(label7);
            addPanel.Controls.Add(label6);
            addPanel.Controls.Add(SaleId);
            addPanel.Controls.Add(SaleQuantity);
            addPanel.Controls.Add(label5);
            addPanel.Controls.Add(label1);
            addPanel.Controls.Add(label2);
            addPanel.Controls.Add(label4);
            addPanel.Controls.Add(label3);
            addPanel.Location = new Point(234, 12);
            addPanel.Name = "addPanel";
            addPanel.Size = new Size(332, 318);
            addPanel.TabIndex = 24;
            addPanel.Paint += addPanel_Paint;
            // 
            // SaleProductId
            // 
            SaleProductId.Location = new Point(117, 92);
            SaleProductId.Name = "SaleProductId";
            SaleProductId.Size = new Size(120, 23);
            SaleProductId.TabIndex = 21;
            // 
            // SalePrice
            // 
            SalePrice.Location = new Point(117, 168);
            SalePrice.Name = "SalePrice";
            SalePrice.Size = new Size(120, 23);
            SalePrice.TabIndex = 20;
            // 
            // SaleFinishDate
            // 
            SaleFinishDate.Location = new Point(117, 267);
            SaleFinishDate.Name = "SaleFinishDate";
            SaleFinishDate.Size = new Size(200, 23);
            SaleFinishDate.TabIndex = 19;
            // 
            // SaleStartDate
            // 
            SaleStartDate.Location = new Point(117, 238);
            SaleStartDate.Name = "SaleStartDate";
            SaleStartDate.Size = new Size(200, 23);
            SaleStartDate.TabIndex = 18;
            // 
            // SaleIfClub
            // 
            SaleIfClub.AutoSize = true;
            SaleIfClub.Location = new Point(117, 206);
            SaleIfClub.Name = "SaleIfClub";
            SaleIfClub.Size = new Size(83, 19);
            SaleIfClub.TabIndex = 17;
            SaleIfClub.Text = "checkBox1";
            SaleIfClub.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(2, 273);
            label7.Name = "label7";
            label7.Size = new Size(83, 15);
            label7.TabIndex = 16;
            label7.Text = "SaleFinishDate";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 242);
            label6.Name = "label6";
            label6.Size = new Size(76, 15);
            label6.TabIndex = 15;
            label6.Text = "SaleStartDate";
            // 
            // SaleId
            // 
            SaleId.AutoSize = true;
            SaleId.Location = new Point(120, 54);
            SaleId.Name = "SaleId";
            SaleId.Size = new Size(0, 15);
            SaleId.TabIndex = 14;
            // 
            // SaleQuantity
            // 
            SaleQuantity.Location = new Point(117, 132);
            SaleQuantity.Name = "SaleQuantity";
            SaleQuantity.Size = new Size(120, 23);
            SaleQuantity.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 207);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 10;
            label5.Text = "SaleIfClub";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(2, 176);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 6;
            label2.Text = "SalePrice";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(-4, 94);
            label4.Name = "label4";
            label4.Size = new Size(80, 15);
            label4.TabIndex = 8;
            label4.Text = "SaleProductId";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(2, 140);
            label3.Name = "label3";
            label3.Size = new Size(74, 15);
            label3.TabIndex = 7;
            label3.Text = "SaleQuantity";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(-4, 54);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 5;
            label1.Text = "SaleId";
            // 
            // Sales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(updates);
            Controls.Add(back);
            Controls.Add(delete);
            Controls.Add(add);
            Controls.Add(addPanel);
            Name = "Sales";
            Text = "Sales";
            addPanel.ResumeLayout(false);
            addPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SaleProductId).EndInit();
            ((System.ComponentModel.ISupportInitialize)SalePrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)SaleQuantity).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button updates;
        private Button back;
        private Button delete;
        private Button add;
        private Panel addPanel;
        private Label SaleId;
        private ComboBox ProductCategory;
        private NumericUpDown Quantity;
        private NumericUpDown SaleQuantity;
        private Label label5;
        private Label label2;
        private Label label4;
        private Label label3;
        private CheckBox SaleIfClub;
        private Label label7;
        private Label label6;
        private NumericUpDown SalePrice;
        private DateTimePicker SaleFinishDate;
        private DateTimePicker SaleStartDate;
        private NumericUpDown SaleProductId;
        private Label label1;
    }
}