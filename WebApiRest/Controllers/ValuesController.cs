using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.ServiceModel;
using System.Threading.Tasks;
using System.Web.Http;
using WebApiRest.ServiceReference1;

namespace WebApiRest.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public async Task<string> Get([FromUri] int num1, [FromUri] int num2)
        {
            NetHttpBinding obj = new NetHttpBinding();
            obj.WebSocketSettings.TransportUsage = System.ServiceModel.Channels.WebSocketTransportUsage.Always;
            ISoapService soapServiceChannel = new SoapServiceClient();
            var sumResponse = await soapServiceChannel.SumAsync(new SumRequest()
            {
                Body = new SumRequestBody()
                {
                    num1 = num1,
                    num2 = num2
                }
            });
            
            return sumResponse.Body.SumResult;
        }


    }
}
