using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp;
using Volo.Abp.Application.Dtos;
using Volo.Abp.AspNetCore.Mvc;

namespace Acme.BookStore.BookManagement.Books
{
    [RemoteService]
    [Route("api/BookManagement/book")]
    public class BookController : BookManagementController, IBookAppService
    {
        private readonly IBookAppService _service;

        public BookController(IBookAppService service)
        {
            _service = service;
        }
        [HttpPost]
        public Task<BookDto> CreateAsync(CreateUpdateBookDto input)
        {
            return _service.CreateAsync(input);
        }
        [HttpDelete]
        [Route("{id}")]
        public Task DeleteAsync(Guid id)
        {
            return _service.DeleteAsync(id);
        }
        [HttpGet]
        [Route("{id}")]
        public Task<BookDto> GetAsync(Guid id)
        {
            return _service.GetAsync(id);
        }

        [HttpGet]
        public Task<PagedResultDto<BookDto>> GetListAsync(PagedAndSortedResultRequestDto input)
        {
            input.MaxResultCount = 1;
            return _service.GetListAsync(input);
        }
        [HttpPut]
        [Route("{id}")]
        public Task<BookDto> UpdateAsync(Guid id, CreateUpdateBookDto input)
        {
            return _service.UpdateAsync(id, input);
        }
    }
}
