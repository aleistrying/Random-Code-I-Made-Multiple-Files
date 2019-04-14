using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingAssignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sets the cursor position to a mid point in the console. 
            Console.SetCursorPosition(Console.BufferWidth / 2-13, 0);
            //Writes text
            Console.WriteLine("Welcome User.");
            Console.SetCursorPosition(Console.BufferWidth / 2-36, 1);
            Console.WriteLine("This program is going to calculate the distance between two points");
            Console.SetCursorPosition(Console.BufferWidth / 2-36, 2);
            Console.WriteLine("and the angle between these points.");

            Console.WriteLine();
            Console.WriteLine("Introduce Values x and y for the program to calculate the distance and angle.");

            Console.WriteLine("x1: ");
            //sets variable x to what it reads on the console
            float x = float.Parse(Console.ReadLine());

            Console.WriteLine("y1: ");
            //sets var y to what user inputs on console
            float y = float.Parse(Console.ReadLine());

            Console.WriteLine("x2: ");
            float x2 = float.Parse(Console.ReadLine());
            
            Console.WriteLine("y2: ");
            float y2 = float.Parse(Console.ReadLine());

            //calculates the difference between the points
            float deltaX = x2 - x;
            float deltaY = y2 - y;

            // distance = root(deltaX^2 deltaY^2) basically the theorem
            float distance = (float)Math.Sqrt((Math.Pow(deltaX, 2) + Math.Pow(deltaY, 2)));

            // angle which is the inverse tangent of oposite divided by the adyacent
            float angle = (float)Math.Atan2(deltaY,deltaX)*180/(float)Math.PI;

            //print out the result in the console
            Console.WriteLine();
            Console.WriteLine("The distance between these two points is {0}",distance);
            Console.WriteLine("The Angle between these two points is {0} degrees", angle);
            Console.WriteLine();
            Console.WriteLine("Press any key to close the program...");
            //holds the program from instantly closing
            Console.ReadKey();
        }
    }
}
