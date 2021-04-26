using QPL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace QPL.Controllers
{
    [RoutePrefix("Api/Users")]
    public class UsersController : ApiController
    {
        [HttpGet]
        [Route("GetAllUsers")]
        public IEnumerable<UserTable> userDetails()
        {
            IEnumerable<UserTable> userList = new List<UserTable>();
            string res = "";

            try
            {
                using (TechLeagueDBEntities objEntity = new TechLeagueDBEntities())
                {
                    userList = objEntity.UserTables.ToList();
                }
            }
            catch(Exception ex)
            {
                res = ex.ToString();
            }

            return userList;
        }

        [HttpPut]
        [Route("UpdateUserDetails")]
        public bool UpdateUser(UserTable userDetails)
        {
            bool isUpdated = false;
            try
            {
                using (var objEntity = new TechLeagueDBEntities())
                {
                    var existingUserDetails = objEntity.UserTables.Where(x => x.UserId == userDetails.UserId).FirstOrDefault<UserTable>();

                    if (existingUserDetails != null)
                    {
                        existingUserDetails.Skills = userDetails.Skills;
                        existingUserDetails.Project = userDetails.Project;
                        existingUserDetails.Hobbies = userDetails.Hobbies;
                        existingUserDetails.ModifiedDate = DateTime.Now;
                    }
                    if (objEntity.SaveChanges() > 0)
                        isUpdated = true;


                }
            }
            catch (Exception ex)
            {
                return false;
            }

            return isUpdated;

        }
           
    }
}
