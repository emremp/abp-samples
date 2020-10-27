using System;
using System.ComponentModel;
namespace Acme.BookStore.BookManagement.Customers.Dtos
{
    [Serializable]
    public class CreateUpdateCustomerDto
    {
        public string Name { get; set; }
    }
}