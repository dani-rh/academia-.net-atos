using Anotações.DataModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anotações
{
    public class Contexto : DbContext
    {
        //Cada DbSet na classe Contexto, vai ser uma tabela no nosso banco de dados(SQL) CodeFirst. 
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Email> Emails { get; set; }

        public Contexto()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["EntityAtos"];

            //string retorno = "";

            //if (settings != null)
            //{
            //    retorno = settings.ConnectionString;
            //}

            //Ao invés de usar as infos acima, colocar a string de conexão da forma abaixo:
            optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=CodeFirst;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            //optionsBuilder.UseLazyLoadingProxies();

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Email>()
                .HasOne(e => e.pessoa)
                .WithMany(e => e.emails)
                .OnDelete(DeleteBehavior.Cascade);
        }

    }
}
