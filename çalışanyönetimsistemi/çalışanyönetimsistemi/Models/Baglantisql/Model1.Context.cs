namespace çalışanyönetimsistemi.Models.Baglantisql
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class çalışanyönetimsistemiEntities : DbContext
    {
        public çalışanyönetimsistemiEntities()
            : base("name=çalışanyönetimsistemiEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<admingirişi> admingirişi { get; set; }
        public virtual DbSet<kullanicigirişi> kullanicigirişi { get; set; }
    }
}
