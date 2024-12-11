using API.BLL.Services;
using API.BLL.Services.Interfaces;
using API.DAL.Repository;
using API.DAL.Repository.Interfaces;

namespace API.Extensions;

public static class ServiceExtensions
{
    public static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        services.AddScoped<IBikeModelRepository, BikeModelRepository>();
        services.AddScoped<IBikeRepository,BikeRepository>();
        services.AddScoped<IBrandRepository,BrandRepository>();
        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<IRentingCenterRepository, RentingCenterRepository>();
        return services;
    }
    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        services.AddScoped<IBikeModelService, BikeModelService>();
        services.AddScoped<IBikeService, BikeService>();
        services.AddScoped<IBrandService, BrandService>();
        services.AddScoped<IUserService, UserService>();
        services.AddScoped<IRentingCenterService, RentingCenterService>();
        return services;
    }
}
