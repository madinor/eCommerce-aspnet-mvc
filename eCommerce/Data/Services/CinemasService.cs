using eCommerce.Controllers;
using eCommerce.Data.Base;
using eCommerce.Models;

namespace eCommerce.Data.Services
{
    public class CinemasService : EntityBaseRepository<Cinema>, ICinemasService
    {
        public CinemasService(EcomDbContext context) : base(context)
        {
        }
    }
}
