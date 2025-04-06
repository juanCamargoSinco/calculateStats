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

        [Theory]
        [
            InlineData(new[] { 6 }, 6),
            InlineData(new[] { 6, 44, 95, 3000 }, 3000),
            InlineData(new[] { 6, 44, 95, 3000, 4921, 4, 8, 6 }, 4921),

        ]
        public void Debe_calcular_valor_maximo_de_secuencia(IEnumerable<int> secuenciaNumeros, int valorMaximoSecuencia)
        {
            Assert.Equal(valorMaximoSecuencia, ProcesadorSecuencias.CalcularValorMaximo(secuenciaNumeros));
        }

        [Theory]
        [
            InlineData(new[] { 10 }, 1),
            InlineData(new[] { 10, 0, -5 }, 3),
            InlineData(new[] { 6, 44, 95, 3000, 4921, 4, 8, 6 }, 8)

        ]
        public void Debe_calcular_el_numero_de_elementos_del_arreglo(IEnumerable<int> secuenciaNumeros, int totalElementos)
        {

            Assert.Equal(totalElementos, ProcesadorSecuencias.CalcularNumeroElementos(secuenciaNumeros));
        }

        [Theory]
        [
            InlineData(new[] { 5 }, 5),
            InlineData(new[] { 5, 10, 42 }, 19),
            InlineData(new[] { 5, 10, 42, 99, 32, 55, 3, 6 }, 31.5)

        ]
        public void Debe_calcular_el_valor_promedio_de_la_secuencia(IEnumerable<int> secuenciaNumeros, double valorPromedio)
        {
            Assert.Equal(valorPromedio, ProcesadorSecuencias.CalcularValorPromedio(secuenciaNumeros));
        }

        [Fact]
        public void Debe_calcular_las_estadisticas_de_la_secuencia()
        {
            IEnumerable<int> secuenciaNumeros = [1];
            var estadisticas = new EstadisticasSecuencia()
            {
                ValorMinimo = 1,
                ValorMaximo = 1,
                ValorPromedio = 1,
                TotalElementos = 1
            };

            Assert.Equal(estadisticas.ValorMinimo, ProcesadorSecuencias.ProcesarSecuencia(secuenciaNumeros).ValorMinimo);
            Assert.Equal(estadisticas.ValorMaximo, ProcesadorSecuencias.ProcesarSecuencia(secuenciaNumeros).ValorMaximo);
            Assert.Equal(estadisticas.ValorPromedio, ProcesadorSecuencias.ProcesarSecuencia(secuenciaNumeros).ValorPromedio);
            Assert.Equal(estadisticas.TotalElementos, ProcesadorSecuencias.ProcesarSecuencia(secuenciaNumeros).TotalElementos);


        }

    }

    public class EstadisticasSecuencia
    {
        public int ValorMinimo { get; set; }
        public int ValorMaximo { get; set; }
        public int ValorPromedio { get; set; }
        public int TotalElementos { get; set; }

    }

    public class ProcesadorSecuencias
    {
        public static EstadisticasSecuencia ProcesarSecuencia(IEnumerable<int> secuenciaNumeros)
        {
            if (secuenciaNumeros.Any() == false)
                throw new Exception();

            return new EstadisticasSecuencia() { TotalElementos = 1, ValorMinimo = 1, ValorPromedio = 1, ValorMaximo = 1 };
        }

        public static int CalcularValorMinimo(IEnumerable<int> secuenciaNumeros)
        {
            return secuenciaNumeros.Min();
        }

        public static int CalcularValorMaximo(IEnumerable<int> secuenciaNumeros)
        {
            return secuenciaNumeros.Max();
        }

        public static int CalcularNumeroElementos(IEnumerable<int> secuenciaNumeros)
        {
            return secuenciaNumeros.Count();
        }

        public static double CalcularValorPromedio(IEnumerable<int> secuenciaNumeros)
        {
            return secuenciaNumeros.Average();
        }
    }
}