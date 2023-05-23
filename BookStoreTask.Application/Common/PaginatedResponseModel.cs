using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreTask.Application.Common
{

    public abstract class PaginatedResponseModel<TResponseModel>
    {
        protected internal PaginatedResponseModel(
            IEnumerable<TResponseModel> models,
            int page,
            int totalPages)
        {
            this.Models = models;
            this.Page = page;
            this.TotalPages = totalPages;
        }

        public IEnumerable<TResponseModel> Models { get; }

        public int Page { get; }

        public int TotalPages { get; }
    }
}
