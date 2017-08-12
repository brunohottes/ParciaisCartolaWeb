using Newtonsoft.Json;
using ParciaisCartola.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web.Mvc;
using static ParciaisCartola.Models.Time;

namespace ParciaisCartola.Controllers
{
    public class TimeController : Controller
    {
        // GET: Time
        private const string BaseUrl = "https://api.cartolafc.globo.com/";

        public async Task<ActionResult> Index()
         {
            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            httpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (compatible; MSIE 10.0; Windows NT 6.2; WOW64; Trident / 6.0)");
            var uri = new Uri($"{BaseUrl}times?q=Brutts");
            var response = await httpClient.GetStringAsync(uri);
            List<Rootobject> timeList = JsonConvert.DeserializeObject<List<Rootobject>>(response);
            return View(timeList);
        }
    }
}