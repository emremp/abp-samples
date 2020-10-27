using System.Threading.Tasks;

namespace Acme.BookStore.BookManagement.Web.Pages.BookManagement.Customers.Customer
{
    public class IndexModel : BookManagementPageModel
    {
        public virtual async Task OnGetAsync()
        {
            await Task.CompletedTask;
        }
    }
}
