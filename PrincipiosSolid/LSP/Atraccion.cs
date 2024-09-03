namespace PrincipiosSolid.LSP
{
    public class Atraccion
    {
        public virtual void Operar()
        {
            Console.WriteLine("La atracción está operando.");
        }
    }

    public class MontañaRusa : Atraccion
    {
        public override void Operar()
        {
            Console.WriteLine("La montaña rusa está operando.");
             
            //throw new Exception("Esta atraccion requiere una inspeccion antes de operar");
        }
    }

    public class CarrosChocones : Atraccion
    {
        public override void Operar()
        {
            Console.WriteLine("Los carros chocones están operando.");
        }
    }
}
