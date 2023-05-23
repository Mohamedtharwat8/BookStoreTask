﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreTask.Application.Features.Categories.Queries.GetCategoriesListWithBooks
{
    public  class CategoryBookDto
    {
        public Guid BookId { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Price { get; set; }
        public string? Artist { get; set; }
        public DateTime Date { get; set; }
        public Guid CategoryId { get; set; }
    }
}
