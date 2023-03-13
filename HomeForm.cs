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
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {

        }

        private void checkInventoryBtn_Click(object sender, EventArgs e)
        {
            CheckInventory checkInventory = new CheckInventory();
            this.Hide();
            checkInventory.ShowDialog();
            this.Show();
        }

        private void addInvetoryBtn_Click(object sender, EventArgs e)
        {
            AddInventory addInventory = new AddInventory();
            this.Hide();
            addInventory.ShowDialog();
            this.Show();
        }

        private void invCategoriesBtn_Click(object sender, EventArgs e)
        {
            AddInventoryCategory addInventoryCategory = new AddInventoryCategory();
            this.Hide();
            addInventoryCategory.ShowDialog();
            this.Show();
        }
    }
}
