namespace PrincipiosSolid.DIP
{
    public class ParqueTematicoDIP
    {
        private readonly IAtraccion atraccion;

        public ParqueTematicoDIP(IAtraccion atraccion)
        {
            this.atraccion = atraccion;
        }

        public void IniciarAtraccion()
        {
            atraccion.Operar();
        }
    }
}
