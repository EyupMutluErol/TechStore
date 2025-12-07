using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using TechStore.Business.Abstract;
using TechStore.Business.Concrete;
using TechStore.DataAccess.Abstract;
using TechStore.DataAccess.Concrete.Context;
using TechStore.DataAccess.Concrete.EntityFramework;

namespace TechStore.Business
{
    public static class ServiceRegistration
    {
        public static void AddBusinessServices(this IServiceCollection services , IConfiguration configuration)
        {
            // 1. Veritabanı Bağlantısı (EF Core)
            services.AddDbContext<TechStoreContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            // 2. Generic Yapıların Kaydı (Repository & Service)
            services.AddScoped(typeof(IGenericRepository<>), typeof(EfGenericRepository<>));
            services.AddScoped(typeof(IGenericService<>), typeof(GenericServiceManager<>));

            // 3. Özel Repository Kayıtları
            services.AddScoped<ICategoryRepository, EfCategoryRepository>();
            services.AddScoped<IProductRepository, EfProductRepository>();
            services.AddScoped<IOrderRepository, EfOrderRepository>();
            services.AddScoped<IOrderDetailRepository, EfOrderDetailRepository>();

            // 4. Özel Service (Manager) Kayıtları
            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddScoped<IProductService, ProductManager>();
            services.AddScoped<IOrderService, OrderManager>();
            services.AddScoped<IOrderDetailService, OrderDetailManager>();
            services.AddScoped<IAppUserService, AppUserManager>();

            // 5. AutoMapper Kaydı
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            // 6. FluentValidation Kaydı
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
