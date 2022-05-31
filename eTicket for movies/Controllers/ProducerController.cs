using eTicket_for_movies.Data;
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
        private readonly AppDbContext _context;
        public ProducerController(AppDbContext context)
        {
            _context = context;

        }
        public async Task<IActionResult> Index() 
        {
            var allProducer = await _context.Producer.ToListAsync();
            return View(allProducer);
        }
    }
}
