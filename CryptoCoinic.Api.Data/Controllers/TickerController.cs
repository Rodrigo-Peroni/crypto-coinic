using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Http;
using System.Configuration;
using System.Text.Json;

namespace CryptoCoinic.Api.Data.Controllers
{
    public class TickerController : ApiController, IDisposable
    {
        private HttpClient client;

        private JsonSerializerOptions deserializationOptions = new JsonSerializerOptions()
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            PropertyNameCaseInsensitive = true
        };

        public TickerController(string broker)
        {
            client = new HttpClient
            {
                BaseAddress = new Uri(ConfigurationManager.AppSettings[broker + "_URI_DataApi"])
            };
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        [HttpGet, ActionName("GetCurrentTicker")]
        public Models.Ticker GetCurrentTicker(string broker, string currency)
        {           
            string tickerJson = null;
            string fiatCurrency = ConfigurationManager.AppSettings[broker + "_Currency"].ToString();

            HttpResponseMessage response = client.GetAsync(String.Format("/api/v3/ticker?symbol={0}{1}T", currency, fiatCurrency)).Result;
            if (response.IsSuccessStatusCode)
            {
                tickerJson = response.Content.ReadAsStringAsync().Result;
            }

            Models.Ticker ticker = JsonSerializer.Deserialize<Models.Ticker>(tickerJson, deserializationOptions);
            ticker.FiatCurrency = fiatCurrency;

            return ticker;
        }

    }
}
