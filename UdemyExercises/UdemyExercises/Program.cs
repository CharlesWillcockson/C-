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
        }
    }
}
