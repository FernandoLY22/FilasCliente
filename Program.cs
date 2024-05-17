using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilasCliente
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue miFila = new Queue ();
            Console.Write("Ingresar el numero de personas en la fila del cajero: ");
            if (!int.TryParse(Console.ReadLine(), out  int n) || n < 0) {
                Console.WriteLine("Por favor , ingresa un numero valido de personas. ");
                return;
            }
            for (int i = 0; i < n; i++) {
                Console.Write ("Nombre de la perosona: ");
                miFila.Enqueue (Console.ReadLine());
            }
            Console.WriteLine("\nEl cajero atendo a: ");

            while (miFila.Count > 0)
            {
                Console.WriteLine(miFila.Dequeue ());
            }
            Console.ReadKey();
        }
    }
}
