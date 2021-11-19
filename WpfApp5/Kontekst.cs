using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp5
{
    public class Kontekst : DbContext
    {
        public DbSet<Osoba> Peoplez { get; set; }
        public DbSet<Adresa> Adresaz { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TestDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Osoba>().HasKey(o => o.Id);
            modelBuilder.Entity<Adresa>().HasKey(a => a.Id);

            modelBuilder.Entity<Osoba>().HasOne(o => o.Adresa)
                .WithOne(a => a.Osoba)
                .HasForeignKey<Osoba>(o => o.Adresa_Id);

            modelBuilder.Entity<Adresa>().HasData
                (
                    new Adresa[]
                    {
                        new Adresa{ Broj = "23", Grad="asd", Ulica="Zklj", Id=-1},
                        new Adresa{ Broj = "13/a/31", Grad="dgdgdrg", Ulica="Neakjh", Id=-2},
                        new Adresa{ Broj = "segf34", Grad="vsvse", Ulica="setse", Id=-3}
                    }
                );
            modelBuilder.Entity<Osoba>().HasData
                (
                    new Osoba[]
                    {
                        new Osoba{ Id = -1, Adresa_Id = -2, Ime = "Pera", Prezime = "Peric"},
                        new Osoba{ Id = -2, Adresa_Id = -3, Ime = "Neko", Prezime = "Nekic"},
                        new Osoba{ Id = -3, Adresa_Id = -1, Ime = "Trecko", Prezime = "Treckovic"}
                    }
                );

            base.OnModelCreating(modelBuilder);
        }
    }
}
