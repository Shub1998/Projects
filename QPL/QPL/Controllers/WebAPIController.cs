using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;


namespace QPL.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*", SupportsCredentials = true)]
    public class WebAPIController : ApiController
    {
        [HttpGet]
        //[Authorize]
        [Route("api/AuthenticateUser")]

        public HttpResponseMessage AuthenticateUser()
        {
            if (User != null)
            {

                return Request.CreateResponse(HttpStatusCode.OK, new
                {
                    status = (int)HttpStatusCode.OK,
                    isAuthenticated = true,
                    //isLibraryAdmin = User.IsInRole(@"domain\AdminGroup"),
                    username = User.Identity.Name.Substring(User.Identity.Name.LastIndexOf(@"\") + 1)
                });
            }
            else
            {
                //This code never execute as we have used Authorize attribute on action method  
                return Request.CreateResponse(HttpStatusCode.OK, new
                {
                    status = (int)HttpStatusCode.BadRequest,
                    isAuthenticated = false,
                    isLibraryAdmin = false,
                    username = ""
                });

            }
        }
    }
}
