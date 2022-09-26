namespace MethodsExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, can we have your first name please?");
            var userName = Console.ReadLine();
            Console.WriteLine($"Hi {userName}, whats your Favorite Color?");
            var favoriteColor = Console.ReadLine();
            Console.WriteLine($"And {userName} what is your favorite band");
            var favBand = Console.ReadLine();
            Console.WriteLine($"And whats your favorite animal {userName}?");
            var favAnimal = Console.ReadLine();
            Console.WriteLine($"Quick question {userName} has listening to {favBand} ever made you see a {favoriteColor} {favAnimal}?");
         }
        public static int Add(int num1, int num2) 
            { return num1 + num2; }
        public static int Multiply(int num1, int num2)
            { return num1 * num2; }

    }

}