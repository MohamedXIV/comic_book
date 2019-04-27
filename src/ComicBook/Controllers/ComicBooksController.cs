using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBook.Controllers
{
    public class ComicBooksController : Controller
    {
        public ActionResult Detail()
        {
            ViewBag.SeriesTitle = "Batman";
            ViewBag.IssueNumber = 101;
            ViewBag.Description = "Batman Family, Batman Incorporated," +
                        " Justice League, Outsiders, Wayne Enterprises," +
                        " Club of Heroes, formerly White Lantern Corps," +
                        " Sinestro Corps, relatives:Damian Wayne (son)," +
                        " Dick Grayson (adopted son), Tim Drake (adopted son)," +
                        " Jason Todd (adopted son), Cassandra Cain (adopted ward)\nMartha Wayne" +
                        " (mother, deceased), Thomas Wayne (father, deceased), Alfred Pennyworth" +
                        " (former guardian), Roderick Kane (grandfather, deceased), Elizabeth Kane" +
                        " (grandmother, deceased), Nathan Kane (uncle, deceased), Simon Hurt (ancestor), Wayne Family";
            ViewBag.Artists = new string[]
            {
                "Sripts: Not Me",
                "Pencils: Not Me",
                "Inks: Not Me",
                "Colors: Not Me",
                "Letters: Not Me"
            };

            return View();
        }
    }
}