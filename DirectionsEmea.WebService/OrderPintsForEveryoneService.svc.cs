using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace DirectionsEmea.WebService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "OrderPintsForEveryone" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select OrderPintsForEveryone.svc or OrderPintsForEveryone.svc.cs at the Solution Explorer and start debugging.
    public class OrderPintsForEveryone : IOrderPintsForEveryoneService
    {
        public bool CreateOrder(int numberOfPints)
        {
            return true;
        }
    }
}
