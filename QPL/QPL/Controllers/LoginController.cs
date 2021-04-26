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
    [RoutePrefix("Api/Login")]
    public class LoginController : ApiController
    {
        [HttpGet]
        [Route("ValidateUser")]
        public bool ValidateUser(LoginTable userDetails)
        {
            LoginTable validate = new LoginTable();
            bool isValid = false;

            try
            {
                using (var objEntity = new TechLeagueDBEntities())
                {
                    var existingUserDetails = objEntity.LoginTables.Where(x => x.NTID == userDetails.NTID && x.Password == userDetails.Password).FirstOrDefault<LoginTable>();

                    if (existingUserDetails != null)
                    {
                        isValid = true;   
                    }
                }
            }
            catch (Exception)
            {
                isValid = false;
            }

            return isValid;
        }
    }
}
