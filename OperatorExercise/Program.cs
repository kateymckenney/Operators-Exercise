using System;


namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {

            //----------EXERCISE ONE------------------------

            int a = 17;
            int b = 4;

            int sum = a + b;
            int subract = a - b;
            int multiply = a * b;

            int quotient = a / b;
            int remainder = a % b;

            Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}");


            //--------------EXERCISE TWO------------------


            

            Console.WriteLine(AreaOfCircle());

        }

        public static double AreaOfCircle()
        {
            Console.WriteLine("Enter the radius of your circle.");
            var userInput = Console.ReadLine();

            var radius = double.Parse(userInput);


            var area = Math.PI * Math.Pow(radius, 2);


            return area;



        }
    }
}
