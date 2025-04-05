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
    public partial class Order : Form
    {
        private AccessData da {  get; set; }
        public Order()
        {
 
                InitializeComponent();
                this.da = new AccessData();
                this.LoadcmbTables();
                this.PopulatedgvOrders();
            
 

        }

        private void LoadcmbTables(string sql= "select TableID,TableNumber from Tables;")
        {
            try
            {
                var ds = this.da.ExecuteQuery(sql);
                cmbTables.DataSource = ds.Tables[0];
                cmbTables.DisplayMember = "TableNumber";
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured, please check: ", MessageBoxIcon.Warning + ex.Message);
            }

            
            
        }


        private void LoadMenuItems(string category)
        {
            try
            {
                var sql = @"SELECT Item, Price 
                FROM MenuItems
                WHERE CategoryID = (
                    SELECT CategoryID 
                    FROM MenuCategories 
                    WHERE CategoryName = '" + category + @"'
                );";

              
                var ds = this.da.ExecuteQuery(sql);
                this.dgvSelectMenu.DataSource = ds.Tables[0];
            }
            catch(Exception ex)
            {
                MessageBox.Show("An error has occured, please check: ", MessageBoxIcon.Warning + ex.Message);
            }
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            try
            {
                LoadMenuItems("Food");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured, please check: ", MessageBoxIcon.Warning + ex.Message);
            }

        }

        private void btnDrinks_Click(object sender, EventArgs e)
        {
            try
            {
                LoadMenuItems("Drinks");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured, please check: ", MessageBoxIcon.Warning + ex.Message);
            }

        }

        private void btnDesserts_Click(object sender, EventArgs e)
        {
            try
            {
                LoadMenuItems("Desserts");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured, please check: ", MessageBoxIcon.Warning + ex.Message);
            }

        }
        private void PopulatedgvOrders()
        {
            try
            {
                this.dgvOrders.Columns.Clear();

                DataGridViewTextBoxColumn itemColumn = new DataGridViewTextBoxColumn();
                itemColumn.Name = "Item";
                itemColumn.HeaderText = "Item";
                itemColumn.ReadOnly = true;
                itemColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dgvOrders.Columns.Add(itemColumn);

                DataGridViewTextBoxColumn priceColumn = new DataGridViewTextBoxColumn();
                priceColumn.Name = "Price";
                priceColumn.HeaderText = "Price";
                priceColumn.DefaultCellStyle.Format = "C2"; // Currency format
                priceColumn.ReadOnly = true;
                priceColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dgvOrders.Columns.Add(priceColumn);

                DataGridViewTextBoxColumn quantityColumn = new DataGridViewTextBoxColumn();
                quantityColumn.Name = "Quantity";
                quantityColumn.HeaderText = "Quantity";
                quantityColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                quantityColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dgvOrders.Columns.Add(quantityColumn);
                this.dgvOrders.AllowUserToAddRows = false;
                this.dgvOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured, please check: ", MessageBoxIcon.Warning + ex.Message);
            }
            this.dgvOrders.AutoGenerateColumns = false;

        }

        private void dgvSelectMenu_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0) 
                {
                    
                    string item = this.dgvSelectMenu.CurrentRow.Cells["Item"].Value.ToString();
                    string price = this.dgvSelectMenu.CurrentRow.Cells["Price"].Value.ToString();

                   
                    bool itemExists = false;
                    foreach (DataGridViewRow row in this.dgvOrders.Rows)
                    {
                        if (row.Cells["Item"].Value != null && row.Cells["Item"].Value.ToString() == item)
                        {
                            
                            int quantity = int.Parse(row.Cells["Quantity"].Value.ToString());
                            row.Cells["Quantity"].Value = (quantity + 1).ToString();
                            itemExists = true;
                            break;
                        }
                    }

                    if (!itemExists)
                    {
                       
                        this.dgvOrders.Rows.Add(item, price, "1");
                    }

                    
                    CalculateTotalPrice();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CalculateTotalPrice()
        {
            try
            {
                decimal totalPrice = 0;

                foreach (DataGridViewRow row in this.dgvOrders.Rows)
                {
                    if (row.Cells["Price"].Value != null && row.Cells["Quantity"].Value != null)
                    {
                       
                        decimal price = decimal.Parse(row.Cells["Price"].Value.ToString().Trim('$')); 
                        int quantity = int.Parse(row.Cells["Quantity"].Value.ToString());

                      
                        totalPrice += price * quantity;
                    }
                }

                
                this.lblTotalPrice.Text = "৳ " + totalPrice.ToString("F2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error calculating total price: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvOrders_DoubleClick(object sender, EventArgs e)
        {

        }

        private void dgvOrders_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                   
                    DataGridViewRow row = this.dgvOrders.Rows[e.RowIndex];
                    string item = row.Cells["Item"].Value.ToString();
                    string price = row.Cells["Price"].Value.ToString();
                    string quantity = row.Cells["Quantity"].Value.ToString();

                   
                    DialogResult result = MessageBox.Show(
                "Do you want to delete this item? Click Yes to Delete.",
                "Remove",
                        MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Question);

                    if (result == DialogResult.OK) 
                    {
                        
                        this.dgvOrders.Rows.RemoveAt(e.RowIndex);

                       
                        CalculateTotalPrice();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                this.dgvOrders.Rows.Clear();
                this.lblTotalPrice.Text = "৳ 0.00";
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured, please check: ", MessageBoxIcon.Warning + ex.Message);
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            try
            {
                
                DialogResult result = MessageBox.Show("Are you sure you want to Logout?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    this.Close();
                    new Home().Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while trying to exit: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {

                if (this.dgvOrders.Rows.Count == 0)
                {
                    MessageBox.Show("No items selected. Please add items to the order.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int tableNumber;
                if (this.cmbTables.Text == null || !int.TryParse(this.cmbTables.Text.ToString(), out tableNumber))
                {
                    MessageBox.Show("Please select a valid table number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                decimal totalPrice;
                if (string.IsNullOrWhiteSpace(this.lblTotalPrice.Text) || !decimal.TryParse(this.lblTotalPrice.Text.Replace("৳", "").Trim(), out totalPrice))
                {
                    MessageBox.Show("Total price is not valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string sql = $@"INSERT INTO Orders (TableNumber, TotalPrice, OrderDate) 
                        OUTPUT INSERTED.OrderID
                        VALUES ({tableNumber}, {totalPrice}, GETDATE());";
                int orderId = this.da.ExecuteInsertQueryWithOutput(sql);

                foreach (DataGridViewRow row in this.dgvOrders.Rows)
                {
                    if (row.Cells["Item"].Value == null || row.Cells["Price"].Value == null || row.Cells["Quantity"].Value == null)
                    {
                        MessageBox.Show("Invalid order item details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string item = row.Cells["Item"].Value.ToString();
                    decimal price;
                    int quantity;

                    if (!decimal.TryParse(row.Cells["Price"].Value.ToString(), out price) || !int.TryParse(row.Cells["Quantity"].Value.ToString(), out quantity))
                    {
                        MessageBox.Show("Invalid price or quantity in order items.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string itemSql = $@"INSERT INTO OrderItems (OrderID, ItemName, Price, Quantity)
                                VALUES ({orderId}, '{item}', {price}, {quantity});";
                    this.da.ExecuteDMLQuery(itemSql);
                }

                MessageBox.Show("Order has been saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                new Payment(orderId, totalPrice,this).Show();
                this.Hide();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Order_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Application.Exit();
        }
    }
}
