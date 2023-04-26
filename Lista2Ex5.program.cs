using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2Ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;

            Console.WriteLine("Informações da área do terreno:");
            Console.Write("Digite o valor base:");
            a = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor altura:");
            b = double.Parse(Console.ReadLine());

            c = a * b;

            Console.WriteLine($"A área é de {c}.");

            if (c>100) { Console.WriteLine("Terreno Grande."); }
            else { Console.WriteLine("Terreno Pequeno."); }
        }
    }
}
