using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    public class Kata
    {
        public static bool IsIsogram(string str)
        {
            str = str.ToLower();
            int count = 0;
            if(str == null)
            {
                return true;
            }

            foreach (var item in str)
            {
                foreach (var item2 in str)
                {
                    if (item==item2)
                    {
                        count++;
                    }
                }
                if (count>=2)
                {
                    return false;
                }
                count = 0;
            }
            return true;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string text = "aAd";
            bool result; 
            result = Kata.IsIsogram(text);
            Console.WriteLine(result);
            Console.ReadLine();
           
        }
    }
}
