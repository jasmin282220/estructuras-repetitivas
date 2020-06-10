using System;

namespace _2E
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, num1, menor;

            Console.Write("ingrese un número: ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.Write("ingrese otro numero: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            menor = num< num1 ? num : num1;

            Console.WriteLine("El menor de los números es {0}.", menor);
        }
    }
}
    
