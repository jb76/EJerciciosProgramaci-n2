using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalabraMasLarga
{
    class Program
    {
        static void Main(string[] args)
        {
            string palabra, palabra_mas_larga = "";
            while (true)
            {
                Console.Write("Ingrese una Palabra: ");
                palabra = Console.ReadLine();

                if (palabra == "")
                    break;
                if (palabra.Length > palabra_mas_larga.Length)
                    palabra_mas_larga = palabra;
            }
            Console.WriteLine(" La palabra más larga fue: {0}", palabra_mas_larga);
            Console.ReadLine();

        }
    }
}
