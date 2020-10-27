using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Acme.BookStore.BookManagement.Customers;
using Acme.BookStore.BookManagement.Customers.Dtos;
using Acme.BookStore.BookManagement.Web.Pages.BookManagement.Customers.Customer.ViewModels;

namespace Acme.BookStore.BookManagement.Web.Pages.BookManagement.Customers.Customer
{
    public class CreateModalModel : BookManagementPageModel
    {
        [BindProperty]
        public CreateEditCustomerViewModel ViewModel { get; set; }

        private readonly ICustomerAppService _service;

        public CreateModalModel(ICustomerAppService service)
        {
            _service = service;
        }

        public virtual async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateEditCustomerViewModel, CreateUpdateCustomerDto>(ViewModel);
            await _service.CreateAsync(dto);
            return NoContent();
        }
    }
}