using Microsoft.EntityFrameworkCore;
using RamenGo.API.Core.DTO;
using RamenGo.API.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RamenGo.API.Core.Contexto
{
    public class DB_Context : Microsoft.EntityFrameworkCore.DbContext
    {
        public DB_Context(DbContextOptions<DB_Context> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                //optionsBuilder.UseSqlServer("Server=bi013\\bi013c;Database=DB_CONTROLEBNDU;User Id=usr_controlebndu;Password=usr_controlebndu");
            }
        }
        //Tabelas
        public DbSet<Broth> Broths { get; set; }
        public DbSet<Protein> Proteins { get; set; }

        //Procedure
        public virtual DbSet<Status> sp_InserePedido { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Broth>(entity =>
            {
                entity.ToTable("Broth")
                .HasKey(s => s.id);
            });
            modelBuilder.Entity<Protein>(entity =>
            {
                entity.ToTable("Protein")
                .HasKey(s => s.id);
            });

            modelBuilder.Entity<Status>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("sp_InserePedido");
            });
        }
    }
}
