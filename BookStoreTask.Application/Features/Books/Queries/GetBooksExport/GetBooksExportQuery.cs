using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreTask.Application.Features.Books.Queries.GetBooksExport
{
  
   public class GetBooksExportQuery : IRequest<BookExportFileVm>
    {
    }
}
