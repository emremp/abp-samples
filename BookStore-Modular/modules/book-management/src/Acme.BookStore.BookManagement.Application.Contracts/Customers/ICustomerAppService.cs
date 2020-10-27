using System;
using Acme.BookStore.BookManagement.Customers.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Acme.BookStore.BookManagement.Customers
{
    public interface ICustomerAppService :
        ICrudAppService< 
            CustomerDto, 
            Guid, 
            PagedAndSortedResultRequestDto,
            CreateUpdateCustomerDto,
            CreateUpdateCustomerDto>
    {

    }
}