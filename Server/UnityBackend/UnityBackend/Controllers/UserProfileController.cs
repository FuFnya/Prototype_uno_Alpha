using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using UnityBackend.Models;
using Treblle.Net;

namespace UnityBackend.Controllers
{
    [Authorize]
    [Route("API/userProfile")]
    [Treblle]
    public class UserProfileController : ApiController
    {
        public string Get(string userName)
        {
            using (var context = new UserProfileDBContext())
            {
                var query=context.Users.FirstOrDefault(x => x.UserName == userName);
                return query == null ? "" : query.UserData;
            }
        }
        public IHttpActionResult Post([FromBody] UserProfileModel userProfile)
        {
            using (var db = new UserProfileDBContext())
            {
                var result= db.Users.SingleOrDefault(b=>b.UserName == userProfile.UserName);
                
                if(result != null)
                {
                    result.UserData=userProfile.UserData;
                    db.SaveChanges();
                }
                return Ok();
            }
        }
    }
}
