using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace kumar
{
    public partial class register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btn_register(object sender,EventArgs e)
        {
            string name = txt_name.Value;
            string email = txt_email.Value;
            string password = txt_password.Value;
            int result = 0;
            if (name==""|| email=="" || password=="")
            {
                if (name == "")
                {

                    txt_label.InnerText = "please enter name";
                }
                else if (email == "")
                {

                    txt_label.InnerText = "please enter email";
                }
                else
                {

                    txt_label.InnerText = "please enter password";
                }
            }
            else {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=kumar;");

            con.Open();

            SqlCommand cmd1 = new SqlCommand("select count(email) from users where email='"+ email +"'",con);
                result = (int)cmd1.ExecuteScalar();
                    if (result > 0)
                {
                    txt_label.InnerText = "Already Exist";
                }
                else { 
            SqlCommand cmd = new SqlCommand("insert into users values(@name,@email,@pass)", con);

            cmd.Parameters.AddWithValue("@name", txt_name.Value);
            cmd.Parameters.AddWithValue("@email", txt_email.Value);
            cmd.Parameters.AddWithValue("@pass", txt_password.Value);

            cmd.ExecuteNonQuery();
            con.Close();

            txt_label.InnerText = "Success";

            }
            }

        }
    }
}