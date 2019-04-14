using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace timeTestForClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch timer = new Stopwatch();
            var num = 1000000;
            string thisVar = "this Variable";

            while (true)
            {
                

                timer.Start();
                StringBuilder strBld = new StringBuilder();
                for (int i = 0; i <= num; i++)
                {
                    strBld.Append("this is number ");
                    strBld.Append(i * i * i);
                    strBld.Append(" test");
                    strBld.Append(" keep reading for more info about ");
                    strBld.Append(thisVar);
                    strBld.Append(".");

                }
                timer.Stop();
                long timeElapsedAppend = timer.ElapsedMilliseconds;
                timer = new Stopwatch();

                timer.Start();
                string test = "";
                for (int i = 0; i <= num; i++)
                {
                    test = "this is number " + i * i * i + " test keep reading for more info about "+ thisVar +".";
                }
                timer.Stop();
                long timeElapsedString = timer.ElapsedMilliseconds;
                timer = new Stopwatch();

                

                //timer.Start();
                //strBld = new StringBuilder();
                //for (int i = 0; i <= num; i++)
                //{
                //    strBld.Append("this is number ");
                //    strBld.Append(i);
                //    strBld.Append(" test keep reading for more info about ");
                //    strBld.Append(thisVar);
                //    strBld.Append(".");
                //}
                //timer.Stop();
                //string timeElapsedAppend2 = timer.ElapsedMilliseconds + " ms";
                //timer = new Stopwatch();

                //timer.Start();
                //strBld = new StringBuilder();
                //for (int i = 0; i <= num; i++)
                //{
                //    strBld.Append("this is number " + i + " test keep reading for more info about " + thisVar + ".");
                //}
                //timer.Stop();
                //string timeElapsedAppend3 = timer.ElapsedMilliseconds + " ms";



                Console.WriteLine(!(timeElapsedAppend >= timeElapsedString)?"(true) append "+ timeElapsedAppend + " ms" + " <= "+timeElapsedString  +" ms"+ " Concat " + Math.Abs(timeElapsedAppend - timeElapsedString) + " (Append wins)" : "(false) append " + timeElapsedAppend+ " ms" + " > " + timeElapsedString+ " ms" + " concat " +  Math.Abs(timeElapsedAppend- timeElapsedString) + " (concat wins)");
                //Console.WriteLine(timeElapsedAppend2);
                //Console.WriteLine(timeElapsedAppend3);
                //Console.WriteLine(timeElapsedString);
                System.Threading.Thread.Sleep(300);
            }
        }
    }
}
