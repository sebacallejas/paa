using System;

namespace Clase02
{
    class Program
    {
        static void Main(string[] args)
        {

            string cadena = "Salí a comprar, aun estando en cuarentena";
            string[] array = cadena.Split('a');
            foreach (string item in array)
            {
                Console.WriteLine(item);
            }


        }
    }
}
