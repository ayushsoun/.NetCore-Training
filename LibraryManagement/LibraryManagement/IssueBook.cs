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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace LibraryManagement
{
    public partial class IssueBook : Form
    {
        public IssueBook()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Your data will not be saved", "Are you sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtDepart.Text != "" && txtBookName.Text != ""
                && txtSemester.Text != "" && txtContact.Text != "" && txtEmail.Text != "" && dateTimePicker1.Text !="")
            {
                String name = txtName.Text;
                String dep = txtDepart.Text;
                String bookName = txtBookName.Text;
                String sem = txtSemester.Text;
                Int64 contact = Convert.ToInt64(txtContact.Text);
                String email = txtEmail.Text;
                String date = dateTimePicker1.Text;

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = ";
                SqlCommand cmd = con.CreateCommand();
                cmd.Connection = con;

                cmd.CommandText = "insert into NewBook (name, dep, bookName, sem, contact, email,date) values(" + name + "" + dep
                    + "" + sem + "" + contact + "" + email + "" + date +")";
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Data Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Empty Fields not allowed", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtContact_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDepartment_TextChanged(object sender, EventArgs e)
        {

        }

        private void IssueBook_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = ";
            SqlCommand cmd = con.CreateCommand();
            cmd.Connection = con;

            con.Open();
            cmd = new SqlCommand("Select bname from NewBook", con );
            SqlDataReader sdr = cmd.ExecuteReader();

            while (sdr.Read()) {
                for(int i=0; i < sdr.FieldCount; i++)
                {
                    txtBookName.Items.Add(sdr.GetString(i));
                }
            }
            sdr.Close();
            con.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(txtEnrollment.Text != "") 
            {
                String eid = txtEnrollment.Text;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = ";
                SqlCommand cmd = con.CreateCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from NewStudent where enroll = " + eid + "'";
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);

                if (ds.Tables[0].Rows.Count != 0)
                {
                    txtName.Text= ds.Tables[0].Rows[0][1].ToString();
                    txtDepart.Text = ds.Tables[0].Rows[0][2].ToString();
                    txtSemester.Text = ds.Tables[0].Rows[0][3].ToString();
                    txtContact.Text = ds.Tables[0].Rows[0][4].ToString();
                    txtEmail.Text = ds.Tables[0].Rows[0][5].ToString();
                }
                else
                {
                    txtName.Clear();
                    txtDepart.Clear();
                    txtSemester.Clear();
                    txtContact.Clear();
                    txtEmail.Clear();
                    MessageBox.Show("Ivalid Enrollment Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
