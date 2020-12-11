using System;

namespace Matematica
{
    public class Calculadora
    {
        public int Sumar(int sumando1, int sumando2)
        {
            return sumando1 + sumando2;
        }
        public int Restar(int restando1, int restando2)
        {
            return restando1 - restando2;
        }
        public int Multiplicar(int multiplicando1, int multiplicando2)
        {
            return multiplicando1 * multiplicando2;
        }
        public int Dividir(int dividiendo1, int dividiendo2)
        {
                return dividiendo1 / dividiendo2;
            }
        public double Inversa(double numero)
        {
            return 1 / numero;
        }
        public int Cuadrado(int numero)
        {
            return numero * numero;
        }
        public double Raiz(double numero)
        {
            return Math.Sqrt(numero);
        }
    }   

}