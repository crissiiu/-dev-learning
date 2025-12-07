namespace Array
{
    internal class Program
    {
        static void Main()
        {
            string[] array1 = new string[3] { "nguyen", "thanh", "sieu" };

            for (int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine(array1[i]);
            }
            MangBaChieu();
            Mang();
        }

        static void MangBaChieu()
        {
            int[,,] mang3Chieu =
            {
                {
                    { 1, 2, 3,4 },
                    { 5,6,7,8 }
                }
            };

            Console.WriteLine(mang3Chieu[0, 1, 2]); // Output: 7
        }

        static void Mang()
        {
            int[][] mm = new int[3][];
            mm[0] = new int[] { 1, 2 };
            mm[1] = new int[] { 3, 4, 5 };
            mm[2] = new int[] { 6, 7, 8, 9 };

            for (int i = 0; i < mm.Length; i++)
            {
                for (int j = 0; j < mm[i].Length; j++)
                {
                    Console.Write(mm[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
