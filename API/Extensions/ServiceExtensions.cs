using API.BLL.Services;
using API.BLL.Services.Interfaces;
using API.DAL.Repository;
using API.DAL.Repository.Interfaces;
using Microsoft.OpenApi.Models;

namespace API.Extensions;

public static class ServiceExtensions
{
    public static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        services.AddScoped<IBikeModelRepository, BikeModelRepository>();
        services.AddScoped<IBikeRepository, BikeRepository>();
        services.AddScoped<IBrandRepository, BrandRepository>();
        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<IOrderRepository,OrderRepository>();
        services.AddScoped<IRentingCenterRepository, RentingCenterRepository>();
        return services;
    }
    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        services.AddScoped<IBikeModelService, BikeModelService>();
        services.AddScoped<IBikeService, BikeService>();
        services.AddScoped<IBrandService, BrandService>();
        services.AddScoped<IUserService, UserService>();
        services.AddScoped<IOrderService,OrderService>();
        services.AddScoped<IRentingCenterService, RentingCenterService>();
        return services;
    }
    public static IServiceCollection AddSwaggerAuthenticationUi(this IServiceCollection services)
    {
        services.AddSwaggerGen(swagger =>
        {
            //This is to generate the Default UI of Swagger Documentation
            swagger.SwaggerDoc("v1", new OpenApiInfo
            {
                Version = "v1",
                Title = "JWT Token Authentication API",
                Description = ".NET 8 Web API"
            });
            // To Enable authorization using Swagger (JWT)
            swagger.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
            {
                Name = "Authorization",
                Type = SecuritySchemeType.ApiKey,
                Scheme = "Bearer",
                BearerFormat = "JWT",
                In = ParameterLocation.Header,
                Description = "JWT Authorization header using the Bearer scheme. \r\n\r\n Enter 'Bearer' [space] and then your token in the text input below.\r\n\r\nExample: \"Bearer 12345abcdef\"",
            });
            swagger.AddSecurityRequirement(new OpenApiSecurityRequirement
            {
                    {
                          new OpenApiSecurityScheme
                            {
                                Reference = new OpenApiReference
                                {
                                    Type = ReferenceType.SecurityScheme,
                                    Id = "Bearer"
                                }
                            },
                            new string[] {}

                    }
            });
        });

        return services;
    }
}

