using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using homeservice.api.Contexts;
using homeservice.api.Models;
using homeservice.api.Response;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace homeservice.api.Repository
{
    public class HomeServiceRepository : BaseRepository, IHomeServiceRepository
    {
        public HomeServiceRepository(AppDbContext context) : base(context)
        {
        }
        public async Task<IEnumerable<ServiceRequests>> ListAsync()
        {

            return await _context.ServiceRequests.ToListAsync();
        }

        public async Task AddAsync(ServiceRequests serviceRequests)
        {
            _context.ServiceRequests.Add(serviceRequests);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Category>> CategoryListAsync()
        {
            return await _context.Categories.ToListAsync();
        }

        public async Task<IEnumerable<CategoryType>> CategoryTypeListAsync()
        {
            return await _context.CategoryTypes.ToListAsync();
        }

        public async Task<IEnumerable<CategoryServices>> CategoryServicesListAsync()
        {
            return await _context.CategoryServices.ToListAsync();
        }
    }
}
