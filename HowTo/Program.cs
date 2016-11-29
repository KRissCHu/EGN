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


            string myEgn = "7524169268";
            int years = int.Parse(myEgn.Substring(0, 2));
            int months = int.Parse(myEgn.Substring(2, 2));
            int days = int.Parse(myEgn.Substring(4, 2));

            string genderDigit = myEgn.Substring(8, 1);

            bool isFemale = IsFemale(genderDigit);


            Console.WriteLine("Am I female? => " + isFemale);


            if(months > 0 && months < 13)
            {
                Console.Write("19" + years);
                Console.WriteLine(".{0}.{1}", months, days);
            }

            else if (months > 19 && months < 33)
            {
                months -= 20;
                Console.Write("18" + years);
                Console.WriteLine(".{0}.{1}", months, days);
            }

            else if(months > 40 && months <53)
            {
                months -= 40;
                Console.Write("20" + years);
                Console.WriteLine(".{0}.{1}", months, days);
            }

            else
            {
                Console.WriteLine("Wrong Data!");
            }


            CheckDigitWeight(myEgn);


        }

        //2 4 8 5 10 9 7 3 6
        public static void CheckDigitWeight(string egn)
        {
            int [] digits = new int[egn.Length];

            int currentsum = (digits[0] * 2) + (digits[1] * 4) + (digits[2] * 8) + (digits[3] * 5) + (digits[4] * 10) + (digits[5] * 9) + (digits[6] * 7) + (digits[7] * 3) + (digits[8] * 6);

            currentsum = currentsum % 11;
            if(currentsum != digits[9])
            {
                Console.WriteLine("Wrong EGN!");
            }
            else
            {

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
