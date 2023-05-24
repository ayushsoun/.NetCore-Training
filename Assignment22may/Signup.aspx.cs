using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoginSignUp
{
    public partial class Signup : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source"); 
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "insert into registration values(" + txtFname + "" + txtLname + "" + txtEmail
                + "" + txtAge + "" + txtCity + "" + txtGender + ")";
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}