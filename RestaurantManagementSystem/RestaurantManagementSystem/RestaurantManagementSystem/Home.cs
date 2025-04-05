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
    public partial class Home : Form
    {
        private AccessData Da { get; set; }
        public Home()
        {

 
                InitializeComponent();
                this.Da = new AccessData();
            

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try 
            {
                if (String.IsNullOrEmpty(this.txtBoxID.Text) || string.IsNullOrEmpty(this.txtBoxPass.Text))
                {
                    MessageBox.Show("Please fill all the empty fields");
                    return;
                }

                string sql = "select * from Users where UserID = '" + this.txtBoxID.Text + "' and Password = '" + this.txtBoxPass.Text + "'";
                var ds = this.Da.ExecuteQuery(sql);
                var name = ds.Tables[0].Rows[0][3].ToString();

                if (ds.Tables[0].Rows.Count == 1)
                {
                    this.Visible = false;
                    if (ds.Tables[0].Rows[0][3].ToString().Equals("Admin"))
                    {

                        new AdminPanel().Show();
                    }
                    else if (ds.Tables[0].Rows[0][3].ToString().Equals("Staff"))
                    {
                        //new FormMember(name, this).Show();
                        new Order().Show();
                    }
                }
                else if(ds.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("Invalid credentials", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception )
            {
                MessageBox.Show("Invalid credentials", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); //
        }

        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
