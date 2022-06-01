using eTicket_for_movies.Data.Base;
using eTicket_for_movies.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTicket_for_movies.Data.Services
{
    public class ProducersService: EntityBaseRepository<Producer> , IProducerService
    {
        public ProducersService(AppDbContext context) : base(context)
        {

        }
    }
}
