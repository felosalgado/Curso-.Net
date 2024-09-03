namespace PrincipiosSolid.ISP
{
    public class MontañaRusa : IOperable, IInspeccionable
    {
        public void Operar()
        {
            Console.WriteLine("La montaña rusa está operando.");
        }

        public void InspeccionarSeguridad()
        {
            Console.WriteLine("Inspeccionando la seguridad de la montaña rusa.");
        }
    }
}
