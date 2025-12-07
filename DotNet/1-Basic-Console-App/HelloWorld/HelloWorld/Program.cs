using System.Text;

namespace HelloWorld
{
    internal class Program
    {

        // Bacic 2 - Value Types and Reference Types in C#
        //link: https://learn.microsoft.com/en-us/dotnet/standard/base-types/common-type-system

        static void Main(string[] args)
        {
            /*
             * Tất cả các kiểu dữ liệu trong C# được chia làm hai loại:
             * - Kiểu giá trị (Value Types): Khi khai báo một biến kiểu giá trị, biến đó trực tiếp chứa dữ liệu. Các kiểu giá trị thường được lưu trữ trên stack. Các kiểu giá trị bao gồm các kiểu số nguyên (int, float, double), kiểu bool, kiểu char, và các struct.
             * - Kiểu tham chiếu (Reference Types): Khi khai báo một biến kiểu tham chiếu, biến đó chứa một tham chiếu (địa chỉ) đến vị trí trong bộ nhớ nơi dữ liệu thực sự được lưu trữ. Các kiểu tham chiếu thường được lưu trữ trên heap. Các kiểu tham chiếu bao gồm các class, interface, array, và delegate.
             */
            /*
            string s1 = $"Nguyễn Thanh Siêu, Hôm nay {DateTime.Now} \\";
            string s2 = "Hello, World!";

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(s1);
            stringBuilder.Append(s2);
            string s = stringBuilder.ToString();

            Console.WriteLine(s);
            */

            // Viết chương trình nhập vào 5 số nguyên và in ra số lớn nhất trong 5 số đó.
            int n;
            int max = int.MinValue;

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"So {i+1}: ");
                n = int.Parse(Console.ReadLine());
                if (n > max)
                {
                    max = n;
                }
            }
            Console.WriteLine($"So lon nhat la: {max}");

            /*
             Câu hỏi:
            Câu lệnh nào sau đây không hợp lệ?
                int x;
                int x, y = 10;
                [X]var x;
                var y = 10;
                [X]var x, y = 10;

            Kiểu dữ liệu nào là cha của tất cả các kiểu dữ liệu khác?
                [X]object
                dynamic
                [X]System.Object
                System.ValueType

            Câu lệnh nào sau đây không hợp lệ?
                string s = @"abc".ToUpper();
                string s = "abc".ToUpper();
                [X]string s = $"{"abc".ToUpper}";
                string s = $"abc".ToUpper();
                string s = "abc.ToUpper()";
             */
        }


        // Basic 1 - Hello World with command line arguments and input parsing
        /*
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
        */
    }
}
