using BookStoreTask.Application.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreTask.Application.Book.Queries.Search
{
    public class BooksSearchSortOrder : SortOrder<BookStoreTask.Domain.Entities.Book>
    {
        public BooksSearchSortOrder(string? sortBy, string? order)
            : base(sortBy, order)
        {
        }

        public override Expression<Func<BookStoreTask.Domain.Entities.Book,
            object>> ToExpression()
            => this.SortBy switch
            {
                "title" => book => book.Title,
                "price" => book => book.Price,
                "author" => book => book.Author,
                _ => book => book.Id
            };
    }
}
