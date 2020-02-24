using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Dic = new string[6];

            Dic[0] = "Boat";
            Dic[1] = "house";
            Dic[2] = "cat";
            Dic[3] = "river";
            Dic[4] = "cupboard";

            // plurals
            Console.WriteLine("Plurals--------------------------------");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(Dic[i] + "s");
            }


            Console.WriteLine("synonym of 2nd word-----------------------------");
            for (int i = 0; i < 5; i++)
            {
                Dic[1] = "home";
                Console.WriteLine(Dic[i]);
            }

            Console.WriteLine("Added new word----------------------------");
            for (int i = 0; i < 6; i++)
            {
                Dic[5] = "Jay";
                Console.WriteLine(Dic[i]);
            }

            Console.WriteLine("Seven letter word----------------------------");
            for (int i = 0; i < 6; i++)
            {
                if ((Dic[i].Length)>6)
                {
                    Console.WriteLine(Dic[i]);
                }
            }
            Console.WriteLine("Third position word----------------------------");

            Console.WriteLine(Dic[2]);

            Array.Sort<string>(Dic);
             Console.WriteLine("Sorted in ascending order----------------------------");
            for (int i = 0; i < 6; i++)
            {
                
                Console.WriteLine(Dic[i]);
            }

            Array.Reverse(Dic);
            Console.WriteLine("Reverse of array----------------------------");
            for (int i = 0; i < 6; i++)
            {

                Console.WriteLine(Dic[i]);
            }



        }
    }
}
