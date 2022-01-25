using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace RestAPI
{
    public class ApiHelper
    {
        public IRestResponse PostMethod()
        {
            RestClient client = new RestClient(baseUrl: "https://rozetka.com.ua/ua/")
            {
                Timeout = 300000
            };
            RestRequest request = new RestRequest(Method.POST);
            request.AddHeader(name: "content-type", value: "application/json");
            Dictionary<string, string> body = new Dictionary<string, string>
            {
                {"e-mail", "webfox02@gmail.com" },
                {"password", "192002Ilya"}
            };
            request.AddJsonBody(body);
            request.RequestFormat = DataFormat.Json;

            IRestResponse response = client.Execute(request);
            return response;
            
        }
        
    }   
}
