using eTicket_for_movies.Data;
using eTicket_for_movies.Data.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTicket_for_movies.Controllers
{
    public class ProducerController : Controller
    {
        private readonly IProducerService _service;
        public ProducerController(IProducerService service)
        {
            _service = service;

        }
        public async Task<IActionResult> Index() 
        {
            var allProducer = await _service.GetAll();
            return View(allProducer);
        }
    }
}
