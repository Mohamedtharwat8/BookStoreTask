﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreTask.Application.Features.Books.Queries.GetBooksList
{
    public  class BookListVm
    {
        public Guid BookId { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime Date { get; set; }
        public string? ImageUrl { get; set; } 
        public int Price { get; set; }
        public string? Author { get; set; } 
        public string? Description { get; set; } 
        public int Quantity { get; set; }
    }
}
