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
    public partial class UserManagement : Form
    {
        private AccessData da {  get; set; }
        public UserManagement()
        {

                InitializeComponent();

                this.da = new AccessData();
                this.PopulateUserGrid();
                this.AutoIdGenerate();



        }

        private void PopulateUserGrid(string sql= "select * from Users ORDER BY UserID;")
        {

            try
            {
                var ds = this.da.ExecuteQuery(sql);
                this.dgvUserList.AutoGenerateColumns = false;
                this.dgvUserList.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured, please check: ", MessageBoxIcon.Warning + ex.Message);
            }

        }

        private void dgvUserList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvUserList_DoubleClick(object sender, EventArgs e)
        {

            try
            {
                this.txtUserID.Text = this.dgvUserList.CurrentRow.Cells["UserID"].Value.ToString();
                this.txtUserName.Text = this.dgvUserList.CurrentRow.Cells["Username"].Value.ToString();
                this.txtPassword.Text = this.dgvUserList.CurrentRow.Cells["Password"].Value.ToString();
                this.cmbRole.Text = this.dgvUserList.CurrentRow.Cells["Role"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured, please check: ", MessageBoxIcon.Warning + ex.Message);
            }
        }

        private void UserManagement_Load(object sender, EventArgs e)
        {

            try
            {
                this.dgvUserList.ClearSelection();
                this.AutoIdGenerate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured, please check: ", MessageBoxIcon.Warning + ex.Message);
            }
        }


        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

            try
            {
                var sql = "select * from Users where Username like '" + this.txtSearch.Text + "%';";
                this.PopulateUserGrid(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured, please check: ", MessageBoxIcon.Warning + ex.Message);
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
                var query = "select * from Users where UserID = '" + this.txtUserID.Text + "'";
                DataTable dt = this.da.ExecuteQueryTable(query);
                if (dt.Rows.Count == 1)
                {
                    //update
                    var sql = @"update Users
                                set Username = " + this.txtUserName.Text + @",
                                Password = " + this.txtPassword.Text + @",
                                Role = '" + this.cmbRole.Text + @"'
                                where UserID = '" + this.txtUserID.Text + "';"; 

                    int count = this.da.ExecuteDMLQuery(sql);

                    if (count == 1)
                        MessageBox.Show("Data has been updated properly");
                    else
                        MessageBox.Show("Data hasn't been updated properly");
                }
                else
                {
                    //insert
                    var sql = "INSERT INTO Users VALUES ('" + this.txtUserID.Text + "', '" + this.txtUserName.Text + "', '" + this.txtPassword.Text + "', '" + this.cmbRole.Text + "');";
                    int count = this.da.ExecuteDMLQuery(sql);

                    if (count == 1)
                        MessageBox.Show("Data has been added properly");
                    else
                        MessageBox.Show("Data hasn't been added properly");
                }

                this.PopulateUserGrid();    
                this.ClearAll();
            }
            catch(Exception exc)
            {
                MessageBox.Show("An error has occured, please check: ", MessageBoxIcon.Warning + exc.Message);

            }
        }
        private bool IsValidToSave()
        {

            if (string.IsNullOrEmpty(this.txtUserID.Text) || string.IsNullOrEmpty(this.txtUserName.Text) ||
string.IsNullOrEmpty(this.txtPassword.Text) ||
string.IsNullOrEmpty(this.cmbRole.Text))
                return false;
            else
                return true;
        }

        private void ClearAll()
        {

            try
            {
                this.txtUserID.Text = "";
                this.txtUserName.Clear();
                this.txtPassword.Clear();
                this.cmbRole.SelectedIndex = -1;
                this.dgvUserList.ClearSelection();
                this.AutoIdGenerate();
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
                if (this.dgvUserList.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Please select a row first to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var userID = this.dgvUserList.CurrentRow.Cells[0].Value.ToString();
                var userName = this.dgvUserList.CurrentRow.Cells[1].Value.ToString();


                DialogResult result = MessageBox.Show("Are you sure you want to delete " + userName + "?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                    return;

                var sql = "delete from Users where UserID = '" + userID + "';";
                var count = this.da.ExecuteDMLQuery(sql);

                if (count == 1)
                    MessageBox.Show(userName.ToUpper() + " has been removed from the list.");
                else
                    MessageBox.Show("Data hasn't been removed properly");

                this.PopulateUserGrid();    
                this.ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured, please check: ", MessageBoxIcon.Warning + exc.Message);
            }
        }
        private void AutoIdGenerate()
        {
            try
            {
                var query = "select max(UserID) from Users;";
                var dt = this.da.ExecuteQueryTable(query);
                var oldId = dt.Rows[0][0].ToString();
                string[] temp = oldId.Split('-');
                var num = Convert.ToInt32(temp[1]);
                var newId = "USR-" + (++num).ToString();
                this.txtUserID.Text = newId;
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



        private void btnLoad_Click(object sender, EventArgs e)
        {
            
            try
            {
                this.PopulateUserGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured, please check: ", MessageBoxIcon.Warning + ex.Message);
            }
        }

        private void UserManagement_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
