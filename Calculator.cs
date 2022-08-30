using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
     public class Program
    {
        static void Main(string[] args)
        {
            Menu();

        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Escolha a opção desejada para efetuar a operação");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2- Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4- Divisão");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("");
            short op = short.Parse(Console.ReadLine());

            switch (op)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Multiplicacao(); break;
                case 4: Divisao(); break;
                default: Menu(); break;

            }

        }

        static void Soma()
        {
            Console.Clear();
            Console.WriteLine("Primeiro Valor");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo Valor");
            float v2 = float.Parse(Console.ReadLine());
            Console.WriteLine("");
            float resultado = v1 + v2;
            Console.WriteLine("O resultado da soma é:" + resultado);
            Console.ReadKey();
            Menu();

        }
        static void Subtracao()
        {
            Console.Clear();
            Console.WriteLine("Primeiro Valor");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo Valor");
            float v2 = float.Parse(Console.ReadLine());
            Console.WriteLine("");
            float resultado = v1 - v2;
            Console.WriteLine("O resultado da subtração é:" + resultado);
            Console.ReadKey();
            Menu();

        }
        static void Multiplicacao()
        {
            Console.Clear();
            Console.WriteLine("Primeiro Valor");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo Valor");
            float v2 = float.Parse(Console.ReadLine());
            Console.WriteLine("");
            float resultado = v1 * v2;
            Console.WriteLine("O resultado da multiplicação é:" + resultado);
            Console.ReadKey();
            Menu();

        }
        static void Divisao ()
        {
            Console.Clear();
            Console.WriteLine("Primeiro Valor");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo Valor");
            float v2 = float.Parse(Console.ReadLine());
            Console.WriteLine("");
            float resultado = v1/v2;
            Console.WriteLine("O resultado da divisão é:" + resultado);
            Console.ReadKey();
            Menu();

        }
    }
}
