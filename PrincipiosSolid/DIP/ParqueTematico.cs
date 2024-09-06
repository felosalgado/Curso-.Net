namespace PrincipiosSolid.DIP
{
    public class ParqueTematico
    {
        private MontañaRusaDIP montañaRusa;

        public ParqueTematico()
        {
            montañaRusa = new MontañaRusaDIP();
        }

        public void IniciarAtraccion()
        {
            montañaRusa.Operar();
        }
    }
}
