namespace çalışanyönetimsistemi.Models.Baglantisql
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class çalışanyönetimsistemiEntities2 : DbContext
    {
        public çalışanyönetimsistemiEntities2()
            : base("name=çalışanyönetimsistemiEntities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<admingirişi> admingirişi { get; set; }
        public virtual DbSet<avanstalep> avanstalep { get; set; }
        public virtual DbSet<çalışanbilgileri> çalışanbilgileri { get; set; }
        public virtual DbSet<iletişim> iletişim { get; set; }
        public virtual DbSet<izintalep> izintalep { get; set; }
        public virtual DbSet<kullaniciadi> kullanicigirişi { get; set; }
    }
}
