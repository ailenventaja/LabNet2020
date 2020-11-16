using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Threading.Tasks;
using System.Web.Mvc;
using ejercicio5.Models;
using Newtonsoft.Json;

namespace ejercicio5.Controllers
{
    public class ApiController : Controller
    {
        // GET: Api
        public async Task<ActionResult> Index()
        {
            var httpClient = new HttpClient();
            var characters = new List<Character>();
            for (int i = 1; i < 100; i++)
            {
                string url = "https://rickandmortyapi.com/api/character/"+i;
                var json = await httpClient.GetStringAsync(url);
                var character = JsonConvert.DeserializeObject<Character>(json);
                characters.Add(character);
            }
         


            return View(characters);
        }
    }
}