using Caculadora;
using System;
using Xunit;

namespace Testes_xUnit
{
    public class UnitTest1
    {
        public Calculadora construirCalculadora()
        {
            string data = "10/10/2000";
            Calculadora calc = new Calculadora(data);

            return calc;
        }

        [Theory]
        [InlineData (1, 2, 3)]
        [InlineData (4, 5, 9)]
        public void TestSomar(int valor1, int valor2, int resultado)
        {
            Calculadora calculadora = construirCalculadora();

            int resultadoCalculadora = calculadora.Somar(valor1, valor2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(4, 5, 20)]
        public void TestMultiplicar(int valor1, int valor2, int resultado)
        {
            Calculadora calculadora = construirCalculadora();

            int resultadoCalculadora = calculadora.Multiplicar(valor1, valor2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(6, 2, 3)]
        [InlineData(20, 4, 5)]
        public void TestDividir(int valor1, int valor2, int resultado)
        {
            Calculadora calculadora = construirCalculadora();

            int resultadoCalculadora = calculadora.Dividir(valor1, valor2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(10, 2, 8)]
        [InlineData(4, 5, -1)]
        public void TestSubitrair(int valor1, int valor2, int resultado)
        {
            Calculadora calculadora = construirCalculadora();

            int resultadoCalculadora = calculadora.Subtrair(valor1, valor2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Fact]
        public void TestDivisaoPorZero()
        {
            Calculadora calculadora = construirCalculadora();

            Assert.Throws<DivideByZeroException>(
                () => calculadora.Dividir(3, 0)
            );
        }

        [Fact]
        public void TestHistorico()
        {
            Calculadora calculadora = construirCalculadora();

            calculadora.Somar(4, 5);
            calculadora.Somar(4, 5);
            calculadora.Somar(4, 5);
            calculadora.Somar(4, 5);

            var lista = calculadora.Historico();

            Assert.NotEmpty(lista);
            Assert.Equal(3, lista.Count);
        }
        //[Fact]
        //public void Test2()
        //{
        //    Calculadora calculadora = new Calculadora();

        //    int resultado = calculadora.Somar(4, 5);

        //    Assert.Equal(9, resultado);
        //}
    }
}
