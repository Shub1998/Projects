using QPL.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace QPL.Controllers
{
    [RoutePrefix("Api/Matches")]
    public class MatchController : ApiController
    {
        [HttpGet]
        [Route("GetAllMatchDetails")]
        public IEnumerable<MatchTable> matchDetails()
        {
            IEnumerable<MatchTable> matchList = new List<MatchTable>();
            string res = "";

            try
            {
                using (TechLeagueDBEntities objEntity = new TechLeagueDBEntities())
                {
                    matchList = objEntity.MatchTables.ToList();
                }
            }
            catch (Exception ex)
            {
                res = ex.ToString();
            }

            return matchList;
        }
    }
}
