using System;

namespace _3E
{
    class Program
    {
        static void Main(string[] args)
        {
    
           
            float numero;
            Console.WriteLine("teclee cualquier cosa");
            numero = Int32.Parse(Console.ReadLine());
            while (numero != 3) ;
            {
                if (numero >0)
                {
                 
              Console.WriteLine("lo que usted acaba de ingresar es un numero positivo");
            
                }
                else
                {
                    Console.WriteLine("el numero que usted ingreso es negativo");
                }
            }
        }
    }
}
 



