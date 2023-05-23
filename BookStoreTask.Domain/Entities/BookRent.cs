using BookStoreTask.Domain.Common;
using System.ComponentModel.DataAnnotations;

namespace BookStoreTask.Domain.Entities
{
    public class BookRent : AuditableEntity
    {
        [Key]
        public Guid BookId { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Price { get; set; }
        public string? Author { get; set; }
        public DateTime Date { get; set; }
        public string? Description { get; set; }
        public string? ImageUrl { get; set; }
        public int Quantity { get; set; }
        public Guid CategoryId { get; set; }
        public Category Category { get; set; } = default!;
    }
}