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
    public partial class AdminPanel : Form
    {

        public AdminPanel()
        {

                InitializeComponent();
            

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

            try
            {
                this.Hide();
                new Home().Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured, please check: ", MessageBoxIcon.Warning + ex.Message);
            }
        }

        private void btnMenuManage_Click(object sender, EventArgs e)
        {

            try
            {
                this.Hide();
                new MenuManagement().Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured, please check: ", MessageBoxIcon.Warning + ex.Message);
            }
        }

        private void btnUserManagement_Click(object sender, EventArgs e)
        {

            try
            {
                this.Hide();
                new UserManagement().Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured, please check: ", MessageBoxIcon.Warning + ex.Message);
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {

            try
            {
                this.Hide();
                new SalesReport().Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured, please check: ", MessageBoxIcon.Warning + ex.Message);
            }
        }

        private void AdminPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
