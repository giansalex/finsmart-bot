using System.Collections.Generic;

namespace Factoring.Cli.Client.Models
{
    public class Balance
    {
        public decimal saldoDisponiblePEN { get; set; }
        public decimal inversionEnCursoUSD { get; set; }
        public decimal saldoDisponibleUSD { get; set; }
        public decimal depositoRequeridoUSD { get; set; }
        public decimal depositoRequeridoPEN { get; set; }
        public decimal inversionEnCursoPEN { get; set; }
        public decimal montoEnValidacionUSD { get; set; }
        public decimal montoEnValidacionPEN { get; set; }
    }

    public class Deudas
    {
        public decimal deudaUSD { get; set; }
        public decimal deudaPEN { get; set; }
    }

    public class FechaTransaccion
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
        public object millis { get; set; }
        public Zone zone { get; set; }
        public Chronology chronology { get; set; }
        public bool afterNow { get; set; }
        public bool beforeNow { get; set; }
        public bool equalNow { get; set; }
    }

    public class FechaAprobacion
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
        public object millis { get; set; }
        public Zone zone { get; set; }
        public Chronology chronology { get; set; }
        public bool afterNow { get; set; }
        public bool beforeNow { get; set; }
        public bool equalNow { get; set; }
    }

    public class Transaccione
    {
        public int id { get; set; }
        public int idInversionista { get; set; }
        public int tipoTransaccion { get; set; }
        public int idCuenta { get; set; }
        public string nombreBanco { get; set; }
        public string numeroCuenta { get; set; }
        public string numeroCCI { get; set; }
        public string moneda { get; set; }
        public decimal monto { get; set; }
        public int idFactura { get; set; }
        public int idVoucher { get; set; }
        public FechaTransaccion fechaTransaccion { get; set; }
        public FechaAprobacion fechaAprobacion { get; set; }
        public int idEstado { get; set; }
        public string descripcionEstado { get; set; }
        public string descripcionTransaccion { get; set; }
        public object nombreInversionista { get; set; }
    }

    public class Cuenta
    {
        public int id { get; set; }
        public int idCliente { get; set; }
        public int idBanco { get; set; }
        public string nombreBanco { get; set; }
        public string cuenta { get; set; }
        public string cci { get; set; }
        public string moneda { get; set; }
        public FechaCreacion fechaCreacion { get; set; }
        public int idEstado { get; set; }
    }

    public class FechaStatusCobro
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
        public object millis { get; set; }
        public Zone zone { get; set; }
        public Chronology chronology { get; set; }
        public bool afterNow { get; set; }
        public bool beforeNow { get; set; }
        public bool equalNow { get; set; }
    }

    public class FechaCobroReal
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
        public object millis { get; set; }
        public Zone zone { get; set; }
        public Chronology chronology { get; set; }
        public bool afterNow { get; set; }
        public bool beforeNow { get; set; }
        public bool equalNow { get; set; }
    }

    public class FechaAdelanto
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
        public object millis { get; set; }
        public Zone zone { get; set; }
        public Chronology chronology { get; set; }
        public bool afterNow { get; set; }
        public bool beforeNow { get; set; }
        public bool equalNow { get; set; }
    }

    public class FechaDeDesembolso
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
        public object millis { get; set; }
        public Zone zone { get; set; }
        public Chronology chronology { get; set; }
        public bool afterNow { get; set; }
        public bool beforeNow { get; set; }
        public bool equalNow { get; set; }
    }

    public class InversionesEnProceso
    {
        public int id { get; set; }
        public int idInversionista { get; set; }
        public int idFactura { get; set; }
        public decimal montoTotal { get; set; }
        public decimal montoAdelanto { get; set; }
        public decimal monto { get; set; }
        public FechaCreacion fechaCreacion { get; set; }
        public int idEstado { get; set; }
        public string razonSocial { get; set; }
        public string ruc { get; set; }
        public string codigo { get; set; }
        public string tiempoRestante { get; set; }
        public string moneda { get; set; }
        public string descripcionEstado { get; set; }
        public decimal factor { get; set; }
        public FechaStatusCobro fechaCobro { get; set; }
        public FechaCobroReal fechaCobroReal { get; set; }
        public FechaAdelanto fechaAdelanto { get; set; }
        public FechaDeDesembolso fechaDeDesembolso { get; set; }
        public decimal reparto { get; set; }
        public decimal reserva { get; set; }
        public decimal tem { get; set; }
        public decimal tea { get; set; }
        public decimal retorno { get; set; }
        public decimal rentabilidad { get; set; }
        public int dateDiff { get; set; }
        public decimal diasCobro { get; set; }
        public int diasCobroReal { get; set; }
    }

    public class PorIniciar
    {
        public decimal porIniciarPEN { get; set; }
        public decimal porIniciarUSD { get; set; }
    }

    public class Status
    {
        public Balance balance { get; set; }
        public decimal totalInversionActual { get; set; }
        public Deudas deudas { get; set; }
        public List<Transaccione> transacciones { get; set; }
        public List<Cuenta> cuentas { get; set; }
        public List<object> inversionesFinalizadas { get; set; }
        public List<InversionesEnProceso> inversionesEnProceso { get; set; }
        public PorIniciar porIniciar { get; set; }
    }
}
