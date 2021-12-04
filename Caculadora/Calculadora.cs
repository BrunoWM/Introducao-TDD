using System;
using System.Collections.Generic;
using System.Text;

namespace Caculadora
{
    public class Calculadora
    {
        private List<string> historico;
        private string data;

        public Calculadora(string data)
        {
            historico = new List<string>();
            this.data = data;
        }

        public int Somar(int valor01, int valor02)
        {
            var resultado = valor01 + valor02;

            historico.Insert(0, $"{data} | {valor01} + {valor02} = {resultado}");

            return resultado;
        }

        public int Subtrair(int valor01, int valor02)
        {
            var resultado = valor01 - valor02;

            historico.Insert(0, $"{data} | {valor01} - {valor02} = {resultado}");

            return resultado;
        }

        public int Dividir(int valor01, int valor02)
        {
            var resultado = valor01 / valor02;

            historico.Insert(0, $"{data} | {valor01} / {valor02} = {resultado}");

            return resultado;
        }

        public int Multiplicar(int valor01, int valor02)
        {
            var resultado = valor01 * valor02;

            historico.Insert(0, $"{data} | {valor01} * {valor02} = {resultado}");

            return resultado;
        }

        public List<string> Historico()
        {
            historico.RemoveRange(3, historico.Count - 3);
            return historico;
        }
    }
}
