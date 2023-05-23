using BookStoreTask.Application.Contracts.Persistence;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreTask.Application.Features.Books.Commands.CreateBook
{
   
   public class CreateBookCommandValidator : AbstractValidator<CreateBookCommand>
    {
        private readonly IBookRepository _bookRepository;
        public CreateBookCommandValidator(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;

            RuleFor(p => p.Name)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
                .MaximumLength(50).WithMessage("{PropertyName} must not exceed 50 characters.");

            RuleFor(p => p.Date)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
                .GreaterThan(DateTime.Now);

            RuleFor(e => e)
                .MustAsync(BookNameAndDateUnique)
                .WithMessage("An Book with the same name and date already exists.");

            RuleFor(p => p.Price)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .GreaterThan(0);
        }

        private async Task<bool> BookNameAndDateUnique(
            CreateBookCommand e, CancellationToken token)
        {
            return !(await _bookRepository
                .IsBookNameAndDateUnique(e.Name, e.Date));
        }
    }
}
