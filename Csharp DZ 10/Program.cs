using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Csharp_DZ_10
{
    class SuperCounter
    {
        public static void Calculate1(int limit)
        {

        }
        public static void Calculate2(int limit)
        {

        }
        public static void Calculate3(int limit)
        {

        }

    }
    public delegate void Deleegate(int a);
    class Program
    {
        static void Main(string[] args)
        {
            string d;
            WriteLine("Enter limit: ");
            d = ReadLine();
            int limit = int.Parse(d);
            Deleegate dele1 = delegate
            {
                for (int i = 0; i < limit; i++)
                {
                    if (true)
                    {
                        Write(i + " ");
                    }
                   
                }
            };
            dele1 += SuperCounter.Calculate1;
            /////////////
            Deleegate dele2 = delegate
            {
                for (int i = 0; i < limit; i++)
                {
                    if (true)
                    {
                        Write(i*2 + " ");
                    }

                }
            };
            dele2 += SuperCounter.Calculate2;
            /////////////
            Deleegate dele3 = delegate
            {
                for (int i = 0; i < limit; i++)
                {
                    if (true)
                    {
                        Write(i*3 + " "); 
                    }

                }
            };
            dele3 += SuperCounter.Calculate3;
            /////////////
            string s;
            WriteLine("Enter case: ");
            s = ReadLine();
            int a = int.Parse(s);
            switch (a)
            {
                case 1:
                    {
                        dele1(limit);
                    }
                    break;
                case 2:
                    {
                        dele2(limit);
                    }
                    break;
                case 3:
                    {
                        dele3(limit);

                    }
                    break;
                default:
                    WriteLine("Error404: ");
                    break;
            }


        }
    }
}
