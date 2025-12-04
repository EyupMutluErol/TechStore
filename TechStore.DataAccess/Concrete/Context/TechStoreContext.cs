using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TechStore.Entities.Concrete;

namespace TechStore.DataAccess.Concrete.Context;

public class TechStoreContext : IdentityDbContext<AppUser, AppRole, string>
{
    public TechStoreContext(DbContextOptions<TechStoreContext> options) : base(options)
    {
    }

    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderDetail> OrderDetails { get; set; }


    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        // Kategori İlişkileri
        builder.Entity<Category>(entity =>
        {
            // Kategori-Alt Kategori ilişkisi
            entity.HasOne(x => x.ParentCategory)
            .WithMany(x => x.SubCategories)
            .HasForeignKey(x => x.ParentCategoryId)
            .OnDelete(DeleteBehavior.Restrict);

            // Kategori-Ürün ilişkisi
            entity.HasMany(x=>x.Products)
            .WithOne(x=>x.Category)
            .HasForeignKey(x=>x.CategoryId)
            .OnDelete(DeleteBehavior.Restrict);
        });

        // Sipariş İlişkileri
        builder.Entity<Order>(entity =>
        {
            // Sipariş-Kullanıcı ilişkisi
            entity.HasOne(x => x.User)
            .WithMany()
            .HasForeignKey(x => x.UserId)
            .OnDelete(DeleteBehavior.Restrict);

            // Sipariş-Sipariş Detayları ilişkisi
            entity.HasMany(x => x.OrderDetails)
            .WithOne(x => x.Order)
            .HasForeignKey(x => x.OrderId)
            .OnDelete(DeleteBehavior.Cascade);
        });

        // Sipariş Detayı İlişkileri
        builder.Entity<OrderDetail>(entity =>
        {
           // Sipariş Detayı-Ürün ilişkisi
            entity.HasOne(x => x.Product)
            .WithMany(x => x.OrderDetails)
            .HasForeignKey(x => x.ProductId)
            .OnDelete(DeleteBehavior.Restrict);
        });

        builder.Entity<Product>().HasQueryFilter(x => !x.IsDeleted);
        builder.Entity<Category>().HasQueryFilter(x => !x.IsDeleted);
        builder.Entity<Order>().HasQueryFilter(x => !x.IsDeleted);
        builder.Entity<AppUser>().HasQueryFilter(x => !x.IsDeleted);

    }
}
