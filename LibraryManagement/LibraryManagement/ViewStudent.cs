using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class ViewStudent : Form
    {
        public ViewStudent()
        {
            InitializeComponent();
        }

        private void txtStudent_TextChanged(object sender, EventArgs e)
        {
            if (txtStudent.Text != "")
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = ";
                SqlCommand cmd = con.CreateCommand();
                cmd.Connection = con;

                cmd.CommandText = "Select * from NewBook where bName LIKE" + txtStudent.Text + "%";
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

                cmd.CommandText = "Select * from Student";
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);

                //show table on grid
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        int sId;
        Int64 rowId;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                sId = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                //MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString())
            }
            panel2.Visible = true;

            //make connection
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = ";
            SqlCommand cmd = con.CreateCommand();
            cmd.Connection = con;

            cmd.CommandText = "Select * from Student where bid = " + sId + "";
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);

            rowId = Convert.ToInt64(ds.Tables.[0].Rows[0][0].ToString());
            txtStudentName.Text = ds.Tables[0].Rows[0][1].ToString();
            txtEnrollment.Text = ds.Tables[0].Rows[0][2].ToString();
            txtSemester.Text = ds.Tables[0].Rows[0][3].ToString();
            txtDepartment.Text = ds.Tables[0].Rows[0][4].ToString();
            txtContact.Text = ds.Tables[0].Rows[0][5].ToString();
            txtEmail.Text = ds.Tables[0].Rows[0][6].ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtStudent.Clear();
            panel2.Visible = false;
        }

        private void txtStudentName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data will be Updated. Confirm?", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                String name = txtStudentName.Text;
                String enroll = txtEnrollment.Text;
                String dep = txtDepartment.Text;
                String sem = txtSemester.Text;
                Int64 contact = Convert.ToInt64(txtContact.Text);
                String email = txtEmail.Text;

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = ";
                SqlCommand cmd = con.CreateCommand();
                cmd.Connection = con;

                cmd.CommandText = "Update NewBook set name = " + name + "enroll = " + enroll +
                    " dep = " + dep + "sem = " + sem + "contact" + contact +
                    "email" + email + "where sid = " + rowId + "";
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

                cmd.CommandText = "Delete from Student where sid = " + rowId + "";
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);
            }
        }

        private void ViewStudent_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = ";
            SqlCommand cmd = con.CreateCommand();
            cmd.Connection = con;

            cmd.CommandText = "Select * from Student";
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);

            //show table on grid
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
