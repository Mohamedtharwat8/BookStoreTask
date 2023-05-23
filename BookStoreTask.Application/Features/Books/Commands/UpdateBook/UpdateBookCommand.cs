using BookStoreTask.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreTask.Application.Features.Books.Commands.UpdateBook
{
   
    public class UpdateBookCommand : IRequest
    { 
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
