using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using homeservice.api.Interfaces;
using homeservice.api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace homeservice.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeServiceController : ControllerBase
    {
        private readonly IHomeService _homeService;

        public HomeServiceController(IHomeService homeService)
        {
            _homeService = homeService;
        }

        [HttpGet]
        [Route("GetServiceRequests")]
        public async Task<IEnumerable<ServiceRequests>> GetServiceRequests()
        {
            var serviceRequests = await _homeService.ListAsync();

            return serviceRequests;
        }

        [HttpGet]
        [Route("GetCategories")]
        public async Task<IEnumerable<Category>> GetServiceCategories()
        {
            var categoryList = await _homeService.CategoryListAsync();

            return categoryList;
        }

        [HttpGet]
        [Route("GetCategoryTypes")]
        public async Task<IEnumerable<CategoryType>> GetCategoryTypes()
        {
            var categoryTypeList = await _homeService.CategoryTyeListAsync();

            return categoryTypeList;
        }

        [HttpGet]
        [Route("GetCategoryService")]
        public async Task<IEnumerable<CategoryServices>> GetCategoryService()
        {
            var categoryTypeList = await _homeService.CategoryServiceListAsync();

            return categoryTypeList;
        }


        [HttpPost]
        [Route("SaveServiceRequest")]
        public async Task<IActionResult> PostAsync([FromBody]ServiceRequests serviceRequest)
        {
            var result = await _homeService.SaveAsync(serviceRequest);

            if (!result.Success)
                return BadRequest(result.Message);

            return Ok(result.ServiceRequests);
        }

    }
}