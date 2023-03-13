using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace InventoryManagementSystem
{
    public partial class CheckInventory : Form
    {
        public CheckInventory()
        {
            InitializeComponent();
            LoadProduct();
        }

        private void CheckInventory_Load(object sender, EventArgs e)
        {
            
            
        }

        public void LoadProduct()
        {
            using (var inv = new invManagementEntities())
            {
                foreach (var myEntity in inv.invDatabases)
                {
                    dgvUser.Rows.Add(myEntity.itemName, myEntity.itemQty, myEntity.itemLocation, myEntity.itemClass);
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvUser.Rows.Clear();
            using (var inv = new invManagementEntities())
            {
                var searchResults = inv.invDatabases
                 .Where(a=> a.itemName.Contains(txtSearch.Text) || a.itemClass.Contains(txtSearch.Text) || a.itemLocation.Contains(txtSearch.Text))
                 .ToList();

                foreach (var myEntity in searchResults)
                {
                    dgvUser.Rows.Add(myEntity.itemName, myEntity.itemQty, myEntity.itemLocation, myEntity.itemClass);
                }
            }

                

        }
    }
}
