namespace CalculateKata
{
    public class CalculateStatsTest
    {
        [Fact]
        public void Debe_devolver_error_al_procesar_secuencia_vacia()
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
            Assert.Equal(valorMinimoSecuencia, ProcesadorSecuencias.ProcesarSecuencia(secuenciaNumeros).ValorMinimo);
        }

        [Theory]
        [
            InlineData(new[] { 6 }, 6),
            InlineData(new[] { 6, 44, 95, 3000 }, 3000),
            InlineData(new[] { 6, 44, 95, 3000, 4921, 4, 8, 6 }, 4921),

        ]
        public void Debe_calcular_valor_maximo_de_secuencia(IEnumerable<int> secuenciaNumeros, int valorMaximoSecuencia)
        {
            Assert.Equal(valorMaximoSecuencia, ProcesadorSecuencias.ProcesarSecuencia(secuenciaNumeros).ValorMaximo);
        }

        [Theory]
        [
            InlineData(new[] { 10 }, 1),
            InlineData(new[] { 10, 0, -5 }, 3),
            InlineData(new[] { 6, 44, 95, 3000, 4921, 4, 8, 6 }, 8)

        ]
        public void Debe_calcular_el_numero_de_elementos_de_la_secuencia(IEnumerable<int> secuenciaNumeros, int totalElementos)
        {

            Assert.Equal(totalElementos, ProcesadorSecuencias.ProcesarSecuencia(secuenciaNumeros).TotalElementos);
        }

        [Theory]
        [
            InlineData(new[] { 5 }, 5),
            InlineData(new[] { 5, 10, 42 }, 19),
            InlineData(new[] { 5, 10, 42, 99, 32, 55, 3, 6 }, 31.5)

        ]
        public void Debe_calcular_el_valor_promedio_de_la_secuencia(IEnumerable<int> secuenciaNumeros, double valorPromedio)
        {
            Assert.Equal(valorPromedio, ProcesadorSecuencias.ProcesarSecuencia(secuenciaNumeros).ValorPromedio);
        }

        [Theory]
        [
            InlineData(new[] { 1 }, 1, 1, 1, 1),
            InlineData(new[] { 5, 15, 30, 122 }, 5, 122, 43, 4),
            InlineData(new[] { 0, 8, 44, 33, 62, 20, 73, 12 }, 0, 73, 31.5, 8)
        ]
        public void Debe_calcular_las_estadisticas_de_la_secuencia(IEnumerable<int> secuenciaNumeros, int valorMinimo, int valorMaximo, double valorPromedio, int totalElementos)
        {
            var estadisticas = new EstadisticasSecuencia(valorMinimo, valorMaximo, valorPromedio, totalElementos);

            Assert.Equal(estadisticas.ValorMinimo, ProcesadorSecuencias.ProcesarSecuencia(secuenciaNumeros).ValorMinimo);
            Assert.Equal(estadisticas.ValorMaximo, ProcesadorSecuencias.ProcesarSecuencia(secuenciaNumeros).ValorMaximo);
            Assert.Equal(estadisticas.ValorPromedio, ProcesadorSecuencias.ProcesarSecuencia(secuenciaNumeros).ValorPromedio);
            Assert.Equal(estadisticas.TotalElementos, ProcesadorSecuencias.ProcesarSecuencia(secuenciaNumeros).TotalElementos);
        }
    }
}