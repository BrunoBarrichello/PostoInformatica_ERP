using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;

namespace PostoInformatica_ERP.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions options) 
            : base(options)
        {
        }

        public DbSet<CLIENTES> Cliente { get; set; }
        public DbSet<USUARIO> USUARIO { get; set; }

    }
}
