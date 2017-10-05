using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DirectionsEmea.Web.Models;
using Microsoft.Xrm.Sdk;

namespace DirectionsEmea.Web.Commands
{
    public class CommandSaveVoteProcess : ICrmCommand
    {
        public VoteViewModel Model { get; set; }

        public GenericResult Execute(IOrganizationService service)
        {
            return new GenericResult() { Success = false, ErrorMessage = "Not implemented " };
        }
    }
}