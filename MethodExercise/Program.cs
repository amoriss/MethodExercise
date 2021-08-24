using System;

namespace MethodExercise
{
    class Program
    {

        public static string animal;
        public static string color;
        public static string fruit;
        public static string shape;
        static void Main()
        {
            Console.WriteLine("Welcome to MadLibs. Answer the following questions");
            InputMethod();
            Console.WriteLine($"Who lives in a {fruit} under the sea? Absorbant and {color} is he. If nautical " +
                $"nonsense be something you wish? Then drop on the deck and flop like a {animal}. Ready?  Spongebob {shape} pants!");
            int addAnswer = Add(5, 5);
            int paramAddAnswer = Add2(10, 10, 10);
            var multAnswer = Multiply(10, 10);
            var subAnswer = Subtract(20, 10);
            var divAnswer = Divide(20, 5);
            var modAnswer = Mod(2, 2);
            Console.WriteLine(addAnswer);
            Console.WriteLine(paramAddAnswer);
            Console.WriteLine(multAnswer);
            Console.WriteLine(subAnswer);
            Console.WriteLine(divAnswer);
            Console.WriteLine(modAnswer);
        }

        public static void InputMethod()
        {

            Console.WriteLine("Enter a kind of animal: ");
            animal = Console.ReadLine();
            Console.WriteLine("Enter a color: ");
            color = Console.ReadLine();
            Console.WriteLine("Enter a type of fruit: ");
            fruit = Console.ReadLine();
            Console.WriteLine("Enter a type of shape: ");
            shape = Console.ReadLine();

        }

        public static int Add(int x, int y) 
        {
            return x + y;
        }
        public static int Subtract(int x, int y)
        {
            return x - y;
        }
        public static int Multiply(int x, int y)
        {
            return x * y;
        }

        public static double Divide(int x, int y)
        {
            return x / y;
        }

        public static double Mod(int x, int y)
        {
            return x % y; 
        }
         
        //params keyword
        public static int Add2(params int[] nums)
        {
            var sum = 0;
            foreach (var x in nums)
            {
                sum += x;
            }

            return sum;
        }


    }
}