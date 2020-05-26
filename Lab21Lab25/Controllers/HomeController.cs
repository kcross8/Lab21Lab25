using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Lab21Lab25.Models;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;
using Microsoft.AspNetCore.Mvc.Formatters;

namespace Lab21Lab25.Controllers
{
    public class HomeController : Controller
    {
        public List<Movie> sessionMovies { get; set; }
        public List<Movie> selectedMovies { get; set; }

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            sessionMovies = new List<Movie>();
            sessionMovies.Add(new Movie(10, "Seinfeld Movie", "Comedy", new DateTime(2013, 1, 23), "George, Elaine", "Cosmo Kramer"));
            sessionMovies.Add(new Movie(10, "Drama Movie", "Drama", new DateTime(2014, 1, 22), "Drama Actor", "Serious Director"));
            sessionMovies.Add(new Movie(10, "The Story", "Documentary", new DateTime(2002, 2, 13), "Nar Arrator", "Big Guy"));
            sessionMovies.Add(new Movie(10, "Romanctics", "Romance", new DateTime(2016, 5, 14), "Cool Person", "Friendly Fellow"));
            sessionMovies.Add(new Movie(10, "Scary Stuff", "Horror", new DateTime(2003, 8, 02), "Big Talent", "Thatone Person"));
            selectedMovies = new List<Movie>();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Registration()
        {
            return View();
        }
        public IActionResult Result(Movie m)
        {
            return View(m);
        }
        public IActionResult MovieList()
        {
            string movieJSON3 = HttpContext.Session.GetString("MovieSession") ?? "empty";
            if (movieJSON3 != "empty")
            {
                sessionMovies = JsonSerializer.Deserialize<List<Movie>>(movieJSON3);
            }
            movieJSON3 = JsonSerializer.Serialize(sessionMovies);

            HttpContext.Session.SetString("MovieSession", movieJSON3);

            return View("MovieList", sessionMovies);
        }       
        public IActionResult Receipt()
        {
            string movieJSON2 = HttpContext.Session.GetString("MovieSession2") ?? "empty";
            if (movieJSON2 != "empty")
            {
                selectedMovies = JsonSerializer.Deserialize<List<Movie>>(movieJSON2);
            }
            movieJSON2 = JsonSerializer.Serialize(selectedMovies);

            HttpContext.Session.SetString("MovieSession2", movieJSON2);

            return View(selectedMovies);
        }
        public IActionResult Cart()
        {
            string movieJSON2 = HttpContext.Session.GetString("MovieSession2") ?? "empty";
            if (movieJSON2 != "empty")
            {
                selectedMovies = JsonSerializer.Deserialize<List<Movie>>(movieJSON2);
            }
            movieJSON2 = JsonSerializer.Serialize(selectedMovies);

            HttpContext.Session.SetString("MovieSession2", movieJSON2);

            return View(selectedMovies);
        }
        public IActionResult AddToSessionsList(Movie movie)
        {
            string movieJSON = HttpContext.Session.GetString("MovieSession") ?? "empty";
            if(movieJSON != "empty")
            {
                sessionMovies = JsonSerializer.Deserialize<List<Movie>>(movieJSON);
            }
            sessionMovies.Add(movie);
            movieJSON = JsonSerializer.Serialize(sessionMovies);

            HttpContext.Session.SetString("MovieSession", movieJSON);

            return View("MovieList", sessionMovies);
        }

        public IActionResult SelectMovies(string title)
        {
            string movieJSON2 = HttpContext.Session.GetString("MovieSession") ?? "empty";
            string movieJSON3 = HttpContext.Session.GetString("MovieSession2") ?? "empty"; 
            if (movieJSON2 != "empty" && movieJSON3 != "empty")
            {
                sessionMovies = JsonSerializer.Deserialize<List<Movie>>(movieJSON2);
                selectedMovies = JsonSerializer.Deserialize<List<Movie>>(movieJSON3);
            }
            Movie selectedMovie = sessionMovies.Where(x => x.Title == title).First();

            var duplicate = selectedMovie.Title;
            if (!selectedMovies.Any(t => t.Title == duplicate))
            {
                selectedMovies.Add(selectedMovie);
                movieJSON2 = JsonSerializer.Serialize(selectedMovies);

                HttpContext.Session.SetString("MovieSession2", movieJSON2);

            }
            else
            {
                return View("ErrorPage");
            }
                return View("MovieList", sessionMovies);
        }
        public IActionResult RemoveMovies(string title)
        {
            string movieJSON2 = HttpContext.Session.GetString("MovieSession2") ?? "empty";
            if (movieJSON2 != "empty")
            {
                selectedMovies = JsonSerializer.Deserialize<List<Movie>>(movieJSON2);
            }
            Movie selectedMovie = selectedMovies.Where(x => x.Title == title).First();
            selectedMovies.Remove(selectedMovie);
            movieJSON2 = JsonSerializer.Serialize(selectedMovies);

            HttpContext.Session.SetString("MovieSession2", movieJSON2);

            return View("Cart", selectedMovies);
        }

        public IActionResult ClearMovies()
        {
            string movieJSON2 = HttpContext.Session.GetString("MovieSession2") ?? "empty";
            if (movieJSON2 != "empty")
            {
                selectedMovies = JsonSerializer.Deserialize<List<Movie>>(movieJSON2);
            }
            selectedMovies = new List<Movie>();
            movieJSON2 = JsonSerializer.Serialize(selectedMovies);

            HttpContext.Session.SetString("MovieSession2", movieJSON2);
            HttpContext.Session.Remove("MovieSession2");

            return View("Index");
        }
        public IActionResult ErrorPage()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
