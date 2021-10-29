using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestWeek8.Core.Models;

namespace TestWeek8.EF
{
    public class RistoranteContext : DbContext
    {
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Piatto> Piatti { get; set; }
        public DbSet<Utente> Utenti { get; set; }

        public RistoranteContext(DbContextOptions<RistoranteContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            #region MENU
            var menuEntity = builder.Entity<Menu>();

            menuEntity.HasKey(m => m.IdMenu);

            menuEntity.Property(m => m.Nome)
                      .IsRequired()
                      .HasMaxLength(50);

            menuEntity.HasMany(m => m.Piatti);

            menuEntity.HasData(
                new Menu
                {
                    IdMenu = 1,
                    Nome = "Menu giornaliero"
                },

                new Menu
                {
                    IdMenu = 2,
                    Nome = "Menu serale"
                }
            );
            #endregion


            #region PIATTI
            var piattoEntity = builder.Entity<Piatto>();

            piattoEntity.HasKey(p => p.IdPiatto);

            piattoEntity.Property(p => p.Nome)
                        .IsRequired()
                        .HasMaxLength(50);

            piattoEntity.Property(p => p.Descrizione)
                        .IsRequired()
                        .HasMaxLength(200);

            piattoEntity.Property(p => p.Tipologia)
                        .IsRequired();

            piattoEntity.Property(p => p.Prezzo)
                        .IsRequired();

            piattoEntity.HasOne(m => m.menuAppartenenza)
                        .WithMany(p => p.Piatti)
                        .HasForeignKey(p => p.MenuID);

            piattoEntity.HasData(
                new Piatto
                {
                    IdPiatto = 1,
                    Nome = "Tagliatelle al Ragu",
                    Descrizione = "piatto di tagliatelle al ragu di carne, 100g",
                    Tipologia = Typology.Primo,
                    Prezzo = 12.55M,
                    MenuID = 1
                },

                new Piatto
                {
                    IdPiatto = 2,
                    Nome = "Verdure miste",
                    Descrizione = "selezione di verdure miste",
                    Tipologia = Typology.Contorno,
                    Prezzo = 12.55M,
                    MenuID = 1
                },

                new Piatto
                {
                    IdPiatto = 3,
                    Nome = "Brodo di carne",
                    Descrizione = "brodo di carne di manzo ",
                    Tipologia = Typology.Primo,
                    Prezzo = 12.55M,
                    MenuID = 2
                },

                new Piatto
                {
                    IdPiatto = 4,
                    Nome = "Cotoletta",
                    Descrizione = "cotoletta alla milanese",
                    Tipologia = Typology.Secondo,
                    Prezzo = 12.55M,
                    MenuID = 2
                }
            );
            #endregion


            #region UTENTE
            var utenteEntity = builder.Entity<Utente>();

            utenteEntity.HasKey(u => u.IdUtente);

            utenteEntity.Property(u => u.Email)
                        .IsRequired();

            utenteEntity.Property(u => u.Password)
                        .IsRequired();

            utenteEntity.Property(u => u.Tipo)
                        .IsRequired();

            utenteEntity.HasData(
                new Utente
                {
                    IdUtente = 1,
                    Email = "Giovanni.Storti@gmail.com",
                    Password = "pdor",
                    Tipo = Core.Models.Type.Ristoratore
                },
                new Utente
                {
                    IdUtente = 2,
                    Email = "Giacomino.Poretti@gmail.com",
                    Password = "tafazzi",
                    Tipo = Core.Models.Type.Cliente
                },

                new Utente
                {
                    IdUtente = 3,
                    Email = "Aldo.Baglio@gmail.com",
                    Password = "rolando",
                    Tipo = Core.Models.Type.Cliente
                }
                );
            #endregion
        }
    }
}
