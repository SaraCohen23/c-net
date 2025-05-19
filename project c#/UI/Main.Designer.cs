namespace UI
{
    partial class Main
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
            manager = new Button();
            cashier = new Button();
            SuspendLayout();
            // 
            // manager
            // 
            manager.ForeColor = SystemColors.MenuHighlight;
            manager.Location = new Point(505, 156);
            manager.Name = "manager";
            manager.Size = new Size(123, 95);
            manager.TabIndex = 0;
            manager.Text = "מנהל";
            manager.UseVisualStyleBackColor = true;
            manager.Click += button1_Click;
            // 
            // cashier
            // 
            cashier.ForeColor = SystemColors.MenuHighlight;
            cashier.Location = new Point(241, 156);
            cashier.Name = "cashier";
            cashier.Size = new Size(120, 95);
            cashier.TabIndex = 1;
            cashier.Text = "קופאי";
            cashier.UseVisualStyleBackColor = true;
            cashier.Click += button2_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cashier);
            Controls.Add(manager);
            Name = "Main";
            Text = "Main";
            ResumeLayout(false);
        }

        #endregion

        private Button manager;
        private Button cashier;
      
    }
}