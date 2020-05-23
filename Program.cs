using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1;
            int pares = 0;
            int impares = 0;
            int[] listanumeros = new int[10];

            Console.WriteLine("Digite uma sequencia de números de 1 a 10");
            Console.ReadLine();

            Console.Clear();

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Digite o " + (i + 1) + "º numero: ");
                n1 = Convert.ToInt32(Console.ReadLine());
                listanumeros[i] = n1;
            }

            for (int i = 0; i < 10; i++)
            {
                if (ImparPar(listanumeros[i]))
                    pares ++;
                else
                    impares ++;
            }

            Console.Clear();
            Console.WriteLine("O total de números pares: " + pares);
            Console.WriteLine("O total de número impares: " + impares);

            Console.ReadLine();

        }

        public static bool ImparPar (int numero)
        {
            bool resultado = numero % 2 == 0;
            return resultado;
        }
    }
}
