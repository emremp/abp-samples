using System;
using Acme.BookStore.BookManagement.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Acme.BookStore.BookManagement.Customers
{
    public class CustomerRepository : EfCoreRepository<IBookManagementDbContext, Customer, Guid>, ICustomerRepository
    {
        public CustomerRepository(IDbContextProvider<IBookManagementDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}