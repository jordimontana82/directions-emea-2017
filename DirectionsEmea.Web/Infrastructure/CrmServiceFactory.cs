using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Tooling.Connector;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace DirectionsEmea.Web.Infrastructure
{
    public class CrmServiceFactory
    {
        public static IOrganizationService GetService()
        {
            var connection = ConfigurationManager.ConnectionStrings["crm"];

            // Connect to the CRM web service using a connection string.
            CrmServiceClient client = new Microsoft.Xrm.Tooling.Connector.CrmServiceClient(connection.ConnectionString);

            //_service = (IOrganizationService)client.OrganizationWebProxyClient != null ? (IOrganizationService)client.OrganizationWebProxyClient : (IOrganizationService)client.OrganizationServiceProxy;
            if (!client.IsReady)
            {
                throw new Exception("Error while connecting to CRM");
            }

            return client;
        }
    }
}