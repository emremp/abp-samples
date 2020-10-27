using System;
using System.Threading.Tasks;
using Acme.BookStore.BookManagement.Customers;
using Volo.Abp.Domain.Repositories;
using Xunit;

namespace Acme.BookStore.BookManagement.EntityFrameworkCore.Customers
{
    public class CustomerRepositoryTests : BookManagementEntityFrameworkCoreTestBase
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerRepositoryTests()
        {
            _customerRepository = GetRequiredService<ICustomerRepository>();
        }

        /*
        [Fact]
        public async Task Test1()
        {
            await WithUnitOfWorkAsync(async () =>
            {
                // Arrange

                // Act

                //Assert
            });
        }
        */
    }
}
