using Microsoft.Identity.Client;

namespace ConsoleAppSecurity
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            //var app = PublicClientApplicationBuilder
            //    .Create("")
            //    .WithAuthority(AzureCloudInstance.AzurePublic, "")
            //    .WithRedirectUri("http://localhost")
            //    .Build();

            var app = ConfidentialClientApplicationBuilder
                .Create("")
                .WithTenantId("")
                .WithClientSecret("")
                .WithRedirectUri("http://localhost")
                .Build();

            string[] scopes = { "user.read" };

            AuthenticationResult result = await app.AcquireTokenForClient(scopes).ExecuteAsync();

            Console.WriteLine(result.AccessToken);
        }
    }
}
