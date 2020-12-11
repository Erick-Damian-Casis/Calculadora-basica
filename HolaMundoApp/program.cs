using System;
using Matematica;
namespace HolaMundoApp
{
    class program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Bienvenido a la calculadora, escribe el signo de la operación que deseas realizar,");
                Console.WriteLine("en caso de operaciones especiales utiliza la numeración a continuación:");
                Console.WriteLine("1=Inversa");
                Console.WriteLine("2=Cuadrado de número");
                Console.WriteLine("3=Raíz cuadrada");
                var signo = Console.ReadLine();

                if (signo == "+")
                    {
                        Console.WriteLine("Escribe el primer número");
                        var primerNumero = Console.ReadLine();
                        Console.WriteLine("Escribe el segundo número");
                        var segundoNumero = Console.ReadLine();
                        var calculadora = new Calculadora();
                        var sumaTotal = calculadora.Sumar(int.Parse(primerNumero), int.Parse(segundoNumero));
                        Console.WriteLine("Respuesta: " + sumaTotal);
                    }

                if (signo == "-")
                    { 
                        Console.WriteLine("Escribe el primer número");
                        var primerNumero = Console.ReadLine();
                        Console.WriteLine("Escribe el segundo número");
                        var segundoNumero = Console.ReadLine();
                        var calculadora = new Calculadora();
                        var restaTotal = calculadora.Restar(int.Parse(primerNumero), int.Parse(segundoNumero));
                        Console.WriteLine("Respuesta: " + restaTotal);
                    }

                if (signo == "*")
                    {
                        Console.WriteLine("Escribe el primer número");
                        var primerNumero = Console.ReadLine();
                        Console.WriteLine("Escribe el segundo número");
                        var segundoNumero = Console.ReadLine();
                        var calculadora = new Calculadora();
                        var multiplicacionTotal = calculadora.Multiplicar(int.Parse(primerNumero), int.Parse(segundoNumero));
                        Console.WriteLine("Respuesta: " + multiplicacionTotal);
                    }

                if (signo == "/")
                    {
                        Console.WriteLine("Escribe el divisor");
                        var primerNumero = Console.ReadLine();
                        Console.WriteLine("Escribe el dividendo");
                        var segundoNumero = Console.ReadLine();
                        var calculadora = new Calculadora();
                        var divisionTotal = calculadora.Dividir(int.Parse(primerNumero), int.Parse(segundoNumero));
                        Console.WriteLine("Respuesta: " + divisionTotal);
                    }

                if (signo == "1")
                    {
                        Console.WriteLine("Ingresa un número para ver la inversa");
                        var numero = Console.ReadLine();
                        var calculadora = new Calculadora();
                        var inversaTotal = calculadora.Inversa(double.Parse(numero));
                        Console.WriteLine("Respuesta: " + inversaTotal);
                    }
                if(signo == "2")
                    {
                    Console.WriteLine("Ingresa el número que deseas elevar al cuadrado");
                    var numero = Console.ReadLine();
                    var calculadora = new Calculadora();
                    var cuadradoTotal = calculadora.Cuadrado(int.Parse(numero));
                    Console.WriteLine("Respuesta: " + cuadradoTotal);
                }
                if (signo == "3")
                {
                    Console.WriteLine("Ingresa un número su raíz");
                    var numero = Console.ReadLine();
                    var calculadora = new Calculadora();
                    var raizTotal = calculadora.Raiz(double.Parse(numero));
                    Console.WriteLine("Respuesta: " + raizTotal);
                }
            } while (true);
        }
    }
}
