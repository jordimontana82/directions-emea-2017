using DirectionsEmea.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DirectionsEmea.Web.Controllers.Api
{
    public class VoteApiController : ApiController
    {
        [HttpPost]
        [Route("api/vote/save")]
        public GenericResult Save([FromBody] VoteViewModel model)
        {
            return new GenericResult();
        }
    }
}
