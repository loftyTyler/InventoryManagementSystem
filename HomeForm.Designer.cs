namespace InventoryManagementSystem
{
    partial class HomeForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.checkInventoryBtn = new System.Windows.Forms.Button();
            this.addInvetoryBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(93, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(550, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Engineering Inventory Management System";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // checkInventoryBtn
            // 
            this.checkInventoryBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkInventoryBtn.Location = new System.Drawing.Point(100, 156);
            this.checkInventoryBtn.Name = "checkInventoryBtn";
            this.checkInventoryBtn.Size = new System.Drawing.Size(253, 45);
            this.checkInventoryBtn.TabIndex = 1;
            this.checkInventoryBtn.Text = "Check Inventory";
            this.checkInventoryBtn.UseVisualStyleBackColor = true;
            this.checkInventoryBtn.Click += new System.EventHandler(this.checkInventoryBtn_Click);
            // 
            // addInvetoryBtn
            // 
            this.addInvetoryBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addInvetoryBtn.Location = new System.Drawing.Point(388, 156);
            this.addInvetoryBtn.Name = "addInvetoryBtn";
            this.addInvetoryBtn.Size = new System.Drawing.Size(212, 45);
            this.addInvetoryBtn.TabIndex = 2;
            this.addInvetoryBtn.Text = "Add Inventory";
            this.addInvetoryBtn.UseVisualStyleBackColor = true;
            this.addInvetoryBtn.Click += new System.EventHandler(this.addInvetoryBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(707, 109);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Blue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 243);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(707, 35);
            this.panel2.TabIndex = 5;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 278);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.addInvetoryBtn);
            this.Controls.Add(this.checkInventoryBtn);
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button checkInventoryBtn;
        private System.Windows.Forms.Button addInvetoryBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

