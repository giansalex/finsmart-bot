using System;
using System.Linq;
using System.Threading.Tasks;
using Factoring.Cli.Client;
using Factoring.Cli.Client.Models;

namespace Factoring.Cli
{
    public class BotInvest
    {
        private readonly IFinsmartApi _api;
        private DateTime _expire;
        private TokenResponse _auth;
        private Status _status;

        public event Action<string> Login;
        public string CredentialToken { get; set; }
        /// <summary>
        /// TEA minimo
        /// </summary>
        public decimal  MinTea { get; set; }

        /// <summary>
        /// Maximo dias de pago de factura.
        /// </summary>
        public int MaxDays { get; set; }

        public BotInvest(IFinsmartApi api)
        {
            _api = api;
        }

        protected virtual void OnLogin(string token)
        {
            Login?.Invoke(token);
        }

        public async Task Process()
        {
            while (true)
            {
                if (IsSessionExpired())
                {
                    await Authenticate();
                }

                if (_status == null)
                {
                    _status = await _api.Status(_auth.userId);
                    WriteLogStatus(_status);
                }

                if (_status.balance.saldoDisponiblePEN < 10)
                {
                    Console.WriteLine("¡¡¡Saldo Insuficiente!!!\nSaldo disponible: " + _status.balance.saldoDisponiblePEN);
                    break;
                }

                var opportunities = await _api.Opportunities();

                foreach (var opportunity in opportunities.OrderByDescending(o => o.tea))
                {
                    if (CanInvest(opportunity))
                    {
                        var montoAvailable = _status.balance.saldoDisponiblePEN;
                        var montoToInvertir = montoAvailable > opportunity.montoTotal ? opportunity.montoTotal: montoAvailable; 
                    
                        var result = await _api.Invest(new Investment
                        {
                            completo = true,
                            idFactura = opportunity.id,
                            inversionistaId = _auth.userId,
                            usuarioId = _auth.id,
                            moneda = opportunity.moneda,
                            montoInversion = montoToInvertir
                        });

                        var message = result.status ? $"Monto invertido {opportunity.moneda} {montoToInvertir}" : $"No es pudo invertir: {result.message}";
                        Console.WriteLine(message);

                        _status = await _api.Status(_auth.userId);
                        WriteLogStatus(_status);
                    }

                    await Task.Delay(60000);
                }
            }
        }

        private bool CanInvest(Opportunities opportunity)
        {
            return opportunity.montoTotal > 0 
                   && opportunity.tea > MinTea
                   && opportunity.diasCobro < MaxDays
                   && opportunity.moneda == "PEN";
        }

        private bool IsSessionExpired()
        {
            return _expire == default || _expire.AddDays(5) > DateTime.Now;
        }

        private async Task Authenticate()
        {
            _auth = await _api.Login(new Credentials {token = CredentialToken, username = string.Empty, password = string.Empty});
            var jwt = Jose.JWT.Payload<JwtToken>(_auth.accessToken);
            _expire = DateTimeOffset.FromUnixTimeSeconds(jwt.exp).LocalDateTime;

            OnLogin(_auth.accessToken);
            WriteLogUser();
        }

        private void WriteLogUser()
        {
            var separator = new string('-', 60);
            Console.WriteLine("\nLogin Successful!");
            Console.WriteLine("Token Expire: " + _expire);
            Console.WriteLine(separator);
            Console.WriteLine("User ID: " + _auth.id);
            Console.WriteLine("Investment ID: " + _auth.userId);
            Console.WriteLine($"Name: {_auth.names} {_auth.lastName1}");
        }

        private void WriteLogStatus(Status status)
        {
            var separator = new string('-', 60);
            Console.WriteLine(separator);
            Console.WriteLine($"Balance:   PEN {status.balance.saldoDisponiblePEN.ToString().PadLeft(10)}, USD {status.balance.saldoDisponibleUSD.ToString().PadLeft(10)}");
            Console.WriteLine($"Invertido: PEN {status.balance.inversionEnCursoPEN.ToString().PadLeft(10)}, USD {status.balance.inversionEnCursoUSD.ToString().PadLeft(10)}");
            Console.WriteLine($"Pendente:  PEN {status.porIniciar.porIniciarPEN.ToString().PadLeft(10)}, USD {status.porIniciar.porIniciarUSD.ToString().PadLeft(10)}");
            Console.WriteLine($"Total:     PEN {(status.balance.saldoDisponiblePEN + status.balance.inversionEnCursoPEN + status.porIniciar.porIniciarPEN).ToString().PadLeft(10)}, USD {(status.balance.saldoDisponibleUSD + status.balance.inversionEnCursoUSD + status.porIniciar.porIniciarUSD).ToString().PadLeft(10)}");
            Console.WriteLine(separator);
        }
    }
}
