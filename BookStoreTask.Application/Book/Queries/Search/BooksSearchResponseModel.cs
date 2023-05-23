using BookStoreTask.Application.Book.Queries.Common;
using BookStoreTask.Application.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreTask.Application.Book.Queries.Search
{
    public class BooksSearchResponseModel : PaginatedResponseModel<BookResponseModel>
    {
        internal BooksSearchResponseModel(
            IEnumerable<BookResponseModel> books,
            int page,
            int totalPages)
            : base(books, page, totalPages)
        {
        }
    }
}
