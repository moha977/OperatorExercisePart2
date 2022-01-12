using System;

namespace OperatorExercisePart2
{
    internal class Program
    {
        static void Main(string[] args)
            
        {
            AreaOfCircle();
        }
        public static void AreaOfCircle()
        {
            Console.WriteLine("What is the radius of your circle?");
            var radius = double.Parse(Console.ReadLine());
            var area = Math.PI * radius * radius;
            Console.WriteLine(area);
          
        }
    }
}
