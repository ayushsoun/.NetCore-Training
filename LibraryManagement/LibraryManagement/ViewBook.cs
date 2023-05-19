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

namespace LibraryManagement
{
    public partial class ViewBook : Form
    {
        public ViewBook()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(txtBook.Text != "")
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = ";
                SqlCommand cmd = con.CreateCommand();
                cmd.Connection = con;

                cmd.CommandText = "Select * from NewBook where bName LIKE" +txtBook.Text+"%";
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);

                //show table on grid
                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = ";
                SqlCommand cmd = con.CreateCommand();
                cmd.Connection = con;

                cmd.CommandText = "Select * from NewBook";
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);

                //show table on grid
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void ViewBook_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = ";
            SqlCommand cmd = con.CreateCommand();   
            cmd.Connection = con;

            cmd.CommandText = "Select * from NewBook";
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);

            //show table on grid
            dataGridView1.DataSource = ds.Tables[0];
        }

        int bId;
        Int64 rowId;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                bId = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                //MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString())
            }
            panel2.Visible = true;

            //make connection
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = ";
            SqlCommand cmd = con.CreateCommand();
            cmd.Connection = con;

            cmd.CommandText = "Select * from NewBook where bid = "+bId +"";
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);

            rowId = Convert.ToInt64(ds.Tables.[0].Rows[0][0].ToString());
            txtBookName.Text = ds.Tables[0].Rows[0][1].ToString();
            txtAuthorName.Text = ds.Tables[0].Rows[0][2].ToString();
            txtPublication.Text = ds.Tables[0].Rows[0][3].ToString();
            txtPurchaseDate.Text = ds.Tables[0].Rows[0][4].ToString();
            txtBookPrice.Text = ds.Tables[0].Rows[0][5].ToString();
            txtBookQuantity.Text = ds.Tables[0].Rows[0][6].ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panel2.Visible=false;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtBook.Clear();
            panel2.Visible=false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data will be Updated. Confirm?", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                String bName = txtBookName.Text;
                String bAuthor = txtAuthorName.Text;
                String bPublication = txtPublication.Text;
                String bDate = txtPurchaseDate.Text;
                Int64 bPrice = Convert.ToInt64(txtBookPrice.Text);
                Int64 bQuantity = Convert.ToInt64(txtBookQuantity.Text);

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = ";
                SqlCommand cmd = con.CreateCommand();
                cmd.Connection = con;

                cmd.CommandText = "Update NewBook set bname = " + bName + "bauthor = " + bAuthor +
                    " bPublication = " + bPublication + "bDate = " + bDate + "bPrice" + bPrice +
                    "bQuantity" + bQuantity + "where bid = " + rowId + "";
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data will be Deleted. Confirm?", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = ";
                SqlCommand cmd = con.CreateCommand();
                cmd.Connection = con;

                cmd.CommandText = "Delete from NewBook where bid = "+rowId+"";
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);
            }
        }

        private void txtBookName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
