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

        [Fact]
        public void Debe_calcular_valor_minimo_de_secuencia()
        {
            IEnumerable<int> secuenciaNumeros = [1];

            Assert.Equal(1, ProcesadorSecuencias.CalcularValorMinimo(secuenciaNumeros));
        }

        [Fact]
        public void Debe_calcular_valor_minimo_de_secuencia_cuando_secuencia_tiene_dos_elementos()
        {
            IEnumerable<int> secuenciaNumeros = [5, 2];

            Assert.Equal(2, ProcesadorSecuencias.CalcularValorMinimo(secuenciaNumeros));
        }

        [Fact]
        public void Debe_calcular_valor_minimo_de_secuencia_cuando_secuencia_tiene_seis_elementos()
        {
            IEnumerable<int> secuenciaNumeros = [6, 9, 15, -2, 92, 0];

            Assert.Equal(-2, ProcesadorSecuencias.CalcularValorMinimo(secuenciaNumeros));
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
    }
}