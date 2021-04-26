using QPL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace QPL.Controllers
{
    [RoutePrefix("Api/Teams")]
    public class TeamsController : ApiController
    {
        [HttpGet]
        [Route("GetAllTeams")]
        public IEnumerable<TeamTable> teamDetails()
        {
            IEnumerable<TeamTable> teamList = new List<TeamTable>();
            string res = "";

            try
            {
                using (TechLeagueDBEntities objEntity = new TechLeagueDBEntities())
                {
                    teamList = objEntity.TeamTables.ToList();
                }
            }
            catch (Exception ex)
            {
                res = ex.ToString();
            }

            return teamList;
        }

        [HttpPost]
        [Route("AddTeamDetails")]
        public string AddRole(TeamTable teamDetails)
        {
            string res = "";
            try
            {
                using (TechLeagueDBEntities objEntity = new TechLeagueDBEntities())
                {
                    objEntity.TeamTables.Add(teamDetails);
                    int result = objEntity.SaveChanges();

                    if (result > 0)
                    {
                        res = "Success";
                    }
                    else
                    {
                        res = "Failed";
                    }
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
