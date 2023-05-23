using AutoMapper;

using BookStoreTask.Application.Contracts.Persistence;
using BookStoreTask.Application.Exceptions;
using BookStoreTask.Domain.Entities;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreTask.Application.Features.Books.Commands.DeleteBook
{
    
    public class DeleteBookCommandHandler : IRequestHandler<DeleteBookCommand>
    {
        private readonly IAsyncRepository<BookRent> _bookRepository;
        private readonly IMapper _mapper;

        public DeleteBookCommandHandler(IMapper mapper,
            IAsyncRepository<BookRent> bookRepository)
        {
            _mapper = mapper;
            _bookRepository = bookRepository;
        }

        public async Task<Unit> Handle(DeleteBookCommand request, CancellationToken cancellationToken)
        {
            var bookToDelete = await _bookRepository.GetByIdAsync(
                request.BookId);

            if (bookToDelete == null)
            {
                throw new NotFoundException(nameof(BookRent), request.BookId);
            }

            await _bookRepository.DeleteAsync(bookToDelete);

            return Unit.Value;
        }
    }
}
