using BookStoreTask.Domain.Entities;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreTask.Application.Contracts.Persistence
{
  
  public interface IBookRepository : IAsyncRepository<BookRent>
    {
        Task<bool> IsBookNameAndDateUnique(string name, DateTime eventDate);
    }
}
