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
    public partial class AddBooks : Form
    {
        public AddBooks()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Your data will not be saved", "Are you sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (textBookName.Text != "" && textAuthorName.Text != "" && textPublication.Text != ""
                && dateTimePicker1.Text != "" && textPrice.Text != "" && textQuant.Text != "")
            {
                string bName = textBookName.Text;
                string bAuthor = textAuthorName.Text;
                string bPublication = textPublication.Text;
                string bDate = dateTimePicker1.Text;
                Int64 bprice = Int64.Parse(textPrice.Text);
                Int64 bquantity = Int64.Parse(textQuant.Text);

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data = ";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                con.Open();
                cmd.CommandText = "insert into NewBook (bName, bAuthor, bPublication, bDate, bPrice, bQuantity) values("+bName+""+bAuthor"+
                    +bPublication+""+bDate+""+bprice+""+bquantity+")";
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Data Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                textBookName.Clear();
                textAuthorName.Clear();
                textPublication.Clear();
                dateTimePicker1.ResetText();
                textPrice.Clear();
                textQuant.Clear();

            }
            else
            {
                MessageBox.Show("Empty Fields not allowed", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
