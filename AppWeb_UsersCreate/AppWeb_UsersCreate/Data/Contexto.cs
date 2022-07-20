using AppWeb_UsersCreate.Models;
using Microsoft.EntityFrameworkCore;

namespace AppWeb_UsersCreate.Data
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) 
            : base(options)
        { }

        public DbSet<Cliente> Cliente { get; set; }

    }
}






