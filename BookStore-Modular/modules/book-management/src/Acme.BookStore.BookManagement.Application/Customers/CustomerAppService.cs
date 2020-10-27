using System;
using Acme.BookStore.BookManagement.Customers.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Acme.BookStore.BookManagement.Customers
{
    public class CustomerAppService : CrudAppService<Customer, CustomerDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateCustomerDto, CreateUpdateCustomerDto>,
        ICustomerAppService
    {

        private readonly ICustomerRepository _repository;
        
        public CustomerAppService(ICustomerRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
