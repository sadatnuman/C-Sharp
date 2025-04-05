using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagementSystem
{
    public partial class MenuManagement : Form
    {
        private AccessData da {  get; set; }
        public MenuManagement()
        {
 
                InitializeComponent();
                this.da = new AccessData();
                this.dgvMenu.ClearSelection();
                this.PopulateMenu();
            

        }

        private void PopulateMenu(string sql = @"SELECT 
                    MenuCategories.CategoryID, 
                    MenuCategories.CategoryName, 
                    MenuItems.Item, 
                    MenuItems.Price,
                    MenuItems.ItemID
                FROM 
                    MenuCategories
                INNER JOIN 
                    MenuItems
                ON 
                    MenuCategories.CategoryID = MenuItems.CategoryID")
        {

            try
            {
                var ds = this.da.ExecuteQuery(sql);
                dgvMenu.AutoGenerateColumns = false;
                dgvMenu.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured, please check: ", MessageBoxIcon.Warning + ex.Message);
            }

        }

        private void MenuManagement_Load(object sender, EventArgs e)
        {

            try
            {
                this.dgvMenu.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured, please check: ", MessageBoxIcon.Warning + ex.Message);
            }
        }

        private void dgvMenu_DoubleClick(object sender, EventArgs e)
        {

            try
            {
                this.txtItem.Text = this.dgvMenu.CurrentRow.Cells["Item"].Value.ToString();
                this.txtPrice.Text = this.dgvMenu.CurrentRow.Cells["Price"].Value.ToString();
                this.cmbCategory.Text = this.dgvMenu.CurrentRow.Cells["CategoryName"].Value.ToString();
                this.txtItemID.Text = this.dgvMenu.CurrentRow.Cells["ItemID"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured, please check: ", MessageBoxIcon.Warning + ex.Message);
            }
        }

        private void cmbCategory_TextChanged(object sender, EventArgs e)
        {

            try
            {
                if (this.cmbCategory.Text.Equals("Food"))
                {
                    this.txtCategoryID.Text = "231";

                }
                else if (this.cmbCategory.Text.Equals("Drinks"))
                {
                    this.txtCategoryID.Text = "452";
                }
                else if (this.cmbCategory.Text.Equals("Desserts"))
                {
                    this.txtCategoryID.Text = "557";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured, please check: ", MessageBoxIcon.Warning + ex.Message);
            }
        }
        private void ClearAll()
        {

            try
            {
                this.dgvMenu.ClearSelection();
                this.txtCategoryID.Clear();
                this.txtItem.Clear();
                this.txtPrice.Clear();
                this.txtItemID.Clear();
                this.cmbCategory.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured, please check: ", MessageBoxIcon.Warning + ex.Message);
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
           
            try
            {
                this.ClearAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured, please check: ", MessageBoxIcon.Warning + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvMenu.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Please select a row first to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var itemID = this.dgvMenu.CurrentRow.Cells[1].Value.ToString();
                var itemName = this.dgvMenu.CurrentRow.Cells[3].Value.ToString();
                //MessageBox.Show(id);

                DialogResult result = MessageBox.Show("Are you sure you want to delete " + itemName + "?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                    return;

                var sql = "delete from MenuItems where ItemID = '" + itemID + "';";
                var count = this.da.ExecuteDMLQuery(sql);

                if (count == 1)
                    MessageBox.Show(itemName.ToUpper() + " has been removed from the list.");
                else
                    MessageBox.Show("Data hasn't been removed properly");

                this.PopulateMenu();
                this.ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured, please check: ", MessageBoxIcon.Warning + exc.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.IsValidToSave())
                {
                    MessageBox.Show("Please fill all the empty fields");
                    return;
                }
                var query = "select * from MenuItems where ItemID = '" + this.txtItemID.Text + "'";
                DataTable dt = this.da.ExecuteQueryTable(query);
                if (dt.Rows.Count == 1)
                {
                    //update
                                var sql = @"UPDATE MenuItems
                        SET Item = '" + this.txtItem.Text + @"',
                            Price = " + this.txtPrice.Text + @",
                            CategoryID = '" + this.txtCategoryID.Text + @"'
                        WHERE ItemID = '" + this.txtItemID.Text + "';";
                    int count = this.da.ExecuteDMLQuery(sql);

                    if (count == 1)
                        MessageBox.Show("Data has been updated properly");
                    else
                        MessageBox.Show("Data hasn't been updated properly");
                }
                else
                {
                    //insert
                    var sql = "INSERT INTO MenuItems VALUES ('" + this.txtItemID.Text + "','" + this.txtItem.Text + "','" + this.txtCategoryID.Text + "', '" + this.txtPrice.Text + "');";
                    int count = this.da.ExecuteDMLQuery(sql);

                    if (count == 1)
                        MessageBox.Show("Data has been added properly");
                    else
                        MessageBox.Show("Data hasn't been added properly");
                }

                this.PopulateMenu();
                this.ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured, please check: ", MessageBoxIcon.Warning + exc.Message);

            }
        }

        private bool IsValidToSave()
        {
            if (string.IsNullOrEmpty(this.txtCategoryID.Text) || string.IsNullOrEmpty(this.txtItem.Text) ||
                string.IsNullOrEmpty(this.txtPrice.Text) ||
                string.IsNullOrEmpty(this.cmbCategory.Text))
                return false;
            else
                return true;

        }

        private void btnBack_Click(object sender, EventArgs e)
        {

            try
            {
                this.Hide();
                new AdminPanel().Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured, please check: ", MessageBoxIcon.Warning + ex.Message);
            }
        }

        private void PerformSearch()
        {
            try
            {
                var sql = @"SELECT 
                        MenuCategories.CategoryID, 
                        MenuCategories.CategoryName, 
                        MenuItems.Item, 
                        MenuItems.Price,
                        MenuItems.ItemID
                    FROM 
                        MenuCategories
                    INNER JOIN 
                        MenuItems
                    ON 
                        MenuCategories.CategoryID = MenuItems.CategoryID
                    WHERE 
                        MenuItems.Item LIKE '" + this.txtSearch.Text + "%';";

                this.PopulateMenu(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occurred while searching: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            this.PerformSearch();
        }

        private void MenuManagement_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
