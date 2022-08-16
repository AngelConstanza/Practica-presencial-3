using System;
namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            string operacion;
            double resultado = 0;
            double valor1;
            double valor2;

            Console.WriteLine("Ingrese el primer valor");
            valor1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la letra de la operacion a realizar: s, r, m, d");
            operacion = Console.ReadLine();
            Console.WriteLine("Ingrese el segundo valor");
            valor2 = double.Parse(Console.ReadLine());
            int num;
            
            switch (operacion)
            {
                case "s":
                    if (operacion == "s")
                        resultado = valor1 + valor2;
                    Console.WriteLine("El resultado de la suma es de " + resultado);
                    break;

                case "r":
                    if (operacion == "r")
                        resultado = valor1 - valor2;
                    Console.WriteLine("El resultado de la resta es de " + resultado);
                    break;

                case "m":
                    if (operacion == "m")
                        resultado = valor1 * valor2;
                    Console.WriteLine("El resultado de la multiplicacion es de " + resultado);
                    break;

                case "d":
                    if (operacion == "d")
                        resultado = valor1 / valor2;
                    Console.WriteLine("El resultado de la division es de " + resultado);
                    break;

                default:
                    Console.WriteLine("Esa operacion no existe");
                    break;
            }
            

        }
    }
}
