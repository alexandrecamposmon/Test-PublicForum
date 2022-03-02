using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.Extensions.DependencyInjection;
using PublicForum.ApplicationCore.Interfaces.Repository;
using PublicForum.ApplicationCore.Interfaces.Services;
using PublicForum.ApplicationCore.Services;
using PublicForum.Infrastructure.Context;
using PublicForum.Infrastructure.Repository;

namespace PublicForum.Configurations
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {

            //AUTHENTICATION
            services.AddScoped<AuthenticationStateProvider, CustomAuthStateProvider>();

            //CONTEXT
            services.AddScoped<ChallengeContext>();

            //REPOSITORIES
            services.AddScoped<ITopicRepository, TopicRepository>();
            services.AddScoped<ILoginRepository, LoginRepository>();

            //SERVICES
            services.AddScoped<ITopicService, TopicService>();
            services.AddScoped<ILoginService, LoginService>();


            return services;
        }
    }
}
