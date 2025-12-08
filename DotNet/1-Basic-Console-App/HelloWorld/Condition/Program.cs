namespace Condition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 3;
            int y = 0;

            if(x == 0)
            {
                Console.WriteLine("x == 0");
            }
            else
            {
                Console.WriteLine("x <> 0");
            }

            switch (x)
            {
                case 0:
                    Console.WriteLine("x == 0");
                    break;
                case 1:
                    Console.WriteLine("x == 1");
                    break;
                default:
                    Console.WriteLine($"x = {x}");
                    break;
            }

            Console.WriteLine("---------For------------");
            int[] array1 = { 1, 2, 3, 4, 5 };
            for(int i = 0; i< array1.Length; i++)
            {
                Console.Write($"{array1[i]} \t");
            }

            Console.WriteLine("\n---------While------------");

            int a = 0;
            while(a <= 0)
            {
                Console.WriteLine(a++);
            }


            Console.WriteLine("---------Do-While------------");
            do
            {
                Console.WriteLine(a);
            } while (a < 0);

            Console.WriteLine("---------Foreach------------");
            foreach(int a1 in array1)
            {
                Console.Write($"{a1} \t");
            }
            Console.WriteLine();
        }
    }
}
