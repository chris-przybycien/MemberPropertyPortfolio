using Microsoft.AspNetCore.Mvc;
using PropertyPortfolio.Database;
using PropertyPortfolio.Models;
using System.Collections.Generic;
using System.Linq;

namespace PropertyPortfolio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PropertyPortfolioApiController : ControllerBase
    {
        private PropertyPortfolioDbContext _dbContext;

        public PropertyPortfolioApiController(PropertyPortfolioDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Owner> GetCustomerProperties()
        {
            var owners = _dbContext.Owners.ToList();
            if (!owners?.Any() ?? true) return new List<Owner>();

            owners.ForEach(o => o.Properties = _dbContext.Properties
                .Where(p => p.OwnerId == o.Id).ToList());

            return _dbContext.Owners;
        }
    }
}