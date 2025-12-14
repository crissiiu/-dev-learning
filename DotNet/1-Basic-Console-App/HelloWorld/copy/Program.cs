namespace copy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"D:\\Documents\\Nguyen-Thanh-Sieu.txt";
            string destinationPath = @"D:\\Documents\\Nguyen-Thanh-Sieu-Copy.txt";

            var buffer = new byte[1024];
            using var instream = File.OpenRead(sourcePath);
            //using var outstream = File.OpenWrite(sourcePath);

            int n = instream.Read(buffer, 0, buffer.Length);
            while (n > 0)
            {
                Console.WriteLine(n.ToString());
                //outstream.Write(buffer, 0, n);
                n = instream.Read(buffer, 0, buffer.Length);
            }
            //instream.Close();
            //outstream.Close();
        }
    }
}
