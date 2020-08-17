using System.Collections.Generic;
using System.Threading.Tasks;
using Factoring.Cli.Client.Models;
using Refit;

namespace Factoring.Cli.Client
{
    [Headers("Authorization: Bearer",
             "User-Agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/79.0.3945.130 Safari/537.36")]
    public interface IFinsmartApi
    {
        [Post("/inversionista/iniciarSesion")]
        Task<AuthResponse> Authenticate(ClientUserPassword credentials);

        [Post("/api/oauth/login")]
        Task<TokenResponse> Login([Body(BodySerializationMethod.UrlEncoded)] Credentials credentials);

        [Get("/api/invoices/opportunities")]
        Task<List<Opportunities>> Opportunities();

        [Get("/api/investors/{id}/status")]
        Task<Status> Status([AliasAs("id")] int id);

        [Post("/api/investors/invertir")]
        Task<InvestResult> Invest(Investment invest);
    }
}
