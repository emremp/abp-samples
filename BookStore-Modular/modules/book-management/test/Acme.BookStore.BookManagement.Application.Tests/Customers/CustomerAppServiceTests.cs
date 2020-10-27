using Shouldly;
using System.Threading.Tasks;
using Xunit;

namespace Acme.BookStore.BookManagement.Customers
{
    public class CustomerAppServiceTests : BookManagementApplicationTestBase
    {
        private readonly ICustomerAppService _customerAppService;

        public CustomerAppServiceTests()
        {
            _customerAppService = GetRequiredService<ICustomerAppService>();
        }

        /*
        [Fact]
        public async Task Test1()
        {
            // Arrange

            // Act

            // Assert
        }
        */
    }
}
