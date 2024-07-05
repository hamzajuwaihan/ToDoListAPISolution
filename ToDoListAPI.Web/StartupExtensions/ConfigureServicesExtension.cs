using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ToDoListAPI.Core.Domain.IdentityEntities;
using ToDoListAPI.Core.Services;
using ToDoListAPI.Core.ServicesContracts;
using ToDoListAPI.Infastructure.Db;

namespace ToDoListAPI.Web.StartupExtensions
{
    public static class ConfigureServicesExtension
    {
        public static IServiceCollection ConfigureServices(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddControllers();

            services.AddScoped<IAddTodoTaskService, AddTodoTaskService>();
            services.AddScoped<IDeleteTodoTaskService, DeleteTodoTaskService>();
            services.AddScoped<IGetTodoTaskService, GetTodoTaskService>();
            services.AddScoped<IUpdateTodoTaskService, UpdateTodoTaskService>();

            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            });

            services.AddIdentity<ApplicationUser, IdentityRole<Guid>>()
             .AddEntityFrameworkStores<ApplicationDbContext>()
             .AddDefaultTokenProviders();

            return services;
        }
    }
}
