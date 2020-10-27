using Acme.BookStore.BookManagement.Books;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;
using Acme.BookStore.BookManagement.Customers;

namespace Acme.BookStore.BookManagement.EntityFrameworkCore
{
    [ConnectionStringName("BookManagement")]
    public interface IBookManagementDbContext : IEfCoreDbContext
    {
        DbSet<Book> Books { get; }
        DbSet<Customer> Customers { get; set; }
    }
}
