using System;

namespace UdemyExercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stringForFloat = "0.85";
            string stringForInt = "12345";
            float float1 = float.Parse(stringForFloat);
            int int1 = Int32.Parse(stringForInt); 
            Console.WriteLine(stringForFloat);
            Console.WriteLine(stringForInt);

            string string1;
            Console.WriteLine("Please enter your name and press enter");
            string1 = Console.ReadLine();
            Console.WriteLine(string1.ToUpper());
            Console.WriteLine(string1.ToLower());
            Console.WriteLine(string1.Trim());
            Console.WriteLine(string1.Substring(2));
            
        }
    }
}
