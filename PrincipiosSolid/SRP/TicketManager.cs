namespace PrincipiosSolid.SRP
{
    public class TicketManager
    {
        public void EmitirBoleto(string visitante, string tipoBoleto)
        {
            //Logica para emitir boleto
            Console.WriteLine($"Boleto emitido para {visitante} de tipo {tipoBoleto}");
        }

        public void GenerarReporteVentas()
        {
            //Logica para genrar reporte de ventas
            Console.WriteLine("Reporte de ventas generado");
        }
    }
}
