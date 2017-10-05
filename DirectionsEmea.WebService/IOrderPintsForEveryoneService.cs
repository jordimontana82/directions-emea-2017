﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace DirectionsEmea.WebService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IOrderPintsForEveryone" in both code and config file together.
    [ServiceContract]
    public interface IOrderPintsForEveryoneService
    {
        [OperationContract]
        bool CreateOrder(int numberOfPints);
    }
}
