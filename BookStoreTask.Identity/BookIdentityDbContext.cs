using BookStoreTask.Identity.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreTask.Identity
{
 
    public class BookIdentityDbContext : IdentityDbContext<ApplicationUser>
    {
        public BookIdentityDbContext()
        {

        }

        public BookIdentityDbContext(DbContextOptions<BookIdentityDbContext> options) : base(options)
        {
        }
    }
}
