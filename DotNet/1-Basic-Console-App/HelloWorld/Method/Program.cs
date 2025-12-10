namespace Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 5, y = 10;
            Console.WriteLine(DemoParamMeters(x, y));
        }

        public static int DemoParamMeters(int x, int y)
        {
            return x + y;
        }

        private void LocalMethod()
        {

        }
    }
}
