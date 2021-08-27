using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace kumar
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btn_login(object sender, EventArgs e)
        {
            string email = txt_email.Value;
            string password = txt_password.Value;
            int result = 0;
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=kumar;");

            con.Open();

            SqlCommand cmd1 = new SqlCommand("select count(*) from users where email='" + email + "' and pass= '"+ password +"'", con);
            result = (int)cmd1.ExecuteScalar();
            if (result > 0)
            {
                txt_label.InnerText = "Sucess";
                Response.Redirect("profile.aspx");
            }
            else
            {
                txt_label.InnerText = "Invalid";
            }
        }
    }
}