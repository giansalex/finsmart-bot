namespace Factoring.Cli.Client.Models
{
    public class Zone
    {
        public bool @fixed { get; set; }
        public string id { get; set; }
    }

    public class Chronology
    {
        public Zone zone { get; set; }
    }

    public class FechaEmision
    {
        public int year { get; set; }
        public int dayOfMonth { get; set; }
        public int dayOfYear { get; set; }
        public int dayOfWeek { get; set; }
        public int era { get; set; }
        public int weekOfWeekyear { get; set; }
        public int hourOfDay { get; set; }
        public int minuteOfHour { get; set; }
        public int secondOfMinute { get; set; }
        public int millisOfSecond { get; set; }
        public int centuryOfEra { get; set; }
        public int yearOfEra { get; set; }
        public int yearOfCentury { get; set; }
        public int weekyear { get; set; }
        public int monthOfYear { get; set; }
        public int millisOfDay { get; set; }
        public int secondOfDay { get; set; }
        public int minuteOfDay { get; set; }
        public long millis { get; set; }
        public Zone zone { get; set; }
        public Chronology chronology { get; set; }
        public bool afterNow { get; set; }
        public bool beforeNow { get; set; }
        public bool equalNow { get; set; }
    }

    public class FechaCobro
    {
        public int year { get; set; }
        public int dayOfMonth { get; set; }
        public int dayOfYear { get; set; }
        public int dayOfWeek { get; set; }
        public int era { get; set; }
        public int weekOfWeekyear { get; set; }
        public int hourOfDay { get; set; }
        public int minuteOfHour { get; set; }
        public int secondOfMinute { get; set; }
        public int millisOfSecond { get; set; }
        public int centuryOfEra { get; set; }
        public int yearOfEra { get; set; }
        public int yearOfCentury { get; set; }
        public int weekyear { get; set; }
        public int monthOfYear { get; set; }
        public int millisOfDay { get; set; }
        public int secondOfDay { get; set; }
        public int minuteOfDay { get; set; }
        public long millis { get; set; }
        public Zone zone { get; set; }
        public Chronology chronology { get; set; }
        public bool afterNow { get; set; }
        public bool beforeNow { get; set; }
        public bool equalNow { get; set; }
    }

    public class FechaCreacion
    {
        public int year { get; set; }
        public int dayOfMonth { get; set; }
        public int dayOfYear { get; set; }
        public int dayOfWeek { get; set; }
        public int era { get; set; }
        public int weekOfWeekyear { get; set; }
        public int hourOfDay { get; set; }
        public int minuteOfHour { get; set; }
        public int secondOfMinute { get; set; }
        public int millisOfSecond { get; set; }
        public int centuryOfEra { get; set; }
        public int yearOfEra { get; set; }
        public int yearOfCentury { get; set; }
        public int weekyear { get; set; }
        public int monthOfYear { get; set; }
        public int millisOfDay { get; set; }
        public int secondOfDay { get; set; }
        public int minuteOfDay { get; set; }
        public long millis { get; set; }
        public Zone zone { get; set; }
        public Chronology chronology { get; set; }
        public bool afterNow { get; set; }
        public bool beforeNow { get; set; }
        public bool equalNow { get; set; }
    }

    public class Opportunities
    {
        public int id { get; set; }
        public int idCliente { get; set; }
        public int idDeudor { get; set; }
        public int idCuentaBancaria { get; set; }
        public string ruc { get; set; }
        public string razonSocial { get; set; }
        public object clienteRazonSocial { get; set; }
        public string direccion { get; set; }
        public string codigo { get; set; }
        public FechaEmision fechaEmision { get; set; }
        public FechaCobro fechaCobro { get; set; }
        public int diasCobro { get; set; }
        public object fechaDeCobroReal { get; set; }
        public object fechaVencimiento { get; set; }
        public object fechaAdelanto { get; set; }
        public object fechaDeDesembolso { get; set; }
        public string moneda { get; set; }
        public decimal monto { get; set; }
        public decimal montoTotal { get; set; }
        public decimal montoDetraccion { get; set; }
        public decimal factor { get; set; }
        public decimal reserva { get; set; }
        public decimal reparto { get; set; }
        public FechaCreacion fechaCreacion { get; set; }
        public int idEstado { get; set; }
        public decimal totalInvertido { get; set; }
        public int duracionMinima { get; set; }
        public decimal porcentajeInvertido { get; set; }
        public object descripcionEstado { get; set; }
        public decimal tea { get; set; }
        public decimal tem { get; set; }
        public decimal retorno { get; set; }
        public decimal adelanto { get; set; }
        public object nombreContacto { get; set; }
        public object telefonoContacto { get; set; }
        public object correoContacto { get; set; }
        public decimal montoRestante { get; set; }
        public decimal gananciaPotencial { get; set; }
        public decimal descuentoEstimado { get; set; }
        public object rucGirador { get; set; }
        public int idAgrupacion { get; set; }
        public int idArchivo { get; set; }
        public object direccionCliente { get; set; }
        public object fechaPagoSaldoCliente { get; set; }
        public object fechaPagoRentabilidadInversionista { get; set; }
        public decimal otrosCostos { get; set; }
        public decimal comisionesInterbancarias { get; set; }
        public int cantidadDiasProyectado { get; set; }
        public int cantidadDiasReal { get; set; }
    }
}
