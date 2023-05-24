using BookStoreTask.UI.Services.Base;
using BookStoreTask.UI.ViewModels;

namespace BookStoreTask.UI.Contracts
{
     
    public interface IBookDataService
    {
        Task<List<BookListViewModel>> GetAllBooks();
        Task<BookDetailViewModel> GetBookById(Guid id);
        Task<ApiResponse<Guid>> CreateBook(BookDetailViewModel BookDetailViewModel);
        Task<ApiResponse<Guid>> UpdateBook(BookDetailViewModel BookDetailViewModel);
        Task<ApiResponse<Guid>> DeleteBook(Guid id);
    }
}
