using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace dotNetProject
{
    public class RestClientCall : IRestClientCall
    {
         IRestClient _restClient;
         IRestResponse _restResponse;
         public RestClientCall(string Url)
         {
             _restClient = new RestClient(Url);
         }
         public dynamic callApi(bool parameters = false, string parLong = null, string parLat = null)
         {
            if (!parameters) _restResponse = _restClient.Execute(new RestRequest());
            else
            {
                var request = new RestRequest("countryCode?", Method.GET);
                request.AddParameter("lat", parLat);
                request.AddParameter("lng", parLong);
                request.AddParameter("type", "JSON");
                request.AddParameter("username", "Whatifjohnyhere");
                _restResponse = _restClient.Execute(request);

            }
            return JsonConvert.DeserializeObject (_restResponse.Content);
         } 
    }// http://api.geonames.org/
}// http://api.geonames.org/countryCode?lat=47.03&lng=10.2&username=demo 
