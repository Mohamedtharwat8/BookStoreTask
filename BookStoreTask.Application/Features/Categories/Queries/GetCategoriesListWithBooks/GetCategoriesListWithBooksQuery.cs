using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreTask.Application.Features.Categories.Queries.GetCategoriesListWithBooks
{
    public  class GetCategoriesListWithBooksQuery : IRequest<List<CategoryBookListVm>>
    {
        public bool IncludeHistory { get; set; }
    }
}
