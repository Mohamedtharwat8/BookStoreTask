using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreTask.Application.Features.Categories.Queries.GetCategoriesListWithBooks
{
    public class CategoryBookListVm
    {
        public Guid CategoryId { get; set; }
        public string Name { get; set; } = string.Empty;
        public ICollection<CategoryBookDto>? Books { get; set; }
    }
}
