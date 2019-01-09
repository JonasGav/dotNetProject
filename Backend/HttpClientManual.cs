using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace dotNetProject
{
    class HttpClientManual
    {
        public string ResponseBody { get; set; }
       
        public async Task RestClien()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync("http://api.open-notify.org/iss-now.json");
            response.EnsureSuccessStatusCode();
            ResponseBody = await response.Content.ReadAsStringAsync();
        }
        public string GetResponse()
        {
            return ResponseBody;
        }
    }
}
