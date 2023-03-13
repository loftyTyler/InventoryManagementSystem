using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class AddCategory : Form
    {
        public AddCategory()
        {
            InitializeComponent();
        }

        private void submitCategoryBtn_Click(object sender, EventArgs e)
        {
            invDatabase inv = new invDatabase();
            invManagementEntities invEntities = new invManagementEntities();
            inv.itemName = changeCategoryTxtBox.Text;
            invEntities.invDatabases.Add(inv);
            invEntities.SaveChanges();
        }
    }
}
