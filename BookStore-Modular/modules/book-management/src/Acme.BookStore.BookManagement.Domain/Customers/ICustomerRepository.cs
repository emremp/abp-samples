using System;
using Volo.Abp.Domain.Repositories;

namespace Acme.BookStore.BookManagement.Customers
{
    public interface ICustomerRepository : IRepository<Customer, Guid>
    {
    }
}