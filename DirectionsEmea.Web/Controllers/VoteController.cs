using DirectionsEmea.Web.Infrastructure;
using DirectionsEmea.Web.Models;
using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DirectionsEmea.Web.Controllers
{
    public class VoteController : Controller
    {
        private IOrganizationService _service = null;

        public VoteController()
        {
            if (_service == null)
                _service = CrmServiceFactory.GetService();
        }


        public ActionResult Index()
        {
            return View();
        }

        
    }
}