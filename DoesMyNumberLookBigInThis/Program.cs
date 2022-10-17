using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoesMyNumberLookBigInThis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Narcissistic(371));
            Console.ReadKey();
        }

        public static bool Narcissistic(int value)
        {
            var a = value.ToString().ToCharArray();
            int[] arr = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                arr[i] = Int32.Parse(a[i].ToString());
            }
            double level = a.Length;
            double result = 0;
            for (int i = 0; i < a.Length; i++)
            {
                result += Math.Pow((double)arr[i], level);
            }

            return result == value ? true : false;
        }

        public static bool Narcissistic1(int value)
        {
            var str = value.ToString();
            return str.Sum(c => Math.Pow(Convert.ToInt16(c.ToString()), str.Length)) == value;
        }

        public static bool Narcissistic2(int value)
        {
            var lstInt = value.ToString().Select(x => int.Parse(x.ToString())).ToList();
            double resultTemp = 0;

            lstInt.ForEach(x =>
            {
                resultTemp += Math.Pow(x, lstInt.Count);
            });

            return resultTemp == value;
        }

        private static HashSet<int> nNums = new HashSet<int>
        {
          0, 1, 2, 3, 4, 5, 6, 7, 8, 9,
          153, 370, 371, 407,
          1634, 8208, 9474,
          54748, 92727, 93084,
          548834,
          1741725, 4210818, 9800817, 9926315,
          24678050, 24678051, 88593477,
          146511208, 472335975, 534494836, 912985153,
        };

        public static bool Narcissistic3(int value) =>
          nNums.Contains(value);
    }
}
