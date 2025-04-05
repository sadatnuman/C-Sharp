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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab8
{
    public partial class Details : Form
    {
        public Details()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            string connectionString = @"Data Source=DESKTOP-HMQ84RV\SQLEXPRESS;Initial Catalog=Lab;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string query = "select * from Registration";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            DataTable dt = ds.Tables[0];
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = dt;
            conn.Close();
        }

       


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                MessageBox.Show(id);
                textBoxID.Text = id;
                textBoxName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBoxPass.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            }

        }

        private void Details_Load(object sender, EventArgs e)
        {

            string connectionString = @"Data Source=DESKTOP-HMQ84RV\SQLEXPRESS;Initial Catalog=Lab;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string query = "select * from Registration";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            DataTable dt = ds.Tables[0];
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-HMQ84RV\SQLEXPRESS;Initial Catalog=Lab;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string query = "update Registration set Name='" + textBoxName.Text + "', Password='" + textBoxPass.Text + "' where ID=" + textBoxID.Text;
            SqlCommand cmd = new SqlCommand(query, conn);
            //cmd.ExecuteNonQuery();
            conn.Close();
            textBoxID.Text = textBoxName.Text = textBoxPass.Text = "";
            LoadData();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
