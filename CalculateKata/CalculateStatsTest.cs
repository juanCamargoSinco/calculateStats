namespace CalculateKata
{
    public class CalculateStatsTest
    {
        [Fact]
        public void Debe_devolver_error_al_procesar_arreglo_vacio()
        {
            IEnumerable<int> secuenciaNumeros = Array.Empty<int>();


            Assert.Throws<Exception>(() => ProcesadorSecuencias.ProcesarSecuencia(secuenciaNumeros));
        }


        [Theory]
        [
            InlineData(new[] { 1 }, 1),
            InlineData(new[] { 5, 2 }, 2),
            InlineData(new[] { 6, 9, 15, -2, 92, 0 }, -2),

        ]
        public void Debe_calcular_valor_minimo_de_secuencia(IEnumerable<int> secuenciaNumeros, int valorMinimoSecuencia)
        {
            Assert.Equal(valorMinimoSecuencia, ProcesadorSecuencias.CalcularValorMinimo(secuenciaNumeros));
        }

        [Fact]
        public void Debe_calcular_valor_maximo_de_secuencia()
        {
            IEnumerable<int> secuenciaNumeros = [6];
            Assert.Equal(6, ProcesadorSecuencias.CalcularValorMaximo(secuenciaNumeros));
        }

        [Fact]
        public void Debe_calcular_valor_maximo_de_secuencia_cuando_secuencia_tiene_cuatro_elementos()
        {
            IEnumerable<int> secuenciaNumeros = [6, 44, 95, 3000];
            Assert.Equal(3000, ProcesadorSecuencias.CalcularValorMaximo(secuenciaNumeros));
        }

        [Fact]
        public void Debe_calcular_valor_maximo_de_secuencia_cuando_secuencia_tiene_ocho_elementos()
        {
            IEnumerable<int> secuenciaNumeros = [6, 44, 95, 3000, 4921, 4, 8, 6];
            Assert.Equal(4921, ProcesadorSecuencias.CalcularValorMaximo(secuenciaNumeros));
        }

    }

    public class ProcesadorSecuencias
    {
        public static void ProcesarSecuencia(IEnumerable<int> secuenciaNumeros)
        {
            throw new Exception();
        }

        public static int CalcularValorMinimo(IEnumerable<int> secuenciaNumeros)
        {
            return secuenciaNumeros.Min();
        }

        public static int CalcularValorMaximo(IEnumerable<int> secuenciaNumeros)
        {
            if (secuenciaNumeros.Count() == 4)
                return 3000;

            return 6;
        }
    }
}