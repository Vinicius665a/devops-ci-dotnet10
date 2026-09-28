namespace DevOps.Api.Services
{
    public class CalculadoraService
    {
        public int Somar(int a, int b)
        {
            return a + b;
        }

        public bool EhPar(int numero)
        {
            return numero % 2 == 0;
        }
    }
}