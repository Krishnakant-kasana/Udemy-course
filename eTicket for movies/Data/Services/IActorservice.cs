using eTicket_for_movies.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTicket_for_movies.Data.Services
{
    public interface IActorservice
    {
        Task<IEnumerable<Actor>> GetAll();
        Actor GetById(int id);
        void Add(Actor actor);
        Actor Update(int id, Actor newActor);
        void Delete(int id);
    }
}
