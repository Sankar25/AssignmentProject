using homeservice.api.Models;
using homeservice.api.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace homeservice.api.Interfaces
{
    public interface IHomeService
    {
        Task<IEnumerable<ServiceRequests>> ListAsync();
        Task<SaveServiceRequestsResponse> SaveAsync(ServiceRequests serviceRequests);

        Task<IEnumerable<Category>> CategoryListAsync();

        Task<IEnumerable<CategoryType>> CategoryTyeListAsync();

        Task<IEnumerable<CategoryServices>> CategoryServiceListAsync();
    }
}
