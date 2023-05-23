using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreTask.Application.Features.Books.Queries.GetBooksExport
{
    
    public class BookExportDto
    {
        public Guid BookId { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime Date { get; set; }
    }
}
