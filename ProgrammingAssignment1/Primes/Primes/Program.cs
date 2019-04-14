using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primes
{
    class Program
    {
        static List<string> DivisibleNumbers = new List<string>();
        static void Primes(string Number)
        {
            try { 
            DivisibleNumbers.Clear();
            ulong num = ulong.Parse(Number);
            for (ulong i = 2; i < num; i++)
            {

                if(num%i == 0)
                {
                    DivisibleNumbers.Add(i.ToString());
                }
                //if(i == num - 1)
                //{
                //    return ;
                //}
            }
            }
            catch { }
        }
        static void Main(string[] args)
        {
            while (true)
            { 
                string userInput = Console.ReadLine();
                Primes(userInput);
                if (DivisibleNumbers.Count == 0)
                {
                    Console.WriteLine("El numero {0} es primo", userInput);
                }
                else
                {
                    Console.WriteLine("El numero {0} es divisible por {1} numeros:", userInput,DivisibleNumbers.Count());
                    string endStr = "";
                    foreach (string s in DivisibleNumbers)
                    {
                        endStr = endStr + s + ", ";
                    }
                    Console.WriteLine(endStr);
                }
            }
        }
    }
}
