namespace InventoryManagementSystem
{
    partial class AddInventory
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
            this.label2 = new System.Windows.Forms.Label();
            this.itemNameInput = new System.Windows.Forms.TextBox();
            this.itemQtyInput = new System.Windows.Forms.TextBox();
            this.itemLocationInput = new System.Windows.Forms.TextBox();
            this.submitItemBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.classDropDown = new System.Windows.Forms.ComboBox();
            this.addCategory = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(40, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inventory Management Systems";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(112, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Add Inventory";
            // 
            // itemNameInput
            // 
            this.itemNameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemNameInput.Location = new System.Drawing.Point(75, 120);
            this.itemNameInput.Name = "itemNameInput";
            this.itemNameInput.Size = new System.Drawing.Size(216, 30);
            this.itemNameInput.TabIndex = 2;
            this.itemNameInput.Text = "Item";
            // 
            // itemQtyInput
            // 
            this.itemQtyInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemQtyInput.Location = new System.Drawing.Point(75, 175);
            this.itemQtyInput.Name = "itemQtyInput";
            this.itemQtyInput.Size = new System.Drawing.Size(216, 30);
            this.itemQtyInput.TabIndex = 3;
            this.itemQtyInput.Text = "Item Quantity";
            // 
            // itemLocationInput
            // 
            this.itemLocationInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemLocationInput.Location = new System.Drawing.Point(75, 237);
            this.itemLocationInput.Name = "itemLocationInput";
            this.itemLocationInput.Size = new System.Drawing.Size(216, 30);
            this.itemLocationInput.TabIndex = 4;
            this.itemLocationInput.Text = "Location";
            // 
            // submitItemBtn
            // 
            this.submitItemBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitItemBtn.Location = new System.Drawing.Point(117, 3);
            this.submitItemBtn.Name = "submitItemBtn";
            this.submitItemBtn.Size = new System.Drawing.Size(118, 42);
            this.submitItemBtn.TabIndex = 6;
            this.submitItemBtn.Text = "Submit";
            this.submitItemBtn.UseVisualStyleBackColor = true;
            this.submitItemBtn.Click += new System.EventHandler(this.submitItemBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(382, 76);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Controls.Add(this.submitItemBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 387);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(382, 63);
            this.panel2.TabIndex = 8;
            // 
            // classDropDown
            // 
            this.classDropDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classDropDown.FormattingEnabled = true;
            this.classDropDown.Location = new System.Drawing.Point(75, 288);
            this.classDropDown.Name = "classDropDown";
            this.classDropDown.Size = new System.Drawing.Size(216, 33);
            this.classDropDown.TabIndex = 9;
            this.classDropDown.Text = "Category";
            // 
            // addCategory
            // 
            this.addCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCategory.Location = new System.Drawing.Point(75, 327);
            this.addCategory.Name = "addCategory";
            this.addCategory.Size = new System.Drawing.Size(213, 34);
            this.addCategory.TabIndex = 10;
            this.addCategory.Text = "Add Different Category";
            this.addCategory.UseVisualStyleBackColor = true;
            this.addCategory.Click += new System.EventHandler(this.addCategory_Click);
            // 
            // AddInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 450);
            this.Controls.Add(this.addCategory);
            this.Controls.Add(this.classDropDown);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.itemLocationInput);
            this.Controls.Add(this.itemQtyInput);
            this.Controls.Add(this.itemNameInput);
            this.Controls.Add(this.label2);
            this.Name = "AddInventory";
            this.Text = "AddInventory";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox itemNameInput;
        private System.Windows.Forms.TextBox itemQtyInput;
        private System.Windows.Forms.TextBox itemLocationInput;
        private System.Windows.Forms.Button submitItemBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.ComboBox classDropDown;
        private System.Windows.Forms.Button addCategory;
    }
}