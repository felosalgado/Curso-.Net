namespace PrincipiosSolid.OCP
{
    public abstract class Boleto
    {
        public abstract double CalcularPrecio();
    }

    public class BoletoAdulto : Boleto
    {
        public override double CalcularPrecio() => 50.0;
    }

    public class BoletoNiño : Boleto
    {
        public override double CalcularPrecio() => 30.0;
    }

    public class BoletoSenior : Boleto
    {
        public override double CalcularPrecio() => 40.0;
    }

    public class BoletoEstudiante : Boleto
    {
        public override double CalcularPrecio() => 10.0;
    }

    public class TicketManagerOCP
    {
        public double CalcularPrecio(Boleto boleto)
        {
            return boleto.CalcularPrecio();
        }
    }
}
