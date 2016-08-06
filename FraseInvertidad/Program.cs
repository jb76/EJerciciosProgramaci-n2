using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FraseInvertida
    {
    class Program
    {
        public static string Mid(string param, int startIndex, int length)
        {
            string result = param.Substring(startIndex, length);
            return result;
        }
        static void Main(string[] args)
        {
            string NOM;
            string AUX;
            int POS = 0;
            AUX = "";
            Console.Write("DIGITE UNA FRASE");
            NOM = Console.ReadLine();
            POS = NOM.Length;
            while ((POS > 0))
            {
                AUX = AUX + Mid(NOM, POS - 1, 1);
                POS = POS - 1;
            }
            Console.WriteLine("FRASE INVERTIDA :" + AUX);
            Console.Write("Pulse una tecla:");
            Console.ReadLine();
        }
    }
}






