using AutoMapper;
using BookStoreTask.Application.Contracts.Persistence;
using BookStoreTask.Application.Exceptions;
using BookStoreTask.Domain.Entities;
using MediatR; 

namespace BookStoreTask.Application.Features.Books.Queries.GetBookDetail
{
    
    public class GetBookDetailQueryHandler 
        : IRequestHandler<GetBookDetailQuery, BookDetailVm>
    {
        private readonly IAsyncRepository<BookRent> _bookRepository;
        private readonly IAsyncRepository<Category> _categoryRepository;
        private readonly IMapper _mapper;

        public GetBookDetailQueryHandler(
            IMapper mapper, 
            IAsyncRepository<BookRent> bookRepository, 
            IAsyncRepository<Category> categoryRepository)
        {
            _mapper = mapper;
            _bookRepository = bookRepository;
            _categoryRepository = categoryRepository;
        }

        public async Task<BookDetailVm> Handle(GetBookDetailQuery request, CancellationToken cancellationToken)
        {
            var @book = await _bookRepository.GetByIdAsync(request.Id);
            var bookDetailDto = _mapper.Map<BookDetailVm>(@book);

            var category = await _categoryRepository.GetByIdAsync(
                @book.CategoryId);

            if (category == null)
            {
                throw new NotFoundException(nameof(BookRent), request.Id);
            }
            bookDetailDto.Category = _mapper.Map<CategoryDto>(category);

            return bookDetailDto;
        }
    }
}
