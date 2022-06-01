﻿using eTicket_for_movies.Data.Base;
using eTicket_for_movies.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTicket_for_movies.Data.Services
{
    public class ActorService : EntityBaseRepository<Actor>,  IActorservice
    {
        public ActorService(AppDbContext context) : base(context) { }
    }
}
