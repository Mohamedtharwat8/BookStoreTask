using AutoMapper;
using Blazored.LocalStorage;
using BookStoreTask.UI.Contracts;
using BookStoreTask.UI.Services.Base;
using BookStoreTask.UI.ViewModels;

namespace BookStoreTask.UI.Services
{
    
     public class BookDataService : BaseDataService, IBookDataService
    {

        private readonly IMapper _mapper;

        public BookDataService(IClient client, IMapper mapper, ILocalStorageService localStorage) 
            : base(client, localStorage)
        {
            _mapper = mapper;
        }

        public async Task<List<BookListViewModel>> GetAllBooks()
        {
            var allBooks = await _client.GetAllBooksAsync();
            var mappedBooks = _mapper.Map<ICollection<BookListViewModel>>(allBooks);
            return mappedBooks.ToList();
        }

        public async Task<BookDetailViewModel> GetBookById(Guid id)
        {
            var selectedBook = await _client.GetBookByIdAsync(id);
            var mappedEvent = _mapper.Map<BookDetailViewModel>(selectedBook);
            return mappedEvent;
        }

        public async Task<ApiResponse<Guid>> CreateBook(BookDetailViewModel bookDetailViewModel)
        {
            try
            {
                CreateBookCommand createBookCommand = _mapper.Map<CreateBookCommand>(bookDetailViewModel);
                var newId = await _client.AddBookAsync(createEventCommand);
                return new ApiResponse<Guid>() { Data = newId, Success = true };
            }
            catch (ApiException ex)
            {
                return ConvertApiExceptions<Guid>(ex);
            }
        }

        public async Task<ApiResponse<Guid>> UpdateBook(BookDetailViewModel bookDetailViewModel)
        {
            try
            {
                UpdateBookCommand updateEventCommand = _mapper.Map<UpdateBookCommand>(bookDetailViewModel);
                await _client.UpdateBookAsync(updateEventCommand);
                return new ApiResponse<Guid>() { Success = true };
            }
            catch (ApiException ex)
            {
                return ConvertApiExceptions<Guid>(ex);
            }
        }

        public async Task<ApiResponse<Guid>> DeleteBook(Guid id)
        {
            try
            {
                await _client.DeleteBookAsync(id);
                return new ApiResponse<Guid>() { Success = true };
            }
            catch (ApiException ex)
            {
                return ConvertApiExceptions<Guid>(ex);
            }
        }

       
    }
}
