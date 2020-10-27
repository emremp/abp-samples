using System;

using System.ComponentModel.DataAnnotations;

namespace Acme.BookStore.BookManagement.Web.Pages.BookManagement.Customers.Customer.ViewModels
{
    public class CreateEditCustomerViewModel
    {
        [Display(Name = "CustomerName")]
        public string Name { get; set; }
    }
}