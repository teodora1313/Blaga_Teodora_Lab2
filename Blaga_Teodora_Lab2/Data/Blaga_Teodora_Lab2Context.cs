using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Blaga_Teodora_Lab2.Models;

namespace Blaga_Teodora_Lab2.Data
{
    public class Blaga_Teodora_Lab2Context : DbContext
    {
        public Blaga_Teodora_Lab2Context (DbContextOptions<Blaga_Teodora_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Blaga_Teodora_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Blaga_Teodora_Lab2.Models.Publisher> Publisher { get; set; } = default!;
        public DbSet<Blaga_Teodora_Lab2.Models.Author> Author { get; set; } = default!;
    }
}
