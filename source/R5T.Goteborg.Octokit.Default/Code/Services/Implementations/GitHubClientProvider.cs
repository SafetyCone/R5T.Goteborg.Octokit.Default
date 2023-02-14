using System;

using Octokit;

using R5T.T0064;


namespace R5T.Goteborg.Octokit.Default
{
    /// <summary>
    /// Default GitHub client is authenticted.
    /// Uses the <see cref="IAuthenticatedGitHubClientProvider"/> service to return an authenticated GitHub client.
    /// </summary>
    [ServiceImplementationMarker]
    public class GitHubClientProvider : IGitHubClientProvider,IServiceImplementation
    {
        private IAuthenticatedGitHubClientProvider AuthenticatedGitHubClientProvider { get; }


        public GitHubClientProvider(IAuthenticatedGitHubClientProvider authenticatedGitHubClientProvider)
        {
            this.AuthenticatedGitHubClientProvider = authenticatedGitHubClientProvider;
        }

        public GitHubClient GetGitHubClient()
        {
            var gitHubClient = this.AuthenticatedGitHubClientProvider.GetAuthenticatedGitHubClient();
            return gitHubClient;
        }
    }
}
