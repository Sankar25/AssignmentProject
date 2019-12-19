using homeservice.api.Interfaces;
using homeservice.api.Models;
using homeservice.api.Repository;
using homeservice.api.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace homeservice.api.Services
{
    public class HomeService : IHomeService
    {

        private readonly IHomeServiceRepository _homeServiceRepository;

        public HomeService(IHomeServiceRepository homeServiceRepository)
        {
            this._homeServiceRepository = homeServiceRepository;
        }

        public async Task<IEnumerable<Category>> CategoryListAsync()
        {
            return await _homeServiceRepository.CategoryListAsync();
        }

        public async Task<IEnumerable<CategoryType>> CategoryTyeListAsync()
        {
            return await _homeServiceRepository.CategoryTypeListAsync();
        }

        public async Task<IEnumerable<ServiceRequests>> ListAsync()
        {
            return await _homeServiceRepository.ListAsync();
        }

        public async Task<SaveServiceRequestsResponse> SaveAsync(ServiceRequests serviceRequests)
        {
            try
            {
                await _homeServiceRepository.AddAsync(serviceRequests);

                return new SaveServiceRequestsResponse(serviceRequests);
            }
            catch (Exception ex)
            {
                return new SaveServiceRequestsResponse($"An error occured whil saving service request: {ex.Message}");
            }
        }

        public async Task<IEnumerable<CategoryServices>> CategoryServiceListAsync()
        {
            return await _homeServiceRepository.CategoryServicesListAsync();
        }
    }
}
