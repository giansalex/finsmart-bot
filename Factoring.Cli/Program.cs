using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Factoring.Cli.Client;
using Factoring.Cli.Client.Models;
using Refit;

namespace Factoring.Cli
{
    class Program
    {
        private static string Token = "";
        static async Task Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("Application only require one parameter (login token).");
                Console.ReadKey();

                return;
            }
            var login = args[0];

            var bot = new BotInvest(CreateClient())
            {
                CredentialToken = login,
                MinTea = 16,
                MaxDays = 100,
            };
            bot.Login += token => Token = token;

            await bot.Process();
        }

        static IFinsmartApi CreateClient()
        {
            return RestService.For<IFinsmartApi>(new HttpClient(new AuthenticatedHttpClientHandler(() => Task.FromResult(Token)))
            {
                BaseAddress = new Uri("https://app.finsmart.pe")
            });
        }
    }
}
