using homeservice.api.Models;
using homeservice.api.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace homeservice.api.Repository
{
    public interface IHomeServiceRepository
    {
        Task<IEnumerable<ServiceRequests>> ListAsync();
        Task AddAsync(ServiceRequests serviceRequests);

        Task<IEnumerable<Category>> CategoryListAsync();

        Task<IEnumerable<CategoryType>> CategoryTypeListAsync();

        Task<IEnumerable<CategoryServices>> CategoryServicesListAsync();
    }
}
