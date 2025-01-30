using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Http;
using System.Threading.Tasks;
using System.Configuration;
using Newtonsoft.Json;

namespace CryptoCoinic.Api.Data.Controllers
{
    public class TickerController : ApiController, IDisposable
    {
        private HttpClient client;

        public TickerController(string broker) //Broker - "Enum"
        {
            client = new HttpClient
            {
                BaseAddress = new Uri(ConfigurationManager.AppSettings["URI_" + broker + "_DataApi"])
            };
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        [HttpGet, ActionName("GetCurrentTicker")]
        public Models.DataContent GetCurrentTicker(string currency) //Currency - "Enum"
        {           
            string tickerJson = null;

            HttpResponseMessage response = client.GetAsync("api/" + currency + "/ticker").Result;
            if (response.IsSuccessStatusCode)
            {
                tickerJson = response.Content.ReadAsStringAsync().Result;
            }

            var ticker = JsonConvert.DeserializeObject<Models.DataContent>(tickerJson);
            return (Models.DataContent)ticker;
        }

    }
}
