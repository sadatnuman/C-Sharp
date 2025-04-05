using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms.VisualStyles;

namespace RestaurantManagementSystem
{
    public partial class SalesReport : Form
    {
        private AccessData Da { get; set; }
        public SalesReport()
        {

                InitializeComponent();
                this.Da = new AccessData();
                this.Revenue();
                this.UpdateTotalOrders();   


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Revenue(string sql= "select SUM(AmountPaid) as Revenue from Sales")
        {
            try
            {
                
                var ds = this.Da.ExecuteQuery(sql);

                
                if (ds.Tables[0].Rows.Count > 0)
                {
                    
                    var revenue = ds.Tables[0].Rows[0]["Revenue"];
                    this.lblRevenue.Text = "৳ "+ revenue.ToString();
                }
                else
                {
                    
                    this.lblRevenue.Text = "৳ 0.00";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured, please check: ", MessageBoxIcon.Warning + ex.Message);
            }
        }

        private void LoadSalesData(string sql = @"SELECT PaymentDate, SUM(AmountPaid) AS TotalAmount
                                          FROM Sales
                                          GROUP BY PaymentDate
                                          ORDER BY PaymentDate;")
        {
            try
            {

                var ds = this.Da.ExecuteQuery(sql);
                if (ds.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("No sales data available to display.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                chartSales.DataSource = ds.Tables[0];
                chartSales.Series.Clear();

                
                chartSales.ChartAreas[0].AxisX.Title = "Date";
                chartSales.ChartAreas[0].AxisY.Title = "Total Sales (৳)";
                chartSales.Titles.Clear();
                chartSales.Titles.Add("Sales Report");

                
                var series = new Series("Total Sales")
                {
                    XValueMember = "PaymentDate", 
                    YValueMembers = "TotalAmount", 
                    ChartType = SeriesChartType.Column,
                    Color = Color.SkyBlue
                };

                chartSales.Series.Add(series);
                chartSales.DataBind();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading sales data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            try
            {
                this.LoadSalesData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured, please check: ", MessageBoxIcon.Warning + ex.Message);
            }
            
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

        private void UpdateTotalOrders(string sql = "SELECT COUNT(*) AS TotalOrders FROM Sales")
        {
            try
            {
                var ds = this.Da.ExecuteQuery(sql);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    var totalOrders = ds.Tables[0].Rows[0]["TotalOrders"];
                    this.lblOrders.Text = totalOrders.ToString();
                }
                else
                {
                    this.lblOrders.Text = "0";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving total orders: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadPaymentMethods(string sql = @"SELECT PaymentMethod, COUNT(*) AS UsageCount
                                               FROM Sales
                                               GROUP BY PaymentMethod
                                               ORDER BY UsageCount DESC;")
        {
            try
            {
                var ds = this.Da.ExecuteQuery(sql);

                if (ds.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("No payment method data available.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                chartSales.DataSource = ds.Tables[0];
                chartSales.Series.Clear();

                chartSales.ChartAreas[0].AxisX.Title = "Payment Method";
                chartSales.ChartAreas[0].AxisY.Title = "Usage Count";
                chartSales.Titles.Clear();
                chartSales.Titles.Add("Payment Methods Used");

                var series = new Series("Payment Methods")
                {
                    XValueMember = "PaymentMethod",
                    YValueMembers = "UsageCount",
                    ChartType = SeriesChartType.Pie
                };

                chartSales.Series.Add(series);
                chartSales.DataBind();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading payment methods data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPaymentMethods_Click(object sender, EventArgs e)
        {
            try
            {
                this.LoadPaymentMethods();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured, please check: ", MessageBoxIcon.Warning + ex.Message);
            }
             
        }

        private void LoadOrdersTrend(string sql = @"SELECT OrderDate, COUNT(*) AS TotalOrders
                                            FROM Orders
                                            GROUP BY OrderDate
                                            ORDER BY OrderDate;")
        {
            try
            {
                var ds = this.Da.ExecuteQuery(sql);

                if (ds.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("No orders trend data available.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                chartSales.DataSource = ds.Tables[0];
                chartSales.Series.Clear();

                chartSales.ChartAreas[0].AxisX.Title = "Date";
                chartSales.ChartAreas[0].AxisY.Title = "Number of Orders";
                chartSales.Titles.Clear();
                chartSales.Titles.Add("Orders Trend");

                var series = new Series("Orders Trend")
                {
                    XValueMember = "OrderDate",
                    YValueMembers = "TotalOrders",
                    ChartType = SeriesChartType.Line,
                    Color = Color.DodgerBlue,
                    BorderWidth = 2
                };

                chartSales.Series.Add(series);
                chartSales.DataBind();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading orders trend data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnOrders_Click(object sender, EventArgs e)
        {
            try
            {
                this.LoadOrdersTrend();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured, please check: ", MessageBoxIcon.Warning + ex.Message);
            }
            
        }

        private void SalesReport_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
