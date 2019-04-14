using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildCards
{

    public class Program
    {
        private static int WildCards(string str)
        {
            int n = 0;
            //Input:"+++++* abcdehhhhhh"
            //Output:"false"
            //Input:"$**+*{2} 9mmmrrrkbb"
            //Output:"true"
            char[] charArray = str.ToCharArray();
            foreach (char c in charArray)
            {
                if (c == ' ')
                {
                    n++;
                    //return false;
                }
            }
            return n;
            //return true;
        }
        public static void Main()
        {
            string str = "";
            string userStr = "";
            while (userStr != "stop")
            {
                userStr = Console.ReadLine();
                //if(WildCards(userStr) == true)
                //{
                //	str = "Space Not Found";
                //}
                //else if (WildCards(userStr) == false)
                //{
                //  str = "Space Found";
                //}
                str = "Hay " + WildCards(userStr).ToString() + " espacios";
                Console.WriteLine(str);
            }
            Console.WriteLine("Code end");
        }
    }
}
