﻿using JustGoTravel.Models.VacationPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JustGoTravel.MVC.Controllers
{
    [Authorize]
    public class VacationPackController : Controller
    {
        // GET: VacationPack
        public ActionResult Index()
        {
            var model = new VacationPackListItem[0];
            return View(model);
        }
        public ActionResult Create()
        {
            return View();
        }

        //GET
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(VacationPackCreate model)
        {
            if (ModelState.IsValid)
            {

            }
            return View(model);
        }
    }
}