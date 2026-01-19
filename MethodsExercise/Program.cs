namespace MethodsExercise
{
    public class Program
    {
        public static void YourStory()
        {
            Console.WriteLine("Welcome! What is your name?");
            string userName = Console.ReadLine();
            Console.WriteLine($"Hello, {userName}! Whats your favorite place?");
            string favPlace = Console.ReadLine();
            Console.WriteLine($"{favPlace}? Sounds like a very interesting place! Next question, whats your favorite food?");
            string favFood = Console.ReadLine();
            Console.WriteLine($"{favFood}? Sounds quite delicious, my favorite food is Sushi's and Ramen, last question, whats your facorite color?");
            string color = Console.ReadLine();
            Console.WriteLine($"{color}? Thats an interesting color choice! My type of color is Red, Cyan and Black! And its nice to meet you too! Im Kris Robin!");
            Console.WriteLine($"\n \nSo your favorite things are {favPlace}, {favFood} and {color}, sounds very interesting favorite things! Glad I get to meet you {userName}, I hope you have a great day {userName}!");

        }

        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static int Subtract(int a, int b)
        {
            return a - b;
        }
        public static int Multiply(int a, int b)
        {
            return a * b;
        }
        public static int Divide(int a, int b)
        {
            return a / b;
        }
        static void Main(string[] args)
        {
            //YourStory();
            int addedNums = Add(a: 2, b: 4);
            Console.WriteLine(addedNums);
            Console.WriteLine(Subtract(a: 2, b: 4));
            Console.WriteLine(Multiply(a: 2, b: 4));
            Console.WriteLine(Divide(a: 2, b: 4));
        }
    }
}
