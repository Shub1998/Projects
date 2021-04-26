using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;

using System.Web.UI.WebControls;

namespace WebAuthFinal
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected string value { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            string result = User.Identity.Name;
            string ntid = result.Substring(5);

           

            try
            {
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
                
                string checkuser = "select DISPLAY_NAME from UserList where NT_ID ='"+ ntid + "'";
                SqlCommand cmd = new SqlCommand(checkuser, conn);
                conn.Open();

                Label1.Text = (string)cmd.ExecuteScalar();

                conn.Close();




            }
            catch (Exception ex)
            {
                Response.Write("error" + ex.ToString());
            }


        }
    }
}