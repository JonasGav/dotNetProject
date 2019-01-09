using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace dotNetProject
{
    public class RestClientCall
    {
         IRestClient _restClient;
         IRestResponse _restResponse;
         public RestClientCall()
         {
             _restClient = new RestClient("http://api.open-notify.org/iss-now.json");
             _restResponse =  _restClient.Execute(new RestRequest());
         }
         public IRestResponse callApi()
         {
             return _restResponse;
         } 
         public string getResponse()
         {
             return _restResponse.Content;
         }
    }
}
