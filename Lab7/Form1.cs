using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-HMQ84RV\SQLEXPRESS;Initial Catalog=Lab;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string query = "insert into Registration (ID, Name, Password) values ('"+textBoxID.Text+ "','"+textBoxName.Text+ "','"+textBoxPass.Text+"')";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();

            Details r = new Details();
            r.Visible = true;
            this.Hide();
                
        }
    }
}
