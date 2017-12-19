using GOTdb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GOTdb.Controllers
{
    public class CharacterController : Controller
    {
        // GET: Character
        public ActionResult Random()
        {
            var character = new Character() { Name = "Shrek!" };
            return View(character);
        }
    }
}