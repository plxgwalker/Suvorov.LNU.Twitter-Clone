﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Suvorov.LNU.TwitterClone.Database.Services;
using Suvorov.LNU.TwitterClone.Models.Database;

namespace Suvorov.LNU.TwitterClone.Database
{
    public static class DIConfiguration
    {
        public static void RegisterDatabseDependencies(this IServiceCollection services, IConfigurationRoot configuration)
        {
            services.AddDbContext<NetworkDbContext>((x) => x.UseSqlServer(configuration.GetConnectionString("NetworkDatabase")));

            services.AddScoped(typeof(DbEntityService<>), typeof(DbEntityService<>));
            //services.AddScoped<DbEntityService<User>, UserService>();
        }
    }
}
