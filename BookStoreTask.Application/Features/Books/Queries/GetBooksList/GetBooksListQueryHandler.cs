using AutoMapper;
using BookStoreTask.Application.Contracts.Persistence;
using BookStoreTask.Domain.Entities;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreTask.Application.Features.Books.Queries.GetBooksList
{
 
   public class GetBooksListQueryHandler : IRequestHandler<GetBooksListQuery,
       List<BookListVm>>
    {
        private readonly IAsyncRepository<BookRent> _bookRepository;
        private readonly IMapper _mapper;

        public GetBooksListQueryHandler(
            IMapper mapper, 
            IAsyncRepository<BookRent> bookRepository)
        {
            _mapper = mapper;
            _bookRepository = bookRepository;
        }

        public async Task<List<BookListVm>> Handle(
            GetBooksListQuery request, 
            CancellationToken cancellationToken)
        {
            var allBooks = (await _bookRepository.ListAllAsync())
                .OrderBy(x => x.Date);
            return _mapper.Map<List<BookListVm>>(allBooks);
        }
    }
}
