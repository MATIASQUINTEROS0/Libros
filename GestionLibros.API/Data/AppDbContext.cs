using Microsoft.EntityFrameworkCore;
using GestionLibros.API.Models;
using System.Collections.Generic;

namespace GestionLibros.API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Libro> Libros { get; set; } 
        holaa
    }
}

