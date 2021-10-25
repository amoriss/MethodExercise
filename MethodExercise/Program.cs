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
            //Console.WriteLine("Welcome to MadLibs. Answer the following questions");
           // InputMethod();
           // Console.WriteLine($"Who lives in a {fruit} under the sea? Absorbant and {color} is he. If nautical " +
            //    $"nonsense be something you wish? Then drop on the deck and flop like a {animal}. Ready?  Spongebob {shape} pants!");
            int addAnswer = Add(5, 5);
            int paramAddAnswer = Add2(10, 10, 10);
            int paramAddAnswer2 = Add2(10, 10, 10, 10); //answer is 40
            var multAnswer = Multiply(10, 10);
            var subAnswer = Subtract(20, 10);
            Console.WriteLine("How many numbers would you like to add together?");
            var numbers = int.Parse(Console.ReadLine());
            int[] array = new int[numbers];
            for (int i = 0; i < numbers; i++)
            {
                Console.WriteLine("Enter in a number:");
                array[i] += int.Parse(Console.ReadLine());
            }
            Console.WriteLine("The total is:"+ Add2(array)); 
            var divAnswer = Divide(20, 5);
            var modAnswer = Mod(2, 2);
            var multAnswer2 = Multiply2(2, 2, 2); //answer is 8
            var subAnswer2 = Subtract2(10, 5, 5); // answer is 0

            Console.WriteLine($"5 + 5 = "+ addAnswer);
            Console.WriteLine($"This is using params keyword for 3 numbers (Adding): {paramAddAnswer}");
            Console.WriteLine($"This is using params keyword for 4 numbers (Adding): {paramAddAnswer2}");
            Console.WriteLine($"10 x 10 = "+ multAnswer);
            Console.WriteLine($"20 - 10 = " + subAnswer);
            Console.WriteLine($"20 / 5 = " + divAnswer);
            Console.WriteLine($"2/2 has a remainder of: "+ modAnswer);
            Console.WriteLine($"This is using params keyword for 3 numbers (Multiplying) {multAnswer2}");
            Console.WriteLine($"This is using params keyword for 3 numbers (Subtracting) {subAnswer2}");
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

        public static int Multiply2(params int[] nums)
        {
            int answer = 1;
            foreach (var x in nums)
            {
                answer *= x;
            }
            return answer;
            
          
        }

        public static int Subtract2(params int[] nums)
        {
         
          int answer = 0;
          for (int i = nums[0]; i < nums.Length - 1; i++)
          {
              answer-=nums[i];
          }
          return answer; 
          
        }


    }
}