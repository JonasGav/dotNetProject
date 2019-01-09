using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace dotNetProject.Backend
{
    class HttpClientCall
    {
        public static async Task<String> CustomExceptionCallAsync()
        {
            using (var client = new HttpClient())
            using (var request = new HttpRequestMessage(HttpMethod.Get, "http://api.open-notify.org/iss-now.json"))
            using (var response = await client.SendAsync(request))
            {
                var content = await response.Content.ReadAsStringAsync();
                return content;
            }
        }
    }
}
