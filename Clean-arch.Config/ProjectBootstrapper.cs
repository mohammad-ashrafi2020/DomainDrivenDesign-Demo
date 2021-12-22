using Clean_arch.Application.Orders;
using Clean_arch.Application.Orders.Services;
using Clean_arch.Application.Products;
using Clean_arch.Contracts;
using Clean_arch.Domain.OrderAgg.Services;
using Clean_arch.Domain.Orders.Repository;
using Clean_arch.Domain.Products;
using Clean_arch.Infrastructure;
using Clean_arch.Infrastructure.Persistent.Memory;
using Clean_arch.Infrastructure.Persistent.Memory.Orders;
using Clean_arch.Infrastructure.Persistent.Memory.Products;
using Microsoft.Extensions.DependencyInjection;

namespace Clean_arch.Config
{
    public class ProjectBootstrapper
    {
        public static void Init(IServiceCollection services)
        {
            services.AddTransient<IOrderService, OrderService>();
            services.AddTransient<IProductService, ProductService>();
            services.AddTransient<IOrderRepository, OrderRepository>();
            services.AddTransient<IProductRepository, ProductRepository>();
            services.AddTransient<IOrderDomainService, OrderDomainService>();

            services.AddScoped<ISmsService, SmsService>();
            services.AddSingleton<Context>();
        }
    }
}