using Acme.BookStore.BookManagement.Books;
using Acme.BookStore.BookManagement.Customers;
using Acme.BookStore.BookManagement.Customers.Dtos;
using AutoMapper;

namespace Acme.BookStore.BookManagement
{
    public class BookManagementApplicationAutoMapperProfile : Profile
    {
        public BookManagementApplicationAutoMapperProfile()
        {
            CreateMap<Book, BookDto>();
            CreateMap<CreateUpdateBookDto, Book>(MemberList.Source);
            CreateMap<Customer, CustomerDto>();
            CreateMap<CreateUpdateCustomerDto, Customer>(MemberList.Source);
        }
    }
}
