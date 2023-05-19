using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void addNewBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isOpen = false;

            foreach(Form f in Application.OpenForms)
            {
                if(f.Text == "AddBooks")
                {
                    isOpen = true;
                    f.BringToFront();
                    break;
                }
            }
            if (isOpen == false)
            {
                AddBooks abs = new AddBooks();
                abs.Show();
            }
        }

        private void viewBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewBook vb = new ViewBook();
            vb.Show();
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "AddStudents")
                {
                    isOpen = true;
                    f.BringToFront();
                    break;
                }
            }
            if (isOpen == false)
            {
                AddStudents astu = new AddStudents();
                astu.Show();
            }
        }

        private void viewStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewStudent vs = new ViewStudent();
            vs.Show();
        }

        private void issueBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IssueBook issueBook = new IssueBook();
            issueBook.Show();
        }
    }
}
