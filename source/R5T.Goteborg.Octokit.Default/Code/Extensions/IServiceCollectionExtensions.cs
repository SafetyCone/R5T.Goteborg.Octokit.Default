using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia.Extensions;


namespace R5T.Goteborg.Octokit.Default
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddDefaultOctokitGitHubOperatorServices<TProductHeaderValueProvider>(this IServiceCollection services)
            where TProductHeaderValueProvider: class, IProductHeaderValueProvider
        {
            services
                .AddSingleton<IGitHubOperator, GitHubOperator>()
                .AddSingleton<IGitHubClientProvider, GitHubClientProvider>()
                .AddSingleton<IAuthenticatedGitHubClientProvider, AuthenticatedGitHubClientProvider>()
                .AddSingleton<IUnauthenticatedGitHubClientProvider, UnauthenticatedGitHubClientProvider>()
                .AddSingleton<IProductHeaderValueProvider, TProductHeaderValueProvider>();
                ;

            return services;
        }
    }
}
