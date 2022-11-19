using System;
using System.Globalization;

namespace Calculator
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Menu();
        }

        private static void Menu()
        {
            Console.Clear();

            Console.WriteLine("Oque deseja fazer?");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("1-Soma");
            Console.WriteLine("2-Subtração");
            Console.WriteLine("3-Divisão");
            Console.WriteLine("4-Multiplicação");
            Console.WriteLine("5-Sair");

            Console.WriteLine("----------------------------------");

            Console.Write("Selecione uma Opção: ");

            short res = short.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            switch (res)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: System.Environment.Exit(0); break;

                default:
                    Menu();
                    break;
            }
        }

        private static void Soma()
        {
            Console.Clear();

            Console.Write("Primeiro Valor: ");
            float v1 = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();
            Console.Write("Segundo Valor: ");
            float v2 = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();

            float resultado = v1 + v2;

            Console.WriteLine($"O resultado da soma é = {resultado}");

            Console.ReadKey();

            Menu();
        }

        private static void Subtracao()
        {
            Console.Clear();

            Console.Write("Primeiro Valor: ");
            float v1 = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();
            Console.Write("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            var resultado = v1 - v2;

            Console.WriteLine($"O resultado da Subtração é = {resultado} ");

            Console.ReadKey();

            Menu();
        }

        private static void Divisao()
        {
            Console.Clear();

            Console.Write("Primeiro Valor: ");
            float v1 = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();
            Console.Write("Segundo Valor: ");
            float v2 = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();
            var resultado = v1 / v2;
            Console.WriteLine($"O resultado da divisão é = {resultado}");

            Console.ReadKey();

            Menu();
        }

        private static void Multiplicacao()
        {
            Console.Clear();

            Console.Write("Primeiro Valor: ");
            float v1 = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();
            Console.Write("Segundo Valor: ");
            float v2 = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();
            var resultado = v1 * v2;

            Console.WriteLine($"O resultado da Multiplicação é = {resultado}");

            Console.ReadKey();

            Menu();
        }
    }
}