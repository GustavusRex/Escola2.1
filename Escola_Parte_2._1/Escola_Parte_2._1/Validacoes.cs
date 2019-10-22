using System;
using System.Linq;

namespace Escola_Parte_2._1
{
    class Validacoes
    {
       public static int Sonumeros(string s)
        {
            int n;
            while ((!int.TryParse(s, out n)) || (n < 0 || n > 4))
            {
                Console.WriteLine("Opção invalida");
                s = Console.ReadLine();

            }
            return n;

        }
        public int Sonumeros2(string s)
        {
            int n;
            while ((!int.TryParse(s, out n)) || (n < 0 || n > 5))
            {
                Console.WriteLine("Opção invalida");
                s = Console.ReadLine();

            }
            return n;

        }
        public int Sonumeros3(string s)
        {
            int n;
            while ((!int.TryParse(s, out n)) || (n < 0 || n > 3))
            {
                Console.WriteLine("Opção invalida");
                s = Console.ReadLine();

            }
            return n;

        }

    } 
}
