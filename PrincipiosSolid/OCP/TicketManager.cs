namespace PrincipiosSolid.OCP
{
    public class TicketManager
    {
        public double CalcularPrecio(string tipoBoleto)
        {
            if (tipoBoleto == "Adulto")
                return 50.0;
            else if (tipoBoleto == "Niño")
                return 30.0;
            else if (tipoBoleto == "AdultoMayor")
                return 40.0;
            else
                return 0.0;
        }
    }
}
