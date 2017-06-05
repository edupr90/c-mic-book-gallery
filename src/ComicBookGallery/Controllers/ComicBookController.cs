using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBookController : Controller
    {
        public ActionResult Detail()
        {

            ViewBag.SeriesTitle = "The Amazing Spider Man";
            ViewBag.IissueNumber = 700;
            ViewBag.Description = "<p>Final issure! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives... <strong> will Peter Parker?</strong></p>";
            ViewBag.Artists = new string[]
            {
                "Script: Dan Slott",
                "Pencils: Humberto Ramos",
                "Inks: Victor Olazaba",
                "Colors: Edgar Delgado",
                "Letters: Chris Elipoulos"
            };

            return View();

        }
    }
}