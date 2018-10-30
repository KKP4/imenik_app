using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using imenik_app.Models;
using Microsoft.EntityFrameworkCore;

namespace imenik_app.imenikDB
{
    public class ImenikDbContext : DbContext
    {
        public ImenikDbContext(DbContextOptions<ImenikDbContext> options)
            : base(options) { }

        public DbSet<Kontakt> Kontakti { get; set; }
    }
}