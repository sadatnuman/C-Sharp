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
    public partial class Payment : Form
    {

        private Order order {  get; set; }
        private int OrderID { get; set; }
        private decimal TotalPrice { get; set; }

        string paymentMethod = "";
        public Payment(int orderId, decimal totalPrice, Order ordr)
        {

                InitializeComponent();
                this.OrderID = orderId;
                this.TotalPrice = totalPrice;
                this.order = ordr;
                this.lblPaymentPrice.Text = $"৳ {totalPrice.ToString("F2")}";
            

        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            try
            {
                decimal totalAmount = decimal.Parse(this.lblPaymentPrice.Text.Replace("৳", "").Trim());
                int orderId = this.OrderID; 



                if (string.IsNullOrEmpty(paymentMethod))
                {
                    MessageBox.Show("Please select a payment method!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string query = @"INSERT INTO Sales (OrderID, AmountPaid, PaymentMethod, PaymentDate) 
                         VALUES (" + orderId + ", " + totalAmount + ", '" + paymentMethod + "', GETDATE());";

                AccessData da = new AccessData();
                int result = da.ExecuteDMLQuery(query);

                if (result > 0)
                {
                    MessageBox.Show("Payment completed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    new Order().Show();
                }
                else
                {
                    MessageBox.Show("Payment failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred during payment processing: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBkash_Click(object sender, EventArgs e)
        {
            try
            {
                paymentMethod = "bKash";
                this.lblPaymentMethod.Text = paymentMethod;

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured, please check: ", MessageBoxIcon.Warning + ex.Message);
            }
        }

        private void btnNagad_Click(object sender, EventArgs e)
        {
            try
            {
                paymentMethod = "Nagad";
                this.lblPaymentMethod.Text = paymentMethod;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured, please check: ", MessageBoxIcon.Warning + ex.Message);
            }
        }

        private void btnCard_Click(object sender, EventArgs e)
        {
            try
            {
                paymentMethod = "Card";
                this.lblPaymentMethod.Text =paymentMethod;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured, please check: ", MessageBoxIcon.Warning + ex.Message);
            }
        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            try
            {
                paymentMethod = "Cash";
                this.lblPaymentMethod.Text = paymentMethod;


            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured, please check: ", MessageBoxIcon.Warning + ex.Message);
            }
        }

        private void Payment_FormClosed(object sender, FormClosedEventArgs e)
        {
             Application.Exit();
        }
    }
}
