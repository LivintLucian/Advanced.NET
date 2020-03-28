namespace Laboratorul5
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SelfReference_DBEntities : DbContext
    {
        public SelfReference_DBEntities()
            : base("name=SelfReference_DBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<SelfReference> SelfReferences { get; set; }
    }
}