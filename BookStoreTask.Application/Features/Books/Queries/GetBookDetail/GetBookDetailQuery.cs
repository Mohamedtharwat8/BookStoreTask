using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreTask.Application.Features.Books.Queries.GetBookDetail
{
   
  public class GetBookDetailQuery : IRequest<BookDetailVm>
    {
        public Guid Id { get; set; }
    }
}
