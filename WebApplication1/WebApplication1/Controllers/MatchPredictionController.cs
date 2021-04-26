using QPL.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;

namespace QPL.Controllers
{
    [RoutePrefix("Api/MatchPredcition")]
    public class MatchPredictionController : ApiController
    {
        [HttpPost]
        [Route("SignUp")]
        public string SignUp(UserSignUp signUp)
        {
            string res = "";

            try
            {
                QLEntities objEntity = new QLEntities();

                using (var connection = objEntity.Database.Connection)
                {
                    if (connection.State != ConnectionState.Open)
                        connection.Open();

                    SqlCommand command = new SqlCommand("SP_QL_PredictionUserSignUp");

                    command.Connection = (SqlConnection)(connection);

                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@NT_ID", signUp.NT_ID);
                    command.Parameters.AddWithValue ("@Department", signUp.Department);
                    command.Parameters.AddWithValue("@Password", signUp.Password);

                    var result = Convert.ToInt32(command.ExecuteScalar());

                    if (result == 0)
                        res = result.ToString();
                    else
                        res = result.ToString();

                }
            }
            catch (Exception ex)
            {
                res = ex.ToString();
            }
            return res;
        }

        [HttpPost]
        [Route("UserLogin")]
        public string GetUserLogin(UserLogin userLogin)
        {
            string res = "";
            try
            {
                QLEntities objEntity = new QLEntities();

                using (var connection = objEntity.Database.Connection)
                {
                    if (connection.State != ConnectionState.Open)
                        connection.Open();

                    SqlCommand command = new SqlCommand("SP_QL_PredictionUserLogin");

                    command.Connection = (SqlConnection)(connection);

                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@NT_ID", userLogin.NT_ID);
                    command.Parameters.AddWithValue("@Password", userLogin.Password);
                    
                    var result = Convert.ToInt32(command.ExecuteScalar());

                    if (result == 0)
                        res = "Success";
                    else
                        res = "Failed";
                }
            }
            catch (Exception ex)
            {
                res = ex.ToString();
            }
            return res;
        }

        [HttpGet]
        [Route("GetCurrentMatchDetails")]
        public IEnumerable<CurrentMatchDetails> GetCurrentMatchDetails()
        {
            List<CurrentMatchDetails> matchList = new List<CurrentMatchDetails>();
            string res = "";
            try
            {
                QLEntities objEntity = new QLEntities();

                using (var connection = objEntity.Database.Connection)
                {
                    if (connection.State != ConnectionState.Open)
                        connection.Open();

                    SqlCommand command = new SqlCommand();

                    command.Connection = (SqlConnection)(connection);

                    command.CommandText = string.Format("exec SP_QL_GetCurrentPredictionMatchDetails");

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var matchDetails = new CurrentMatchDetails();

                            matchDetails.MatchFixtureId = Convert.ToInt32(reader["MatchFixtureId"]);
                            matchDetails.Team1Id = Convert.ToInt32(reader["Team1Id"]);
                            matchDetails.Team2Id = Convert.ToInt32(reader["Team2Id"]);
                            matchDetails.Team1Name = reader["Team1Name"].ToString();
                            matchDetails.Team2Name = reader["Team2Name"].ToString();
                            matchDetails.MatchDate = reader["MatchDate"].ToString();

                            matchList.Add(matchDetails);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                res = ex.ToString();
            }

            return matchList;
        }

        [HttpPost]
        [Route("AddPrediction")]
        public string AddPrediction(MatchPrediction matchPrediction)
        {
            string res = "Failed";

            try
            {
                QLEntities objEntity = new QLEntities();

                using (var connection = objEntity.Database.Connection)
                {
                    if (connection.State != ConnectionState.Open)
                        connection.Open();

                    SqlCommand command = new SqlCommand("SP_QL_AddMatchPrediction");

                    command.Connection = (SqlConnection)(connection);

                    command.CommandType = CommandType.StoredProcedure;

                    //command.CommandText = string.Format("exec SP_QL_UpdateAnswerByTeam");

                    command.Parameters.AddWithValue("@NT_ID", matchPrediction.NT_ID);
                    command.Parameters.AddWithValue("@Stage1WinnerTeam", matchPrediction.Stage1WinnerTeam);
                    command.Parameters.AddWithValue("@Stage2WinnerTeam", matchPrediction.Stage2WinnerTeam);
                    command.Parameters.AddWithValue("@Stage3WinnerTeam", matchPrediction.Stage3WinnerTeam);
                    command.Parameters.AddWithValue("@WinnerTeam", matchPrediction.WinnerTeam);

                    var result = Convert.ToInt32(command.ExecuteScalar());

                    if (result == 0)
                        res = "Success";

                }
            }
            catch (Exception ex)
            {
                res = ex.ToString();
            }
            return res;
        }
    }
}
