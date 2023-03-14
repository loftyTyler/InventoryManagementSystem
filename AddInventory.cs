using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class AddInventory : Form
    {
        public AddInventory()
        {
            InitializeComponent();
            DropDownTest();
        }

        private void submitItemBtn_Click(object sender, EventArgs e)
        {
            
            if (itemNameInput != null && itemNameInput.Text != "Item")
            {
                if(itemQtyInput != null && itemQtyInput.Text != "Item Quantity")
                {
                    if(itemLocationInput != null && itemLocationInput.Text != "Location")
                    {
                        if(classDropDown != null && classDropDown.Text != "Classification")
                        {
                            invDatabase inv = new invDatabase();
                            invManagementEntities invEntities = new invManagementEntities();
                            var nameRow = invEntities.invDatabases.FirstOrDefault(a => a.itemName == itemNameInput.Text);
                            if (nameRow != null)
                            {                       
                                MessageBox.Show("Item is already in Database");
                            } else
                            {
                                inv.itemName = itemNameInput.Text;
                                inv.itemQty = Int16.Parse(itemQtyInput.Text);
                                inv.itemLocation = itemLocationInput.Text;
                                //inv.itemClass = itemClassInput.Text;
                                inv.itemClass = classDropDown.Text;
                                invEntities.invDatabases.Add(inv);
                                invEntities.SaveChanges();
                                MessageBox.Show("Item added successfully.");
                            }

                            
                        } else
                        {
                            MessageBox.Show("Enter a Classification");
                        }
                    } else
                    {
                        MessageBox.Show("Enter a Location and Classification");
                    }
                }
                else
                {
                    MessageBox.Show("Enter a Quantity, Location, and Classification");
                }
            } else
            {
                MessageBox.Show("Enter all fields");
            }
           
        }

        public void DropDownTest()
        {
            //This code is being used to create a drop down of all categories that are inputed
            using (var inv = new invManagementEntities())
            {
                var searchResults = inv.invDatabases.Select(e=> e.itemClass).Distinct().ToList();

                foreach (var myEntity in searchResults)
                {
                    classDropDown.Items.Add(myEntity);
                }
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addCategory_Click(object sender, EventArgs e)
        {
            AddCategory addCategory = new AddCategory();
            this.Hide();
            addCategory.ShowDialog();
            this.Show();
        }
    }
}
