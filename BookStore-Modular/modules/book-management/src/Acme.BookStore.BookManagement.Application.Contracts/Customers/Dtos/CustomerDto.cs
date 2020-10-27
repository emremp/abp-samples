using System;
using Volo.Abp.Application.Dtos;

namespace Acme.BookStore.BookManagement.Customers.Dtos
{
    [Serializable]
    public class CustomerDto : AuditedEntityDto<Guid>
    {
        public string Name { get; set; }
    }
}