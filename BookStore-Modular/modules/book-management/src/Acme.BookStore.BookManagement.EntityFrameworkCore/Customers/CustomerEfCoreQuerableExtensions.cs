using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Acme.BookStore.BookManagement.Customers
{
    public static class CustomerEfCoreQueryableExtensions
    {
        public static IQueryable<Customer> IncludeDetails(this IQueryable<Customer> queryable, bool include = true)
        {
            if (!include)
            {
                return queryable;
            }

            return queryable
                // .Include(x => x.xxx) // TODO: AbpHelper generated
                ;
        }
    }
}