namespace UI
{
    partial class club
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(club));
            checkBox1 = new CheckBox();
            id = new Label();
            next = new Button();
            cusId = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)cusId).BeginInit();
            SuspendLayout();
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(435, 183);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(49, 19);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "club";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // id
            // 
            id.AutoSize = true;
            id.Location = new Point(435, 224);
            id.Name = "id";
            id.Size = new Size(69, 15);
            id.TabIndex = 3;
            id.Text = "CustomerId";
            // 
            // next
            // 
            next.Location = new Point(435, 304);
            next.Name = "next";
            next.Size = new Size(75, 23);
            next.TabIndex = 4;
            next.Text = "next";
            next.UseVisualStyleBackColor = true;
            next.Click += next_Click;
            // 
            // cusId
            // 
            cusId.Location = new Point(435, 257);
            cusId.Name = "cusId";
            cusId.Size = new Size(120, 23);
            cusId.TabIndex = 5;
            // 
            // club
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(cusId);
            Controls.Add(next);
            Controls.Add(id);
            Controls.Add(checkBox1);
            DoubleBuffered = true;
            Name = "club";
            Text = "club";
            ((System.ComponentModel.ISupportInitialize)cusId).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBox1;
        private Label id;
        private Button next;
        private NumericUpDown cusId;
    }
}