using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoginSignUp
{
    public partial class Login : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source");

        private bool ValidateUser(string username, string password)
        {
            string lookupPassword = null;

            //checking for invalid user
            //also username must not be null and is between 1 and 15 chars

            if((null == username) || (0== username.Length) || (username.Length > 15))
            {
                System.Diagnostics.Trace.WriteLine("Username validation failed for input");
                return false;
            }
            
            if((null == password) || (0== password.Length) || (password.Length >25))
            {
                System.Diagnostics.Trace.WriteLine("Password validation failed for input");
                return false;
            }

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select password from users where userName = @userName", con);
                cmd.Parameters.Add("@UserName", SqlDbType.VarChar, 25);
                cmd.Parameters["@UserName"].Value = username;

                //Execute and fetch passsword field into lookUp password string
                //
                lookupPassword = (string)cmd.ExecuteScalar();

                //clean up command and execution 
                cmd.Dispose();
                con.Dispose();
            }
            catch(Exception ex)
            {
                System.Diagnostics.Trace.WriteLine (ex.Message);
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "insert into registration values(" + txtEmailLogin + "" + txtPassword + ")";
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}