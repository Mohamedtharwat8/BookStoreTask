namespace BookStoreTask.UI.ViewModels
{
    public class CategoryBooksViewModel
    {
        public Guid CategoryId { get; set; }
        public string Name { get; set; } = string.Empty;
        public ICollection<BookNestedViewModel>? Events { get; set; }
    }
}
