using System;
using System.Threading.Tasks;
using Acme.BookStore.BookManagement.Customers.Dtos;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp;
using Volo.Abp.Application.Dtos;
using Volo.Abp.AspNetCore.Mvc;

namespace Acme.BookStore.BookManagement.Customers
{
    [RemoteService]
    [Route("api/BookManagement/customer")]
    public class CustomerController : BookManagementController, ICustomerAppService
    {
        private readonly ICustomerAppService _service;

        public CustomerController(ICustomerAppService service)
        {
            _service = service;
        }
        [HttpPost]
        public Task<CustomerDto> CreateAsync(CreateUpdateCustomerDto input)
        {
            return _service.CreateAsync(input);
        }
        [HttpDelete]
        [Route("{id}")]
        public Task DeleteAsync(Guid id)
        {
            return _service.DeleteAsync(id);
        }
        [HttpGet]
        [Route("{id}")]
        public Task<CustomerDto> GetAsync(Guid id)
        {
            return _service.GetAsync(id);
        }

        [HttpGet]
        public Task<PagedResultDto<CustomerDto>> GetListAsync(PagedAndSortedResultRequestDto input)
        {
            input.MaxResultCount = 1;
            return _service.GetListAsync(input);
        }
        [HttpPut]
        [Route("{id}")]
        public Task<CustomerDto> UpdateAsync(Guid id, CreateUpdateCustomerDto input)
        {
            return _service.UpdateAsync(id, input);
        }
    }
}
