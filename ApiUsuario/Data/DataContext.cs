using System;
using ApiUsuario.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiUsuario.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}

