using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QualityLeague
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected string dropdownvalue { get; set; }
    


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
         
        }

        protected void Button1_Click(object sender, ImageClickEventArgs e)
        {
            dropdownvalue = DropDownList1.SelectedValue.ToString();
           
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            int count = 0;
           
           
            if (DropDownList1.SelectedValue == "The FRONTLINE")
            {
                
                if(CheckBox9.Checked == false)
                {
                    count++;
                }
                if(CheckBox10.Checked == false)
                {
                    count++;
                }
                if (CheckBox11.Checked == false)
                {
                    count++;
                }
                if (CheckBox12.Checked == false)
                {
                    count++;
                }
                if (CheckBox13.Checked == false)
                {
                    count++;
                }
                if (CheckBox28.Checked == false)
                {
                    count++;
                }
                if (CheckBox29.Checked == false)
                {
                    count++;
                }
                if (CheckBox36.Checked == false)
                {
                    count++;
                }
                 if (CheckBox37.Checked == false)
                {
                    count++;
                }
                if (CheckBox38.Checked == false)
                {
                    count++;
                }
               

            }
            else if(DropDownList1.SelectedValue == "Perfect Strikers")
            {
                if (CheckBox14.Checked == false)
                {
                    count++;
                }
                if (CheckBox15.Checked == false)
                {
                    count++;
                }
                if (CheckBox16.Checked == false)
                {
                    count++;
                }
                if (CheckBox39.Checked == false)
                {
                    count++;
                }
                if (CheckBox40.Checked == false)
                {
                    count++;
                }
                if (CheckBox41.Checked == false)
                {
                    count++;
                }
                if (CheckBox42.Checked == false)
                {
                    count++;
                }

            }
            else if(DropDownList1.SelectedValue == "Conquerors")
            {
                if (CheckBox17.Checked == false)
                {
                    count++;
                }
                if (CheckBox18.Checked == false)
                {
                    count++;
                }
                if (CheckBox19.Checked == false)
                {
                    count++;
                }
                if (CheckBox20.Checked == false)
                {
                    count++;
                }
                if (CheckBox21.Checked == false)
                {
                    count++;
                }
                if (CheckBox22.Checked == false)
                {
                    count++;
                }
                if (CheckBox43.Checked == false)
                {
                    count++;
                }
                if (CheckBox44.Checked == false)
                {
                    count++;
                }
                if (CheckBox45.Checked == false)
                {
                    count++;
                }
                if (CheckBox46.Checked == false)
                {
                    count++;
                }
                if (CheckBox47.Checked == false)
                {
                    count++;
                }
            }

            else if (DropDownList1.SelectedValue == "Immortal CAT")
            {
                if (CheckBox1.Checked == false)
                {
                    count++;
                }
                if (CheckBox2.Checked == false)
                {
                    count++;
                }
                if (CheckBox3.Checked == false)
                {
                    count++;
                }
                if (CheckBox4.Checked == false)
                {
                    count++;
                }
                if (CheckBox5.Checked == false)
                {
                    count++;
                }
                if (CheckBox6.Checked == false)
                {
                    count++;
                }
                if (CheckBox7.Checked == false)
                {
                    count++;
                }
                if (CheckBox8.Checked == false)
                {
                    count++;
                }
                if (CheckBox26.Checked == false)
                {
                    count++;
                }
                if (CheckBox27.Checked == false)
                {
                    count++;
                }
               
                if (CheckBox30.Checked == false)
                {
                    count++;
                }
                if (CheckBox31.Checked == false)
                {
                    count++;
                }
                if (CheckBox32.Checked == false)
                {
                    count++;
                }
                if (CheckBox33.Checked == false)
                {
                    count++;
                }
                if (CheckBox34.Checked == false)
                {
                    count++;
                }
                if (CheckBox35.Checked == false)
                {
                    count++;
                }
            }

            else if (DropDownList1.SelectedValue == "DOVE")
            {
                if (CheckBox23.Checked == false)
                {
                    count++;
                }
                if (CheckBox24.Checked == false)
                {
                    count++;
                }
                if (CheckBox25.Checked == false)
                {
                    count++;
                }
                if (CheckBox48.Checked == false)
                {
                    count++;
                }
                if (CheckBox49.Checked == false)
                {
                    count++;
                }
                if (CheckBox50.Checked == false)
                {
                    count++;
                }
                if (CheckBox51.Checked == false)
                {
                    count++;
                }
                if (CheckBox52.Checked == false)
                {
                    count++;
                }
                if (CheckBox53.Checked == false)
                {
                    count++;
                }
               
            }
            try
            {

                SqlCommand cmd;
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["QualityConnection"].ConnectionString);
                conn.Open();


                int points = count * 500;
               
                    //old value
                string select = "select Score from TeamTable where TeamName = '" + DropDownList1.SelectedValue + "'";
                cmd = new SqlCommand(select, conn);
                int oldValue = Convert.ToInt32(cmd.ExecuteScalar());

                int newValue = oldValue - points;

                //update value 

                string update = "update TeamTable set Score = '" + newValue + "' where TeamName =  '" + DropDownList1.SelectedValue + "'";

                cmd = new SqlCommand(update, conn);

                cmd.ExecuteNonQuery();
                conn.Close();
                Response.Redirect("WebForm3.aspx?msg=" + DropDownList1.SelectedValue + "");
            }
            catch (Exception ex)
            {
                Response.Write("error" + ex.ToString());
            }


        }

    }
}