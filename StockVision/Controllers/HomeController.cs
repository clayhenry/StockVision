using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using StockVision.Models;

namespace StockVision.Controllers
{
    //Welcome to Alpha Vantage! Your API key is: J1NLGRBMU07CHSQX. 
    public class HomeController : Controller
    {
        // GET
        public IActionResult Index()
        {

       
            return Content("asdasas");
        }
        
        [Route("Hello")]
        public IActionResult Hello()
        {
            return Content("hello");
        }
        
        
        [HttpGet("Hello/{ticker}")]
        public async Task<IActionResult> Ticker(string ticker)
        {
            using (var client = new HttpClient())
            {
                try
                {
                    client.BaseAddress = new Uri("https://www.alphavantage.co");
                    var response = await client.GetAsync($"query?function=TIME_SERIES_INTRADAY&symbol={ticker}&interval=1min&apikey=J1NLGRBMU07CHSQX");
                    response.EnsureSuccessStatusCode();

                    var stringResult = await response.Content.ReadAsStringAsync();
                    var rawData = JsonConvert.DeserializeObject<Alphavantage>(stringResult);
                    return Json(rawData.TimeSeries1min.First());
                }
                catch (HttpRequestException httpRequestException)
                {
                    return BadRequest($"Error getting weather from OpenWeather: {httpRequestException.Message}");
                }
            }
        }
    }
}