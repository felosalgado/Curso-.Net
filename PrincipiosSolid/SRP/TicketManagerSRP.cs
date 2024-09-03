namespace PrincipiosSolid.SRP
{
    public class TicketManagerSRP
    {
        public void EmitirBoleto(string visitante, string tipoBoleto)
        {
            //Logica para emitir boleto
            Console.WriteLine($"Boleto emitido para {visitante} de tipo {tipoBoleto}");
        }
    }
}
