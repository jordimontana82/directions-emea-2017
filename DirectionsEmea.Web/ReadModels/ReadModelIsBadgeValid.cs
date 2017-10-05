using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DirectionsEmea.Web.Models;
using Microsoft.Xrm.Sdk;
using TypedEntities;
using System.Linq;

namespace DirectionsEmea.Web.ReadModels
{
    public class ReadModelIsBadgeValid : IReadModel
    {
        public string BadgeId { get; set; }

        public GenericResult Execute(IOrganizationService service)
        {
            throw new NotImplementedException();
        }
    }
}