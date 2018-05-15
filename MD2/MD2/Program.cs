using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MD2
{
    class Program
    {
        static void Main(string[] args)
        {
            int izvele = 1;

            while (izvele != 0)
            {
                Console.WriteLine("1. Izvadit reizrekina tabulu");
                Console.WriteLine("2. Skaitit no 10 uz leju");
                Console.WriteLine("3. Izvadit zvaigznites");
                Console.WriteLine("4. Faktorials");
                Console.WriteLine("0. Izeja");

                string input = Console.ReadLine();
                izvele = Convert.ToInt32(input);

                switch(izvele)
                {
                    case 1:
                        Console.WriteLine();
                        Console.WriteLine("1.uzdevums");
                        Tabula();
                        break;
                    case 2:
                        Console.WriteLine();
                        Console.WriteLine("2.uzdevums");
                        Zvaigznites();
                        break;
                    case 3:
                        Console.WriteLine();
                        Console.WriteLine("3.uzdevums");
                        UzLeju();
                        break;
                    case 4:
                        Faktorials();
                        break;
                    case 0:
                        izvele = 0;
                        break;
                    default:
                        Console.WriteLine("Neeksiste!");
                        break;
                }
            }
        }

        static void Zvaigznites()
        {
            string virkne = "";

            for (int i = 1; i < 4; i++)
            {
                virkne = virkne + "*";
                Console.WriteLine(virkne);
            }
            Console.WriteLine();
        }

        static void Tabula()
        {
            Console.Write("Ievadiet skaitli: ");
            int sk = Convert.ToInt32(Console.ReadLine());
            int sk_rez;

            for (int i = 1; i < 11; i++)
            {
                sk_rez = sk * i;
                Console.WriteLine("{0} * {1} = {2}", sk, i, sk_rez);
            }
            Console.WriteLine();
         }

        static void UzLeju()
        {
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(i + " ");
            }
            Console.WriteLine();
        }

        static void Faktorials()
        {
            Console.Write("Ievadiet skaitli: ");
            int sk = Convert.ToInt32(Console.ReadLine());
            int rez = 0;

            if (sk == 0) // Skaitla 0! = 1
            {
                Console.Write("0! = 1");
            }
            else
            {
                for (int i = 1; i <= sk; i++) // Parejiem skaitliem, sakot no 1
                {
                    int vecaRez = rez;
                    rez = rez + i;
                    Console.WriteLine(vecaRez + "+" + i + "=" + rez);
                }
                Console.Write("{0}! = {1}", sk, rez);
            }
            Console.WriteLine();
        }
    }
}
