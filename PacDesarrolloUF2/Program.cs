using System;

namespace PacDesarrolloUF2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] array = new string[10, 10];

            int n = 1; //En esta línea declaramos la variable la cual va a recorrer uno a uno el array bidimensional
            
            for (int y = 1; y <= 10; y++)
            {
                for (int x = 0; x < 10; x++) //En estos for lo que hacemos es recorrer el array bidimensional, demanera que el resultado sea de 10x10
                {
                    if (EsPrimo(n) == true) //Para este paso lo que hacemos es realizar la llamada al método creado para esta condición y verificar si se cumple o no, tomando diferentes acciones (mostrando "X" o "n")
                    {
                        Console.Write($" {n} ");
                    }
                    else
                    {
                        Console.Write(" X ");
                    }                                       
                    n++;                    
                }
                Console.WriteLine(); //Con esta instrucción lo que hacemos es realizar el salto de línea cuando la condición termine de recorrer la fila que se esté ejecutando           
            }
                Console.ReadKey(); //Creamos un ReadKey para poder visualizar el código ejecutado y cerrarlo cuando pulsemos cualquier tecla
        }

        public static bool EsPrimo(int n) //Creamos el método/función para realizar los cálculos para "n" y verificar si se considera primo o no siguiendo la regla correspondiente para calcularlos
        {
            if (n == 1)
                return false;
            for (int i = 2; i < n; i++)
                if (n % i == 0)
                    return false;
            return true;
        }
    }
}
