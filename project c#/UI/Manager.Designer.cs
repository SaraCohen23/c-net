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
            dataGridView1 = new DataGridView();
            Tabs = new TabControl();
            add = new TabPage();
            update = new TabPage();
            delete = new TabPage();
            show = new TabPage();
            showAll = new TabPage();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            Tabs.SuspendLayout();
            showAll.SuspendLayout();
            SuspendLayout();
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
            // add
            // 
            add.Location = new Point(4, 24);
            add.Name = "add";
            add.Padding = new Padding(3);
            add.Size = new Size(324, 72);
            add.TabIndex = 0;
            add.Text = "הוספה";
            add.UseVisualStyleBackColor = true;
            // 
            // update
            // 
            update.Location = new Point(4, 24);
            update.Name = "update";
            update.Padding = new Padding(3);
            update.Size = new Size(324, 72);
            update.TabIndex = 1;
            update.Text = "עדכון";
            update.UseVisualStyleBackColor = true;
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
            // show
            // 
            show.Location = new Point(4, 24);
            show.Name = "show";
            show.Padding = new Padding(3);
            show.Size = new Size(324, 72);
            show.TabIndex = 3;
            show.Text = "הצג";
            show.UseVisualStyleBackColor = true;
            // 
            // showAll
            // 
            showAll.Controls.Add(dataGridView1);
            showAll.Location = new Point(4, 24);
            showAll.Name = "showAll";
            showAll.Padding = new Padding(3);
            showAll.Size = new Size(364, 245);
            showAll.TabIndex = 4;
            showAll.Text = "הצג הכל";
            showAll.UseVisualStyleBackColor = true;
            // 
            // Manager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Tabs);
            Name = "Manager";
            Text = "Manager";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            Tabs.ResumeLayout(false);
            showAll.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridView1;
        private TabControl Tabs;
        private TabPage add;
        private TabPage update;
        private TabPage delete;
        private TabPage show;
        private TabPage showAll;
    }
}