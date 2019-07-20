using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace App.Models
{
    public class BookContext : DbContext
    {
        public BookContext(DbContextOptions<BookContext> options)
            : base(options)
        {
        }

        public DbSet<App.Models.Book> Book { get; set; }
    }
}
