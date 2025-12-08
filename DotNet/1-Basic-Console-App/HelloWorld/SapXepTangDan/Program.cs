namespace SapXepTangDan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();
            int[] arr = new int[10];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new Random().Next(1, 100);
            }

            Console.WriteLine("Mang ban dau: ");
            foreach (var item in arr)
            {
                Console.Write($"{item}\t");
            }

            // Sap xep tang dan
            Console.WriteLine("\nMang sau khi sap xep tang dan: ");
            //for (int i = 0; i < arr.Length - 1; i++)
            //{
            //    for (int j = i + 1; j < arr.Length; j++)
            //    {
            //        if (arr[i] > arr[j])
            //        {
            //            // Hoan vi
            //            int temp = arr[i];
            //            arr[i] = arr[j];
            //            arr[j] = temp;
            //        }
            //    }
            //}
            //foreach (var item in arr)
            //{
            //    Console.Write($"{item}\t");
            //}

            arr = arr.OrderBy(x => x).ToArray();
            foreach (var item in arr)
            {
                Console.Write($"{item}\t");
            }
        }
    }
}
