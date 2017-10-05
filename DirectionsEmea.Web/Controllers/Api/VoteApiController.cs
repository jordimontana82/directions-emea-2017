using DirectionsEmea.Web.Commands;
using DirectionsEmea.Web.Infrastructure;
using DirectionsEmea.Web.Models;
using Microsoft.Xrm.Sdk;
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
        private IOrganizationService _service = null;

        public VoteApiController()
        {
            if (_service == null)
                _service = CrmServiceFactory.GetService();
        }

        [HttpPost]
        [Route("api/vote/save")]
        public GenericResult Save([FromBody] VoteViewModel model)
        {
            var cmd = new CommandSaveVoteProcess()
            {
                Model = model
            };
            return cmd.Execute(_service);
        }
    }
}
