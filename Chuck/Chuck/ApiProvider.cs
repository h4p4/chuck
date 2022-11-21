using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Chuck
{
    public class ApiProvider
    {
        public async Task<Rootobject> GetJokes() 
        {
            HttpClient httpClient = new HttpClient();
            string request = "https://api.chucknorris.io/jokes/search?query=hitler";
            HttpResponseMessage response =
                (await httpClient.GetAsync(request)).EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();

            JObject jObject = JObject.Parse(responseBody);
            Rootobject rootobject = jObject.ToObject<Rootobject>();

            return rootobject;
        }
    }
}
