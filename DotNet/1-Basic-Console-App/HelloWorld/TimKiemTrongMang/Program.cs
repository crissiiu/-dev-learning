namespace TimKiemTrongMang
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();
            var arr = new int[10];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next() % 1000;
            }

            foreach (var item in arr)
            {
                Console.Write($"{item}\t");
            }

            Console.WriteLine("\nNhap so can tim: ");
            int n = int.Parse(Console.ReadLine());

            int j = 0;
            while (j < arr.Length && arr[j] != n)
            {
                j++;
            }

            if (j == arr.Length)
            {
                Console.WriteLine("Khong tim thay");
            }
            else
            {
                Console.WriteLine($"Tim thay {n} tai vi tri {j + 1}");
            }

            Console.WriteLine();
        }
    }
}
