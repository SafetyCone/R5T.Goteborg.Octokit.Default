using System;

using Octokit;using R5T.T0064;


namespace R5T.Goteborg.Octokit.Default
{[ServiceImplementationMarker]
    /// <summary>
    /// Default unauthenticated GitHub client provider uses the <see cref="IProductHeaderValueProvider"/> service to just provide an unauthenticated GitHub client.
    /// </summary>
    public class UnauthenticatedGitHubClientProvider : IUnauthenticatedGitHubClientProvider,IServiceImplementation
    {
        private IProductHeaderValueProvider ProductHeaderValueProvider { get; }


        public UnauthenticatedGitHubClientProvider(IProductHeaderValueProvider productHeaderValueProvider)
        {
            this.ProductHeaderValueProvider = productHeaderValueProvider;
        }

        public GitHubClient GetUnauthenticatedGitHubClient()
        {
            var productHeaderValue = this.ProductHeaderValueProvider.GetProductHeaderValue();

            var gitHubClient = new GitHubClient(productHeaderValue);
            return gitHubClient;
        }
    }
}
