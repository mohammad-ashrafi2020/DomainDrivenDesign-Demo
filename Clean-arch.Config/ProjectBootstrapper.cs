using Clean_arch.Application.Products.Create;
using Clean_arch.Application.Shared;
using Clean_arch.Application.Users;
using Clean_arch.Contracts;
using Clean_arch.Domain.Orders.Repository;
using Clean_arch.Domain.Products;
using Clean_arch.Domain.UserAgg;
using Clean_arch.Infrastructure;
using Clean_arch.Infrastructure.Persistant.Ef;
using Clean_arch.Infrastructure.Persistant.Ef.Orders;
using Clean_arch.Infrastructure.Persistant.Ef.Products;
using Clean_arch.Infrastructure.Persistant.Ef.Users;
using Clean_arch.Query.Models.Products.Repository;
using Clean_arch.Query.Models.Users.Repository;
using Clean_arch.Query.Products.GetById;
using Clean_arch.Query.Shared.Repository;
using FluentValidation;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MongoDB.Driver;

namespace Clean_arch.Config
{
    public class ProjectBootstrapper
    {
        public static void Init(IServiceCollection services, string connectionString)
        {
            //Domain Services
            services.AddTransient<IUserDomainService, UserDomainService>();

            services.AddTransient<IProductRepository, ProductRepository>();
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IOrderRepository, OrderRepository>();
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(CommandValidationBehavior<,>));
            services.AddMediatR(typeof(CreateProductCommand).Assembly);
            services.AddMediatR(typeof(GetProductByIdQuery).Assembly);

            //services.AddTransient(typeof(IBaseReadRepository<>), typeof(BaseReadRepository<>));
            services.AddTransient<IUserReadRepository, UserReadRepository>();
            services.AddTransient<IProductReadRepository, ProductReadRepository>();

            services.AddSingleton<IMongoClient, MongoClient>(option =>
            {
                return new MongoClient("mongodb://localhost:27017");
            });
            services.AddValidatorsFromAssembly(typeof(CreateProductCommandValidator).Assembly);

            services.AddDbContext<AppDbContext>(option =>
            {
                option.UseSqlServer(connectionString);
            });
            services.AddScoped<ISmsService, SmsService>();
        }
    }
}