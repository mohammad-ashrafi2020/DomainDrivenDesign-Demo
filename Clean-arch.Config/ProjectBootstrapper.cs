﻿using Clean_arch.Contracts;
using Clean_arch.Domain.OrderAgg.Services;
using Clean_arch.Domain.Orders.Repository;
using Clean_arch.Domain.Products;
using Clean_arch.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using MediatR;
using Clean_arch.Application.Products.Create;
using Clean_arch.Infrastructure.Persistant.Ef;
using Microsoft.EntityFrameworkCore;
using Clean_arch.Infrastructure.Persistant.Ef.Products;
using Clean_arch.Domain.UserAgg;
using Clean_arch.Infrastructure.Persistant.Ef.Users;
using Clean_arch.Infrastructure.Persistant.Ef.Orders;

namespace Clean_arch.Config
{
    public class ProjectBootstrapper
    {
        public static void Init(IServiceCollection services,string connectionString)
        {
            services.AddTransient<IProductRepository, ProductRepository>();
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IOrderRepository, OrderRepository>();

            services.AddMediatR(typeof(CreateProductCommand).Assembly);
            services.AddDbContext<AppDbContext>(option =>
            {
                option.UseSqlServer(connectionString);
            });
            services.AddScoped<ISmsService, SmsService>();
        }
    }
}