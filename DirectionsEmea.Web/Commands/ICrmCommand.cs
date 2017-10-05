using DirectionsEmea.Web.Models;
using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectionsEmea.Web.Commands
{
    interface ICrmCommand
    {
        GenericResult Execute(IOrganizationService service);
    }
}
