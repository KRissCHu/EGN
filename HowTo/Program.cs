using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowTo
{
    class Program
    {
        static void Main(string[] args)
        {
            //8406194582 - 1984
            //7552011038 - 2075
            //7524169268 - 1875


            string myEgn = "9712064404";
            int years = int.Parse(myEgn.Substring(0, 2));
            int months = int.Parse(myEgn.Substring(2, 2));
            int days = int.Parse(myEgn.Substring(4, 2));

            string genderDigit = myEgn.Substring(8, 1);

            bool isFemale = IsFemale(genderDigit);


            Console.WriteLine("Am I female? => " + isFemale);


            if(months > 0 && months < 13)
            {
                Console.WriteLine("19" + years);
            }

            if (months > 19 && months < 33)
            {
                Console.WriteLine("18" + years);
            }

            /*int counter = 1;
            for(int i = 20; i < 33; i++)
            {
                Console.WriteLine(counter + " => " + i);
                counter++;
            }*/

            if(months > 40 && months <53)
            {
                Console.WriteLine("20" + years);
            }



        }

        public static bool IsFemale(string genderDigit)
        {
            bool isFemale = false;
            int actualDigit = int.Parse(genderDigit);
            if(actualDigit % 2 != 0)
            {
                isFemale = true;
            }
            
            return isFemale;
        }

    }
}
