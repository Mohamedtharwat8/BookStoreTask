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

namespace BookStoreTask.Application.Features.Books.Commands.CreateBook
{
   
   public class CreateBookCommandHandler : IRequestHandler<CreateBookCommand, Guid>
    {
        private readonly IBookRepository _bookRepository;
        private readonly IMapper _mapper; 
        private readonly ILogger<CreateBookCommandHandler> _logger;


        public CreateBookCommandHandler(IMapper mapper, 
            IBookRepository bookRepository,
           
            ILogger<CreateBookCommandHandler> logger)
        {
            _mapper = mapper;
            _bookRepository = bookRepository;
            _logger = logger;
        }

        public async Task<Guid> Handle(CreateBookCommand request, CancellationToken cancellationToken)
        {
            var validator = new CreateBookCommandValidator(_bookRepository);
            var validationResult = await validator.ValidateAsync(request);

            if (validationResult.Errors.Count > 0)
                throw new Exceptions.ValidationException(validationResult);

            var @book = _mapper.Map<BookRent>(request);


            @book = await _bookRepository.AddAsync(@book);


            

            return @book.BookId;
        }
    }
}