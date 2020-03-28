namespace ConsoleApp1
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ProductContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public ProductContext() : base("name=ProductContext")
        { }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>()
            .Map(m =>
            {
                m.Properties(p => new { p.SKU, p.Description, p.Price });
                m.ToTable("Product", "BazaDeDate");
            })
            .Map(m =>
            {
                m.Properties(p => new { p.SKU, p.ImageURL });
                m.ToTable("ProductWebInfo", "BazaDeDate");
            });
        }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}