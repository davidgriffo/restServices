using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;
using Data;


namespace WebService.Rest
{
    [ServiceContract(Namespace = "")]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class PunService
    {
        [WebGet(UriTemplate="/Puns")]
        public Pun[] GetPuns()
        {
            var service = new PunDataService();
            return service.GetPuns();
        }

    }
}
