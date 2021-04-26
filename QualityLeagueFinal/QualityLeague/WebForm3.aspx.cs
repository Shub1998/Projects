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
        string team1 = "DOVE";
        string team2 = "Conquerors";
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

                string select = "select Name from PlayerTable where TeamName ='" + team1 + "'";
                string select1 = "select Name from PlayerTable where TeamName ='" + team2 + "'";
                SqlDataAdapter adpt = new SqlDataAdapter(select, conn);

                SqlDataAdapter adpt1 = new SqlDataAdapter(select1, conn);


                DataTable dt1 = new DataTable();

                adpt1.Fill(dt1);

                DataTable dt = new DataTable();
                adpt.Fill(dt);


                DropDownList1.DataSource = dt;
                DropDownList1.DataBind();
                DropDownList1.DataTextField = "Name";
                DropDownList1.DataValueField = "Name";
                DropDownList1.DataBind();

                DropDownList4.DataSource = dt1;
                DropDownList4.DataBind();
                DropDownList4.DataTextField = "Name";
                DropDownList4.DataValueField = "Name";
                DropDownList4.DataBind();

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
        protected void Button2_Click1(object sender, ImageClickEventArgs e)
        {

            try
            {
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["QualityConnection"].ConnectionString);
                conn.Open();
                string select = "select Name from PlayerTable where TeamName = '" + DropDownList5.SelectedValue + "'";

                SqlDataAdapter adpt = new SqlDataAdapter(select, conn);
                DataTable dt = new DataTable();
                adpt.Fill(dt);
                DropDownList6.DataSource = dt;
                DropDownList6.DataBind();
                DropDownList6.DataTextField = "Name";
                DropDownList6.DataValueField = "Name";
                DropDownList6.DataBind();
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
                string getPlayerData = "select Score from TeamTable where TeamName = '" + DropDownList2.SelectedValue + "'";
                cmd = new SqlCommand(getPlayerData, conn);
                int oldValue = Convert.ToInt32(cmd.ExecuteScalar());
               
                //update new value
                int newValue = oldValue + 100;
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

        protected void Button7_Click(object sender, EventArgs e)
        {
            //Valid Button 1. Add 50 points to Asspociate who asked the question
            try
            {
                SqlCommand cmd;
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["QualityConnection"].ConnectionString);
                conn.Open();

                //fetch old value
                string getPlayerData = "select Score from TeamTable where TeamName = '" + DropDownList2.SelectedValue + "'";
                cmd = new SqlCommand(getPlayerData, conn);
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

        protected void Button8_Click(object sender, EventArgs e)
        {
            //Valid Button 1. Add 50 points to Asspociate who asked the question
            try
            {
                SqlCommand cmd;
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["QualityConnection"].ConnectionString);
                conn.Open();

                //fetch old value
                string getPlayerData = "select Score from TeamTable where TeamName = '" + team1 + "'";
                cmd = new SqlCommand(getPlayerData, conn);
                int oldValue = Convert.ToInt32(cmd.ExecuteScalar());

                //update new value
                int newValue = oldValue - 50;
                string update = "update TeamTable set Score = '" + newValue + "' where TeamName =  '" + team1 + "'";
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
                string getTeamData = "select Score from TeamTable where TeamName = '" + team1 + "'";
                cmd = new SqlCommand(getTeamData, conn);
                int oldValue = Convert.ToInt32(cmd.ExecuteScalar());

                //update new value
                int newValue = oldValue+200;
                string update = "update TeamTable set Score = '" + newValue + "' where TeamName =  '" + team1 + "'";
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
                string updatecount = "update PlayerTable set Cnt = 1 where TeamName= '" + team1 + "' AND Name = '" + dropdown + "'";
                cmd = new SqlCommand(updatecount, conn);
                cmd.ExecuteNonQuery();

                //check whtrher he is a CF member or not
                string getPlayerData = "select CF from PlayerTable where Name = '" + dropdown + "'";
                cmd = new SqlCommand(getPlayerData, conn);
                int cfVALUE = Convert.ToInt32(cmd.ExecuteScalar());

                if (cfVALUE == 1)
                {
                    addedValue = 100;
                }
                else
                    addedValue = 100;

                //fetch old value

                string getTeamData = "select Score from TeamTable where TeamName = '" + team1 + "'";
                cmd = new SqlCommand(getTeamData, conn);
                int oldValue = Convert.ToInt32(cmd.ExecuteScalar());

                //update new value
                int newValue = oldValue + addedValue;

                string update = "update TeamTable set Score = '" + newValue + "' where TeamName =  '" + team1 + "'";
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
                string updatecount = "update PlayerTable set Cnt = 1 where TeamName= '" + team1 + "' AND Name = '" + dropdown + "'";
                cmd = new SqlCommand(updatecount, conn);
                cmd.ExecuteNonQuery();

                //homeValue
                string getHomeData = "select Score from TeamTable where TeamName = '" + team1 + "'";
                cmd = new SqlCommand(getHomeData, conn);
                int homeValue = Convert.ToInt32(cmd.ExecuteScalar());


                //get Question Asked TEam value
                string getVisitorData = "select Score from TeamTable where TeamName = '" + DropDownList2.SelectedValue + "'";
                cmd = new SqlCommand(getVisitorData, conn);
                int visitorValue = Convert.ToInt32(cmd.ExecuteScalar());


               // int newHome = homeValue - 100;
                int newVisitor = visitorValue + 200;

                
                
              /*  //update home score
                string update = "update TeamTable set Score = '" + newHome + "' where TeamName =  '" + msg + "'";
                cmd = new SqlCommand(update, conn);
                cmd.ExecuteNonQuery();*/


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


                string query = "select COUNT(*) from PlayerTable where TeamName = '" + team1 + "' AND Cnt = 0";
                cmd = new SqlCommand(query, conn);
                int cntvalue = Convert.ToInt32(cmd.ExecuteScalar());

              

                if (cntvalue != 0)

                {
                    string getoldvalue = "select Score from TeamTable where TeamName = '" + team1 + "'";
                    cmd = new SqlCommand(getoldvalue, conn);
                    int oldvalue = Convert.ToInt32(cmd.ExecuteScalar());

                    int updatevalue = oldvalue - (cntvalue*100);
                    string update = "update TeamTable set Score = '" + updatevalue + "' where TeamName =  '" + team1 + "'";
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


                string getHomeData = "select Score from TeamTable where TeamName = '" + DropDownList7.SelectedValue + "'";
                cmd = new SqlCommand(getHomeData, conn);
                int homeValue = Convert.ToInt32(cmd.ExecuteScalar());

               


                int newValue = homeValue + Convert.ToInt32(TextBox2.Text);

                string update = "update TeamTable set Score = '" + newValue + "' where TeamName =  '" +DropDownList7.SelectedValue + "'";
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
        protected void Button11_Click(object sender, EventArgs e)
        {
            //Valid Button 1. Add 50 points to Asspociate who asked the question
            try
            {
                SqlCommand cmd;
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["QualityConnection"].ConnectionString);
                conn.Open();

                //fetch old value
                string getPlayerData = "select Score from TeamTable where TeamName = '" + team2 + "'";
                cmd = new SqlCommand(getPlayerData, conn);
                int oldValue = Convert.ToInt32(cmd.ExecuteScalar());

                //update new value
                int newValue = oldValue - 50;
                string update = "update TeamTable set Score = '" + newValue + "' where TeamName =  '" + team2 + "'";
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

        protected void Button9_Click1(object sender, EventArgs e)
        {

            int addedValue = 0;
            //correct answer 1. Add 100 to Home Team
            try
            {
                SqlCommand cmd;
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["QualityConnection"].ConnectionString);
                conn.Open();

                //setting value of count
                string updatecount = "update PlayerTable set Cnt = 1 where TeamName= '" + "Conquerors" + "' AND Name = '" + dropdown + "'";
                cmd = new SqlCommand(updatecount, conn);
                cmd.ExecuteNonQuery();

                //check whtrher he is a CF member or not
                string getPlayerData = "select CF from PlayerTable where Name = '" + dropdown + "'";
                cmd = new SqlCommand(getPlayerData, conn);
                int cfVALUE = Convert.ToInt32(cmd.ExecuteScalar());

                if (cfVALUE == 1)
                {
                    addedValue = 100;
                }
                else
                    addedValue = 100;

                //fetch old value

                string getTeamData = "select Score from TeamTable where TeamName = '" + team2 + "'";
                cmd = new SqlCommand(getTeamData, conn);
                int oldValue = Convert.ToInt32(cmd.ExecuteScalar());

                //update new value
                int newValue = oldValue + addedValue;

                string update = "update TeamTable set Score = '" + newValue + "' where TeamName =  '" + team2 + "'";
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

        protected void Button10_Click(object sender, EventArgs e)
        {
            // Adding 100 points to the question asked team and subtracting 100 from home team (Incorrect button)


            try
            {
                SqlCommand cmd;
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["QualityConnection"].ConnectionString);
                conn.Open();

                //setting value of count
                string updatecount = "update PlayerTable set Cnt = 1 where TeamName= '" + team2 + "' AND Name = '" + dropdown + "'";
                cmd = new SqlCommand(updatecount, conn);
                cmd.ExecuteNonQuery();

                //homeValue
                string getHomeData = "select Score from TeamTable where TeamName = '" + team2 + "'";
                cmd = new SqlCommand(getHomeData, conn);
                int homeValue = Convert.ToInt32(cmd.ExecuteScalar());


                //get Question Asked TEam value
                string getVisitorData = "select Score from TeamTable where TeamName = '" + DropDownList5.SelectedValue + "'";
                cmd = new SqlCommand(getVisitorData, conn);
                int visitorValue = Convert.ToInt32(cmd.ExecuteScalar());


                // int newHome = homeValue - 100;
                int newVisitor = visitorValue + 200;



                /*  //update home score
                  string update = "update TeamTable set Score = '" + newHome + "' where TeamName =  '" + msg + "'";
                  cmd = new SqlCommand(update, conn);
                  cmd.ExecuteNonQuery();*/


                //update visitor score

                string updateVisitor = "update TeamTable set Score = '" + newVisitor + "' where TeamName =  '" + DropDownList5.SelectedValue + "'";
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

        protected void Button12_Click1(object sender, EventArgs e)
        {
            //Valid Button 1. Add 50 points to Asspociate who asked the question
            try
            {
                SqlCommand cmd;
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["QualityConnection"].ConnectionString);
                conn.Open();

                //fetch old value
                string getPlayerData = "select Score from TeamTable where TeamName = '" + DropDownList5.SelectedValue + "'";
                cmd = new SqlCommand(getPlayerData, conn);
                int oldValue = Convert.ToInt32(cmd.ExecuteScalar());

                //update new value
                int newValue = oldValue + 100;
                string update = "update TeamTable set Score = '" + newValue + "' where TeamName =  '" + DropDownList5.SelectedValue + "'";
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

        protected void Button13_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd;
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["QualityConnection"].ConnectionString);
                conn.Open();

                //fetch old value
                string getTeamData = "select Score from TeamTable where TeamName = '" + team2 + "'";
                cmd = new SqlCommand(getTeamData, conn);
                int oldValue = Convert.ToInt32(cmd.ExecuteScalar());

                //update new value
                int newValue = oldValue + 200;
                string update = "update TeamTable set Score = '" + newValue + "' where TeamName =  '" + team2 + "'";
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

        protected void Button14_Click(object sender, EventArgs e)
        {
            //Valid Button 1. Add 50 points to Asspociate who asked the question
            try
            {
                SqlCommand cmd;
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["QualityConnection"].ConnectionString);
                conn.Open();

                //fetch old value
                string getPlayerData = "select Score from TeamTable where TeamName = '" + DropDownList5.SelectedValue + "'";
                cmd = new SqlCommand(getPlayerData, conn);
                int oldValue = Convert.ToInt32(cmd.ExecuteScalar());

                //update new value
                int newValue = oldValue - 50;
                string update = "update TeamTable set Score = '" + newValue + "' where TeamName =  '" + DropDownList5.SelectedValue + "'";
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

        protected void Button15_Click(object sender, EventArgs e)
        {
            //Valid Button 1. Add 50 points to Asspociate who asked the question
            try
            {
                SqlCommand cmd;
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["QualityConnection"].ConnectionString);
                conn.Open();

                //fetch old value
                string getPlayerData = "select Score from TeamTable where TeamName = '" + team1 + "'";
                cmd = new SqlCommand(getPlayerData, conn);
                int oldValue = Convert.ToInt32(cmd.ExecuteScalar());

                string getPlayerData1 = "select Score from TeamTable where TeamName = '" + team2 + "'";
                cmd = new SqlCommand(getPlayerData1, conn);
                int oldValue1 = Convert.ToInt32(cmd.ExecuteScalar());

                //update new value
                int newValue = oldValue +200;
                int newValue1 = oldValue1-200;
                string update = "update TeamTable set Score = '" + newValue + "' where TeamName =  '" + team1 + "'";
                cmd = new SqlCommand(update, conn);

                cmd.ExecuteNonQuery();

                string update1 = "update TeamTable set Score = '" + newValue1 + "' where TeamName =  '" + team2 + "'";
                cmd = new SqlCommand(update1, conn);

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

        protected void Button16_Click(object sender, EventArgs e)
        {
            //Valid Button 1. Add 50 points to Asspociate who asked the question
            try
            {
                SqlCommand cmd;
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["QualityConnection"].ConnectionString);
                conn.Open();

                //fetch old value
                string getPlayerData = "select Score from TeamTable where TeamName = '" + team2 + "'";
                cmd = new SqlCommand(getPlayerData, conn);
                int oldValue = Convert.ToInt32(cmd.ExecuteScalar());

                string getPlayerData1 = "select Score from TeamTable where TeamName = '" + team1 + "'";
                cmd = new SqlCommand(getPlayerData1, conn);
                int oldValue1 = Convert.ToInt32(cmd.ExecuteScalar());

                //update new value
                int newValue = oldValue + 200;
                int newValue1 = oldValue1 - 200;
                string update = "update TeamTable set Score = '" + newValue + "' where TeamName =  '" + team2 + "'";
                cmd = new SqlCommand(update, conn);

                cmd.ExecuteNonQuery();

                string update1 = "update TeamTable set Score = '" + newValue1 + "' where TeamName =  '" + team1 + "'";
                cmd = new SqlCommand(update1, conn);

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
    }
}