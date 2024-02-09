using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using moment2.Models;

namespace moment2.Controllers;

    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //Viewbag
            ViewBag.Message = "Hej från ViewBag";

            //Vy-modell
            var jsonStr = System.IO.File.ReadAllText("playlist.json");
            var songs = JsonSerializer.Deserialize<List<PlaylistModel>>(jsonStr);
            return View(songs);            
        }



        [Route("/about")]//ändrar routing
        public IActionResult About() {

            //Viewdata
            ViewData["Message"] = "Hej hej från viewdata!";
            return View();
        }



        //Denna tar BARA emot GET
        [Route("/playlist")] //ändrar routing
        public IActionResult MyPlaylist(){
            return View();
        }



        //Denna tar emot POST
        [Route("/playlist")]//ändrar routing
        [HttpPost]
         public IActionResult MyPlaylist(PlaylistModel model) 
         {
            //Hämtar data från formulär
            //Valid input
            if(ModelState.IsValid)
            {
                string jsonStr = System.IO.File.ReadAllText("playlist.json");
                //Deserialize Json
                var songs = JsonSerializer.Deserialize<List<PlaylistModel>>(jsonStr);

                //Lägg till song
                if(songs != null)
                {
                    songs.Add(model);
                    jsonStr = JsonSerializer.Serialize(songs);
                    //skriv ändring till json
                    System.IO.File.WriteAllText("playlist.json", jsonStr);
                }
                //Rensar formulär från data
                 ModelState.Clear();

                //Redirect, när song är tillagd hamnar man på startsida
                return RedirectToAction("Index", "Home");
            }

            return View();
        }
    }
    
