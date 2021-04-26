using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace QualityLeague
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected string value { get; set; }
        string msg;
        protected string dropdown { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            

             msg = Request["msg"];
             value = msg;
            dropdown = DropDownList1.SelectedValue;
            
            try
            {
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["QualityConnection"].ConnectionString);
                conn.Open();
                string select = "select Name from PlayerTable where TeamName = '" + msg + "'";

                SqlDataAdapter adpt = new SqlDataAdapter(select, conn);
                DataTable dt = new DataTable();
                adpt.Fill(dt);
                DropDownList1.DataSource = dt;
                DropDownList1.DataBind();
                DropDownList1.DataTextField = "Name";
                DropDownList1.DataValueField = "Name";
                DropDownList1.DataBind();
                conn.Close();
            }
            catch (Exception ex)
            {
                Response.Write("error" + ex.ToString());
            }

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        protected void Button1_Click(object sender, ImageClickEventArgs e)
        {  

            try
            {
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["QualityConnection"].ConnectionString);
                conn.Open();
                string select = "select Name from PlayerTable where TeamName = '" + DropDownList2.SelectedValue + "'";              

                SqlDataAdapter adpt = new SqlDataAdapter(select, conn);
                DataTable dt = new DataTable();
                adpt.Fill(dt);
                DropDownList3.DataSource = dt;
                DropDownList3.DataBind();
                DropDownList3.DataTextField = "Name";
                DropDownList3.DataValueField = "Name";
                DropDownList3.DataBind();
                conn.Close();

                
            }
            catch (Exception ex)
            {
                Response.Write("error" + ex.ToString());
            }
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            //Valid Button 1. Add 50 points to Asspociate who asked the question
            try
            {
                SqlCommand cmd;
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["QualityConnection"].ConnectionString);
                conn.Open();

                //fetch old value
                string getPlayerData = "select PlayerScore from PlayerTable where Name = '" + DropDownList3.SelectedValue + "'";
                cmd = new SqlCommand(getPlayerData, conn);
                int oldValue = Convert.ToInt32(cmd.ExecuteScalar());
               
                //update new value
                int newValue = oldValue + 50;
                string update = "update PlayerTable set PlayerScore = '" + newValue + "' where Name =  '" + DropDownList3.SelectedValue + "'";
                cmd = new SqlCommand(update, conn);
             
                cmd.ExecuteNonQuery();
                conn.Close();
                GridView1.DataBind();
                GridView2.DataBind();

            }
            catch (Exception ex)
            {
                Response.Write("error" + ex.ToString());
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd;
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["QualityConnection"].ConnectionString);
                conn.Open();

                //fetch old value
                string getTeamData = "select Score from TeamTable where TeamName = '" + DropDownList2.SelectedValue + "'";
                cmd = new SqlCommand(getTeamData, conn);
                int oldValue = Convert.ToInt32(cmd.ExecuteScalar());

                //update new value
                int newValue = oldValue - 50;
                string update = "update TeamTable set Score = '" + newValue + "' where TeamName =  '" + DropDownList2.SelectedValue + "'";
                cmd = new SqlCommand(update, conn);

                cmd.ExecuteNonQuery();
                conn.Close();
                GridView1.DataBind();
                GridView2.DataBind();

            }
            catch (Exception ex)
            {
                Response.Write("error" + ex.ToString());
            }
        }

        protected void Button3_Click1(object sender, EventArgs e)
        {

            int addedValue = 0;
            //correct answer 1. Add 100 to Home Team
            try
            {
                SqlCommand cmd;
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["QualityConnection"].ConnectionString);
                conn.Open();

                //setting value of count
                string updatecount = "update PlayerTable set Cnt = 1 where TeamName= '" + msg + "' AND Name = '" + dropdown + "'";
                cmd = new SqlCommand(updatecount, conn);
                cmd.ExecuteNonQuery();

                //check whtrher he is a CF member or not
                string getPlayerData = "select CF from PlayerTable where Name = '" + dropdown + "'";
                cmd = new SqlCommand(getPlayerData, conn);
                int cfVALUE = Convert.ToInt32(cmd.ExecuteScalar());

                if (cfVALUE == 1)
                {
                    addedValue = 200;
                }
                else
                    addedValue = 100;

                //fetch old value

                string getTeamData = "select Score from TeamTable where TeamName = '" + msg + "'";
                cmd = new SqlCommand(getTeamData, conn);
                int oldValue = Convert.ToInt32(cmd.ExecuteScalar());

                //update new value
                int newValue = oldValue + addedValue;

                string update = "update TeamTable set Score = '" + newValue + "' where TeamName =  '" + msg + "'";
                cmd = new SqlCommand(update, conn);

                cmd.ExecuteNonQuery();
                conn.Close();
                GridView1.DataBind();
                GridView2.DataBind();

            }
            catch (Exception ex)
            {
                Response.Write("error" + ex.ToString());
            }

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            // Adding 100 points to the question asked team and subtracting 100 from home team (Incorrect button)


            try
            {
                SqlCommand cmd;
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["QualityConnection"].ConnectionString);
                conn.Open();

                //setting value of count
                string updatecount = "update PlayerTable set Cnt = 1 where TeamName= '" + msg + "' AND Name = '" + dropdown + "'";
                cmd = new SqlCommand(updatecount, conn);
                cmd.ExecuteNonQuery();

                //homeValue
                string getHomeData = "select Score from TeamTable where TeamName = '" + msg + "'";
                cmd = new SqlCommand(getHomeData, conn);
                int homeValue = Convert.ToInt32(cmd.ExecuteScalar());


                //get Question Asked TEam value
                string getVisitorData = "select Score from TeamTable where TeamName = '" + DropDownList2.SelectedValue + "'";
                cmd = new SqlCommand(getVisitorData, conn);
                int visitorValue = Convert.ToInt32(cmd.ExecuteScalar());


                int newHome = homeValue - 100;
                int newVisitor = visitorValue + 100;

                
                
                //update home score
                string update = "update TeamTable set Score = '" + newHome + "' where TeamName =  '" + msg + "'";
                cmd = new SqlCommand(update, conn);
                cmd.ExecuteNonQuery();


                //update visitor score

                string updateVisitor = "update TeamTable set Score = '" + newVisitor + "' where TeamName =  '" + DropDownList2.SelectedValue + "'";
                cmd = new SqlCommand(updateVisitor, conn);
                cmd.ExecuteNonQuery();

                conn.Close();
                GridView1.DataBind();
                GridView2.DataBind();

            }
            catch (Exception ex)
            {
                Response.Write("error" + ex.ToString());
            }

        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            myModal.Style.Add("display", "block");
            try
            {
                SqlCommand cmd;
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["QualityConnection"].ConnectionString);
                conn.Open();


                string query = "select COUNT(*) from PlayerTable where TeamName = '" + msg + "' AND Cnt = 0";
                cmd = new SqlCommand(query, conn);
                int cntvalue = Convert.ToInt32(cmd.ExecuteScalar());

                if (cntvalue != 0)

                {
                    string getoldvalue = "select Score from TeamTable where TeamName = '" + msg + "'";
                    cmd = new SqlCommand(getoldvalue, conn);
                    int oldvalue = Convert.ToInt32(cmd.ExecuteScalar());

                    int updatevalue = oldvalue - (cntvalue*500);
                    string update = "update TeamTable set Score = '" + updatevalue + "' where TeamName =  '" + msg + "'";
                    cmd = new SqlCommand(update, conn);

                    cmd.ExecuteNonQuery();
                    conn.Close();


                }
                

            }
            catch (Exception ex)
            {
                Response.Write("error" + ex.ToString());
            }


        }
        protected void onCrossClicked(object sender, EventArgs e)
        {
            myModal.Style.Add("display", "none");
            GridView1.DataBind();
            GridView2.DataBind();
        }
        protected void onSubmitClicked(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd;
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["QualityConnection"].ConnectionString);
                conn.Open();


                string getHomeData = "select Score from TeamTable where TeamName = '" + msg + "'";
                cmd = new SqlCommand(getHomeData, conn);
                int homeValue = Convert.ToInt32(cmd.ExecuteScalar());

                string select = "insert into Feedback(TeamName,Feedback,SDMScore) values(@a,@b,@c)";
                cmd = new SqlCommand(select, conn);
                cmd.Parameters.AddWithValue("@a", msg);
                cmd.Parameters.AddWithValue("@b", TextBox1.Text);
                cmd.Parameters.AddWithValue("@c", TextBox2.Text);
                cmd.ExecuteNonQuery();


                int newValue = homeValue + Convert.ToInt32(TextBox2.Text);

                string update = "update TeamTable set Score = '" + newValue + "' where TeamName =  '" + msg + "'";
                cmd = new SqlCommand(update, conn);

                cmd.ExecuteNonQuery();
                conn.Close();
                myModal.Style.Add("display", "none");
                GridView1.DataBind();
                GridView2.DataBind();


            }
            catch (Exception ex)
            {
                Response.Write("error" + ex.ToString());
            }
        }

     /* protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            try
            {
                SqlCommand cmd;
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["QualityConnection"].ConnectionString);
                conn.Open();

               


                for (int i = 0; i < GridView1.Rows.Count; i++)
                {
                    string getData = "select Score from TeamTable where TeamName = '" + msg + "'";
                    cmd = new SqlCommand(getData, conn);
                    int oldval = Convert.ToInt32(cmd.ExecuteScalar());
                    int newval = Convert.ToInt32(GridView1.Rows[i].Cells[1].Text);
                    if (newval!=oldval)
                    { 
                           GridView1.Rows[i].BackColor = Color.Yellow;
                    }

                }

                

            }
            catch (Exception ex)
            {
                Response.Write("error" + ex.ToString());
            }
           
           
           

        } */


    }
}