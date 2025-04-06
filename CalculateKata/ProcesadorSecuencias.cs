namespace CalculateKata
{
    public class ProcesadorSecuencias
    {
        private static int CalcularNumeroElementos(IEnumerable<int> secuenciaNumeros)
        {
            return secuenciaNumeros.Count();
        }

        private static int CalcularValorMaximo(IEnumerable<int> secuenciaNumeros)
        {
            return secuenciaNumeros.Max();
        }

        private static int CalcularValorMinimo(IEnumerable<int> secuenciaNumeros)
        {
            return secuenciaNumeros.Min();
        }

        private static double CalcularValorPromedio(IEnumerable<int> secuenciaNumeros)
        {
            return secuenciaNumeros.Average();
        }
        public static EstadisticasSecuencia ProcesarSecuencia(IEnumerable<int> secuenciaNumeros)
        {
            if (secuenciaNumeros.Any() == false)
                throw new Exception();

            return new EstadisticasSecuencia(
                    CalcularValorMinimo(secuenciaNumeros),
                    CalcularValorMaximo(secuenciaNumeros),
                    CalcularValorPromedio(secuenciaNumeros),
                    CalcularNumeroElementos(secuenciaNumeros)
                   );
        }
    }
}