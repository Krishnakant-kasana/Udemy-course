using eTicket_for_movies.Data;
using Microsoft.AspNetCore.Mvc;
using eTicket_for_movies.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTicket_for_movies.Controllers
{
    public class ActorController : Controller
    {
        private readonly IActorservice _service;
        public ActorController(IActorservice service)
        {
            _service = service;

        }
        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAll();
            return View(data);
        }
    }
}
