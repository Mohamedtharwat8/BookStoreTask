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

namespace BookStoreTask.Application.Features.Books.Commands.UpdateBook
{
    
    public class UpdateBookCommandHandler : IRequestHandler<UpdateBookCommand>
    {
        private readonly IAsyncRepository<BookRent> _bookRepository;
        private readonly IMapper _mapper;

        public UpdateBookCommandHandler(
            IMapper mapper,
            IAsyncRepository<BookRent> bookRepository)
        {
            _mapper = mapper;
            _bookRepository = bookRepository;
        }

        public async Task<Unit> Handle(UpdateBookCommand request, CancellationToken cancellationToken)
        {

            var bookToUpdate = await _bookRepository.GetByIdAsync(request.BookId);
            if (bookToUpdate == null)
            {
                throw new NotFoundException(nameof(BookRent), request.BookId);
            }

            var validator = new UpdateBookCommandValidator();
            var validationResult = await validator.ValidateAsync(request);

            if (validationResult.Errors.Count > 0)
                throw new ValidationException(validationResult);

            _mapper.Map(request, bookToUpdate, typeof(UpdateBookCommand),
                typeof(BookRent));

            await _bookRepository.UpdateAsync(bookToUpdate);

            return Unit.Value;
        }
    }
}