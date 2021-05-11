using JustGoTravel.Models.Agent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JustGoTravel.MVC.Controllers
{
    [Authorize]
    public class AgentController : Controller
    {
        // GET: Agent
        public ActionResult Index()
        {
            var model = new AgentListItem[0];
            return View(model);
        }
    }
}