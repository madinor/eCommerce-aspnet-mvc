using eCommerce.Controllers;
using eCommerce.Data.Base;
using eCommerce.Models;

namespace eCommerce.Data.Services
{
    public class ProducersService : EntityBaseRepository<Producer>, IProducersService
    {
        public ProducersService(EcomDbContext context) : base(context)
        {
        }
    }
}
