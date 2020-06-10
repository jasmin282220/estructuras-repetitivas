using System;
using System.Diagnostics.Contracts;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
       /* programa se ejcutara hasta que se ingresen los numeros deseados 
        * y al final ingrese el 5*/
            int positivo = 0;
            int negativo = 0;
            int numero;
            int contar = 0;

            Console.WriteLine("ingrese un numero");
            numero = Int32.Parse(Console.ReadLine());
            while (numero!=5)
            {
                contar = contar + 1;

                if (numero > 0)
                {
                    positivo = positivo + 1;
                    Console.WriteLine("ingrese otro numero");
                    numero = Int32.Parse(Console.ReadLine());
                }
                else 
                {
                    negativo = negativo - 1;
                    Console.WriteLine("ingrese otro  numero");
                    numero = Int32.Parse(Console.ReadLine());
                   
                }
            }
            Console.WriteLine("has introducido la cantidad de {0}", contar);
            Console.WriteLine("son positivos {0}", positivo);
            Console.WriteLine("son negativos  {0}", negativo);
            Console.ReadKey();
        }
    }
}
