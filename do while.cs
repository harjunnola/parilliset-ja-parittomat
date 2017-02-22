using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("anna luku");
            number = int.Parse(Console.ReadLine());

            int i = 0;
            int sumValue=0;


            if (number >= 1)
            {
                do
                {
                    i++;
                    sumValue = sumValue + i;
                } while (i < number);

            


                Console.WriteLine("Vastaus: parittomien summa {0} parillisten summa {0}", sumValue);
            }
                
            Console.ReadLine();

        }
    }
}
