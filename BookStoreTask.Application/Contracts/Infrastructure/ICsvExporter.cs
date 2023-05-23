using BookStoreTask.Application.Features.Books.Queries.GetBooksExport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreTask.Application.Contracts.Infrastructure
{
    public interface ICsvExporter
    {
        byte[] ExportBooksToCsv(List<BookExportDto> bookExportDtos);
    }
}
