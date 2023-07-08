using eCommerce.Controllers;
using eCommerce.Data.Base;
using eCommerce.Models;
using Microsoft.EntityFrameworkCore;

namespace eCommerce.Data.Services
{
    public class ActorsService : EntityBaseRepository<Actor>, IActorsService
    {
        public ActorsService(EcomDbContext context) : base(context) { }
    }
}


