using BitirmeProjesi.Data.Migrations;
using BitirmeProjesi.Data.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitirmeProjesi.Data
{
    public class Context: DbContext
    {
        public Context():base("Context")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<Context, Configuration>("Context"));
        }
        public DbSet<Kampanya> Kampanyalar { get; set; }
        public DbSet<Aday> Adaylar { get; set; }
        public DbSet<Secim> Secimler { get; set; }
        public DbSet<Kullanicilar> Kullanicilar { get; set; }
        public DbSet<Sehir> Sehirler { get; set; }
        public DbSet<Ilce> Ilceler { get; set; }
        //public DbSet<OyTablo> Oylar { get; set; }
        //public DbSet<Oylarr> Oylarrs { get; set; }
        public DbSet<OyKullanmaTablosu> Oys { get; set; }
        public DbSet<OyKullanTablo> Oylar { get; set; }
       
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Entity<Aday>()
                .HasRequired(a => a.Kullanici)
                .WithMany()
                .HasForeignKey(a => a.KullaniciId);

            modelBuilder.Entity<Aday>()
                .HasRequired(a => a.Secim)
                .WithMany()
                .HasForeignKey(a => a.SecimId);

            modelBuilder.Entity<Ilce>()
                .HasRequired(i => i.Sehir)
                .WithMany()
                .HasForeignKey(i => i.SehirId);
            modelBuilder.Entity<OyKullanmaTablosu>()
                .HasRequired(oyy => oyy.Secim)
                .WithMany()
                .HasForeignKey(oyy => oyy.SecimId)
                .WillCascadeOnDelete(false);
            modelBuilder.Entity<OyKullanmaTablosu>()
                .HasRequired(oyy => oyy.Aday)
                .WithMany()
                .HasForeignKey(oyy => oyy.AdayId);


            modelBuilder.Entity<OyKullanTablo>()
                .HasRequired(o => o.Secim)
                .WithMany()
                .HasForeignKey(o => o.SecimId)
                .WillCascadeOnDelete(false);
            modelBuilder.Entity<OyKullanTablo>()
                .HasRequired(o => o.Aday)
                .WithMany()
                .HasForeignKey(o => o.AdayId);
            //modelBuilder.Entity<OyTablo>()
            //    .HasRequired(o => o.Aday)
            //    .WithMany()
            //    .HasForeignKey(o => o.AdayId);

            //modelBuilder.Entity<OyTablo>()
            //    .HasRequired(os => os.Secim)
            //    .WithMany()
            //    .HasForeignKey(os => os.SecimId);


     




            base.OnModelCreating(modelBuilder);
        }
    }
}
