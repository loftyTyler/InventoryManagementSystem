namespace InventoryManagementSystem
{
    partial class AddCategory
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.changeCategoryTxtBox = new System.Windows.Forms.TextBox();
            this.submitCategoryBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 27);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 96);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(405, 27);
            this.panel2.TabIndex = 1;
            // 
            // changeCategoryTxtBox
            // 
            this.changeCategoryTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeCategoryTxtBox.Location = new System.Drawing.Point(23, 46);
            this.changeCategoryTxtBox.Name = "changeCategoryTxtBox";
            this.changeCategoryTxtBox.Size = new System.Drawing.Size(193, 30);
            this.changeCategoryTxtBox.TabIndex = 2;
            // 
            // submitCategoryBtn
            // 
            this.submitCategoryBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitCategoryBtn.Location = new System.Drawing.Point(257, 46);
            this.submitCategoryBtn.Name = "submitCategoryBtn";
            this.submitCategoryBtn.Size = new System.Drawing.Size(100, 33);
            this.submitCategoryBtn.TabIndex = 0;
            this.submitCategoryBtn.Text = "Submit";
            this.submitCategoryBtn.UseVisualStyleBackColor = true;
            this.submitCategoryBtn.Click += new System.EventHandler(this.submitCategoryBtn_Click);
            // 
            // AddCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 123);
            this.Controls.Add(this.submitCategoryBtn);
            this.Controls.Add(this.changeCategoryTxtBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AddCategory";
            this.Text = "AddCategory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox changeCategoryTxtBox;
        private System.Windows.Forms.Button submitCategoryBtn;
    }
}