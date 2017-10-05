using DirectionsEmea.Web.Models;
using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DirectionsEmea.Web.Commands
{
    public class CommandCreateVote : ICrmCommand
    {
        public VoteViewModel Model { get; set; }

        public GenericResult Execute(IOrganizationService service)
        {
            return new GenericResult() { Success = false, ErrorMessage = "Not implemented " };
        }
    }
}