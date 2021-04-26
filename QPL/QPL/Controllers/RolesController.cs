using QPL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace QPL.Controllers
{
    [RoutePrefix("Api/Roles")]
    public class RolesController : ApiController
    {
        [HttpGet]
        [Route("GetAllRoles")]
        public IEnumerable<RoleTable> roleDetails()
        {
            IEnumerable<RoleTable> roleList = new List<RoleTable>();
            string res = "";

            try
            {
                using (TechLeagueDBEntities objEntity = new TechLeagueDBEntities())
                {
                    roleList = objEntity.RoleTables.ToList();
                }
            }
            catch (Exception ex)
            {
                res = ex.ToString();
            }

            return roleList;
        }

        [HttpPost]
        [Route("AddRoleDetails")]
        public string AddRole(RoleTable roleDetails)
        {
            string res = "";
            try
            {
                using (TechLeagueDBEntities objEntity = new TechLeagueDBEntities())
                {
                    objEntity.RoleTables.Add(roleDetails);
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
