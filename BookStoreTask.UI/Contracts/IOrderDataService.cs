using BookStoreTask.UI.ViewModels;

namespace BookStoreTask.UI.Contracts
{
    public interface IOrderDataService
    {
        Task<PagedOrderForMonthViewModel> GetPagedOrderForMonth(DateTime date, int page, int size);
    }
}
