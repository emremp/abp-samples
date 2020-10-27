using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace Acme.BookStore.BookManagement.Customers
{
    public class Customer : AuditedAggregateRoot<Guid>
    {
        public string Name { get; set; }


        protected Customer()
        {
        }

        public Customer(
            Guid id, 
            string name
        ) : base(id)
        {
            Name = name;
        }
    }
}
