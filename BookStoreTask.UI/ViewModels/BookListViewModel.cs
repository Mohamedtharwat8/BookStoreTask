namespace BookStoreTask.UI.ViewModels
{
    public class BookListViewModel
    {
        public Guid BookId { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime Date { get; set; }
        public string? ImageUrl { get; set; }
    }
}
