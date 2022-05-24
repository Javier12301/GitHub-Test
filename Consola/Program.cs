using System;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            do
            {
                Console.WriteLine("Ingresar Numerador");
                
                int NUMERADOR = int.Parse(Console.ReadLine());
                
                Console.WriteLine("Ingresar Decimal");
                
                int DECIMAL = int.Parse(Console.ReadLine());
                
                try
                {
                    int resultado = NUMERADOR / DECIMAL;
                    Console.WriteLine("El resultado es: "+resultado);
                    
                    Console.WriteLine("¿Desea finalizar el programa?\n 0 para finalizar, n!=0 para continuar");
                    i = int.Parse(Console.ReadLine());
                    Console.ReadKey();
                    Console.Clear();
                }
                catch (Exception ex) when (DECIMAL==0)
                {
                    Console.WriteLine("\nSe produjo un error, no se puede dividir por 0 ");
                    Console.WriteLine("\nERROR TIPO: \n"+ex);
                    Console.ReadKey();
                    Console.WriteLine("");
                    
                    Console.WriteLine("¿Desea finalizar el programa?\n 0 para finalizar, n!=0 para continuar");
                    i = int.Parse(Console.ReadLine());
                    Console.Clear();
                }


            } while (i != 0);
        }
    }
}
