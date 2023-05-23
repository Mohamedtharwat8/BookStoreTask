using BookStoreTask.Application.Contracts.Persistence;
using BookStoreTask.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreTask.Persistence.Repositories
{
    public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(BookDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<List<Category>> GetCategoriesWithEvents(bool includePassedEvents)
        {
            var allCategories = await _dbContext.Categories.Include(x => x.Books).ToListAsync();
            if (!includePassedEvents)
            {
                allCategories.ForEach(p => p.Books.ToList().RemoveAll(c => c.Date < DateTime.Today));
            }
            return allCategories;
        }
    }
}
