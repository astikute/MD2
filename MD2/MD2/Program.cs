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
            //Uzdevums_1
            Console.WriteLine("1.uzdevums");
            Console.Write("Ievadiet skaitli: ");
            int sk = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < 11; i++)
            {
                int sk_rez = sk * i;
                Console.WriteLine("{0} * {1} = {2}", sk, i, sk_rez);
            }

            //Uzdevums_2
            Console.WriteLine();
            Console.WriteLine("2.uzdevums");
            Zvaigznites();

            //Uzdevums_3
            Console.WriteLine();
            Console.WriteLine("3.uzdevums");
            for (int i = 10; i > 0; i--)
            {
                Console.Write(i + " ");
            }

            Console.Read();
        }

        static void Zvaigznites()
        {
            string virkne = "";

            for (int i = 1; i < 4; i++)
            {
                virkne = virkne + "*";
                Console.WriteLine(virkne);
            }
        }
    }
}
