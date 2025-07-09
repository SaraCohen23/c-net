namespace UI
{
    partial class Manager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manager));
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            label1 = new Label();
            filter = new ComboBox();
            show_all = new Button();
            filterr = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(252, 186);
            panel1.Name = "panel1";
            panel1.Size = new Size(379, 224);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(379, 221);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // button1
            // 
            button1.Location = new Point(110, 199);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "add new";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(387, 52);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 2;
            label1.Text = "label1";
            label1.Click += label1_Click;
            // 
            // filter
            // 
            filter.FormattingEnabled = true;
            filter.Location = new Point(510, 95);
            filter.Name = "filter";
            filter.Size = new Size(121, 23);
            filter.TabIndex = 3;
            filter.SelectedIndexChanged += category;
            // 
            // show_all
            // 
            show_all.Location = new Point(110, 121);
            show_all.Name = "show_all";
            show_all.Size = new Size(75, 23);
            show_all.TabIndex = 4;
            show_all.Text = "show all";
            show_all.UseVisualStyleBackColor = true;
            show_all.Click += show_all_Click;
            // 
            // filterr
            // 
            filterr.Location = new Point(110, 161);
            filterr.Name = "filterr";
            filterr.Size = new Size(75, 23);
            filterr.TabIndex = 5;
            filterr.Text = "filter";
            filterr.UseVisualStyleBackColor = true;
            filterr.Click += filterr_Click;
            // 
            // Manager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(811, 450);
            Controls.Add(filterr);
            Controls.Add(show_all);
            Controls.Add(filter);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Name = "Manager";
            Text = "Manager";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private DataGridView dataGridView1;
        private Label label1;
        private ComboBox filter;
        private Button show_all;
        private Button filterr;
    }
}