﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreTask.Application.Book.Queries.GetBookList
{
    public class BookListVm
    {
        public IList<BookLookupDto> Books { get; set; }
    }
}
