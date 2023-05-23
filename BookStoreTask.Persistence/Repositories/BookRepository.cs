using BookStoreTask.Application.Contracts.Persistence;
using BookStoreTask.Domain.Entities;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreTask.Persistence.Repositories
{
     
   public class BookRepository : BaseRepository<BookRent>, IBookRepository
    {
        public BookRepository(BookDbContext dbContext) : base(dbContext)
        {
        }

        public Task<bool> IsBookNameAndDateUnique(string name, DateTime eventDate)
        {
            var matches = _dbContext.Events.Any(
                e => e.Name.Equals(name)
                && e.Date.Date.Equals(eventDate.Date));
            return Task.FromResult(matches);
        }

       
    }
}
