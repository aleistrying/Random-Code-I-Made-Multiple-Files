using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QACreator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine() + " ";
                bool spaceTag = true;
                string newStr = "";
                string newWord = "";
                foreach (char c in input.ToCharArray())
                {

                    if (c == ' ' && !spaceTag)
                    {
                        newStr = newStr + "\"" + newWord + "\", ";
                        newWord = "";
                        spaceTag = true;
                    }
                    else if (c != ' ')
                    {
                        spaceTag = false;
                        newWord = newWord + c;

                    }
                    
                }
                Console.WriteLine(newStr);
                //Console.ReadLine();
            }
        }
    }
}
