﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMusicStore.Models
{
    public class ArtistController : Controller
    {
        //
        // GET: /Artist/

        public ActionResult Index()
        {
            return View();
        }

    }
}
