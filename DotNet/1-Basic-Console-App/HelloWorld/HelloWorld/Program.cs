namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            if (args.Length > 0)
            {
                foreach (var arg in args)
                {
                    Console.WriteLine($"Argument: {arg}");
                }
            }

            var s = Console.ReadLine();
            if (int.TryParse(s, out var val))
            {
                Console.WriteLine($"You entered the number: {val}");
            }
            else
            {
                Console.WriteLine("You did not enter a valid number.");
            }
            Console.WriteLine(val);
        }
    }
}
