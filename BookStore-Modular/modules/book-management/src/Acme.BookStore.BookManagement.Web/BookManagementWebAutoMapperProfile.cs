using Acme.BookStore.BookManagement.Customers.Dtos;
using Acme.BookStore.BookManagement.Web.Pages.BookManagement.Customers.Customer.ViewModels;
using AutoMapper;

namespace Acme.BookStore.BookManagement.Web
{
    public class BookManagementWebAutoMapperProfile : Profile
    {
        public BookManagementWebAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */
            CreateMap<CustomerDto, CreateEditCustomerViewModel>();
            CreateMap<CreateEditCustomerViewModel, CreateUpdateCustomerDto>();
        }
    }
}
