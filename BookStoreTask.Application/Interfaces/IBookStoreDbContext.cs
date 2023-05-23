using Microsoft.EntityFrameworkCore;
using BookStoreTask.Domain.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreTask.Application.Interfaces
{
    public interface IBookStoreDbContext
    {
        DbSet<Book> Books { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
