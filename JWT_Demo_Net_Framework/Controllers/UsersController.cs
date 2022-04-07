using JWT_Demo_Net_Framework.Models;
using JWT_Demo_Net_Framework.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace JWT_Demo_Net_Framework.Controllers
{
    public class UsersController : ApiController
    {
        // GET: Users
        private UserRepository userRepository = new UserRepository();

        [System.Web.Http.HttpPost]
        public IHttpActionResult Authenticate(AuthRequest request)
        {
            var response = userRepository.Authenticate(request);
            if(response == null)
            {
                return NotFound();
            }
            return Ok(response);
        }
    }
}