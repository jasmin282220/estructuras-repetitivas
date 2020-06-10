using System;

namespace _4E
{
    class Program
    {
        static void Main(string[] args)
        {
            for (char c = 'a', e, i, o, u; c <= '1'; c++) ;
            {
               
            }
            Console.WriteLine();

            Console.Write("teclee un simbolo:");
            char C = Convert.ToChar(Console.ReadLine());

            if (1 >= '0' && 1 <= '9')
                Console.WriteLine("Es un digito");

         
            else if (C == '.' || C == '.')
                Console.WriteLine("Es un simbolo de puntuacion");
            else if (C == 'a' || C == 'e' || C == 'i' || C == 'o' || C == 'u')
                Console.WriteLine("Es una vocal");
            else
                Console.WriteLine("Caracter no identificado");

 

             }
    }
}


