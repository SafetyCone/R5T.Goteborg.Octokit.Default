using System;

using Octokit;


namespace R5T.Goteborg.Octokit.Default
{
    /// <summary>
    /// Default GitHub client is authenticted.
    /// Uses the <see cref="IAuthenticatedGitHubClientProvider"/> service to return an authenticated GitHub client.
    /// </summary>
    public class GitHubClientProvider : IGitHubClientProvider
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
