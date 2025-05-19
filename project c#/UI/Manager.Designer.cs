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
            label1 = new Label();
            comboBox1 = new ComboBox();
            showAll = new TabPage();
            dataGridView1 = new DataGridView();
            show = new TabPage();
            delete = new TabPage();
            update = new TabPage();
            add = new TabPage();
            Tabs = new TabControl();
            showAll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            Tabs.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(514, 19);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 8;
            label1.Text = "label1";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(650, 171);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 9;
            // 
            // showAll
            // 
            showAll.Controls.Add(dataGridView1);
            showAll.Location = new Point(4, 24);
            showAll.Name = "showAll";
            showAll.Padding = new Padding(3);
            showAll.Size = new Size(340, 242);
            showAll.TabIndex = 4;
            showAll.Text = "הצג הכל";
            showAll.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(361, 239);
            dataGridView1.TabIndex = 5;
            // 
            // show
            // 
            show.Location = new Point(4, 24);
            show.Name = "show";
            show.Padding = new Padding(3);
            show.Size = new Size(340, 242);
            show.TabIndex = 3;
            show.Text = "הצג";
            show.UseVisualStyleBackColor = true;
            // 
            // delete
            // 
            delete.Location = new Point(4, 24);
            delete.Name = "delete";
            delete.Padding = new Padding(3);
            delete.Size = new Size(340, 242);
            delete.TabIndex = 2;
            delete.Text = "מחיקה";
            delete.UseVisualStyleBackColor = true;
            // 
            // update
            // 
            update.Location = new Point(4, 24);
            update.Name = "update";
            update.Padding = new Padding(3);
            update.Size = new Size(340, 242);
            update.TabIndex = 1;
            update.Text = "עדכון";
            update.UseVisualStyleBackColor = true;
            // 
            // add
            // 
            add.Location = new Point(4, 24);
            add.Name = "add";
            add.Padding = new Padding(3);
            add.Size = new Size(340, 242);
            add.TabIndex = 0;
            add.Text = "הוספה";
            add.UseVisualStyleBackColor = true;
            // 
            // Tabs
            // 
            Tabs.Controls.Add(add);
            Tabs.Controls.Add(update);
            Tabs.Controls.Add(delete);
            Tabs.Controls.Add(show);
            Tabs.Controls.Add(showAll);
            Tabs.Location = new Point(218, 62);
            Tabs.Name = "Tabs";
            Tabs.SelectedIndex = 0;
            Tabs.Size = new Size(348, 270);
            Tabs.TabIndex = 7;
            Tabs.SelectedIndexChanged += Tabs_SelectedIndexChanged;
            // 
            // Manager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(811, 450);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(Tabs);
            Name = "Manager";
            Text = "Manager";
            Load += Manager_Load;
            showAll.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            Tabs.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private ComboBox comboBox1;
        private TabPage showAll;
        private DataGridView dataGridView1;
        private TabPage show;
        private TabPage delete;
        private TabPage update;
        private TabPage add;
        private TabControl Tabs;
    }
}