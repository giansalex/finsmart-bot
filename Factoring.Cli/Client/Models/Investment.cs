namespace Factoring.Cli.Client.Models
{
    public class Investment
    {
        public bool completo { get; set; }
        public int idFactura { get; set; }
        public string moneda { get; set; }
        public decimal montoInversion { get; set; }
        public int inversionistaId { get; set; }
        public int usuarioId { get; set; }
    }
}
