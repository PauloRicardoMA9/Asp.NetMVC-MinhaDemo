using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MinhaDemo.Models;

namespace MinhaDemo.Data
{
    public class MinhaDemoContext : DbContext
    {
        public MinhaDemoContext (DbContextOptions<MinhaDemoContext> options)
            : base(options)
        {
        }

        public DbSet<Filme> Filme { get; set; }
    }
}
